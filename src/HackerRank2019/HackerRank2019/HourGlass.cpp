

#include <string>
#include <iostream>
#include <sstream>



#include "HourGlass.h"

using namespace std;

HourGlass::HourGlass()
{
}

HourGlass::~HourGlass()
{
}

void HourGlass::ReadDataAndRun()
{
	int iLine = 0;
	for (std::string line; std::getline(std::cin, line);) {
		stringstream stream(line);
		std::string buf;
		
		int iPos = 0;
		while (stream >> buf) {
			FixedArray[iLine][iPos]= std::stoi(buf);
			iPos += 1;
		}
		iLine += 1;
		if (iLine >= 6) break;
	}

	Run();
}

void HourGlass::Run()
{
	int TempMaxValue = INT_MIN;
	int SavedCounters[2];
	int SavedSum = INT_MIN;
	for (int i = 0; i < 4; i++) {
		for (int j = 0; j < 4; j++) {
			int sum = FixedArray[i][j] + //a
				FixedArray[i][j + 1] + //b
				FixedArray[i][j + 2] +//c
				FixedArray[i + 1][j + 1] +//d
				FixedArray[i + 2][j] +//e
				FixedArray[i + 2][j + 1] +//f
				FixedArray[i + 2][j + 2]; //g
			if (sum > TempMaxValue) {
				SavedCounters[0] = i;
				SavedCounters[1] = j;
				TempMaxValue = sum;
				SavedSum = sum;
			}

		}
	}
	std::cout << SavedSum;
}
