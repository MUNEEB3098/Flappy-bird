#include<iostream>
#include<string>
using namespace std;
//reverse string>
int main()
{
	int i = 123;
	string k = "                    ";
	
	int num = 16;
	for (int x = 0; i > 0; x++)
	{
		if (i < num)
		{
			k[x] = char(48 + i);
			i /= num;
		}
		else
		{
			if(i%num>9)
			{
				int n = i % num;
				string l = "                    ";
				int index = 0;
				for(int y=0;y<3;y++)
				{
					l[index] = char(48 + n % 10);
					n = (n - (n % 10)) / 10;
					index++;
				}
				l[index+1] = char(48 +n); 
				i%=num;
				k = k + l;
			}
			else
			{
				k[x] = char(48 + (i % num));
				i /= num;
			}
		}
	}
	cout << k;
}