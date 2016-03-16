using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using System.Text;
using System.Net.Mail;
using System.IO;
using System.Reflection;
using System.Linq;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
  [TestClass]
  public class SimpleEmail : TestBase<AmazonSimpleEmailServiceClient>
  {
    [ClassCleanup]
    public static void Cleanup()
    {
      BaseClean();
    }

    // To run this test uncomment the TestMethod attribute and use
    // valid email ids for sourceAddress and destinationAddress.
    [TestMethod]
    [TestCategory("SimpleEmail")]
    public void TestSendEmail()
    {
      // Replace these email with valid emails.
      var sourceAddress = "bruce@example.com";
      var destinationAddress = "alice@example.com";

      // verify email addresses, both source and destination
      VerifyEmails(sourceAddress, destinationAddress);

      // send email
      var sendEmailRequest = new SendEmailRequest
      {
        Source = sourceAddress,
        Destination = new Destination
        {
          ToAddresses = new List<string> { destinationAddress }
        },
        Message = new Message
        {
          Subject = new Content("Re: Monday meeting"),
          Body = new Body
          {
            Html = new Content(@"<h2>Meeting on Monday</h2> <br/> Monday's meeting to discuss <b>intern projects</b> <br/> Let's start at 9:30am.")
          }
        }
      };
      Client.SendEmail(sendEmailRequest);
    }

    [TestMethod]
    [TestCategory("SimpleEmail")]
    public void TestSendRawEmailWithBccRecipient()
    {
      // Replace these email with valid emails.
      var sourceAddress = "bruce@example.com";
      var bccDestination = "alice@example.com";
      var destinationAddress = "lisa@example.com";

      List<String> bccAddresses = bccDestination.Replace(", ", ",").Split(',').ToList();

      // verify email addresses, both source and destination
      VerifyEmails(sourceAddress, destinationAddress, bccDestination);
      var text = "Text version";
      var html = "<p>HTML version</p>";
      AlternateView plainView = AlternateView.CreateAlternateViewFromString(text, Encoding.UTF8, "text/plain");
      AlternateView htmlView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, "text/html");

      MailMessage mailMessage = new MailMessage();
      mailMessage.From = new MailAddress(sourceAddress);

      List<String> toAddresses = destinationAddress.Replace(", ", ",").Split(',').ToList();
      
      //API errs if we don't set the To address but that's not the client's fault
      foreach (String toAddress in toAddresses)
      {
        mailMessage.To.Add(new MailAddress(toAddress));
      }
      
      mailMessage.Subject = "Test Email using SendRawEmailMessage";
      mailMessage.SubjectEncoding = Encoding.UTF8;

      if (text != null)
      {
        mailMessage.AlternateViews.Add(plainView);
      }

      if (html != null)
      {
        mailMessage.AlternateViews.Add(htmlView);
      }

      RawMessage rawMessage = new RawMessage();

      using (MemoryStream memoryStream = ConvertMailMessageToMemoryStream(mailMessage))
      {
        rawMessage.Data = memoryStream;
      }

      SendRawEmailRequest request = new SendRawEmailRequest();
      request.RawMessage = rawMessage;
      request.Destination = new Destination()
      {
        //ToAddresses = toAddresses, //If included, overwrites all the headers, that's a known issue
        BccAddresses = bccAddresses
      };
      request.Source = sourceAddress;
      SendRawEmailResponse response = Client.SendRawEmail(request);
    }

    /// <summary>
    /// Converts a MailMessage object into a MemoryStream
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    /// <remarks>Known reflection method to use the private Send method API from MailMessage</remarks>
    public static MemoryStream ConvertMailMessageToMemoryStream(MailMessage message)
    {
      System.Reflection.Assembly assembly = typeof(SmtpClient).Assembly;
      Type mailWriterType = assembly.GetType("System.Net.Mail.MailWriter");
      MemoryStream fileStream = new MemoryStream();
      ConstructorInfo mailWriterContructor = mailWriterType.GetConstructor(System.Reflection.BindingFlags.Instance | BindingFlags.NonPublic, null, new[] { typeof(Stream) }, null);
      object mailWriter = mailWriterContructor.Invoke(new object[] { fileStream });
      MethodInfo sendMethod = typeof(MailMessage).GetMethod("Send", BindingFlags.Instance | BindingFlags.NonPublic);
      ///The 4.5 framework has 3 parameters, otherwise we just set 2
      if (sendMethod.GetParameters().Length ==2)
      {
        sendMethod.Invoke(message, BindingFlags.Instance | BindingFlags.NonPublic, null, new[] { mailWriter, true }, null);
      }
      else
      {
        sendMethod.Invoke(message, BindingFlags.Instance | BindingFlags.NonPublic, null, new[] { mailWriter, true, true }, null);
      }
      MethodInfo closeMethod = mailWriter.GetType().GetMethod("Close", BindingFlags.Instance | BindingFlags.NonPublic);
      closeMethod.Invoke(mailWriter, BindingFlags.Instance | BindingFlags.NonPublic, null, new object[] { }, null);
      return fileStream;
    }

    public static void VerifyEmails(params string[] emails)
    {
      // start verification process for all email addresses
      foreach (var email in emails)
      {
        Client.VerifyEmailIdentity(new VerifyEmailIdentityRequest
        {
          EmailAddress = email
        });
      }

      // wait until all are verified, maximum wait time of two minutes
      bool allVerified = true;
      DateTime latest = DateTime.Now + TimeSpan.FromMinutes(2);
      while (DateTime.Now < latest)
      {
        // get verification status for all emails
        var verificationAttributes = Client.GetIdentityVerificationAttributes(new GetIdentityVerificationAttributesRequest
        {
          Identities = new List<string>(emails)
        }).VerificationAttributes;

        // test verification status
        allVerified = true;
        foreach (var email in emails)
        {
          var attribute = verificationAttributes[email];
          if (attribute.VerificationStatus != VerificationStatus.Success)
            allVerified = false;
        }

        if (allVerified)
          break;

        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(15));
      }

      if (!allVerified)
        throw new InvalidOperationException("Not all email addresses have been verified");
    }
  }
}