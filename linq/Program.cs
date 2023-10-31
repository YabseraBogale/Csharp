// See https://aka.ms/new-console-template for more information

int[] number={1,2,5,10};

var subset=from i in number where i%2==0 select i;
// had to use foreach to sove it
foreach(var i in subset){
	Console.WriteLine($"subset: {i}");
	}


//c# is good for windows application gui development but i don't what to say about the rest
