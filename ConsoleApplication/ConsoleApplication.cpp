/*
Entry point from DemoMFC
Gets filename i.e. entire file path from DemoMFC - file which has been copied to USB device
Reads policy of attached USB device from currentpolicy.txt file
Reads allowed file types for given policy from names database
Finds file type of file being copied
Compares allowed file types with type of file being copied
If allowed, encryption
Else, deletion 
*/

#include "stdafx.h"
#include "stdafx.h"
//#include "magic.h"
#include<iostream>
#include<fstream>
#include<string>
#include<windows.h>
#include <cstdlib>
#include<sstream>
using namespace std;

/*
Function will return a number corresponding to file extension of the file to be copied.
*/
int fileHeader(string filename)
{
	ifstream input(filename.c_str(), ios::binary);
	cout << filename;
	if (input.is_open())
	{
		input.seekg(0, ios::beg);
		unsigned char magic[4] = { 0 };
		input.read((char*)magic, sizeof(magic));

		//Image Files
		const unsigned char png[4] = { 0x89,0x50,0x4E,0x47 };				//1
		const unsigned char tiff[4] = { 0x49, 0x49, 0x2A, 0x00 };			//2
		const unsigned char jpeg[4] = {0xFF, 0xD8, 0xFF, 0xE0  };			//3
		const unsigned char jpg[4] = { 0xFF, 0xD8, 0xFF, 0xDB };			//3

		//Office Files
		const unsigned char doc[4] = { 0xD0, 0xCF, 0x11, 0xE0 };			//4 - doc, xls,ppt
		const unsigned char pdf[4] = { 0x25, 0x50, 0x44, 0x46 };			//5
		const unsigned char pptx[4] = { 0x50, 0x4B, 0x03, 0x04  };			//6 - docx, pptx, xslx
		const unsigned char iso[4] = { 0x43, 0x44, 0x30, 0x30 };			//7
		//Audio / Video Files
		const unsigned char mkv[4] = { 0x1A, 0x45, 0xDF, 0xA3 };			//8
		//const unsigned char mp3[4] = {  };								//8
		const unsigned char wav[4] = { 0x52, 0x49, 0x46, 0x46  };			//9 - wav, avi
		const unsigned char gif[4] = { 0x47, 0x49, 0x46, 0x38 };			//10
		
		

		if (memcmp(magic, png, sizeof(magic)) == 0)
		{
			return 1;
		}
		else if (memcmp(magic, tiff, sizeof(magic)) == 0)
		{
			return 2;
		}
		else if ((memcmp(magic, jpeg, sizeof(magic)) == 0) || (memcmp(magic, jpg, sizeof(magic)) == 0))
		{
			return 3;
		}
		
		else if (memcmp(magic, doc, sizeof(magic)) == 0)
		{
			return 4;
		}
		else if (memcmp(magic, pdf, sizeof(magic)) == 0)
		{
			return 5;
		}
		else if (memcmp(magic, pptx, sizeof(magic)) == 0)
		{
			return 6;
		}
		else if (memcmp(magic, iso, sizeof(magic)) == 0)
		{
			return 7;
		}
		else if (memcmp(magic, mkv, sizeof(magic)) == 0)
		{
			return 8;
		}
		else if (memcmp(magic, wav, sizeof(magic)) == 0)
		{
			return 9;
		}
		else if (memcmp(magic, gif, sizeof(magic)) == 0)
		{
			return	10;
		}
		else
		{
			cout << " File Type not recognized";
			return 99;
		}
	}
}
//else
//cout << "Error!";

