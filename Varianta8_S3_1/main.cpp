#include <iostream>

using namespace std;

int main()
{
    int a[11][11],n,i,j,k;
    cin>>n;
    for(int i=1;i<=n;i++)
    {
        for(int j=1;j<=n;j++)
            cin>>a[i][j];
    }
    for(int i=1;i<=n;i++)
    {

        k=0;
        for(int j=1;j<=n;j++)
            k=k*2+a[i][j];
        cout<<k<<" ";
    }
    return 0;
}
