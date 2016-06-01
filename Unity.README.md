## Download the Unity Package

You can directly download the Unity Packages build [here](http://sdk-for-net.amazonwebservices.com/latest/aws-sdk-unity.zip)

## Supported Services

At the moment Unity Solution only supports the following services

* [Amazon Cognito](http://aws.amazon.com/cognito/)
* [Amazon DynamoDB](http://aws.amazon.com/dynamodb/)
* [AWS Identity and Access Management ](http://aws.amazon.com/)
* [Amazon Kinesis Streams](https://aws.amazon.com/kinesis/streams/)
* [AWS Lambda](https://aws.amazon.com/lambda/)
* [Amazon Mobile Analytics](http://aws.amazon.com/mobileanalytics/)
* [Amazon Simple Email Service](https://aws.amazon.com/ses/)
* [Amazon Simple Notification Service](http://aws.amazon.com/sns/)
* [Amazon Simple Queue Service](https://aws.amazon.com/sqs/)
* [Amazon Simple Storage Service](http://aws.amazon.com/s3/)

## Supported Unity Version

With this release we are only supporting Unity versions > 4.6

## Supported Platforms

The AWS SDK for .NET (Unity) is currently only supported on Android, iOS and on Standalone platforms.

## Unity SDK Fundamentals

There are only a few fundamentals that are helpful to know when developing against the AWS SDK for .NET on Unity

* To enable logging you need to create a config file called awsconfig.xml in a `Resources` directory add add the following

		<?xml version="1.0" encoding="utf-8"?>
		<aws 
			<logging
	    		logTo="UnityLogger"
	    		logResponses="Always"
	    		logMetrics="true"
	    		logMetricsFormat="JSON" />
			/>
		/>
	
You can also do this configuration in a script

		var loggingConfig = AWSConfigs.LoggingConfig;
		loggingConfig.LogTo = LoggingOptions.UnityLogger;
		loggingConfig.LogMetrics = true;
		loggingConfig.LogResponses = ResponseLoggingOption.Always;
		loggingConfig.LogResponsesSizeLimit = 4096;
		loggingConfig.LogMetricsFormat = LogMetricsFormatOption.JSON;


* To Build the SDK from the `AWSSDK.Unity.sln` solution file you will need Unity 5 installed in the standard location (we reference the UnityEngine runtime from standard installation location)
* The SDK uses reflection for platform specific components. In case of IL2CPP since `strip bytecode` is always enabled on iOS you need to have a `link.xml` in your assembly root with the following entries


		<linker>
			<!-- if you are using AWSConfigs.HttpClient.UnityWebRequest option-->

		<assembly fullname="UnityEngine">
			<type fullname="UnityEngine.Experimental.Networking.UnityWebRequest" preserve="all" />
			<type fullname="UnityEngine.Experimental.Networking.UploadHandlerRaw" preserve="all" />
			<type fullname="UnityEngine.Experimental.Networking.UploadHandler" preserve="all" />
			<type fullname="UnityEngine.Experimental.Networking.DownloadHandler" preserve="all" />
			<type fullname="UnityEngine.Experimental.Networking.DownloadHandlerBuffer" preserve="all" />
		</assembly>
		
		<assembly fullname="mscorlib">
			<namespace fullname="System.Security.Cryptography" preserve="all"/>
   		</assembly>

		<assembly fullname="System">
			<namespace fullname="System.Security.Cryptography" preserve="all"/>
   		</assembly>

		<assembly fullname="AWSSDK.Core" preserve="all"/>
   		<assembly fullname="AWSSDK.CognitoIdentity" preserve="all"/>
   		<assembly fullname="AWSSDK.SecurityToken" preserve="all"/>
		add more services that you need here... 
		</linker>