int getFileExtension(string s1)
{
	string filename;
	int fileTypeNumber;
	fileTypeNumber = fileHeader(s1);
	return fileTypeNumber;
}
void encryption(string f3)
{
	cout << "in enc";
	string filename = f3;
	unsigned char magic[512] = { 0 };
	ifstream input(filename.c_str(), ios::binary);
	if (input.is_open())
	{
		input.seekg(0, ios::beg);
		input.read((char*)magic, sizeof(magic));
	}
	int count = 7;
	input.close();
	unsigned char key[8] = { 'a','d','1','3','s','k','2','2' };
	int j = 0;
	int newval;
	for (int x = 0; x<strlen((const char*)magic); x++)
	{
		magic[x] = magic[x] ^ key[j % 8];
		newval = int(magic[x]) + count;
		magic[x] = (unsigned char)newval;
		cout << magic[x];
		j++;
	}
	ofstream output(filename.c_str(), ios::in | ios::out | ios::binary | ios::ate);
	if (output.is_open())
	{
		output.seekp(0, ios::beg);
		output.write((char*)magic, sizeof(magic));
		output.seekp(0, ios::end);

		output << "MIT$";
		output.close();
	}
	

}
void compareExtensions(int *savedpolicyarray, int filetypearray, int len,string f2)
{
	int msgboxID;
	int i = 0, flag = 0;
	/*Compare array of allowed file extensions with file extension of file to be copied
	Extension of file to be copied is put in filetypearray - received from findFileExtension.cpp
	*/
	string filename = f2;
	for (i = 0; i<len; i++)
	{
		if (savedpolicyarray[i] == filetypearray)
		{
			flag = 1;
			break;
		}
		else
		{
			flag = 0;
		}
	}

	if (flag == 1)
	{
		 msgboxID = MessageBox(
			NULL,
			(LPCWSTR)L"File can be copied.",
			(LPCWSTR)L"File Details",
			MB_OK
		);
		cout << "\n File Type Allowed to be copied!";
		encryption(filename);
		 msgboxID = MessageBox(
			NULL,
			(LPCWSTR)L"File has been encrypted.",
			(LPCWSTR)L"File Details",
			MB_OK
		);

	}
	else
	{
		 msgboxID = MessageBox(
			NULL,
			(LPCWSTR)L"File can't be copied.",
			(LPCWSTR)L"File Details",
			MB_ICONWARNING
		);
		
		remove(filename.c_str());
		cout << "\n File cannot be copied!";
	}
}

int main(int argc, char* argv[])
{
	ShowWindow(GetConsoleWindow(), SW_HIDE);
	string policy_file = "C:\\Watchware\\names.txt";
 	Sleep(20); 
	string currentpol = "C:\\Watchware\\currentpolicy.txt";
	string filename = string(argv[1]);
	cout << filename;
	Sleep(20);
	string depart;
	ifstream f1(currentpol.c_str());
	if (f1.is_open())
	{
	getline(f1, depart);
	f1.close();
	}
	cout << depart;
	string line;
	int x;
	int len;
	string str = " ";
	int array_size = 1024;
	int filetypearray = 0;
	string delim = "*";
	string token;
	int substrlen = 0;
	int * savedpolicyarray = new int[array_size];
	int position = 0;
	int i, j;
	//int pos;
	
	ifstream myfile(policy_file.c_str(), ios::binary);
	if (myfile.is_open())
	{
	
		while (!myfile.eof())
		{
			getline(myfile, line);
			

			if (line.find(depart, 0) != string::npos)
			{
				x = line.find("*");

				len = line.length();

				substrlen = len - x;
				token = line.substr(x, len);
				cout << token << "\n";
				break;
			}
		}
		std::istringstream ss(token);
		std::string input;
		j = 0;
		while (std::getline(ss, input, '*')) {
			//std::cout << input << '\n';
			savedpolicyarray[j] = atoi(input.c_str());
			j++;
		}
		for (i = 0; i < j; i++)
		{
			cout << savedpolicyarray[i] << "\t";
		}
		myfile.close();
	}
	else
	{
		cout << "Error in opening file! :(";
	}


	filetypearray = getFileExtension(filename);

	cout << filetypearray;
	//filetypearray = fileHeader(); put name of file which is to be copied as parameter
	compareExtensions(savedpolicyarray, filetypearray, j,filename);
	getchar();
}
