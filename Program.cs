

int TempString1= 0;
int TempString2 = 0;
string input = "";
int HorizontalMove = 0;
int VerticalMove = 0;
System.Console.Write("Please enter your input : ");
input = Console.ReadLine()!;
string ValidInput(string input)
{
    
    bool isValid = true;
    do
    {
        isValid = true;
        
        

        for (int i = 0; i < input.Length; i++)
        {
            if (!(input[i] is 'V' or '<' or '>' or '^'))
            {
                if (Char.IsDigit(input[i]) && i != 0) { }
                else
                {
                    System.Console.WriteLine("Not a Valid input character");
                    isValid = false;
                    System.Console.WriteLine(" The Program will end now. PLease try again.");
                    Environment.Exit(1);
                    
                }
            }
        }
    }
    while (!isValid);
    return input;
    }
ValidInput(input);


for (int i = 0; i < input.Length; i++)
{
    TempString1++ ;
   char c = input[i + TempString1];
   if(Char.IsDigit(c) == true )
   {
    switch(input.Substring(i + 2))
    {
     
    
     
    }

   }
   else
   {
    switch(c)
    {
        case 'V': HorizontalMove--; break;
        case '^': HorizontalMove++; break;
        case '<': VerticalMove++; break;
        case '>': VerticalMove--; break;
    }
   }
}
   

if(HorizontalMove == 0 && VerticalMove == 0 ){System.Console.WriteLine(" The Rover didn't move away from the Station");}
else if(VerticalMove < 0){System.Console.WriteLine($"The Rover moved {VerticalMove * -1} East");}
else if(HorizontalMove < 0){System.Console.WriteLine($"The Rover moved {HorizontalMove * -1} South ");}
else if(HorizontalMove > 0 ){System.Console.WriteLine($"The Rover moved {HorizontalMove} North");}
else if(VerticalMove > 0 ){System.Console.WriteLine($"The Rover moved {VerticalMove} West");}
if(MahatthanDistance() < 0){System.Console.WriteLine($"The Manhattan distance is {MahatthanDistance() * -1 }");}
else{System.Console.WriteLine($"The Manhattan distance is {MahatthanDistance()}");}
System.Console.WriteLine($"The Linear distance is {LinearDistance()}");
#region MahatthanDistance
int MahatthanDistance()
{
   return VerticalMove + HorizontalMove;

}
#endregion
#region Linear Distance
double LinearDistance()

{
   return Math.Sqrt(HorizontalMove * HorizontalMove + VerticalMove * VerticalMove);
}
#endregion

