﻿// See https://aka.ms/new-console-template for more information
using DesignPatterns.AbstractFactory;
using DesignPatterns.Adapter;
using DesignPatterns.Bridge;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Observer;
using DesignPatterns.Strategy;

Console.WriteLine("Hello, World!");

#region Adapter Design Pattern
//ITarget Itarget = new EmployeeAdapter();
//ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
//client.ShowEmployeeList();
//Console.ReadKey();
#endregion

#region Brdige Design Pattern 
/*
IMessageSender email = new EmailSender();
IMessageSender queue = new MSMQSender();
IMessageSender web = new WebServiceSender();

Message message = new SystemMessage();
message.Subject = "Test Message";
message.Body = "Hi, This is a Test Message";

message.MessageSender = email;
message.Send();

message.MessageSender = queue;
message.Send();

message.MessageSender = web;
message.Send();

UserMessage usermsg = new UserMessage();
usermsg.Subject = "Test Message";
usermsg.Body = "Hi, This is a Test Message";
usermsg.UserComments = "I hope you are well";

usermsg.MessageSender = email;
usermsg.Send();

Console.ReadKey();
*/
#endregion

#region Strategy Design Pattern
/*
//Ask the user to Select the Travel Type
Console.WriteLine("Please Enter Travel Type : \n1 for Auto \n2 for Bus \n3 for Train \n4 for Taxi");
int travelType = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You Select Travel type : " + travelType);
//Create an Instance of the TravelContext class
TravelContext ctx = new TravelContext();
//Based on the Travel Type Selected by user at Runtime,
//Create the Appropriate Travel Instance and call the SetTravelStrategy method
if (travelType == (int)TravelType.Bus)
{
    ctx.SetTravelStrategy(new BusTravelStrategy());
}
else if (travelType == (int)TravelType.Train)
{
    ctx.SetTravelStrategy(new TrainTravelStrategy());
}
else if (travelType == (int)TravelType.Taxi)
{
    ctx.SetTravelStrategy(new TaxiTravelStrategy());
}
else if (travelType == (int)TravelType.Auto)
{
    ctx.SetTravelStrategy(new AutoTravelStrategy());
}
else
{
    Console.WriteLine("You Select an Invalid Option");
}
//Finally, call the GotoAirport Method
ctx.GotoAirport();
Console.Read();
*/
#endregion

#region Observer Design Pattern
/*
//Create a Product with Out of Stock Status
Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
//User Anurag will be created and the user1 object will be registered to the subject
Observer user1 = new Observer("Anurag");
user1.AddSubscriber(RedMI);
//User Pranaya will be created and the user1 object will be registered to the subject
Observer user2 = new Observer("Pranaya");
user2.AddSubscriber(RedMI);
//User Priyanka will be created and the user3 object will be registered to the subject
Observer user3 = new Observer("Priyanka");
user3.AddSubscriber(RedMI);
Console.WriteLine("Red MI Mobile current state : " + RedMI.GetAvailability());
Console.WriteLine();
user3.RemoveSubscriber(RedMI);
// Now the product is available
RedMI.SetAvailability("Available");
Console.Read();
*/
#endregion

#region FactoryMethod
/*
// The client code works with an instance of a concrete creator
// The CreateProduct will return the actual product instance via the product interface
//PlatinumFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
ICreditCard creditCard = new PlatinumFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine("Card Type : " + creditCard.GetCardType());
    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}
Console.WriteLine("--------------");
//MoneyBackFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
creditCard = new MoneyBackFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine("Card Type : " + creditCard.GetCardType());
    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}
Console.ReadLine();
*/
#endregion

#region Abstract Factory
    IVehicleFactory honda = new HondaFactory();
    VehicleClient hondaclient = new VehicleClient(honda, "Regular");

    Console.WriteLine("******* Honda **********");
    Console.WriteLine(hondaclient.GetBikeName());
    Console.WriteLine(hondaclient.GetScooterName());

    hondaclient = new VehicleClient(honda, "Sports");
    Console.WriteLine(hondaclient.GetBikeName());
    Console.WriteLine(hondaclient.GetScooterName());

    IVehicleFactory hero = new HeroFactory();
    VehicleClient heroclient = new VehicleClient(hero, "Regular");

    Console.WriteLine("******* Hero **********");
    Console.WriteLine(heroclient.GetBikeName());
    Console.WriteLine(heroclient.GetScooterName());

    heroclient = new VehicleClient(hero, "Sports");
    Console.WriteLine(heroclient.GetBikeName());
    Console.WriteLine(heroclient.GetScooterName());

    Console.ReadKey();
#endregion