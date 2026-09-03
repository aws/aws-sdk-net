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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A Bridge is the connection between your data center's Instances and the Amazon Web
    /// Services cloud. A bridge can be used to send video from the Amazon Web Services cloud
    /// to your data center or from your data center to the Amazon Web Services cloud.
    /// </summary>
    public partial class Bridge
    {
        /// <summary>
        /// Gets and sets the property BridgeArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) of the bridge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BridgeArn { get; set; }

        /// <summary>
        /// Checks to see if the BridgeArn property is set.
        /// </summary>
        internal bool IsSetBridgeArn() => this.BridgeArn != null;

        /// <summary>
        /// Gets and sets the property BridgeMessages. 
        /// <para>
        ///  Messages with details about the bridge. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MessageDetail> BridgeMessages { get; set; } = AWSConfigs.InitializeCollections ? new List<MessageDetail>() : null;

        /// <summary>
        /// Checks to see if the BridgeMessages property is set.
        /// </summary>
        internal bool IsSetBridgeMessages() => this.BridgeMessages != null && (this.BridgeMessages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BridgeState. 
        /// <para>
        /// The state of the bridge. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BridgeState BridgeState { get; set; }

        /// <summary>
        /// Checks to see if the BridgeState property is set.
        /// </summary>
        internal bool IsSetBridgeState() => this.BridgeState != null;

        /// <summary>
        /// Gets and sets the property EgressGatewayBridge. 
        /// <para>
        ///  An egress bridge is a cloud-to-ground bridge. The content comes from an existing
        /// MediaConnect flow and is delivered to your premises. 
        /// </para>
        /// </summary>
        public EgressGatewayBridge EgressGatewayBridge { get; set; }

        /// <summary>
        /// Checks to see if the EgressGatewayBridge property is set.
        /// </summary>
        internal bool IsSetEgressGatewayBridge() => this.EgressGatewayBridge != null;

        /// <summary>
        /// Gets and sets the property IngressGatewayBridge. 
        /// <para>
        ///  An ingress bridge is a ground-to-cloud bridge. The content originates at your premises
        /// and is delivered to the cloud. 
        /// </para>
        /// </summary>
        public IngressGatewayBridge IngressGatewayBridge { get; set; }

        /// <summary>
        /// Checks to see if the IngressGatewayBridge property is set.
        /// </summary>
        internal bool IsSetIngressGatewayBridge() => this.IngressGatewayBridge != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the bridge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        ///  The outputs on this bridge.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BridgeOutput> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new List<BridgeOutput>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlacementArn. 
        /// <para>
        ///  The placement Amazon Resource Number (ARN) of the bridge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlacementArn { get; set; }

        /// <summary>
        /// Checks to see if the PlacementArn property is set.
        /// </summary>
        internal bool IsSetPlacementArn() => this.PlacementArn != null;

        /// <summary>
        /// Gets and sets the property SourceFailoverConfig. 
        /// <para>
        ///  The settings for source failover. 
        /// </para>
        /// </summary>
        public FailoverConfig SourceFailoverConfig { get; set; }

        /// <summary>
        /// Checks to see if the SourceFailoverConfig property is set.
        /// </summary>
        internal bool IsSetSourceFailoverConfig() => this.SourceFailoverConfig != null;

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        ///  The sources on this bridge.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BridgeSource> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<BridgeSource>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
