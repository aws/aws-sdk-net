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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Metadata options that allow you to configure and secure the Amazon EC2 instance.
    /// </summary>
    public partial class AwsEc2InstanceMetadataOptions
    {
        private string _httpEndpoint;
        private string _httpProtocolIpv6;
        private int? _httpPutResponseHopLimit;
        private string _httpTokens;
        private string _instanceMetadataTags;

        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// Enables or disables the HTTP metadata endpoint on the instance. 
        /// </para>
        /// </summary>
        public string HttpEndpoint
        {
            get { return this._httpEndpoint; }
            set { this._httpEndpoint = value; }
        }

        // Check to see if HttpEndpoint property is set
        internal bool IsSetHttpEndpoint()
        {
            return this._httpEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property HttpProtocolIpv6. 
        /// <para>
        /// Enables or disables the IPv6 endpoint for the instance metadata service. 
        /// </para>
        /// </summary>
        public string HttpProtocolIpv6
        {
            get { return this._httpProtocolIpv6; }
            set { this._httpProtocolIpv6 = value; }
        }

        // Check to see if HttpProtocolIpv6 property is set
        internal bool IsSetHttpProtocolIpv6()
        {
            return this._httpProtocolIpv6 != null;
        }

        /// <summary>
        /// Gets and sets the property HttpPutResponseHopLimit. 
        /// <para>
        /// The desired HTTP PUT response hop limit for instance metadata requests. The larger
        /// the number, the further instance metadata requests can travel. 
        /// </para>
        /// </summary>
        public int? HttpPutResponseHopLimit
        {
            get { return this._httpPutResponseHopLimit; }
            set { this._httpPutResponseHopLimit = value; }
        }

        // Check to see if HttpPutResponseHopLimit property is set
        internal bool IsSetHttpPutResponseHopLimit()
        {
            return this._httpPutResponseHopLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HttpTokens. 
        /// <para>
        /// The state of token usage for your instance metadata requests. 
        /// </para>
        /// </summary>
        public string HttpTokens
        {
            get { return this._httpTokens; }
            set { this._httpTokens = value; }
        }

        // Check to see if HttpTokens property is set
        internal bool IsSetHttpTokens()
        {
            return this._httpTokens != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceMetadataTags. 
        /// <para>
        /// Specifies whether to allow access to instance tags from the instance metadata. 
        /// </para>
        /// </summary>
        public string InstanceMetadataTags
        {
            get { return this._instanceMetadataTags; }
            set { this._instanceMetadataTags = value; }
        }

        // Check to see if InstanceMetadataTags property is set
        internal bool IsSetInstanceMetadataTags()
        {
            return this._instanceMetadataTags != null;
        }

    }
}