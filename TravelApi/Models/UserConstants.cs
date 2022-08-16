using System;
using System.Collections.Generic;

namespace TravelApi.Models
{
  public class UserConstants
  {
    public static List<User> Users = new List<User>()
    {
      new User { Id = 1, Username = "Joe", Password = "test"},
      new User { Id = 2, Username = "Matt", Password = "test"}
    };
  }
}