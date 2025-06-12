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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
    /// The settings for the source of the flow.
    /// </summary>
    public partial class Source
    {
        private int? _dataTransferSubscriberFeePercent;
        private Encryption _decryption;
        private string _description;
        private string _entitlementArn;
        private GatewayBridgeSource _gatewayBridgeSource;
        private string _ingestIp;
        private int? _ingestPort;
        private List<MediaStreamSourceConfiguration> _mediaStreamSourceConfigurations = AWSConfigs.InitializeCollections ? new List<MediaStreamSourceConfiguration>() : null;
        private string _name;
        private string _peerIpAddress;
        private int? _senderControlPort;
        private string _senderIpAddress;
        private string _sourceArn;
        private Transport _transport;
        private string _vpcInterfaceName;
        private string _whitelistCidr;

        /// <summary>
        /// Gets and sets the property DataTransferSubscriberFeePercent. 
        /// <para>
        ///  Percentage from 0-100 of the data transfer cost to be billed to the subscriber.
        /// </para>
        /// </summary>
        public int? DataTransferSubscriberFeePercent
        {
            get { return this._dataTransferSubscriberFeePercent; }
            set { this._dataTransferSubscriberFeePercent = value; }
        }

        // Check to see if DataTransferSubscriberFeePercent property is set
        internal bool IsSetDataTransferSubscriberFeePercent()
        {
            return this._dataTransferSubscriberFeePercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Decryption. 
        /// <para>
        ///  The type of encryption that is used on the content ingested from this source.
        /// </para>
        /// </summary>
        public Encryption Decryption
        {
            get { return this._decryption; }
            set { this._decryption = value; }
        }

        // Check to see if Decryption property is set
        internal bool IsSetDecryption()
        {
            return this._decryption != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description for the source. This value is not used or seen outside of the current
        /// MediaConnect account.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EntitlementArn. 
        /// <para>
        ///  The ARN of the entitlement that allows you to subscribe to content that comes from
        /// another Amazon Web Services account. The entitlement is set by the content originator
        /// and the ARN is generated as part of the originator's flow.
        /// </para>
        /// </summary>
        public string EntitlementArn
        {
            get { return this._entitlementArn; }
            set { this._entitlementArn = value; }
        }

        // Check to see if EntitlementArn property is set
        internal bool IsSetEntitlementArn()
        {
            return this._entitlementArn != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayBridgeSource. 
        /// <para>
        ///  The source configuration for cloud flows receiving a stream from a bridge.
        /// </para>
        /// </summary>
        public GatewayBridgeSource GatewayBridgeSource
        {
            get { return this._gatewayBridgeSource; }
            set { this._gatewayBridgeSource = value; }
        }

        // Check to see if GatewayBridgeSource property is set
        internal bool IsSetGatewayBridgeSource()
        {
            return this._gatewayBridgeSource != null;
        }

        /// <summary>
        /// Gets and sets the property IngestIp. 
        /// <para>
        ///  The IP address that the flow will be listening on for incoming content.
        /// </para>
        /// </summary>
        public string IngestIp
        {
            get { return this._ingestIp; }
            set { this._ingestIp = value; }
        }

        // Check to see if IngestIp property is set
        internal bool IsSetIngestIp()
        {
            return this._ingestIp != null;
        }

        /// <summary>
        /// Gets and sets the property IngestPort. 
        /// <para>
        ///  The port that the flow will be listening on for incoming content.
        /// </para>
        /// </summary>
        public int? IngestPort
        {
            get { return this._ingestPort; }
            set { this._ingestPort = value; }
        }

        // Check to see if IngestPort property is set
        internal bool IsSetIngestPort()
        {
            return this._ingestPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MediaStreamSourceConfigurations. 
        /// <para>
        ///  The media streams that are associated with the source, and the parameters for those
        /// associations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaStreamSourceConfiguration> MediaStreamSourceConfigurations
        {
            get { return this._mediaStreamSourceConfigurations; }
            set { this._mediaStreamSourceConfigurations = value; }
        }

        // Check to see if MediaStreamSourceConfigurations property is set
        internal bool IsSetMediaStreamSourceConfigurations()
        {
            return this._mediaStreamSourceConfigurations != null && (this._mediaStreamSourceConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PeerIpAddress. 
        /// <para>
        /// The IP address of the device that is currently sending content to this source. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// For sources that use protocols where you specify the origin (such as SRT Caller),
        /// this value matches the configured origin address. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For sources that use listener protocols (such as SRT Listener or RTP), this value
        /// shows the address of the connected sender. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Peer IP addresses aren't available for entitlements and CDI/ST2110 sources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The peer IP address might not be visible for flows that haven't been started yet,
        /// or flows that were started before May 2025. In these cases, restart your flow to see
        /// the peer IP address.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public string PeerIpAddress
        {
            get { return this._peerIpAddress; }
            set { this._peerIpAddress = value; }
        }

        // Check to see if PeerIpAddress property is set
        internal bool IsSetPeerIpAddress()
        {
            return this._peerIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SenderControlPort. 
        /// <para>
        ///  The IP address that the flow communicates with to initiate connection with the sender.
        /// </para>
        /// </summary>
        public int? SenderControlPort
        {
            get { return this._senderControlPort; }
            set { this._senderControlPort = value; }
        }

        // Check to see if SenderControlPort property is set
        internal bool IsSetSenderControlPort()
        {
            return this._senderControlPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SenderIpAddress. 
        /// <para>
        ///  The port that the flow uses to send outbound requests to initiate connection with
        /// the sender.
        /// </para>
        /// </summary>
        public string SenderIpAddress
        {
            get { return this._senderIpAddress; }
            set { this._senderIpAddress = value; }
        }

        // Check to see if SenderIpAddress property is set
        internal bool IsSetSenderIpAddress()
        {
            return this._senderIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        ///  The ARN of the source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Transport. 
        /// <para>
        ///  Attributes related to the transport stream that are used in the source.
        /// </para>
        /// </summary>
        public Transport Transport
        {
            get { return this._transport; }
            set { this._transport = value; }
        }

        // Check to see if Transport property is set
        internal bool IsSetTransport()
        {
            return this._transport != null;
        }

        /// <summary>
        /// Gets and sets the property VpcInterfaceName. 
        /// <para>
        ///  The name of the VPC interface that is used for this source.
        /// </para>
        /// </summary>
        public string VpcInterfaceName
        {
            get { return this._vpcInterfaceName; }
            set { this._vpcInterfaceName = value; }
        }

        // Check to see if VpcInterfaceName property is set
        internal bool IsSetVpcInterfaceName()
        {
            return this._vpcInterfaceName != null;
        }

        /// <summary>
        /// Gets and sets the property WhitelistCidr. 
        /// <para>
        ///  The range of IP addresses that should be allowed to contribute content to your source.
        /// These IP addresses should be in the form of a Classless Inter-Domain Routing (CIDR)
        /// block; for example, 10.0.0.0/16.
        /// </para>
        /// </summary>
        public string WhitelistCidr
        {
            get { return this._whitelistCidr; }
            set { this._whitelistCidr = value; }
        }

        // Check to see if WhitelistCidr property is set
        internal bool IsSetWhitelistCidr()
        {
            return this._whitelistCidr != null;
        }

    }
}