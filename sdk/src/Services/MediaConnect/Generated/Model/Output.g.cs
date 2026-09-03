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
    /// The settings for an output.
    /// </summary>
    public partial class Output
    {
        /// <summary>
        /// Gets and sets the property BridgeArn. 
        /// <para>
        ///  The ARN of the bridge added to this output.
        /// </para>
        /// </summary>
        public string BridgeArn { get; set; }

        /// <summary>
        /// Checks to see if the BridgeArn property is set.
        /// </summary>
        internal bool IsSetBridgeArn() => this.BridgeArn != null;

        /// <summary>
        /// Gets and sets the property BridgePorts. 
        /// <para>
        ///  The bridge output ports currently in use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> BridgePorts { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the BridgePorts property is set.
        /// </summary>
        internal bool IsSetBridgePorts() => this.BridgePorts != null && (this.BridgePorts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectedRouterInputArn. 
        /// <para>
        /// The ARN of the router input that's connected to this flow output.
        /// </para>
        /// </summary>
        public string ConnectedRouterInputArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedRouterInputArn property is set.
        /// </summary>
        internal bool IsSetConnectedRouterInputArn() => this.ConnectedRouterInputArn != null;

        /// <summary>
        /// Gets and sets the property DataTransferSubscriberFeePercent. 
        /// <para>
        ///  Percentage from 0-100 of the data transfer cost to be billed to the subscriber.
        /// </para>
        /// </summary>
        public int? DataTransferSubscriberFeePercent { get; set; }

        /// <summary>
        /// Checks to see if the DataTransferSubscriberFeePercent property is set.
        /// </summary>
        internal bool IsSetDataTransferSubscriberFeePercent() => this.DataTransferSubscriberFeePercent.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the output.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        ///  The address where you want to send the output.
        /// </para>
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property Encryption. 
        /// <para>
        ///  The type of key used for the encryption. If no keyType is provided, the service will
        /// use the default setting (static-key).
        /// </para>
        /// </summary>
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Checks to see if the Encryption property is set.
        /// </summary>
        internal bool IsSetEncryption() => this.Encryption != null;

        /// <summary>
        /// Gets and sets the property EntitlementArn. 
        /// <para>
        ///  The ARN of the entitlement on the originator''s flow. This value is relevant only
        /// on entitled flows.
        /// </para>
        /// </summary>
        public string EntitlementArn { get; set; }

        /// <summary>
        /// Checks to see if the EntitlementArn property is set.
        /// </summary>
        internal bool IsSetEntitlementArn() => this.EntitlementArn != null;

        /// <summary>
        /// Gets and sets the property ListenerAddress. 
        /// <para>
        ///  The IP address that the receiver requires in order to establish a connection with
        /// the flow. For public networking, the ListenerAddress is represented by the elastic
        /// IP address of the flow. For private networking, the ListenerAddress is represented
        /// by the elastic network interface IP address of the VPC. This field applies only to
        /// outputs that use the Zixi pull or SRT listener protocol.
        /// </para>
        /// </summary>
        public string ListenerAddress { get; set; }

        /// <summary>
        /// Checks to see if the ListenerAddress property is set.
        /// </summary>
        internal bool IsSetListenerAddress() => this.ListenerAddress != null;

        /// <summary>
        /// Gets and sets the property MediaLiveInputArn. 
        /// <para>
        ///  The input ARN of the MediaLive channel. This parameter is relevant only for outputs
        /// that were added by creating a MediaLive input.
        /// </para>
        /// </summary>
        public string MediaLiveInputArn { get; set; }

        /// <summary>
        /// Checks to see if the MediaLiveInputArn property is set.
        /// </summary>
        internal bool IsSetMediaLiveInputArn() => this.MediaLiveInputArn != null;

        /// <summary>
        /// Gets and sets the property MediaStreamOutputConfigurations. 
        /// <para>
        ///  The configuration for each media stream that is associated with the output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaStreamOutputConfiguration> MediaStreamOutputConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<MediaStreamOutputConfiguration>() : null;

        /// <summary>
        /// Checks to see if the MediaStreamOutputConfigurations property is set.
        /// </summary>
        internal bool IsSetMediaStreamOutputConfigurations() => this.MediaStreamOutputConfigurations != null && (this.MediaStreamOutputConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the output. This value must be unique within the current flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputArn. 
        /// <para>
        ///  The ARN of the output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OutputArn { get; set; }

        /// <summary>
        /// Checks to see if the OutputArn property is set.
        /// </summary>
        internal bool IsSetOutputArn() => this.OutputArn != null;

        /// <summary>
        /// Gets and sets the property OutputStatus. 
        /// <para>
        ///  An indication of whether the output is transmitting data or not.
        /// </para>
        /// </summary>
        public OutputStatus OutputStatus { get; set; }

        /// <summary>
        /// Checks to see if the OutputStatus property is set.
        /// </summary>
        internal bool IsSetOutputStatus() => this.OutputStatus != null;

        /// <summary>
        /// Gets and sets the property PeerIpAddress. 
        /// <para>
        /// The IP address of the device that is currently receiving content from this output.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// For outputs that use protocols where you specify the destination (such as SRT Caller
        /// or Zixi Push), this value matches the configured destination address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For outputs that use listener protocols (such as SRT Listener), this value shows the
        /// address of the connected receiver. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Peer IP addresses aren't available for entitlements, managed MediaLive outputs, NDI®
        /// sources and outputs, and CDI/ST2110 outputs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The peer IP address might not be visible for flows that haven't been started yet,
        /// or flows that were started before May 2025. In these cases, restart your flow to see
        /// the peer IP address.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public string PeerIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PeerIpAddress property is set.
        /// </summary>
        internal bool IsSetPeerIpAddress() => this.PeerIpAddress != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        ///  The port to use when content is distributed to this output.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property RouterIntegrationState. 
        /// <para>
        /// Indicates if router integration is enabled or disabled on the flow output.
        /// </para>
        /// </summary>
        public State RouterIntegrationState { get; set; }

        /// <summary>
        /// Checks to see if the RouterIntegrationState property is set.
        /// </summary>
        internal bool IsSetRouterIntegrationState() => this.RouterIntegrationState != null;

        /// <summary>
        /// Gets and sets the property RouterIntegrationTransitEncryption. 
        /// <para>
        /// The encryption configuration for the output when router integration is enabled.
        /// </para>
        /// </summary>
        public FlowTransitEncryption RouterIntegrationTransitEncryption { get; set; }

        /// <summary>
        /// Checks to see if the RouterIntegrationTransitEncryption property is set.
        /// </summary>
        internal bool IsSetRouterIntegrationTransitEncryption() => this.RouterIntegrationTransitEncryption != null;

        /// <summary>
        /// Gets and sets the property Transport. 
        /// <para>
        ///  Attributes related to the transport stream that are used in the output.
        /// </para>
        /// </summary>
        public Transport Transport { get; set; }

        /// <summary>
        /// Checks to see if the Transport property is set.
        /// </summary>
        internal bool IsSetTransport() => this.Transport != null;

        /// <summary>
        /// Gets and sets the property VpcInterfaceAttachment. 
        /// <para>
        ///  The name of the VPC interface attachment to use for this output.
        /// </para>
        /// </summary>
        public VpcInterfaceAttachment VpcInterfaceAttachment { get; set; }

        /// <summary>
        /// Checks to see if the VpcInterfaceAttachment property is set.
        /// </summary>
        internal bool IsSetVpcInterfaceAttachment() => this.VpcInterfaceAttachment != null;
    }
}
