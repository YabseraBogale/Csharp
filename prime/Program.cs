﻿int[] orArray=new int[8];

for(int i=0;i<orArray.Length;i++){
	Console.Write("Enter NUmber");
	orArray[i]=Conver.ToInt32(Console.ReadLine());
}

int primeCount=0;
foreach(int num in orArray){
	if(IsPrime(num)==true){
		primeCount+=1;
	}
}

int[] prArray=new int[primeCount];

static bool IsPrime(int number){
	if(number<2){
		return false;
	} else if(number==2){
		return true;
	}
	for(int i=2;i<Math.Sqrt(number);i++){
		if(number%i==0){
			return false;
		}
	}
	return true;
}

