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
    /// This is the response object from the DeleteIpamPolicy operation.
    /// </summary>
    public partial class DeleteIpamPolicyResponse : AmazonWebServiceResponse
    {
        private IpamPolicy _ipamPolicy;

        /// <summary>
        /// Gets and sets the property IpamPolicy. 
        /// <para>
        /// Information about the deleted IPAM policy.
        /// </para>
        ///  
        /// <para>
        /// An IPAM policy is a set of rules that define how public IPv4 addresses from IPAM pools
        /// are allocated to Amazon Web Services resources. Each rule maps an Amazon Web Services
        /// service to IPAM pools that the service will use to get IP addresses. A single policy
        /// can have multiple rules and be applied to multiple Amazon Web Services Regions. If
        /// the IPAM pool run out of addresses then the services fallback to Amazon-provided IP
        /// addresses. A policy can be applied to an individual Amazon Web Services account or
        /// an entity within Amazon Web Services Organizations.
        /// </para>
        /// </summary>
        public IpamPolicy IpamPolicy
        {
            get { return this._ipamPolicy; }
            set { this._ipamPolicy = value; }
        }

        // Check to see if IpamPolicy property is set
        internal bool IsSetIpamPolicy()
        {
            return this._ipamPolicy != null;
        }

    }
}