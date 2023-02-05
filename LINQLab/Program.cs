int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

int min = nums.Min();
Console.WriteLine(min);
int max = nums.Max();
Console.WriteLine(max);
int MaxLessThan1k = nums.Where(n => n < 1000).Max();
Console.WriteLine(MaxLessThan1k);
var NumBetween = nums.Where(n => n > 10 && n < 100);
foreach (var item in NumBetween)
{
    Console.WriteLine(item);
}
var NumBetweenInclusive = nums.Where(n => n >= 100000 && n <= 999999);
foreach (var item in NumBetweenInclusive)
{
    Console.WriteLine(item);
}
var EvenNumbersList = nums.Where(n => n % 2 == 0);
foreach (int n in EvenNumbersList)
{
    Console.Write(n +  " ");
}