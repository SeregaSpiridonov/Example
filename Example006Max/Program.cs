int a = 2;
int b = 4;
int c = 8;
int d = 3;
int e = 1;
int max = a;

if(max < b) max = b;
if(max < c) max = c;
if(max < d) max = d;
if(max < e) max = e;

Console.Write("Максимальное = ");
Console.Write(max);