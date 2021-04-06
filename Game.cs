using System;
using System.Collections.Generic;
using logingame.Models;

namespace logingame
{
  public class Game
  {
    public Game()
    {
      User tim = new User("Timbo", "Timbosl!ce");
      Register(tim);
      User jordan = new User("Catman", "<3catsmeow<3");
      Register(jordan);
      User daniel = new User("Bigdad", "RawRxD");
      Register(daniel);
    }

    public Dictionary<string, User> Users { get; set; } = new Dictionary<string, User>();
    public void Login()
    {
      System.Console.WriteLine("Please enter your creds to continue. \nUsername:");
      string username = Console.ReadLine();
      System.Console.WriteLine("Password:");
      string password = Console.ReadLine();
      if (Users.ContainsKey(username.ToLower()) && Users[username.ToLower()].ValidatePassword(password))
      {
        System.Console.WriteLine("Welcome to the mainframe " + username);
      }
      else
      {
        System.Console.WriteLine("The authorities are enroute");
      }
    }

    public void Register(User newUser)
    {
      Users.Add(newUser.Name.ToLower(), newUser);
      //   return "User ADded";
    }


  }
}