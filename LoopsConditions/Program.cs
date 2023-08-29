// See https://aka.ms/new-console-template for more information
// using Internal;

// using Internal;

Console.WriteLine("Hello, World Again!");


//Create a loop that prints all values from 1-255.
// for (int i = 1; i <= 255; i++) 
// {
//     Console.Write(i);
// }


//------------------------------------------------------------------------------------------


//Create a new loop that generates 5 random numbers between 10 and 20.
// Random rand = new Random();
// for (int i = 1; i <= 5; i++) //Making 5 random numbers
// {
//     int randomNumber = rand.Next(10,21); //making a random number between 10 and 20
//     Console.WriteLine(randomNumber);
// }  


//------------------------------------------------------------------------------------

//Modify the previous loop to add the random values together and print the sum after the loop finishes.
Random rand = new Random();
int sum = 0; // Initialize the sum variable to 0

for (int i = 1; i <= 5; i++)  // Generate 5 random numbers
{
    int randomNumber = rand.Next(10, 21);
    Console.WriteLine(randomNumber);
    
    sum += randomNumber; // Add the random number to the sum
}

Console.WriteLine("The sums random number: " + sum);


//----------------------------------------------------------------------------



//Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.
for (int i = 1; i <= 100; i++)  // Loop from 1 to 100
{
    // 
    if (i % 3 == 0 && i % 5 != 0) //Check if the number is divided by 3 or 5, but not both,,, Divided by 3, not by 5
    {
        // Print the number
        Console.WriteLine(i);
    }
    else if (i % 5 == 0 && i % 3 != 0) // Divided by 5, not by 3
    {
        
        Console.WriteLine(i);
    }
}



//---------------------------------------------------------------------------------------------------



// Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.

for (int i = 1; i <= 100; i++)
{
    
    if (i % 3 == 0 && i % 5 != 0) // if divided by 3 will print Fizz
    {
        Console.WriteLine("Fizz");  
    }
    else if (i % 5 == 0 && i % 3 != 0) // if divided by 5 will print Buzz
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0 && i % 5 == 0) // Divided by both 3 and 5
    {
        Console.WriteLine("FizzBuzz");
    }
    else
    {
        Console.WriteLine(i); 
    }
}



//----------------------------------------------------------------------------------------

//Modify the previous loop once more to now also print "FizzBuzz" for numbers that are multiples of both 3 and 5.

for (int i = 1; i <= 100; i++)
{
    
    if (i % 3 == 0 && i % 5 == 0) // Divided by both 3 and 5
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0) // Divided by 3, not by 5
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0) // Divided by 5, not by 3
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i); 
    }
}
