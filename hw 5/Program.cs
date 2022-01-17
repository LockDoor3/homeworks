using hw5;


RN test = new();
RN test1 = new(10,5);
RN test2 = new(2,3);
RN test3 = new(1, 2);
RN test4 = new(1);


test = test1 + test2;
test = test1 - test2;
test2++;
test1--;


Console.WriteLine(test1 >= test3);
Console.WriteLine(test2 <= test3);
Console.WriteLine(test > test3);
Console.WriteLine(test1 < test3);
Console.WriteLine(test2 != test3);
Console.WriteLine(test == test3);


test3++;
test3++;

Console.WriteLine(test3 == test2);
Console.WriteLine(test3 == test1);


Console.WriteLine((float)test3);
Console.WriteLine((int)test2);


Console.WriteLine(test3.GetHashCode());

Console.WriteLine(test.Equals(test));
Console.WriteLine(test4.Equals(test1));


test2--;
test2--;
test2--;

Console.WriteLine(test2.ToString());
Console.WriteLine(test.ToString());
Console.WriteLine(test4.ToString());