// See https://aka.ms/new-console-template for more information
Console.WriteLine("Simple Calculator");


Console.WriteLine("Enter Two Numbers");

int[] numbers=new int[2];

for(int i=0;i<2;i++){
    Console.Write("Enter Number: ");
    numbers[i]=Convert.ToInt32(Console.ReadLine());
}


Console.Write("Enter '+' '-' '*' '/' 'mod' for the operation: ");

string op=Console.ReadLine();

if(op=="+"){
    Console.WriteLine($"{numbers[0]} + {numbers[1]} = {numbers[0]+numbers[1]}");
} else if(op=="-"){
    Console.WriteLine($"{numbers[0]} - {numbers[1]} = {numbers[0]-numbers[1]}");
} else if(op=="*"){
    Console.WriteLine($"{numbers[0]} * {numbers[1]} = {numbers[0]*numbers[1]}");
} else if(op=="/" && numbers[0]!=0){
    Console.WriteLine($"the sum of {numbers[0]} / {numbers[1]} = {numbers[0]/numbers[1]}");
}
else {
    Console.WriteLine("Enter the right Operation");
}
