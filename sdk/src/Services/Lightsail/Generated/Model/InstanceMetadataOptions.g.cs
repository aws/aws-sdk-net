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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// The metadata options for the instance.
    /// </summary>
    public partial class InstanceMetadataOptions
    {
        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// Indicates whether the HTTP metadata endpoint on your instances is enabled or disabled.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>disabled</c>, you cannot access your instance metadata.
        /// </para>
        /// </summary>
        public HttpEndpoint HttpEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the HttpEndpoint property is set.
        /// </summary>
        internal bool IsSetHttpEndpoint() => this.HttpEndpoint != null;

        /// <summary>
        /// Gets and sets the property HttpProtocolIpv6. 
        /// <para>
        /// Indicates whether the IPv6 endpoint for the instance metadata service is enabled or
        /// disabled.
        /// </para>
        /// </summary>
        public HttpProtocolIpv6 HttpProtocolIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the HttpProtocolIpv6 property is set.
        /// </summary>
        internal bool IsSetHttpProtocolIpv6() => this.HttpProtocolIpv6 != null;

        /// <summary>
        /// Gets and sets the property HttpPutResponseHopLimit. 
        /// <para>
        /// The desired HTTP PUT response hop limit for instance metadata requests. A larger number
        /// means that the instance metadata requests can travel farther.
        /// </para>
        /// </summary>
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// Checks to see if the HttpPutResponseHopLimit property is set.
        /// </summary>
        internal bool IsSetHttpPutResponseHopLimit() => this.HttpPutResponseHopLimit.HasValue;

        /// <summary>
        /// Gets and sets the property HttpTokens. 
        /// <para>
        /// The state of token usage for your instance metadata requests.
        /// </para>
        ///  
        /// <para>
        /// If the state is <c>optional</c>, you can choose whether to retrieve instance metadata
        /// with a signed token header on your request. If you retrieve the IAM role credentials
        /// without a token, the version 1.0 role credentials are returned. If you retrieve the
        /// IAM role credentials by using a valid signed token, the version 2.0 role credentials
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If the state is <c>required</c>, you must send a signed token header with all instance
        /// metadata retrieval requests. In this state, retrieving the IAM role credential always
        /// returns the version 2.0 credentials. The version 1.0 credentials are not available.
        /// </para>
        ///  <important> 
        /// <para>
        /// Not all instance blueprints in Lightsail support version 2.0 credentials. Use the
        /// <c>MetadataNoToken</c> instance metric to track the number of calls to the instance
        /// metadata service that are using version 1.0 credentials. For more information, see
        /// <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-viewing-instance-health-metrics">Viewing
        /// instance metrics in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        public HttpTokens HttpTokens { get; set; }

        /// <summary>
        /// Checks to see if the HttpTokens property is set.
        /// </summary>
        internal bool IsSetHttpTokens() => this.HttpTokens != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the metadata option changes.
        /// </para>
        ///  
        /// <para>
        /// The following states are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>pending</c> - The metadata options are being updated. The instance is not yet
        /// ready to process metadata traffic with the new selection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>applied</c> - The metadata options have been successfully applied to the instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceMetadataState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
