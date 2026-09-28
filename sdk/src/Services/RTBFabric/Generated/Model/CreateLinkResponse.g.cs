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
    /// This is the response object from the CreateLink operation.
    /// </summary>
    public partial class CreateLinkResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property ConnectivityType. 
        /// <para>
        /// The connectivity type of the link.
        /// </para>
        /// </summary>
        public ConnectivityType ConnectivityType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectivityType property is set.
        /// </summary>
        internal bool IsSetConnectivityType() => this.ConnectivityType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the link was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerProvidedId. 
        /// <para>
        /// The customer-provided unique identifier of the link.
        /// </para>
        /// </summary>
        public string CustomerProvidedId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerProvidedId property is set.
        /// </summary>
        internal bool IsSetCustomerProvidedId() => this.CustomerProvidedId != null;

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// The direction of the link.
        /// </para>
        /// </summary>
        public LinkDirection Direction { get; set; }

        /// <summary>
        /// Checks to see if the Direction property is set.
        /// </summary>
        internal bool IsSetDirection() => this.Direction != null;

        /// <summary>
        /// Gets and sets the property FlowModules. 
        /// <para>
        /// The configuration of flow modules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModuleConfiguration> FlowModules { get; set; } = AWSConfigs.InitializeCollections ? new List<ModuleConfiguration>() : null;

        /// <summary>
        /// Checks to see if the FlowModules property is set.
        /// </summary>
        internal bool IsSetFlowModules() => this.FlowModules != null && (this.FlowModules.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property LinkId. 
        /// <para>
        /// The unique identifier of the link.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 30)]
        public string LinkId { get; set; }

        /// <summary>
        /// Checks to see if the LinkId property is set.
        /// </summary>
        internal bool IsSetLinkId() => this.LinkId != null;

        /// <summary>
        /// Gets and sets the property LogSettings.
        /// </summary>
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
        /// Gets and sets the property PendingFlowModules. 
        /// <para>
        /// The configuration of pending flow modules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModuleConfiguration> PendingFlowModules { get; set; } = AWSConfigs.InitializeCollections ? new List<ModuleConfiguration>() : null;

        /// <summary>
        /// Checks to see if the PendingFlowModules property is set.
        /// </summary>
        internal bool IsSetPendingFlowModules() => this.PendingFlowModules != null && (this.PendingFlowModules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LinkStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the link was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
