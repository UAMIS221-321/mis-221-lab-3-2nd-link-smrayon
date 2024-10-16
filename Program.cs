// See https://aka.ms/new-console-template for more information

using System;

using System.Net.NetworkInformation;

class Program {
    static string GetEnjoymentLevel() {
        Console.WriteLine("What is your preferred level of enjoyment: Boring, Average, Fun, or Epic?");
        return Console.ReadLine();
    }

    static string GetStadiumRecommendation(string enjoymentLevel){
        if (enjoymentLevel.ToLower() == "boring"){
            return "Neyland Stadium";
        }

        else if (enjoymentLevel.ToLower() == "average"){
            return "Jordan-Hare Stadium";
        }

        else if (enjoymentLevel.ToLower() == "fun"){
            return "Tiger Stadium";
        }

        else if (enjoymentLevel.ToLower() == "epic"){
            return "Saban Field at Bryant-Denny Stadium";
        }

        else{
            return "None";
        }
    }


    static string GetGameRecommendation(string stadium) {
        if (stadium == "Neyland Stadium"){
            return "vs Kent State";
        }

        else if (stadium == "Jordan-Hare Stadium"){
            return "vs Kentucky";
        }

        else if (stadium == "Tiger Stadium"){
            return "vs Alabama";
        }

        else if (stadium == "Saban Field at Bryant-Denny Stadium"){
            return "vs Auburn";
        }

        else {
            return "None";
        }
    }

    static void DisplayStadiumDetails(string stadium, string game) {
        System.Console.WriteLine("I recommend: " + stadium + " for the game " + game);
    }

    static void Main(string[] args) {
        string enjoymentLevel = GetEnjoymentLevel();
        string stadium = GetStadiumRecommendation(enjoymentLevel);
        string game = GetGameRecommendation(stadium);
        DisplayStadiumDetails(stadium, game);
    }

}