using System;
using System.Globalization;
    while (true)
    {
    Console.WriteLine("Let's Take a Quiz with Friend!");
    Console.WriteLine ("Answer to the question or write 'quit' to close the game");
    Console.WriteLine("What kind of food is Penne?");
    Console.WriteLine ("first player:");
    
    int firstPlayerPoints = 0;
    int secondPlayerPoints = 0;
    
    string? FirstPlayerSign = Console.ReadLine ();
    if (FirstPlayerSign == "quit")
    {
        break;
    }
     Console.WriteLine ("second player:");
    string? SecondPlayerSign = Console.ReadLine ();
     if (SecondPlayerSign == "quit")
    {
        break;
    }
     if ( FirstPlayerSign != "pasta" && SecondPlayerSign != "pasta")
        {
            Console.WriteLine ("Ur both wrong!"); 
        }
     else if ( FirstPlayerSign == SecondPlayerSign)
        {
            Console.WriteLine ("It's a draw!");
        } 
    else if ( FirstPlayerSign == "pasta" && SecondPlayerSign != "pasta")
        {
            Console.WriteLine ("First Player won!");
            firstPlayerPoints = firstPlayerPoints + 1;
        }
        if ( FirstPlayerSign != "pasta" && SecondPlayerSign == "pasta")
        {
            Console.WriteLine ("Second player won!");
            secondPlayerPoints = secondPlayerPoints + 1;
        }
        Console.WriteLine($"current points : firstplayer {firstPlayerPoints} : secondplayer {secondPlayerPoints}");
        
        Console.WriteLine ("Which mountain is the highest in the world?");
        Console.WriteLine ("first player:");
    string? FirstPlayerSecondSign = Console.ReadLine();
         if (FirstPlayerSecondSign == "quit")
    {
        break;
    }
            Console.WriteLine ("second player:");
    string? SecondPlayerSecondSign = Console.ReadLine ();
     if (SecondPlayerSecondSign == "quit")
    {
        break;
    }
    if ( FirstPlayerSecondSign != "mount everest" && SecondPlayerSecondSign != "mount everest")
        {
            Console.WriteLine ("Ur both wrong!"); 
        }
    else if ( FirstPlayerSecondSign == SecondPlayerSecondSign)
        {
            Console.WriteLine ("It's a draw!");
        } 
        else if ( FirstPlayerSecondSign == "mount everest" && SecondPlayerSecondSign != "mount everest")
        {
            Console.WriteLine ("First Player won!");
             firstPlayerPoints = firstPlayerPoints + 1;
        }
        else if ( FirstPlayerSecondSign != "mount everest" && SecondPlayerSecondSign == "mount everest")

        {
            Console.WriteLine ("Second player won!");
             secondPlayerPoints = secondPlayerPoints + 1;
        }
        Console.WriteLine($"current points : firstplayer {firstPlayerPoints} : secondplayer {secondPlayerPoints}");
        Console.WriteLine ("Which is the nearest star to earth?");
        Console.WriteLine ("first player:");
    string? FirstPlayerThirdSign = Console.ReadLine();
         if (FirstPlayerThirdSign == "quit")
    {
        break;
    }
    
            Console.WriteLine ("second player:");
    string? SecondPlayerThirdSign = Console.ReadLine ();
     if (SecondPlayerThirdSign == "quit")
    {
        break;
    }
    if ( FirstPlayerThirdSign != "sun" && SecondPlayerThirdSign != "sun")
        {
            Console.WriteLine ("Ur both wrong!"); 
        }
    else if ( FirstPlayerThirdSign == SecondPlayerThirdSign)
        {
            Console.WriteLine ("It's a draw!");
        } 
        else if ( FirstPlayerThirdSign == "sun" && SecondPlayerThirdSign != "sun")
        {
            Console.WriteLine ("First Player won!");
            firstPlayerPoints = firstPlayerPoints + 1;
        }
        if ( FirstPlayerThirdSign != "sun" && SecondPlayerThirdSign == "sun")
        {
            Console.WriteLine ("Second player won!");
            secondPlayerPoints = secondPlayerPoints + 1;
        }
        Console.WriteLine($"current points : firstplayer {firstPlayerPoints} : secondplayer {secondPlayerPoints}");
        Console.WriteLine ("Who painted the Mona Lisa?");
        Console.WriteLine ("first player:");
    string? FirstPlayerFourthSign = Console.ReadLine();
     if (FirstPlayerFourthSign == "quit")
    {
        break;
    }
        Console.WriteLine ("second player:");
    string? SecondPlayerFourthSign = Console.ReadLine();
     if (SecondPlayerFourthSign == "quit")
    {
        break;
    }
        if ( FirstPlayerFourthSign != "leonardo da vinci" && SecondPlayerSign != "leonardo da vinci")
        {
            Console.WriteLine ("Ur both wrong!"); 
        }
       else if ( FirstPlayerFourthSign == SecondPlayerFourthSign)
        {
            Console.WriteLine ("It's a draw!");
        } 
            else if ( FirstPlayerFourthSign == "leonardo da vinci" && SecondPlayerFourthSign != "leonardo da vinci")
        {
            Console.WriteLine ("First Player won!");
            firstPlayerPoints = firstPlayerPoints + 1;
        }
        if ( FirstPlayerFourthSign != "leonardo da vinci" && SecondPlayerFourthSign == "leonardo da vinci")
        {
            Console.WriteLine ("Second player won!");
            secondPlayerPoints = secondPlayerPoints + 1;
        }
        Console.WriteLine($"current points : firstplayer {firstPlayerPoints} : secondplayer {secondPlayerPoints}");
            Console.WriteLine("Press Enter to start a new game or write 'quit' to close");
        Console.ReadLine();
    string? FirstPlayerFifthSign = Console.ReadLine(); 
    if (FirstPlayerFifthSign == "quit")
    {
        break;
    }
    string? SecondPlayerFifthSign = Console.ReadLine (); 
    if (SecondPlayerFifthSign == "quit")
    {
        break;
    }
   }
