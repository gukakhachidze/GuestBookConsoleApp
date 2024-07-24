using GuestBookLibrary.Models;

namespace GuestBookLibrary.GuestBookLogic
{
    public static class GuestBook
    {
        public static void PrintGuestInformation(List<GuestModel> guests)
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

        public static void GetGuestInformation(List<GuestModel> guests)
        {
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInfoFromConsole("What is your first name: ");
                guest.LastName = GetInfoFromConsole("What is your last name: ");
                guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");
                moreGuestsComing = GetInfoFromConsole("Are more guests coming (yes/no): ");

                guests.Add(guest);

                Console.Clear();

            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
    }
}
