using System.ComponentModel;
using System.Runtime.Remoting.Messaging;

namespace FriendOrganizer.Model
{
    public class LookupItem
    {
        public int Id { get; set; }

        public string DisplayMember { get; set; }

    }

    public class NullLookupItem : LookupItem
    {
        public new int? Id
        {
            get { return null; }
        }
    }
}
