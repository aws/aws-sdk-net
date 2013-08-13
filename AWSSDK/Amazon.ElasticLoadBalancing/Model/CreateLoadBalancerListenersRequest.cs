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
    /// Container for the parameters to the CreateLoadBalancerListeners operation.
    /// <para> Creates one or more listeners on a LoadBalancer for the specified port. If a listener with the given port does not already exist, it
    /// will be created; otherwise, the properties of the new listener must match the properties of the existing listener. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLoadBalancerListeners"/>
    public class CreateLoadBalancerListenersRequest : AmazonWebServiceRequest
    {
        private string loadBalancerName;
        private List<Listener> listeners = new List<Listener>();
        /// <summary>
        /// Default constructor for a new CreateLoadBalancerListenersRequest object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public CreateLoadBalancerListenersRequest() {}
    
        /// <summary>
        /// Constructs a new CreateLoadBalancerListenersRequest object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name of the new LoadBalancer. The name must be unique within your AWS account. </param>
        /// <param name="listeners"> A list of <c>LoadBalancerPort</c>, <c>InstancePort</c>, <c>Protocol</c>, and <c>SSLCertificateId</c> items.
        /// </param>
        public CreateLoadBalancerListenersRequest(string loadBalancerName, List<Listener> listeners) 
        {
            this.loadBalancerName = loadBalancerName;
            this.listeners = listeners;
        }
    

        /// <summary>
        /// The name of the new LoadBalancer. The name must be unique within your AWS account.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateLoadBalancerListenersRequest WithLoadBalancerName(string loadBalancerName)
        {
            this.loadBalancerName = loadBalancerName;
            return this;
        }
            

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this.loadBalancerName != null;       
        }

        /// <summary>
        /// A list of <c>LoadBalancerPort</c>, <c>InstancePort</c>, <c>Protocol</c>, and <c>SSLCertificateId</c> items.
        ///  
        /// </summary>
        public List<Listener> Listeners
        {
            get { return this.listeners; }
            set { this.listeners = value; }
        }
        /// <summary>
        /// Adds elements to the Listeners collection
        /// </summary>
        /// <param name="listeners">The values to add to the Listeners collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateLoadBalancerListenersRequest WithListeners(params Listener[] listeners)
        {
            foreach (Listener element in listeners)
            {
                this.listeners.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Listeners collection
        /// </summary>
        /// <param name="listeners">The values to add to the Listeners collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateLoadBalancerListenersRequest WithListeners(IEnumerable<Listener> listeners)
        {
            foreach (Listener element in listeners)
            {
                this.listeners.Add(element);
            }

            return this;
        }

        // Check to see if Listeners property is set
        internal bool IsSetListeners()
        {
            return this.listeners.Count > 0;       
        }
    }
}
    
