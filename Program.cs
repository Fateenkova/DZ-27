Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int sum=0;
while(num>0)
{
    sum=sum+num%10;
    num=num/10;
}
Console.WriteLine(sum);

