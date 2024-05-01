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
    /// This is the response object from the DescribeVpcAttribute operation.
    /// </summary>
    public partial class DescribeVpcAttributeResponse : AmazonWebServiceResponse
    {
        private bool? _enableDnsHostnames;
        private bool? _enableDnsSupport;
        private bool? _enableNetworkAddressUsageMetrics;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property EnableDnsHostnames. 
        /// <para>
        /// Indicates whether the instances launched in the VPC get DNS hostnames. If this attribute
        /// is <c>true</c>, instances in the VPC get DNS hostnames; otherwise, they do not.
        /// </para>
        /// </summary>
        public bool? EnableDnsHostnames
        {
            get { return this._enableDnsHostnames; }
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
        /// Indicates whether DNS resolution is enabled for the VPC. If this attribute is <c>true</c>,
        /// the Amazon DNS server resolves DNS hostnames for your instances to their corresponding
        /// IP addresses; otherwise, it does not.
        /// </para>
        /// </summary>
        public bool? EnableDnsSupport
        {
            get { return this._enableDnsSupport; }
            set { this._enableDnsSupport = value; }
        }

        // Check to see if EnableDnsSupport property is set
        internal bool IsSetEnableDnsSupport()
        {
            return this._enableDnsSupport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableNetworkAddressUsageMetrics. 
        /// <para>
        /// Indicates whether Network Address Usage metrics are enabled for your VPC.
        /// </para>
        /// </summary>
        public bool? EnableNetworkAddressUsageMetrics
        {
            get { return this._enableNetworkAddressUsageMetrics; }
            set { this._enableNetworkAddressUsageMetrics = value; }
        }

        // Check to see if EnableNetworkAddressUsageMetrics property is set
        internal bool IsSetEnableNetworkAddressUsageMetrics()
        {
            return this._enableNetworkAddressUsageMetrics.HasValue; 
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