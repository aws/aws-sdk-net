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
    /// The settings for an output.
    /// </summary>
    public partial class Output
    {
        private string _bridgeArn;
        private List<int> _bridgePorts = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private int? _dataTransferSubscriberFeePercent;
        private string _description;
        private string _destination;
        private Encryption _encryption;
        private string _entitlementArn;
        private string _listenerAddress;
        private string _mediaLiveInputArn;
        private List<MediaStreamOutputConfiguration> _mediaStreamOutputConfigurations = AWSConfigs.InitializeCollections ? new List<MediaStreamOutputConfiguration>() : null;
        private string _name;
        private string _outputArn;
        private OutputStatus _outputStatus;
        private int? _port;
        private Transport _transport;
        private VpcInterfaceAttachment _vpcInterfaceAttachment;

        /// <summary>
        /// Gets and sets the property BridgeArn. 
        /// <para>
        ///  The ARN of the bridge added to this output.
        /// </para>
        /// </summary>
        public string BridgeArn
        {
            get { return this._bridgeArn; }
            set { this._bridgeArn = value; }
        }

        // Check to see if BridgeArn property is set
        internal bool IsSetBridgeArn()
        {
            return this._bridgeArn != null;
        }

        /// <summary>
        /// Gets and sets the property BridgePorts. 
        /// <para>
        ///  The bridge output ports currently in use.
        /// </para>
        /// </summary>
        public List<int> BridgePorts
        {
            get { return this._bridgePorts; }
            set { this._bridgePorts = value; }
        }

        // Check to see if BridgePorts property is set
        internal bool IsSetBridgePorts()
        {
            return this._bridgePorts != null && (this._bridgePorts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the output.
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
        /// Gets and sets the property Destination. 
        /// <para>
        ///  The address where you want to send the output.
        /// </para>
        /// </summary>
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Encryption. 
        /// <para>
        ///  The type of key used for the encryption. If no keyType is provided, the service will
        /// use the default setting (static-key).
        /// </para>
        /// </summary>
        public Encryption Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property EntitlementArn. 
        /// <para>
        ///  The ARN of the entitlement on the originator''s flow. This value is relevant only
        /// on entitled flows.
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
        /// Gets and sets the property ListenerAddress. 
        /// <para>
        ///  The IP address that the receiver requires in order to establish a connection with
        /// the flow. For public networking, the ListenerAddress is represented by the elastic
        /// IP address of the flow. For private networking, the ListenerAddress is represented
        /// by the elastic network interface IP address of the VPC. This field applies only to
        /// outputs that use the Zixi pull or SRT listener protocol.
        /// </para>
        /// </summary>
        public string ListenerAddress
        {
            get { return this._listenerAddress; }
            set { this._listenerAddress = value; }
        }

        // Check to see if ListenerAddress property is set
        internal bool IsSetListenerAddress()
        {
            return this._listenerAddress != null;
        }

        /// <summary>
        /// Gets and sets the property MediaLiveInputArn. 
        /// <para>
        ///  The input ARN of the MediaLive channel. This parameter is relevant only for outputs
        /// that were added by creating a MediaLive input.
        /// </para>
        /// </summary>
        public string MediaLiveInputArn
        {
            get { return this._mediaLiveInputArn; }
            set { this._mediaLiveInputArn = value; }
        }

        // Check to see if MediaLiveInputArn property is set
        internal bool IsSetMediaLiveInputArn()
        {
            return this._mediaLiveInputArn != null;
        }

        /// <summary>
        /// Gets and sets the property MediaStreamOutputConfigurations. 
        /// <para>
        ///  The configuration for each media stream that is associated with the output.
        /// </para>
        /// </summary>
        public List<MediaStreamOutputConfiguration> MediaStreamOutputConfigurations
        {
            get { return this._mediaStreamOutputConfigurations; }
            set { this._mediaStreamOutputConfigurations = value; }
        }

        // Check to see if MediaStreamOutputConfigurations property is set
        internal bool IsSetMediaStreamOutputConfigurations()
        {
            return this._mediaStreamOutputConfigurations != null && (this._mediaStreamOutputConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the output. This value must be unique within the current flow.
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
        /// Gets and sets the property OutputArn. 
        /// <para>
        ///  The ARN of the output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OutputArn
        {
            get { return this._outputArn; }
            set { this._outputArn = value; }
        }

        // Check to see if OutputArn property is set
        internal bool IsSetOutputArn()
        {
            return this._outputArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutputStatus. 
        /// <para>
        ///  An indication of whether the output is transmitting data or not.
        /// </para>
        /// </summary>
        public OutputStatus OutputStatus
        {
            get { return this._outputStatus; }
            set { this._outputStatus = value; }
        }

        // Check to see if OutputStatus property is set
        internal bool IsSetOutputStatus()
        {
            return this._outputStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        ///  The port to use when content is distributed to this output.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Transport. 
        /// <para>
        ///  Attributes related to the transport stream that are used in the output.
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
        /// Gets and sets the property VpcInterfaceAttachment. 
        /// <para>
        ///  The name of the VPC interface attachment to use for this output.
        /// </para>
        /// </summary>
        public VpcInterfaceAttachment VpcInterfaceAttachment
        {
            get { return this._vpcInterfaceAttachment; }
            set { this._vpcInterfaceAttachment = value; }
        }

        // Check to see if VpcInterfaceAttachment property is set
        internal bool IsSetVpcInterfaceAttachment()
        {
            return this._vpcInterfaceAttachment != null;
        }

    }
}