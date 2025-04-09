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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the StartConnection operation.
    /// <note> 
    /// <para>
    ///  Amazon Web Services uses this action to install Outpost servers.
    /// </para>
    ///  </note> 
    /// <para>
    ///  Starts the connection required for Outpost server installation. 
    /// </para>
    ///  
    /// <para>
    ///  Use CloudTrail to monitor this action or Amazon Web Services managed policy for Amazon
    /// Web Services Outposts to secure it. For more information, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/security-iam-awsmanpol.html">
    /// Amazon Web Services managed policies for Amazon Web Services Outposts</a> and <a href="https://docs.aws.amazon.com/outposts/latest/userguide/logging-using-cloudtrail.html">
    /// Logging Amazon Web Services Outposts API calls with Amazon Web Services CloudTrail</a>
    /// in the <i>Amazon Web Services Outposts User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class StartConnectionRequest : AmazonOutpostsRequest
    {
        private string _assetId;
        private string _clientPublicKey;
        private string _deviceSerialNumber;
        private int? _networkInterfaceDeviceIndex;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        ///  The ID of the Outpost server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientPublicKey. 
        /// <para>
        ///  The public key of the client. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=44, Max=44)]
        public string ClientPublicKey
        {
            get { return this._clientPublicKey; }
            set { this._clientPublicKey = value; }
        }

        // Check to see if ClientPublicKey property is set
        internal bool IsSetClientPublicKey()
        {
            return this._clientPublicKey != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceSerialNumber. 
        /// <para>
        ///  The serial number of the dongle. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DeviceSerialNumber
        {
            get { return this._deviceSerialNumber; }
            set { this._deviceSerialNumber = value; }
        }

        // Check to see if DeviceSerialNumber property is set
        internal bool IsSetDeviceSerialNumber()
        {
            return this._deviceSerialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceDeviceIndex. 
        /// <para>
        ///  The device index of the network interface on the Outpost server. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public int? NetworkInterfaceDeviceIndex
        {
            get { return this._networkInterfaceDeviceIndex; }
            set { this._networkInterfaceDeviceIndex = value; }
        }

        // Check to see if NetworkInterfaceDeviceIndex property is set
        internal bool IsSetNetworkInterfaceDeviceIndex()
        {
            return this._networkInterfaceDeviceIndex.HasValue; 
        }

    }
}