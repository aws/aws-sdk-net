/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about a requested IPAM policy allocation rule.
    /// 
    ///  
    /// <para>
    /// Allocation rules are optional configurations within an IPAM policy that map Amazon
    /// Web Services resource types to specific IPAM pools. If no rules are defined, the resource
    /// types default to using Amazon-provided IP addresses.
    /// </para>
    /// </summary>
    public partial class IpamPolicyAllocationRuleRequest
    {
        private string _sourceIpamPoolId;

        /// <summary>
        /// Gets and sets the property SourceIpamPoolId. 
        /// <para>
        /// The ID of the source IPAM pool for the requested allocation rule.
        /// </para>
        ///  
        /// <para>
        /// An IPAM pool is a collection of IP addresses in IPAM that can be allocated to Amazon
        /// Web Services resources.
        /// </para>
        /// </summary>
        public string SourceIpamPoolId
        {
            get { return this._sourceIpamPoolId; }
            set { this._sourceIpamPoolId = value; }
        }

        // Check to see if SourceIpamPoolId property is set
        internal bool IsSetSourceIpamPoolId()
        {
            return this._sourceIpamPoolId != null;
        }

    }
}