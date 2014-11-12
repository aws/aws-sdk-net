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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVpcAttribute operation.
    /// Modifies the specified attribute of the specified VPC.
    /// </summary>
    public partial class ModifyVpcAttributeRequest : AmazonEC2Request
    {
        private bool? _enableDnsHostnames;
        private bool? _enableDnsSupport;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property EnableDnsHostnames. 
        /// <para>
        /// Indicates whether the instances launched in the VPC get DNS hostnames. If enabled,
        /// instances in the VPC get DNS hostnames; otherwise, they do not.
        /// </para>
        ///  
        /// <para>
        /// You can only enable DNS hostnames if you also enable DNS support.
        /// </para>
        /// </summary>
        public bool EnableDnsHostnames
        {
            get { return this._enableDnsHostnames.GetValueOrDefault(); }
            set { this._enableDnsHostnames = value; }
        }

        // Check to see if EnableDnsHostnames property is set
        internal bool IsSetEnableDnsHostnames()
        {
            return this._enableDnsHostnames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableDnsSupport. 
        /// <para>
        /// Indicates whether the DNS resolution is supported for the VPC. If enabled, queries
        /// to the Amazon provided DNS server at the 169.254.169.253 IP address, or the reserved
        /// IP address at the base of the VPC network range "plus two" will succeed. If disabled,
        /// the Amazon provided DNS service in the VPC that resolves public DNS hostnames to IP
        /// addresses is not enabled.
        /// </para>
        /// </summary>
        public bool EnableDnsSupport
        {
            get { return this._enableDnsSupport.GetValueOrDefault(); }
            set { this._enableDnsSupport = value; }
        }

        // Check to see if EnableDnsSupport property is set
        internal bool IsSetEnableDnsSupport()
        {
            return this._enableDnsSupport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}