using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWSSDKDocSamples.SNS
{
    class SNSSamples : ISample
    {
        public static async Task SNSCreateSubscribePublish()
        {
            #region SNSCreateSubscribePublish
            var snsClient = new AmazonSimpleNotificationServiceClient();

            var topicRequest = new CreateTopicRequest
            {
                Name = "CodingTestResults"
            };

            var topicResponse = await snsClient.CreateTopicAsync(topicRequest);

            var topicAttrRequest = new SetTopicAttributesRequest
            {
                TopicArn = topicResponse.TopicArn,
                AttributeName = "DisplayName",
                AttributeValue = "Coding Test Results"
            };

            await snsClient.SetTopicAttributesAsync(topicAttrRequest);

            await snsClient.SubscribeAsync(new SubscribeRequest
            {
                Endpoint = "johndoe@example.com",
                Protocol = "email",
                TopicArn = topicResponse.TopicArn
            });

            // Wait for up to 2 minutes for the user to confirm the subscription.
            DateTime latest = DateTime.Now + TimeSpan.FromMinutes(2);

            while (DateTime.Now < latest)
            {
                var subsRequest = new ListSubscriptionsByTopicRequest
                {
                    TopicArn = topicResponse.TopicArn
                };

                var subs = (await snsClient.ListSubscriptionsByTopicAsync(subsRequest)).Subscriptions;

                var sub = subs[0];

                if (!string.Equals(sub.SubscriptionArn,
                  "PendingConfirmation", StringComparison.Ordinal))
                {
                    break;
                }

                // Wait 15 seconds before trying again.
                await Task.Delay(TimeSpan.FromSeconds(15));
            }

            await snsClient.PublishAsync(new PublishRequest
            {
                Subject = "Coding Test Results for " +
                DateTime.Today.ToShortDateString(),
                Message = "All of today's coding tests passed.",
                TopicArn = topicResponse.TopicArn
            });
            #endregion
        }

        public static async Task SNSListTopics()
        {
            #region SNSListTopics
            var snsClient = new AmazonSimpleNotificationServiceClient();
            var request = new ListTopicsRequest();
            var response = new ListTopicsResponse();

            do
            {
                response = await snsClient.ListTopicsAsync(request);

                if (response.Topics != null)
                {
                    foreach (var topic in response.Topics)
                    {
                        Console.WriteLine("Topic: {0}", topic.TopicArn);

                        var attrs = (await snsClient.GetTopicAttributesAsync(
                          new GetTopicAttributesRequest
                          {
                              TopicArn = topic.TopicArn
                          })).Attributes;

                        if (attrs != null)
                        {
                            foreach (var attr in attrs)
                            {
                                Console.WriteLine(" -{0} : {1}", attr.Key, attr.Value);
                            }
                        }

                        Console.WriteLine();

                    }
                }

                request.NextToken = response.NextToken;

            } while (!string.IsNullOrEmpty(response.NextToken));
            #endregion

            Console.ReadLine();
        }

        public static async Task SNSListSubscriptionsByTopic()
        {
            #region SNSListSubscriptionsByTopic
            var snsClient = new AmazonSimpleNotificationServiceClient();
            var request = new ListSubscriptionsByTopicRequest();
            var response = new ListSubscriptionsByTopicResponse();

            request.TopicArn = "arn:aws:sns:us-east-1:80398EXAMPLE:CodingTestResults";

            do
            {
                response = await snsClient.ListSubscriptionsByTopicAsync(request);

                if (response.Subscriptions != null)
                {
                    foreach (var sub in response.Subscriptions)
                    {
                        Console.WriteLine("Subscription: {0}", sub.SubscriptionArn);

                        var subAttrs = (await snsClient.GetSubscriptionAttributesAsync(
                          new GetSubscriptionAttributesRequest
                          {
                              SubscriptionArn = sub.SubscriptionArn
                          })).Attributes;

                        if (subAttrs != null)
                        {
                            foreach (var subAttr in subAttrs)
                            {
                                Console.WriteLine(" -{0} : {1}", subAttr.Key, subAttr.Value);
                            }
                        }

                        Console.WriteLine();
                    }
                }

                request.NextToken = response.NextToken;

            } while (!string.IsNullOrEmpty(response.NextToken));
            #endregion

            Console.ReadLine();
        }

        public static async Task SNSListSubscriptions()
        {
            #region SNSListSubscriptions
            var snsClient = new AmazonSimpleNotificationServiceClient();
            var request = new ListSubscriptionsRequest();
            var response = new ListSubscriptionsResponse();

            do
            {
                response = await snsClient.ListSubscriptionsAsync(request);

                if (response.Subscriptions != null )
                {
                    foreach (var sub in response.Subscriptions)
                    {
                        Console.WriteLine("Subscription: {0}", sub.SubscriptionArn);
                    }
                }

                request.NextToken = response.NextToken;

            } while (!string.IsNullOrEmpty(response.NextToken));
            #endregion

            Console.ReadLine();
        }

        public static async Task SNSUnsubscribe()
        {
            #region SNSUnsubscribe
            var snsClient = new AmazonSimpleNotificationServiceClient();
            var request = new UnsubscribeRequest();

            request.SubscriptionArn =
              "arn:aws:sns:us-east-1:80398EXAMPLE:CodingTestResults:" +
              "2f5671ba-c68e-4231-a94a-e82d3EXAMPLE";

            await snsClient.UnsubscribeAsync(request);
            #endregion
        }

        public static async Task SNSAddPermission()
        {
            #region SNSAddPermission
            var snsClient = new AmazonSimpleNotificationServiceClient();

            var request = new AddPermissionRequest
            {
                TopicArn = "arn:aws:sns:us-east-1:80398EXAMPLE:CodingTestResults",
                ActionName = new List<string>() { "Subscribe" },
                AWSAccountId = new List<string>() { "80398EXAMPLE" },
                Label = "SubscribePolicy"
            };

            await snsClient.AddPermissionAsync(request);
            #endregion
        }

        public static async Task SNSDeleteTopic()
        {
            #region SNSDeleteTopic
            var snsClient = new AmazonSimpleNotificationServiceClient();

            var request = new DeleteTopicRequest
            {
                TopicArn = "arn:aws:sns:us-east-1:80398EXAMPLE:CodingTestResults"
            };

            await snsClient.DeleteTopicAsync(request);
            #endregion
        }

        public static async Task SNSConfirmSubscription()
        {
            #region SNSConfirmSubscription
            var snsClient = new AmazonSimpleNotificationServiceClient();

            var request = new ConfirmSubscriptionRequest
            {
                TopicArn = "arn:aws:sns:us-east-1:80398EXAMPLE:CodingTestResults",
                Token = "2336412f37fb687f5d51e6e241d638b059833563d4ff1b6f50a3be00e3a" +
                "ff3a5f486f64ab082b19d3b9a6e569ea3f6acb10d944314fc3af72ebc36085519" +
                "3a02f5a8631552643b8089c751cb8343d581231fb631f34783e30fd2d959dd5bb" +
                "ea7b11ef09dbd06023af5de4d390d53a10dc9652c01983b028206a1b3e00EXAMPLE"
            };

            await snsClient.ConfirmSubscriptionAsync(request);
            #endregion
        }

        public static async Task SNSMobilePushAPIsCreatePlatformApplication()
        {
            #region SNSMobilePushAPIsCreatePlatformApplication
            var snsClient = new AmazonSimpleNotificationServiceClient();

            var request = new CreatePlatformApplicationRequest
            {
                Attributes = new Dictionary<string, string>() { { "PlatformCredential", "AIzaSyDM1GHqKEdVg1pVFTXPReFT7UdGEXAMPLE" } },
                Name = "TimeCardProcessingApplication",
                Platform = "GCM"
            };

            await snsClient.CreatePlatformApplicationAsync(request);
            #endregion
        }

        public static async Task SNSMobilePushAPIsSetPlatformApplicationAttributes()
        {
            #region SNSMobilePushAPIsSetPlatformApplicationAttributes
            var snsClient = new AmazonSimpleNotificationServiceClient();

            var request =
              new SetPlatformApplicationAttributesRequest
              {
                  Attributes = new Dictionary<string, string>()
                  { { "EventDeliveryFailure",
                "arn:aws:sns:us-east-1:80398EXAMPLE:CodingTestResults" } },
                  PlatformApplicationArn =
                  "arn:aws:sns:us-east-1:80398EXAMPLE:" +
                  "app/GCM/TimeCardProcessingApplication"
              };

            await snsClient.SetPlatformApplicationAttributesAsync(request);
            #endregion
        }

        public static async Task SNSMobilePushAPIsCreatePlatformEndpoint()
        {
            #region SNSMobilePushAPIsCreatePlatformEndpoint
            var snsClient = new AmazonSimpleNotificationServiceClient();

            var request = new CreatePlatformEndpointRequest
            {
                CustomUserData = "Any arbitrary data can go here",
                PlatformApplicationArn = "arn:aws:sns:us-east-1:80398EXAMPLE:" +
                "app/GCM/TimeCardProcessingApplication",
                Token = "APBTKzPGlCyT6E6oOfpdwLpcRNxQp5vCPFiF" +
                "eru9oZylc22HvZSwQTDgmmw9WdNlXMerUPEXAMPLE"
            };

            await snsClient.CreatePlatformEndpointAsync(request);
            #endregion
        }

        public static async Task SNSMobilePushAPIsSetEndpointAttributes()
        {
            #region SNSMobilePushAPIsSetEndpointAttributes
            var snsClient = new AmazonSimpleNotificationServiceClient();

            var request = new SetEndpointAttributesRequest
            {
                EndpointArn = "arn:aws:sns:us-east-1:80398EXAMPLE:" +
                "endpoint/GCM/TimeCardProcessingApplication/" +
                "d84b5f0d-7136-3bbe-9b42-4e001EXAMPLE",
                Attributes = new Dictionary<string, string>() { { "Enabled", "true" } }
            };

            await snsClient.SetEndpointAttributesAsync(request);
            #endregion
        }

        public static async Task SNSMobilePushAPIsListApplicationsEndpoints()
        {
            #region SNSMobilePushAPIsListApplicationsEndpoints
            var snsClient = new AmazonSimpleNotificationServiceClient();
            var appsResponse = await snsClient.ListPlatformApplicationsAsync();

            if (appsResponse.PlatformApplications != null)
            {
                foreach (var app in appsResponse.PlatformApplications)
                {
                    Console.WriteLine();

                    var appAttrsRequest = new GetPlatformApplicationAttributesRequest
                    {
                        PlatformApplicationArn = app.PlatformApplicationArn
                    };

                    var appAttrsResponse =
                      await snsClient.GetPlatformApplicationAttributesAsync(appAttrsRequest);

                    var endpointsByAppRequest =
                      new ListEndpointsByPlatformApplicationRequest
                      {
                          PlatformApplicationArn = app.PlatformApplicationArn
                      };

                    var endpointsByAppResponse =
                      await snsClient.ListEndpointsByPlatformApplicationAsync(
                      endpointsByAppRequest);

                    Console.WriteLine("Application: " + app.PlatformApplicationArn);
                    Console.WriteLine("  Properties: ");

                    if (appAttrsResponse.Attributes != null)
                    {
                        foreach (var attr in appAttrsResponse.Attributes)
                        {
                            Console.WriteLine("    " + attr.Key + ": " + attr.Value);
                        }
                    }

                    Console.WriteLine("  Endpoints: ");

                    if (endpointsByAppResponse.Endpoints != null)
                    {
                        foreach (var endpoint in endpointsByAppResponse.Endpoints)
                        {
                            Console.WriteLine("     ARN: " + endpoint.EndpointArn);
                            Console.WriteLine("     Attributes: ");

                            if (endpoint.Attributes != null)
                            {
                                foreach (var attr in endpoint.Attributes)
                                {
                                    Console.WriteLine("       " + attr.Key + ": " + attr.Value);
                                }
                            }
                        }
                    }
                }
            }

            #endregion

            Console.ReadLine();
        }

        public static async Task SNSMobilePushAPIsDeletePlatformEndpoint()
        {
            #region SNSMobilePushAPIsDeletePlatformEndpoint
            var snsClient = new AmazonSimpleNotificationServiceClient();

            var request = new DeleteEndpointRequest
            {
                EndpointArn = "arn:aws:sns:us-east-1:80398EXAMPLE:" +
                "endpoint/GCM/TimeCardProcessingApplication/" +
                "d84b5f0d-7136-3bbe-9b42-4e001EXAMPLE"
            };

            await snsClient.DeleteEndpointAsync(request);
            #endregion
        }

        public static async Task SNSMobilePushAPIsDeletePlatformApplication()
        {
            #region SNSMobilePushAPIsDeletePlatformApplication
            var snsClient = new AmazonSimpleNotificationServiceClient();

            var request = new DeletePlatformApplicationRequest
            {
                PlatformApplicationArn = "arn:aws:sns:us-east-1:80398EXAMPLE:" +
                "app/GCM/TimeCardProcessingApplication"
            };

            await snsClient.DeletePlatformApplicationAsync(request);
            #endregion
        }

        #region ISample Members
        public virtual Task Run()
        {
            return Task.CompletedTask;
        }
        #endregion
    }
}
