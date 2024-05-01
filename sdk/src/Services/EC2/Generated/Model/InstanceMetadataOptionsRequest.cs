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
    /// The metadata options for the instance.
    /// </summary>
    public partial class InstanceMetadataOptionsRequest
    {
        private InstanceMetadataEndpointState _httpEndpoint;
        private InstanceMetadataProtocolState _httpProtocolIpv6;
        private int? _httpPutResponseHopLimit;
        private HttpTokensState _httpTokens;
        private InstanceMetadataTagsState _instanceMetadataTags;

        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// Enables or disables the HTTP metadata endpoint on your instances.
        /// </para>
        ///  
        /// <para>
        /// If you specify a value of <c>disabled</c>, you cannot access your instance metadata.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>enabled</c> 
        /// </para>
        /// </summary>
        public InstanceMetadataEndpointState HttpEndpoint
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
        ///  
        /// <para>
        /// Default: <c>disabled</c> 
        /// </para>
        /// </summary>
        public InstanceMetadataProtocolState HttpProtocolIpv6
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
        /// The maximum number of hops that the metadata token can travel.
        /// </para>
        ///  
        /// <para>
        /// Possible values: Integers from 1 to 64
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
        /// Indicates whether IMDSv2 is required.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>optional</c> - IMDSv2 is optional, which means that you can use either IMDSv2
        /// or IMDSv1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>required</c> - IMDSv2 is required, which means that IMDSv1 is disabled, and you
        /// must use IMDSv2.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the value of <c>ImdsSupport</c> for the Amazon Machine Image (AMI) for your instance
        /// is <c>v2.0</c> and the account level default is set to <c>no-preference</c>, the default
        /// is <c>required</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value of <c>ImdsSupport</c> for the Amazon Machine Image (AMI) for your instance
        /// is <c>v2.0</c>, but the account level default is set to <c>V1 or V2</c>, the default
        /// is <c>optional</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default value can also be affected by other combinations of parameters. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-instance-metadata-options.html#instance-metadata-options-order-of-precedence">Order
        /// of precedence for instance metadata options</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public HttpTokensState HttpTokens
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
        /// Set to <c>enabled</c> to allow access to instance tags from the instance metadata.
        /// Set to <c>disabled</c> to turn off access to instance tags from the instance metadata.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html#work-with-tags-in-IMDS">Work
        /// with instance tags using the instance metadata</a>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>disabled</c> 
        /// </para>
        /// </summary>
        public InstanceMetadataTagsState InstanceMetadataTags
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