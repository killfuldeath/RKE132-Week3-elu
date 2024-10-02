Console.WriteLine("Please tell me a number:");

int num = Convert.ToInt32(Console.ReadLine());

int result = num % 2;  //ausalt, see osa on mulle liigselt tuttav, vanas koolis oli see mingi nali

// Console.WriteLine(result);  maagia!
//peaaegu unustasin teha !=, sest jätkasin nagu torm ja panin ==
if (result != 0) 
{
    Console.WriteLine("This number is odd.");
}
else
{
    Console.WriteLine("This number is even");
}
