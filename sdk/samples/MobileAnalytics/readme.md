#Mobile Analytics Sample

###How to Run the Amazon Mobile Analytics Sample

#####Setting up the SDK and Sample
1. Install nuget package AWSSDK.MobileAnalytics.
2. Get your App ID (created in the Amazon Mobile Analytics console at https://console.aws.amazon.com/mobileanalytics/home/?region=us-east-1#/overview?consoleState=management) in the "App ID" field.
5. Add your App ID and AWS credential in MainActivity.cs.

#####Run the app
1. Connect your Mobile device to PC and click "debug" button in Visual Studio.
2. In the app view, you can press two buttons. One will record a custom event and the other will record a monetization event.
Note: The AWS SDK sends events every 60 seconds. After clicking on one of the buttons to record an event, you need to wait up to 60 seconds for the events to be delivered (you should see a logging message stating successful delivery when this happens). Once sent, it will take up to an hour for the events to show up on the Amazon Mobile Analytics console.

