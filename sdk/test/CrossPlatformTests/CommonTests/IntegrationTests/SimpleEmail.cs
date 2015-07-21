using System;
using System.Collections.Generic;




using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using NUnit.Framework;
using CommonTests.Framework;


namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class SimpleEmail : TestBase<AmazonSimpleEmailServiceClient>
    {
        // Replace these email with valid emails.
        private const string sourceAddress = "bruce@example.com";
        private const string destinationAddress = "alice@example.com";

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        // To run this test uncomment the TestMethod attribute and use
        // valid email ids for sourceAddress and destinationAddress.
        //[Test]
        [Category("SimpleEmail")]
        public void TestSendEmail()
        {
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
            Client.SendEmailAsync(sendEmailRequest).Wait();
        }

        public void VerifyEmails(params string[] emails)
        {
            // start verification process for all email addresses
            foreach (var email in emails)
            {
                Client.VerifyEmailIdentityAsync(new VerifyEmailIdentityRequest
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
                var verificationAttributes = Client.GetIdentityVerificationAttributesAsync(new GetIdentityVerificationAttributesRequest
                {
                    Identities = new List<string>(emails)
                }).Result.VerificationAttributes;

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

                UtilityMethods.Sleep(TimeSpan.FromSeconds(15));
            }

            if (!allVerified)
                throw new InvalidOperationException("Not all email addresses have been verified");
        }
    }
}