using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;


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
        //[TestMethod]        
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
            while(DateTime.Now < latest)
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