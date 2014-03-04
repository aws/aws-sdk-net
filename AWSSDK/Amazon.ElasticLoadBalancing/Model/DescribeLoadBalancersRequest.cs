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
    /// Container for the parameters to the DescribeLoadBalancers operation.
    /// <para> Returns detailed configuration information for all the load balancers created for the account. If you specify load balancer names,
    /// the action returns configuration information of the specified load balancers. </para> <para><b>NOTE:</b> In order to retrieve this
    /// information, you must provide the same account credentials that was used to create the load balancer.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancers"/>
    public class DescribeLoadBalancersRequest : AmazonWebServiceRequest
    {
        private List<string> loadBalancerNames = new List<string>();
        private string marker;
        /// <summary>
        /// Default constructor for a new DescribeLoadBalancersRequest object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public DescribeLoadBalancersRequest() {}
    
        /// <summary>
        /// Constructs a new DescribeLoadBalancersRequest object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerNames"> A list of load balancer names associated with the account. </param>
        public DescribeLoadBalancersRequest(List<string> loadBalancerNames)
        {
            this.loadBalancerNames = loadBalancerNames;
        }
    

        /// <summary>
        /// A list of load balancer names associated with the account.
        ///  
        /// </summary>
        public List<string> LoadBalancerNames
        {
            get { return this.loadBalancerNames; }
            set { this.loadBalancerNames = value; }
        }
        /// <summary>
        /// Adds elements to the LoadBalancerNames collection
        /// </summary>
        /// <param name="loadBalancerNames">The values to add to the LoadBalancerNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLoadBalancersRequest WithLoadBalancerNames(params string[] loadBalancerNames)
        {
            foreach (string element in loadBalancerNames)
            {
                this.loadBalancerNames.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the LoadBalancerNames collection
        /// </summary>
        /// <param name="loadBalancerNames">The values to add to the LoadBalancerNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLoadBalancersRequest WithLoadBalancerNames(IEnumerable<string> loadBalancerNames)
        {
            foreach (string element in loadBalancerNames)
            {
                this.loadBalancerNames.Add(element);
            }

            return this;
        }

        // Check to see if LoadBalancerNames property is set
        internal bool IsSetLoadBalancerNames()
        {
            return this.loadBalancerNames.Count > 0;
        }

        /// <summary>
        /// An optional parameter reserved for future use.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLoadBalancersRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
    
