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
    /// <para>Modifies the specified attribute of the specified VPC.</para>
    /// </summary>
    public partial class ModifyVpcAttributeRequest : AmazonEC2Request
    {
        private string vpcId;
        private bool? enableDnsSupport;
        private bool? enableDnsHostnames;


        /// <summary>
        /// The ID of the VPC.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// Indicates whether the DNS resolution is supported for the VPC. If this attribute is <c>false</c>, the Amazon provided DNS service in the VPC
        /// that resolves public DNS hostnames to IP addresses is not enabled. If this attribute is <c>true</c>, queries to the Amazon provided DNS
        /// server at the 169.254.169.253 IP address, or the reserved IP address at the base of the VPC network range "plus two" will succeed.
        ///  
        /// </summary>
        public bool EnableDnsSupport
        {
            get { return this.enableDnsSupport ?? default(bool); }
            set { this.enableDnsSupport = value; }
        }

        // Check to see if EnableDnsSupport property is set
        internal bool IsSetEnableDnsSupport()
        {
            return this.enableDnsSupport.HasValue;
        }

        /// <summary>
        /// Indicates whether the instances launched in the VPC get DNS hostnames. If this attribute is <c>true</c>, instances in the VPC get DNS
        /// hostnames; otherwise, they do not. You can only set <c>enableDnsHostnames</c> to <c>true</c> if you also set the <c>EnableDnsSupport</c>
        /// attribute to <c>true</c>.
        ///  
        /// </summary>
        public bool EnableDnsHostnames
        {
            get { return this.enableDnsHostnames ?? default(bool); }
            set { this.enableDnsHostnames = value; }
        }

        // Check to see if EnableDnsHostnames property is set
        internal bool IsSetEnableDnsHostnames()
        {
            return this.enableDnsHostnames.HasValue;
        }

    }
}
    
