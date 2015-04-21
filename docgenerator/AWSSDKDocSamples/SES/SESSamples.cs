using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;

using System.IO;

namespace AWSSDKDocSamples.SES
{
  class SESSamples : ISample
  {
    public static void SESSendEmail()
    {
      #region SESSendEmail
      var sesClient = new AmazonSimpleEmailServiceClient();           
      
      var dest = new Destination
      {
        ToAddresses = new List<string>() { "janedoe@example.com" },
        CcAddresses = new List<string>() { "richarddoe@example.com" }
      };

      var from = "johndoe@example.com";
      var subject = new Content("You're invited to the meeting");
      var body = new Body(new Content("Please join us Monday at 7:00 PM."));
      var msg = new Message(subject, body);

      var request = new SendEmailRequest
      {
        Destination = dest,
        Message = msg, 
        Source = from
      };

      sesClient.SendEmail(request);
      #endregion
    }

    public static void SESSendRawEmail()
    {
      #region SESSendRawEmail
      // using System.IO;

      var sesClient = new AmazonSimpleEmailServiceClient();

      var stream = new MemoryStream(
        Encoding.UTF8.GetBytes("From: johndoe@example.com\n" +
          "To: janedoe@example.com\n" +
          "Subject: You're invited to the meeting\n" +
          "Content-Type: text/plain\n\n" +
          "Please join us Monday at 7:00 PM.")
      );

      var raw = new RawMessage
      {
        Data = stream
      };

      var to = new List<string>() { "janedoe@example.com" };
      var from = "johndoe@example.com";

      var request = new SendRawEmailRequest
      {
        Destinations = to,
        RawMessage = raw,
        Source = from
      };

      sesClient.SendRawEmail(request);
      #endregion
    }

    public static void SESGetSendQuota()
    {
      #region SESGetSendQuota
      var sesClient = new AmazonSimpleEmailServiceClient();
      var response = sesClient.GetSendQuota();

      Console.WriteLine("Maximum emails that can be sent each 24 hours: " +
        response.Max24HourSend);
      Console.WriteLine("Maximum emails that can be sent per second: " +
        response.MaxSendRate);
      Console.WriteLine("Number of emails sent in last 24 hours: " + 
        response.SentLast24Hours);
      #endregion

      Console.ReadLine();
    }

    public static void SESSetIdentityFeedbackForwardingEnabled()
    {
      #region SESSetIdentityFeedbackForwardingEnabled
      var sesClient = new AmazonSimpleEmailServiceClient();

      var request = new SetIdentityFeedbackForwardingEnabledRequest
      {
        ForwardingEnabled = true,
        Identity = "johndoe@example.com"
      };

      sesClient.SetIdentityFeedbackForwardingEnabled(request);
      #endregion
    }

    public static void SESListIdentities()
    {
      #region SESListIdentities
      var sesClient = new AmazonSimpleEmailServiceClient();

      var response = sesClient.ListIdentities();

      if (response.Identities.Count > 0)
      {
        Console.WriteLine("Identities:");

        foreach (var identity in response.Identities)
        {
          Console.WriteLine("  " + identity);
        }
      }
      #endregion

      Console.ReadLine();
    }

    public static void SESListVerifiedEmailAddresses()
    {
      #region SESListVerifiedEmailAddresses
      var sesClient = new AmazonSimpleEmailServiceClient();

      var response = sesClient.ListVerifiedEmailAddresses();

      if (response.VerifiedEmailAddresses.Count > 0)
      {
        Console.WriteLine("Verified email addresses:");

        foreach (var address in response.VerifiedEmailAddresses)
        {
          Console.WriteLine("  " + address);
        }
      }
      #endregion

      Console.ReadLine();
    }

    public static void SESGetSendStatistics()
    {
      #region SESGetSendStatistics
      var sesClient = new AmazonSimpleEmailServiceClient();

      var response = sesClient.GetSendStatistics();

      Console.WriteLine("For request " + 
        response.ResponseMetadata.RequestId + ":");

      if (response.SendDataPoints.Count > 0)
      {
        foreach (var point in response.SendDataPoints)
        {
          Console.WriteLine();
          Console.WriteLine("Data points for " + point.Timestamp + ":");
          Console.WriteLine("  Bounces: " + point.Bounces);
          Console.WriteLine("  Complaints: " + point.Complaints);
          Console.WriteLine("  Delivery Attempts: " + point.DeliveryAttempts);
          Console.WriteLine("  Rejects: " + point.Rejects);
        }
      }
      else
      {
        Console.WriteLine("No data points.");
      }
      #endregion

      Console.ReadLine();
    }

    public static void SESGetIdentityNotificationAttributes()
    {
      #region SESGetIdentityNotificationAttributes
      var sesClient = new AmazonSimpleEmailServiceClient();
      var idsResponse = sesClient.ListIdentities();

      if (idsResponse.Identities.Count > 0)
      {
        var request = new GetIdentityNotificationAttributesRequest
        {
          Identities = idsResponse.Identities
        };

        var response = sesClient.GetIdentityNotificationAttributes(request);

        foreach (var attr in response.NotificationAttributes)
        {
          Console.WriteLine(attr.Key);
          Console.WriteLine("  Bounce Topic: " + attr.Value.BounceTopic);
          Console.WriteLine("  Complaint Topic: " + attr.Value.ComplaintTopic);
          Console.WriteLine("  Forwarding Enabled: " + 
            attr.Value.ForwardingEnabled);
          Console.WriteLine();
        }
      }
      #endregion

      Console.ReadLine();
    }

