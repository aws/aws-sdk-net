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
    /// <para> Returns detailed configuration information for the specified LoadBalancers. If no LoadBalancers are specified, the operation returns
    /// configuration information for all LoadBalancers created by the caller. </para> <para><b>NOTE:</b> The client must have created the specified
    /// input LoadBalancers in order to retrieve this information; the client must provide the same account credentials as those that were used to
    /// create the LoadBalancer. </para>
    /// </summary>
    public partial class DescribeLoadBalancersRequest : AmazonWebServiceRequest
    {
        private List<string> loadBalancerNames = new List<string>();
        private string marker;
        /// <summary>
        /// Default constructor for a new DescribeLoadBalancersRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public DescribeLoadBalancersRequest() {}
    
        /// <summary>
        /// Constructs a new DescribeLoadBalancersRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerNames"> A list of names associated with the LoadBalancers at creation time. </param>
        public DescribeLoadBalancersRequest(List<string> loadBalancerNames)
        {
            this.loadBalancerNames = loadBalancerNames;
        }
    

        /// <summary>
        /// A list of names associated with the LoadBalancers at creation time.
        ///  
        /// </summary>
        public List<string> LoadBalancerNames
        {
            get { return this.loadBalancerNames; }
            set { this.loadBalancerNames = value; }
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

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

    }
}
    
