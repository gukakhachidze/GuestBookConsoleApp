using GuestBookLibrary.GuestBookLogic;
using GuestBookLibrary.Models;

// Capture the information about each guest (assumtion is at least one guest and unknow maximum)
// info to capture: First name, Last name, message to the host
// Once done, loop through each guest and print their info


List<GuestModel> guests = new List<GuestModel>();

GuestBook.GetGuestInformation(guests);
GuestBook.PrintGuestInformation(guests);





