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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */

using System;
using System.Collections.Generic;

using Amazon.Runtime.Resources;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace Amazon.SQS.Resources
{
    /// <summary>    
    /// A service is the entry point for using the Resource API. This class allows you to 
    /// access the top-level resources and operations associated with the
    /// Amazon Simple Queue Service service.
    /// </summary>
    public class SQS : Service<IAmazonSQS>
    {

        #region Constructors

        /// <summary>
        /// Constructs SQS with the credentials loaded from the application's
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
        public SQS() : base(new AmazonSQSClient()) {}

        /// <summary>
        /// Constructs SQS with an instance of AmazonSQSClient.
        /// </summary>     
        /// <param name="client">The AmazonSQSClient to use for requests.</param>   
        public SQS(IAmazonSQS client)
            : base(client)
        {
            this.ShouldDisposeClient = false;
        }

        #endregion
 
        # region Methods for service-level operations

        /// <summary>
        /// Calls the CreateQueue operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue operation.</param>
        /// <returns>An instance of the Queue resource.</returns>
        public IQueue CreateQueue(CreateQueueRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.CreateQueue, "CreateQueue");
            return new Internal.Queue(url : response.QueueUrl, client : this.Client);
            
        }
        /// <summary>
        /// Calls the CreateQueue on the service.
        /// </summary>
        /// <param name="queueName">The name for the queue to be created.</param>
        /// <returns>An IQueue associated with the service.</returns>
        public IQueue CreateQueue(string queueName)
        {
            var request = new CreateQueueRequest();
            request.QueueName = queueName;
            return CreateQueue(request);
         }


        /// <summary>
        /// Calls the GetQueueUrl operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueUrl operation.</param>
        /// <returns>An instance of the Queue resource.</returns>
        public IQueue GetQueueByName(GetQueueUrlRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.GetQueueUrl, "GetQueueByName");
            return new Internal.Queue(url : response.QueueUrl, client : this.Client);
            
        }
        /// <summary>
        /// Calls the GetQueueByName on the service.
        /// </summary>
        /// <param name="queueName">The name of the queue whose URL must be fetched. Maximum 80 characters; alphanumeric characters, hyphens (-), and underscores (_) are allowed.</param>
        /// <returns>An IQueue associated with the service.</returns>
        public IQueue GetQueueByName(string queueName)
        {
            var request = new GetQueueUrlRequest();
            request.QueueName = queueName;
            return GetQueueByName(request);
         }


        #endregion

        #region Methods to get resource collections associated with the service
        /// <summary>
        /// Gets the Queues associated with the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues operation.</param>
        /// <returns>An IEnumerable&lt;IQueue&gt; that contains the Queues associated with the service.</returns>
        public IEnumerable<IQueue> GetQueues(ListQueuesRequest request)
        {
                    
            var items = new List<IQueue>();
            foreach (var item in ResourcesUtilities.Invoke(request, this.Client.ListQueues, "Queues").QueueUrls)
            {        
                items.Add(new Internal.Queue(url : item, client : this.Client));
            }
            return items;

        }

        /// <summary>
        /// Gets the Queues associated with the service.
        /// </summary>
        /// <param name="queueNamePrefix">A string to use for filtering the list results. Only those queues whose name begins with the specified string are returned.</param>
        /// <returns>An IEnumerable&lt;IQueue&gt; that contains the Queues associated with the service.</returns>
        public IEnumerable<IQueue> GetQueues(string queueNamePrefix)
        {
            var request = new ListQueuesRequest();
            request.QueueNamePrefix = queueNamePrefix;
            return GetQueues(request);
         }


        #endregion

        #region Methods to get individual resources associated with the service

        /// <summary>
        /// Gets a Queue resource associated with the service using 
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
        /// <param name="url">The url of the Queue.</param>
        /// <returns>An instance of Queue resource.</returns>

        public IQueue GetQueueByUrl(string url)
        {
            return new Internal.Queue(url : url, client : this.Client);
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