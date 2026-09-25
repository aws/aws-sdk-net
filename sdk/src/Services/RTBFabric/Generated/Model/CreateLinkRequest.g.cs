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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLink operation. Creates a new link between
    /// gateways. <para> Establishes a connection that allows gateways to communicate and
    /// exchange bid requests and responses. </para>
    /// </summary>
    public partial class CreateLinkRequest : AmazonRTBFabricRequest
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Attributes of the link.
        /// </para>
        /// </summary>
        public LinkAttributes Attributes { get; set; }

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null;

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 32)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;

        /// <summary>
        /// Gets and sets the property HttpResponderAllowed. 
        /// <para>
        /// Boolean to specify if an HTTP responder is allowed.
        /// </para>
        /// </summary>
        public bool? HttpResponderAllowed { get; set; }

        /// <summary>
        /// Checks to see if the HttpResponderAllowed property is set.
        /// </summary>
        internal bool IsSetHttpResponderAllowed() => this.HttpResponderAllowed.HasValue;

        /// <summary>
        /// Gets and sets the property LogSettings. 
        /// <para>
        /// Application log settings for the link. This value is required. Under <c>applicationLogs.sampling</c>,
        /// the <c>errorLog</c> and <c>filterLog</c> fields set the percentage of eligible events
        /// to log. Valid values range from <c>0</c> through <c>100</c>. To turn off application
        /// logs, set both fields to <c>0</c>, as in <c>{"applicationLogs":{"sampling":{"errorLog":0,"filterLog":0}}}</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LinkLogSettings LogSettings { get; set; }

        /// <summary>
        /// Checks to see if the LogSettings property is set.
        /// </summary>
        internal bool IsSetLogSettings() => this.LogSettings != null;

        /// <summary>
        /// Gets and sets the property PeerGatewayId. 
        /// <para>
        /// The unique identifier of the peer gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 32)]
        public string PeerGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the PeerGatewayId property is set.
        /// </summary>
        internal bool IsSetPeerGatewayId() => this.PeerGatewayId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of the key-value pairs of the tag or tags to assign to the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutInMillis. 
        /// <para>
        /// The timeout value in milliseconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 100, Max = 5000)]
        public long? TimeoutInMillis { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInMillis property is set.
        /// </summary>
        internal bool IsSetTimeoutInMillis() => this.TimeoutInMillis.HasValue;
    }
}
