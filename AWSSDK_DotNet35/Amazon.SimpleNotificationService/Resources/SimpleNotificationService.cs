/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */

using System;
using System.Collections.Generic;

using Amazon.Runtime.Resources;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

namespace Amazon.SimpleNotificationService.Resources
{
    /// <summary>    
    /// A service is the entry point for using the Resource API. This class allows you to 
    /// access the top-level resources and operations associated with the
    /// Amazon Simple Notification Service service.
    /// </summary>
    public class SimpleNotificationService : Service<IAmazonSimpleNotificationService>
    {

        #region Constructors

        /// <summary>
        /// Constructs SimpleNotificationService with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public SimpleNotificationService() : base(new AmazonSimpleNotificationServiceClient()) {}

        /// <summary>
        /// Constructs SimpleNotificationService with an instance of AmazonSimpleNotificationServiceClient.
        /// </summary>     
        /// <param name="client">The AmazonSimpleNotificationServiceClient to use for requests.</param>   
        public SimpleNotificationService(IAmazonSimpleNotificationService client)
            : base(client)
        {
            this.ShouldDisposeClient = false;
        }

        #endregion
 
        # region Methods for service-level operations

        /// <summary>
        /// Calls the CreatePlatformApplication operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformApplication operation.</param>
        /// <returns>An instance of the PlatformApplication resource.</returns>
        public IPlatformApplication CreatePlatformApplication(CreatePlatformApplicationRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.CreatePlatformApplication, "CreatePlatformApplication");
            return new Internal.PlatformApplication(arn : response.PlatformApplicationArn, client : this.Client);
            
        }
        /// <summary>
        /// Calls the CreatePlatformApplication on the service.
        /// </summary>
        /// <param name="name">Application names must be made up of only uppercase and lowercase ASCII letters, numbers, underscores, hyphens, and periods, and must be between 1 and 256 characters long.</param>
        /// <param name="platform">The following platforms are supported: ADM (Amazon Device Messaging), APNS (Apple Push Notification Service), APNS_SANDBOX, and GCM (Google Cloud Messaging).</param>
        /// <param name="attributes">For a list of attributes, see <a href="http://docs.aws.amazon.com/sns/latest/api/API_SetPlatformApplicationAttributes.html">SetPlatformApplicationAttributes</a></param>
        /// <returns>An IPlatformApplication associated with the service.</returns>
        public IPlatformApplication CreatePlatformApplication(string name, string platform, Dictionary<string, string> attributes)
        {
            var request = new CreatePlatformApplicationRequest();
            request.Attributes = attributes;
            request.Name = name;
            request.Platform = platform;
            return CreatePlatformApplication(request);
         }


        /// <summary>
        /// Calls the CreateTopic operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic operation.</param>
        /// <returns>An instance of the Topic resource.</returns>
        public ITopic CreateTopic(CreateTopicRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.CreateTopic, "CreateTopic");
            return new Internal.Topic(arn : response.TopicArn, client : this.Client);
            
        }
        /// <summary>
        /// Calls the CreateTopic on the service.
        /// </summary>
        /// <param name="name">The name of the topic you want to create. Constraints: Topic names must be made up of only uppercase and lowercase ASCII letters, numbers, underscores, and hyphens, and must be between 1 and 256 characters long. </param>
        /// <returns>An ITopic associated with the service.</returns>
        public ITopic CreateTopic(string name)
        {
            var request = new CreateTopicRequest();
            request.Name = name;
            return CreateTopic(request);
         }


        #endregion

        #region Methods to get resource collections associated with the service
        /// <summary>
        /// Gets the PlatformApplications associated with the service.
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformApplicationsEnumerator operation.</param>
        /// <returns>An IEnumerable&lt;IPlatformApplication&gt; that contains the PlatformApplications associated with the service.</returns>
        public IEnumerable<IPlatformApplication> GetPlatformApplications(ListPlatformApplicationsRequest request)
        {
                    
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListPlatformApplicationsEnumerator, "PlatformApplications"))
            {            
                yield return new Internal.PlatformApplication(arn : item.PlatformApplicationArn, client : this.Client);    
            }

        }

        /// <summary>
        /// Gets the PlatformApplications associated with the service.
        /// </summary>
        /// <returns>An IEnumerable&lt;IPlatformApplication&gt; that contains the PlatformApplications associated with the service.</returns>
        public IEnumerable<IPlatformApplication> GetPlatformApplications()
        {
            var request = new ListPlatformApplicationsRequest();
            return GetPlatformApplications(request);
         }

        /// <summary>
        /// Gets the Subscriptions associated with the service.
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionsEnumerator operation.</param>
        /// <returns>An IEnumerable&lt;ISubscription&gt; that contains the Subscriptions associated with the service.</returns>
        public IEnumerable<ISubscription> GetSubscriptions(ListSubscriptionsRequest request)
        {
                    
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListSubscriptionsEnumerator, "Subscriptions"))
            {            
                yield return new Internal.Subscription(arn : item.SubscriptionArn, client : this.Client);    
            }

        }

        /// <summary>
        /// Gets the Subscriptions associated with the service.
        /// </summary>
        /// <returns>An IEnumerable&lt;ISubscription&gt; that contains the Subscriptions associated with the service.</returns>
        public IEnumerable<ISubscription> GetSubscriptions()
        {
            var request = new ListSubscriptionsRequest();
            return GetSubscriptions(request);
         }

        /// <summary>
        /// Gets the Topics associated with the service.
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopicsEnumerator operation.</param>
        /// <returns>An IEnumerable&lt;ITopic&gt; that contains the Topics associated with the service.</returns>
        public IEnumerable<ITopic> GetTopics(ListTopicsRequest request)
        {
                    
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListTopicsEnumerator, "Topics"))
            {            
                yield return new Internal.Topic(arn : item.TopicArn, client : this.Client);    
            }

        }

        /// <summary>
        /// Gets the Topics associated with the service.
        /// </summary>
        /// <returns>An IEnumerable&lt;ITopic&gt; that contains the Topics associated with the service.</returns>
        public IEnumerable<ITopic> GetTopics()
        {
            var request = new ListTopicsRequest();
            return GetTopics(request);
         }


        #endregion

        #region Methods to get individual resources associated with the service

        /// <summary>
        /// Gets a PlatformApplication resource associated with the service using 
        /// its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="arn">The arn of the PlatformApplication.</param>
        /// <returns>An instance of PlatformApplication resource.</returns>

        public IPlatformApplication GetPlatformApplicationByArn(string arn)
        {
            return new Internal.PlatformApplication(arn : arn, client : this.Client);
        }

        /// <summary>
        /// Gets a PlatformEndpoint resource associated with the service using 
        /// its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="arn">The arn of the PlatformEndpoint.</param>
        /// <returns>An instance of PlatformEndpoint resource.</returns>

        public IPlatformEndpoint GetPlatformEndpointByArn(string arn)
        {
            return new Internal.PlatformEndpoint(arn : arn, client : this.Client);
        }

        /// <summary>
        /// Gets a Subscription resource associated with the service using 
        /// its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="arn">The arn of the Subscription.</param>
        /// <returns>An instance of Subscription resource.</returns>

        public ISubscription GetSubscriptionByArn(string arn)
        {
            return new Internal.Subscription(arn : arn, client : this.Client);
        }

        /// <summary>
        /// Gets a Topic resource associated with the service using 
        /// its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="arn">The arn of the Topic.</param>
        /// <returns>An instance of Topic resource.</returns>

        public ITopic GetTopicByArn(string arn)
        {
            return new Internal.Topic(arn : arn, client : this.Client);
        }

        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion
    }
}