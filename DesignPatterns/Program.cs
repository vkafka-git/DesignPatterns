// See https://aka.ms/new-console-template for more information
using DesignPatterns.Adapter;

Console.WriteLine("Hello, World!");

#region Adapter Design Pattern
    ITarget Itarget = new EmployeeAdapter();
    ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
    client.ShowEmployeeList();
    Console.ReadKey();
#endregion