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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */

using System;
using System.Collections.Generic;

using Amazon.Runtime.Resources;
using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;

namespace Amazon.CloudFormation.Resources
{
    /// <summary>    
    /// A service is the entry point for using the Resource API. This class allows you to 
    /// access the top-level resources and operations associated with the
    /// AWS CloudFormation service.
    /// </summary>
    public class CloudFormation : Service<IAmazonCloudFormation>
    {

        #region Constructors

        /// <summary>
        /// Constructs CloudFormation with the credentials loaded from the application's
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
        public CloudFormation() : base(new AmazonCloudFormationClient()) {}

        /// <summary>
        /// Constructs CloudFormation with an instance of AmazonCloudFormationClient.
        /// </summary>     
        /// <param name="client">The AmazonCloudFormationClient to use for requests.</param>   
        public CloudFormation(IAmazonCloudFormation client)
            : base(client)
        {
            this.ShouldDisposeClient = false;
        }

        #endregion
 
        # region Methods for service-level operations

        /// <summary>
        /// Calls the CreateStack operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation.</param>
        /// <returns>An instance of the Stack resource.</returns>
        public IStack CreateStack(CreateStackRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.CreateStack, "CreateStack");
            return new Internal.Stack(name : request.StackName, client : this.Client);
            
        }

        #endregion

        #region Methods to get resource collections associated with the service
        /// <summary>
        /// Gets the Stacks associated with the service.
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacksEnumerator operation.</param>
        /// <returns>An IEnumerable&lt;IStack&gt; that contains the Stacks associated with the service.</returns>
        public IEnumerable<IStack> GetStacks(DescribeStacksRequest request)
        {
                    
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.DescribeStacksEnumerator, "Stacks"))
            {            
                yield return new Internal.Stack(model : item, client : this.Client);    
            }

        }

        /// <summary>
        /// Gets the Stacks associated with the service.
        /// </summary>
        /// <returns>An IEnumerable&lt;IStack&gt; that contains the Stacks associated with the service.</returns>
        public IEnumerable<IStack> GetStacks()
        {
            var request = new DescribeStacksRequest();
            return GetStacks(request);
         }


        #endregion

        #region Methods to get individual resources associated with the service

        /// <summary>
        /// Gets a Event resource associated with the service using 
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
        /// <param name="id">The id of the Event.</param>
        /// <returns>An instance of Event resource.</returns>

        public IEvent GetEventById(string id)
        {
            return new Internal.Event(id : id, client : this.Client);
        }

        /// <summary>
        /// Gets a Stack resource associated with the service using 
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
        /// <param name="name">The name of the Stack.</param>
        /// <returns>An instance of Stack resource.</returns>

        public IStack GetStackByName(string name)
        {
            return new Internal.Stack(name : name, client : this.Client);
        }

        /// <summary>
        /// Gets a StackResourceSummary resource associated with the service using 
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
        /// <param name="logicalId">The logicalid of the StackResourceSummary.</param>
        /// <param name="stackName">The stackname of the StackResourceSummary.</param>
        /// <returns>An instance of StackResourceSummary resource.</returns>

        public IStackResourceSummary GetStackResourceSummaryById(string logicalId, string stackName)
        {
            return new Internal.StackResourceSummary(logicalId : logicalId, stackName : stackName, client : this.Client);
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