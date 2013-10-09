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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeElasticIps operation.
    /// <para>Describes <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic IP addresses</a>
    /// .</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeElasticIps"/>
    public class DescribeElasticIpsRequest : AmazonWebServiceRequest
    {
        private string instanceId;
        private string stackId;
        private List<string> ips = new List<string>();

        /// <summary>
        /// The instance ID. If you include this parameter, <c>DescribeElasticIps</c> returns a description of the Elastic IP addresses associated with
        /// the specified instance.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeElasticIpsRequest WithInstanceId(string instanceId)
        {
            this.instanceId = instanceId;
            return this;
        }
            

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// A stack ID. If you include this parameter, <c>DescribeElasticIps</c> returns a description of the Elastic IP addresses that are registered
        /// with the specified stack.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeElasticIpsRequest WithStackId(string stackId)
        {
            this.stackId = stackId;
            return this;
        }
            

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// An array of Elastic IP addresses to be described. If you include this parameter, <c>DescribeElasticIps</c> returns a description of the
        /// specified Elastic IP addresses. Otherwise, it returns a description of every Elastic IP address.
        ///  
        /// </summary>
        public List<string> Ips
        {
            get { return this.ips; }
            set { this.ips = value; }
        }
        /// <summary>
        /// Adds elements to the Ips collection
        /// </summary>
        /// <param name="ips">The values to add to the Ips collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeElasticIpsRequest WithIps(params string[] ips)
        {
            foreach (string element in ips)
            {
                this.ips.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Ips collection
        /// </summary>
        /// <param name="ips">The values to add to the Ips collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeElasticIpsRequest WithIps(IEnumerable<string> ips)
        {
            foreach (string element in ips)
            {
                this.ips.Add(element);
            }

            return this;
        }

        // Check to see if Ips property is set
        internal bool IsSetIps()
        {
            return this.ips.Count > 0;
        }
    }
}
    
