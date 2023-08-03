// See https://aka.ms/new-console-template for more information
using DesignPatterns.Adapter;
using DesignPatterns.Bridge;

Console.WriteLine("Hello, World!");

#region Adapter Design Pattern
    //ITarget Itarget = new EmployeeAdapter();
    //ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
    //client.ShowEmployeeList();
    //Console.ReadKey();
#endregion

#region Brdige Design Pattern 
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
#endregion