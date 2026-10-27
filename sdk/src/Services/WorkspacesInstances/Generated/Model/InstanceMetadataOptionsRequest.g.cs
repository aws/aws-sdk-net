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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Defines instance metadata service configuration.
    /// </summary>
    public partial class InstanceMetadataOptionsRequest
    {
        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// Enables or disables HTTP endpoint for instance metadata.
        /// </para>
        /// </summary>
        public HttpEndpointEnum HttpEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the HttpEndpoint property is set.
        /// </summary>
        internal bool IsSetHttpEndpoint() => this.HttpEndpoint != null;

        /// <summary>
        /// Gets and sets the property HttpProtocolIpv6. 
        /// <para>
        /// Configures IPv6 support for instance metadata HTTP protocol.
        /// </para>
        /// </summary>
        public HttpProtocolIpv6Enum HttpProtocolIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the HttpProtocolIpv6 property is set.
        /// </summary>
        internal bool IsSetHttpProtocolIpv6() => this.HttpProtocolIpv6 != null;

        /// <summary>
        /// Gets and sets the property HttpPutResponseHopLimit. 
        /// <para>
        /// Sets maximum number of network hops for metadata PUT responses.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// Checks to see if the HttpPutResponseHopLimit property is set.
        /// </summary>
        internal bool IsSetHttpPutResponseHopLimit() => this.HttpPutResponseHopLimit.HasValue;

        /// <summary>
        /// Gets and sets the property HttpTokens. 
        /// <para>
        /// Configures token requirement for instance metadata retrieval.
        /// </para>
        /// </summary>
        public HttpTokensEnum HttpTokens { get; set; }

        /// <summary>
        /// Checks to see if the HttpTokens property is set.
        /// </summary>
        internal bool IsSetHttpTokens() => this.HttpTokens != null;

        /// <summary>
        /// Gets and sets the property InstanceMetadataTags. 
        /// <para>
        /// Enables or disables instance metadata tags retrieval.
        /// </para>
        /// </summary>
        public InstanceMetadataTagsEnum InstanceMetadataTags { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMetadataTags property is set.
        /// </summary>
        internal bool IsSetInstanceMetadataTags() => this.InstanceMetadataTags != null;
    }
}
