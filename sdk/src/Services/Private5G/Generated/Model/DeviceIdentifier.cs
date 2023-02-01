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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Information about a subscriber of a device that can use a network.
    /// </summary>
    public partial class DeviceIdentifier
    {
        private DateTime? _createdAt;
        private string _deviceIdentifierArn;
        private string _iccid;
        private string _imsi;
        private string _networkArn;
        private string _orderArn;
        private DeviceIdentifierStatus _status;
        private string _trafficGroupArn;
        private string _vendor;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The creation time of this device identifier.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceIdentifierArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device identifier.
        /// </para>
        /// </summary>
        public string DeviceIdentifierArn
        {
            get { return this._deviceIdentifierArn; }
            set { this._deviceIdentifierArn = value; }
        }

        // Check to see if DeviceIdentifierArn property is set
        internal bool IsSetDeviceIdentifierArn()
        {
            return this._deviceIdentifierArn != null;
        }

        /// <summary>
        /// Gets and sets the property Iccid. 
        /// <para>
        /// The Integrated Circuit Card Identifier of the device identifier.
        /// </para>
        /// </summary>
        public string Iccid
        {
            get { return this._iccid; }
            set { this._iccid = value; }
        }

        // Check to see if Iccid property is set
        internal bool IsSetIccid()
        {
            return this._iccid != null;
        }

        /// <summary>
        /// Gets and sets the property Imsi. 
        /// <para>
        /// The International Mobile Subscriber Identity of the device identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Imsi
        {
            get { return this._imsi; }
            set { this._imsi = value; }
        }

        // Check to see if Imsi property is set
        internal bool IsSetImsi()
        {
            return this._imsi != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network on which the device identifier appears.
        /// </para>
        /// </summary>
        public string NetworkArn
        {
            get { return this._networkArn; }
            set { this._networkArn = value; }
        }

        // Check to see if NetworkArn property is set
        internal bool IsSetNetworkArn()
        {
            return this._networkArn != null;
        }

        /// <summary>
        /// Gets and sets the property OrderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the order used to purchase the device identifier.
        /// </para>
        /// </summary>
        public string OrderArn
        {
            get { return this._orderArn; }
            set { this._orderArn = value; }
        }

        // Check to see if OrderArn property is set
        internal bool IsSetOrderArn()
        {
            return this._orderArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the device identifier.
        /// </para>
        /// </summary>
        public DeviceIdentifierStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the traffic group to which the device identifier
        /// belongs.
        /// </para>
        /// </summary>
        public string TrafficGroupArn
        {
            get { return this._trafficGroupArn; }
            set { this._trafficGroupArn = value; }
        }

        // Check to see if TrafficGroupArn property is set
        internal bool IsSetTrafficGroupArn()
        {
            return this._trafficGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property Vendor. 
        /// <para>
        /// The vendor of the device identifier.
        /// </para>
        /// </summary>
        public string Vendor
        {
            get { return this._vendor; }
            set { this._vendor = value; }
        }

        // Check to see if Vendor property is set
        internal bool IsSetVendor()
        {
            return this._vendor != null;
        }

    }
}