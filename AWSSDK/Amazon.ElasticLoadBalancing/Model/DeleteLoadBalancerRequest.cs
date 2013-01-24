/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteLoadBalancer operation.
    /// <para> Deletes the specified LoadBalancer. </para> <para> If attempting to recreate the LoadBalancer, the client must reconfigure all the
    /// settings. The DNS name associated with a deleted LoadBalancer will no longer be usable. Once deleted, the name and associated DNS record of
    /// the LoadBalancer no longer exist and traffic sent to any of its IP addresses will no longer be delivered to client instances. The client
    /// will not receive the same DNS name even if a new LoadBalancer with same LoadBalancerName is created. </para> <para> To successfully call
    /// this API, the client must provide the same account credentials as were used to create the LoadBalancer. </para> <para><b>NOTE:</b> By
    /// design, if the LoadBalancer does not exist or has already been deleted, DeleteLoadBalancer still succeeds. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeleteLoadBalancer"/>
    public class DeleteLoadBalancerRequest : AmazonWebServiceRequest
    {
        private string loadBalancerName;
        /// <summary>
        /// Default constructor for a new DeleteLoadBalancerRequest object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public DeleteLoadBalancerRequest() {}
    
        /// <summary>
        /// Constructs a new DeleteLoadBalancerRequest object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the LoadBalancer. The name must be unique within the client AWS account. </param>
        public DeleteLoadBalancerRequest(string loadBalancerName) 
        {
            this.loadBalancerName = loadBalancerName;
        }
    

        /// <summary>
        /// The name associated with the LoadBalancer. The name must be unique within the client AWS account.
        ///  
        /// </summary>
        public string LoadBalancerName
        {
            get { return this.loadBalancerName; }
            set { this.loadBalancerName = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The value to set for the LoadBalancerName property </param>
        /// <returns>this instance</returns>
        public DeleteLoadBalancerRequest WithLoadBalancerName(string loadBalancerName)
        {
            this.loadBalancerName = loadBalancerName;
            return this;
        }
            

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this.loadBalancerName != null;       
        }
    }
}
    