    public static void SESSetIdentityDkimEnabled()
    {
      #region SESSetIdentityDkimEnabled
      var sesClient = new AmazonSimpleEmailServiceClient();

      var request = new SetIdentityDkimEnabledRequest
      {
        DkimEnabled = false,
        Identity = "johndoe@example.com"
      };

      sesClient.SetIdentityDkimEnabled(request);
      #endregion
    }

    public static void SESGetIdentityVerificationAttributes()
    {
      #region SESGetIdentityVerificationAttributes
      var sesClient = new AmazonSimpleEmailServiceClient();

      var idsResponse = sesClient.ListIdentities();

      if (idsResponse.Identities.Count > 0)
      {
        var request = new GetIdentityVerificationAttributesRequest
        {
          Identities = idsResponse.Identities
        };

        var response = sesClient.GetIdentityVerificationAttributes(request);

        foreach (var attr in response.VerificationAttributes)
        {
          Console.WriteLine(attr.Key);
          Console.WriteLine("  Verification Status: " + 
            attr.Value.VerificationStatus.Value);
          Console.WriteLine("  Verification Token: " + 
            attr.Value.VerificationToken);
          Console.WriteLine();
        }
      };
      #endregion

      Console.ReadLine();
    }

    public static void SESVerifyEmailAddress()
    {
      #region SESVerifyEmailAddress
      var sesClient = new AmazonSimpleEmailServiceClient();

      var request = new VerifyEmailAddressRequest
      {
        EmailAddress = "johndoe@example.com"
      };

      sesClient.VerifyEmailAddress(request); 
      #endregion
    }

    public static void SESVerifyEmailIdentity()
    {
      #region SESVerifyEmailIdentity
      var sesClient = new AmazonSimpleEmailServiceClient();

      var request = new VerifyEmailIdentityRequest
      {
        EmailAddress = "johndoe@example.com"
      };

      sesClient.VerifyEmailIdentity(request);
      #endregion
    }

    public static void SESGetIdentityDkimAttributes()
    {
      #region SESGetIdentityDkimAttributes
      var sesClient = new AmazonSimpleEmailServiceClient();

      var idsResponse = sesClient.ListIdentities();

      if (idsResponse.Identities.Count > 0)
      {
        var request = new GetIdentityDkimAttributesRequest
        {
          Identities = idsResponse.Identities
        };

        var response = sesClient.GetIdentityDkimAttributes(request);

        foreach (var attr in response.DkimAttributes)
        {
          Console.WriteLine(attr.Key);
          Console.WriteLine("  DKIM Enabled: " + attr.Value.DkimEnabled);
          Console.WriteLine("  DKIM Verification Status: " + 
            attr.Value.DkimVerificationStatus.Value);

          if (attr.Value.DkimTokens.Count > 0)
          {
            Console.WriteLine("  DKIM Tokens: ");

            foreach (var token in attr.Value.DkimTokens)
            {
              Console.WriteLine("    " + token);
            }          
          }
          
          Console.WriteLine();
        }
      };
      #endregion

      Console.ReadLine();
    }

    public static void SESSetIdentityNotificationTopic()
    {
      #region SESSetIdentityNotificationTopic
      var sesClient = new AmazonSimpleEmailServiceClient();

      var bounceRequest = new SetIdentityNotificationTopicRequest
      {
        Identity = "johndoe@example.com",
        NotificationType = NotificationType.Bounce,
        SnsTopic = "arn:aws:sns:us-east-1:80398EXAMPLE:CodingTestResults"
      };

      sesClient.SetIdentityNotificationTopic(bounceRequest);

      var complaintRequest = new SetIdentityNotificationTopicRequest
      {
        Identity = "johndoe@example.com",
        NotificationType = NotificationType.Complaint,
        SnsTopic = "arn:aws:sns:us-east-1:80398EXAMPLE:CodingTestResults"
      };

      sesClient.SetIdentityNotificationTopic(complaintRequest);
      #endregion
    }

    public static void SESDeleteVerifiedEmailAddress()
    {
      #region SESDeleteVerifiedEmailAddress
      var sesClient = new AmazonSimpleEmailServiceClient();

      var request = new DeleteVerifiedEmailAddressRequest
      {
        EmailAddress = "johndoe@example.com"
      };

      sesClient.DeleteVerifiedEmailAddress(request);
      #endregion
    }

    public static void SESVerifyDomainIdentity()
    {
      #region SESVerifyDomainIdentity
      var sesClient = new AmazonSimpleEmailServiceClient();

      var request = new VerifyDomainIdentityRequest
      {
        Domain = "example.com"
      };

      var response = sesClient.VerifyDomainIdentity(request);

      Console.WriteLine("Verification token: " + response.VerificationToken);
      #endregion

      Console.ReadLine();
    }

    public static void SESVerifyDomainDkim()
    {
      #region SESVerifyDomainDkim
      var sesClient = new AmazonSimpleEmailServiceClient();

      var request = new VerifyDomainDkimRequest
      {       
        Domain = "example.com"
      };

      var response = sesClient.VerifyDomainDkim(request);

      Console.WriteLine("DKIM tokens:");

      foreach (var token in response.DkimTokens)
      {
        Console.WriteLine("  " + token);
      }
      #endregion

      Console.ReadLine();
    }

    public static void SESDeleteIdentity()
    {
      #region SESDeleteIdentity
      var sesClient = new AmazonSimpleEmailServiceClient();

      var request = new DeleteIdentityRequest
      {
        Identity = "johndoe@example.com"
      };

      sesClient.DeleteIdentity(request);
      #endregion
    }

    #region ISample Members
    public virtual void Run()
    {

    }
    #endregion
  }
}
