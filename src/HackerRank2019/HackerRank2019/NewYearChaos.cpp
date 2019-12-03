#include "NewYearChaos.h"

NewYearChaos::NewYearChaos()
{
	int t;
	cin >> t;
	cin.ignore(numeric_limits<streamsize>::max(), '\n');

	for (int t_itr = 0; t_itr < t; t_itr++) {
		int n;
		cin >> n;
		cin.ignore(numeric_limits<streamsize>::max(), '\n');

		string q_temp_temp;
		getline(cin, q_temp_temp);

		vector<string> q_temp = split_string(q_temp_temp);

		vector<int> q(n);

		for (int i = 0; i < n; i++) {
			int q_item = stoi(q_temp[i]);

			q[i] = q_item;
		}

		minimumBribes(q);
	}

	return 0;
}
