#include<stdio.h>

void exchange(int *a, int *b)
{
	int temp;
	temp = *a;
	*a = *b;
	*b = temp;
}


int Partition(int a[], int p, int r)
{
	int x = a[r];
	int i = p - 1;
	int j = p;
	for (; j <= r - 1; j++)
	{
		if (a[j]>x)
		{
			i += 1;
			exchange(&a[i], &a[j]);
		}
	}
	exchange(&a[i + 1], &a[r]);
	return i + 1;
}

void QuickSort(int a[], int p, int r)
{
	int q;
	if (p<r)
	{
		q = Partition(a, p, r);
		QuickSort(a, p, q - 1);
		QuickSort(a, q + 1, r);
	}
}

int main()
{
	int i;
	int a[12] = { 13, 19, 9, 5, 12, 8, 7, 4, 11, 2, 6, 21 };
	QuickSort(a, 0, 11);
	for (i = 0; i<12; i++)
	{
		printf("%d	", a[i]);
	}
	return 0;
}
