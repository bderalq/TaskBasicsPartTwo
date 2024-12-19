// task 1 Challenge 1 : for loop  
for (int s = 1; s <= 10; s++)
{
    Console.WriteLine(s);
}

Console.WriteLine("---------------------------------");

// task 1 Bonus Question While Loop 
int z = 5;
while (z > 0)
{
    Console.WriteLine(z);
    z--;
}

Console.WriteLine("---------------------------------");
// task 2 Challenge 1 : Days of The Week 

string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday" };
Console.WriteLine("Weekly Class Schedule : ");
for (int i = 0;  i < daysOfWeek.Length; i++)
{
    Console.WriteLine(daysOfWeek[i]);   
}

Console.WriteLine("---------------------------------");
// task 2 Challenge 2 : SUM 

int[] h = { 12, 19, 23, 32, 11, 15, 21 };
int sum = 0;
for  (int i = 0; i  <= h.Length-1; i++)
{
    sum += h[i] ;
}
Console.WriteLine("Array total is = " + sum);

// task 2 Bonus 

// Multi-dimensional array can be used to store more than one array as one,
// and can be looked at as a table with rows and columns. A two-dimensional array 
// can be exressed with [,] and a 3D array can be expressed with [,,]. 
// An example of a multi-dimensional array can is as follows : 

int[,] multi = { { 2, 5, 7, 8 }, { 3, 5, 6, 7 } };
string[,] multiple = { { "one", "two", "three" }, { "four", "five", "six" } };

