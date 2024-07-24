using GuestBookLibrary.Models;

// Capture the information about each guest (assumtion is at least one guest and unknow maximum)
// info to capture: First name, Last name, message to the host
// Once done, loop through each guest and print their info


List<GuestModel> guests = new List<GuestModel>();

GetGuestInformation(guests);
PrintGuestInformation(guests);


static void PrintGuestInformation(List<GuestModel> guests)
{
    foreach (GuestModel guest in guests)
    {
        Console.WriteLine(guest.GuestInfo);
    }
}
static void GetGuestInformation(List<GuestModel> guests)
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

static string GetInfoFromConsole(string message)
{
    string output = "";

    Console.Write(message);
    output = Console.ReadLine();

    return output;
}