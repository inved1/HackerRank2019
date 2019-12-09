#include "TwoStrings.h"


#include <bitset>


using namespace std;

string TwoStrings::check(string s1, string s2)
{
	string ret;


	return ret;

}

void TwoStrings::run()
{
	

    int q;
    cin >> q;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    for (int q_itr = 0; q_itr < q; q_itr++) {
        string s1;
        getline(cin, s1);

        string s2;
        getline(cin, s2);

        string result = twoStrings(s1, s2);

        fout << result << "\n";
    }

    fout.close();

}
