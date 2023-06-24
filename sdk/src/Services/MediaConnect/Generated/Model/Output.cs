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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The settings for an output.
    /// </summary>
    public partial class Output
    {
        private string _bridgeArn;
        private List<int> _bridgePorts = new List<int>();
        private int? _dataTransferSubscriberFeePercent;
        private string _description;
        private string _destination;
        private Encryption _encryption;
        private string _entitlementArn;
        private string _listenerAddress;
        private string _mediaLiveInputArn;
        private List<MediaStreamOutputConfiguration> _mediaStreamOutputConfigurations = new List<MediaStreamOutputConfiguration>();
        private string _name;
        private string _outputArn;
        private int? _port;
        private Transport _transport;
        private VpcInterfaceAttachment _vpcInterfaceAttachment;

        /// <summary>
        /// Gets and sets the property BridgeArn. The ARN of the bridge that added this output.
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
        /// Gets and sets the property BridgePorts. The bridge output ports currently in use.
        /// </summary>
        public List<int> BridgePorts
        {
            get { return this._bridgePorts; }
            set { this._bridgePorts = value; }
        }

        // Check to see if BridgePorts property is set
        internal bool IsSetBridgePorts()
        {
            return this._bridgePorts != null && this._bridgePorts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataTransferSubscriberFeePercent. Percentage from 0-100
        /// of the data transfer cost to be billed to the subscriber.
        /// </summary>
        public int DataTransferSubscriberFeePercent
        {
            get { return this._dataTransferSubscriberFeePercent.GetValueOrDefault(); }
            set { this._dataTransferSubscriberFeePercent = value; }
        }

        // Check to see if DataTransferSubscriberFeePercent property is set
        internal bool IsSetDataTransferSubscriberFeePercent()
        {
            return this._dataTransferSubscriberFeePercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. A description of the output.
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
        /// Gets and sets the property Destination. The address where you want to send the output.
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
        /// Gets and sets the property Encryption. The type of key used for the encryption. If
        /// no keyType is provided, the service will use the default setting (static-key).
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
        /// Gets and sets the property EntitlementArn. The ARN of the entitlement on the originator''s
        /// flow. This value is relevant only on entitled flows.
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
        /// Gets and sets the property ListenerAddress. The IP address that the receiver requires
        /// in order to establish a connection with the flow. For public networking, the ListenerAddress
        /// is represented by the elastic IP address of the flow. For private networking, the
        /// ListenerAddress is represented by the elastic network interface IP address of the
        /// VPC. This field applies only to outputs that use the Zixi pull or SRT listener protocol.
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
        /// Gets and sets the property MediaLiveInputArn. The input ARN of the AWS Elemental MediaLive
        /// channel. This parameter is relevant only for outputs that were added by creating a
        /// MediaLive input.
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
        /// Gets and sets the property MediaStreamOutputConfigurations. The configuration for
        /// each media stream that is associated with the output.
        /// </summary>
        public List<MediaStreamOutputConfiguration> MediaStreamOutputConfigurations
        {
            get { return this._mediaStreamOutputConfigurations; }
            set { this._mediaStreamOutputConfigurations = value; }
        }

        // Check to see if MediaStreamOutputConfigurations property is set
        internal bool IsSetMediaStreamOutputConfigurations()
        {
            return this._mediaStreamOutputConfigurations != null && this._mediaStreamOutputConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the output. This value must be unique
        /// within the current flow.
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
        /// Gets and sets the property OutputArn. The ARN of the output.
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
        /// Gets and sets the property Port. The port to use when content is distributed to this
        /// output.
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Transport. Attributes related to the transport stream that
        /// are used in the output.
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
        /// Gets and sets the property VpcInterfaceAttachment. The name of the VPC interface attachment
        /// to use for this output.
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