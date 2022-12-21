// вводим тип переменной, пробел, имя переменной = . Обязательно!! вводимые данные и выходные должны быть одинаковыми.
int number = Convert.ToInt32(Console.ReadLine());

int sqr = number * number;

int sqrMath = Convert.ToInt32(Math.Pow(number, 5));

System.Console.WriteLine(sqr);

System.Console.WriteLine(sqrMath);