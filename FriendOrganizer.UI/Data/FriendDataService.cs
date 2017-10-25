using System.Collections.Generic;
using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            yield return new Friend {FirstName = "Mike", LastName = "Hawk"};
            yield return new Friend { FirstName = "Ben", LastName = "Dover" };
            yield return new Friend { FirstName = "Isaac", LastName = "Cox" };
            yield return new Friend { FirstName = "Mike", LastName = "Hunt" };
        }
    }
}
