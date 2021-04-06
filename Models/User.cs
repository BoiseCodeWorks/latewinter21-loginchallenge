namespace logingame.Models
{
  //anything contained in class is considered a member of it
  public class User
  {

    public User(string name, string password)
    {
      Name = name;
      Password = password;
    }

    //autoprops
    public string Name { get; set; }
    private string Password { get; set; }

    //this is what the autoprops are doing in the background.
    private string _email;



    public string Email
    {
      get
      {
        return _email;
      }
      set
      {
        _email = value;
      }
    }

    //access modifier, return type, method name
    public bool ValidatePassword(string input)
    {
      return input == Password;
    }



  }
}