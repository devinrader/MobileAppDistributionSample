Mobile App Distribution Sample
====================

A simple Mobile App Distribution application written using Twilio and ASP.NET MVC 5.

To learn more about this application, check out my blog post showing how to create a simple Mobile App Distribution application using Twilio and ASP.NET MVC.

About this Application 
-----

This application was created using Visual Studio 2013, ASP.NET MVC 5 and Twilio.  To use this application you will need to create a Twilio account, which you can do for free.

To run this project you will need to replace the temporary Twilio AccountSid and AuthToken values in `Credentials.cs`:

    public static string AccountSid {get { return "[YOUR_ACCOUNT_SID]";}}
    public static string AuthToken { get { return "[YOUR_AUTH_TOKEN]";}}

You will also need to replace the temporary FROM number value with your own Twilio phone number in `Constants.cs`:

    public const string FROM = "[CALL_ID_PHONE_NUMBER]";
