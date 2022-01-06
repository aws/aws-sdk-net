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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The metadata options for the instance.
    /// </summary>
    public partial class InstanceMetadataOptionsResponse
    {
        private InstanceMetadataEndpointState _httpEndpoint;
        private InstanceMetadataProtocolState _httpProtocolIpv6;
        private int? _httpPutResponseHopLimit;
        private HttpTokensState _httpTokens;
        private InstanceMetadataTagsState _instanceMetadataTags;
        private InstanceMetadataOptionsState _state;

        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// Indicates whether the HTTP metadata endpoint on your instances is enabled or disabled.
        /// </para>
        ///  
        /// <para>
        /// If the value is <code>disabled</code>, you cannot access your instance metadata.
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
        /// Indicates whether the IPv6 endpoint for the instance metadata service is enabled or
        /// disabled.
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
        /// The desired HTTP PUT response hop limit for instance metadata requests. The larger
        /// the number, the further instance metadata requests can travel.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        ///  
        /// <para>
        /// Possible values: Integers from 1 to 64
        /// </para>
        /// </summary>
        public int HttpPutResponseHopLimit
        {
            get { return this._httpPutResponseHopLimit.GetValueOrDefault(); }
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
        ///  
        /// <para>
        /// If the state is <code>optional</code>, you can choose to retrieve instance metadata
        /// with or without a signed token header on your request. If you retrieve the IAM role
        /// credentials without a token, the version 1.0 role credentials are returned. If you
        /// retrieve the IAM role credentials using a valid signed token, the version 2.0 role
        /// credentials are returned.
        /// </para>
        ///  
        /// <para>
        /// If the state is <code>required</code>, you must send a signed token header with any
        /// instance metadata retrieval requests. In this state, retrieving the IAM role credential
        /// always returns the version 2.0 credentials; the version 1.0 credentials are not available.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>optional</code> 
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
        /// Indicates whether access to instance tags from the instance metadata is enabled or
        /// disabled. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html#work-with-tags-in-IMDS">Work
        /// with instance tags using the instance metadata</a>.
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

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the metadata option changes.
        /// </para>
        ///  
        /// <para>
        ///  <code>pending</code> - The metadata options are being updated and the instance is
        /// not ready to process metadata traffic with the new selection.
        /// </para>
        ///  
        /// <para>
        ///  <code>applied</code> - The metadata options have been successfully applied on the
        /// instance.
        /// </para>
        /// </summary>
        public InstanceMetadataOptionsState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}