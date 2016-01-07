using Amazon.Runtime;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using AWSSDK.Tests.Framework;

namespace AWSSDK.IntegrationTests.SimpleEmail
{
    [TestFixture(TestOf = typeof(SimpleEmailTests))]
    [Category("Integration")]
    public class SimpleEmailTests : TestBase<AmazonSimpleEmailServiceClient>
    {
        // Replace these email with valid emails.
        private const string sourceAddress = "nobody@example.com";
        private const string destinationAddress = "nobody@example.com";

        // To run this test uncomment the Test attribute and use
        // valid email ids for sourceAddress and destinationAddress.
        //[Test]
        public void SendEmailTest()
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
                    Subject = new Content("Unity SES Test"),
                    Body = new Body
                    {
                        Html = new Content(@"Ignore this email <br/> Because it is just a test <br/> And a haiku, too!")
                    }
                }
            };

            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            Client.SendEmailAsync(sendEmailRequest, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
        }


        [Test]
        [Category("WWW")]
        public void SendEmailToInvalidAddressTest()
        {
            var sendEmailRequest = new SendEmailRequest
            {
                Source = "notarealemail@example.com",
                Destination = new Destination
                {
                    ToAddresses = new List<string> { "aslonotarealemail@example.com" }
                },
                Message = new Message
                {
                    Subject = new Content("Unity SES Test"),
                    Body = new Body
                    {
                        Html = new Content(@"Ignore this email <br/> Because it is just a test <br/> And a haiku, too!")
                    }
                }
            };

            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            Client.SendEmailAsync(sendEmailRequest, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNotNull(responseException);
            Assert.IsInstanceOf(typeof(MessageRejectedException), responseException);
        }

        public void VerifyEmails(params string[] emails)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            // start verification process for all email addresses
            foreach (var email in emails)
            {
                Client.VerifyEmailIdentityAsync(new VerifyEmailIdentityRequest
                {
                    EmailAddress = email
                }, (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);
            }

            // wait until all are verified, maximum wait time of two minutes
            bool allVerified = true;
            DateTime latest = DateTime.Now + TimeSpan.FromMinutes(2);
            while (DateTime.Now < latest)
            {
                // get verification status for all emails
                Dictionary<string, IdentityVerificationAttributes> verificationAttributes = null;
                Client.GetIdentityVerificationAttributesAsync(new GetIdentityVerificationAttributesRequest
                {
                    Identities = new List<string>(emails)
                }, (response) =>
                {
                    responseException = response.Exception;
                    if (responseException == null)
                    {
                        verificationAttributes = response.Response.VerificationAttributes;
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);

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

                Thread.Sleep(TimeSpan.FromSeconds(15));
            }

            if (!allVerified)
                throw new InvalidOperationException("Not all email addresses have been verified");
        }
    }
}