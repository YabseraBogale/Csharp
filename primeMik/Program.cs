int[] orArray=new int[4];

for(int i=0;i<orArray.Length;i++){
	Console.Write("Enter Number: ");
	orArray[i]=Convert.ToInt32(Console.ReadLine());
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

Console.WriteLine("prime number count: {0}",primeCount);
