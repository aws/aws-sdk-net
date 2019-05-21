/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the StartDeviceSync operation.
    /// Resets a device and its account to the known default settings. This clears all information
    /// and settings set by previous users in the following ways:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Bluetooth - This unpairs all bluetooth devices paired with your echo device.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Volume - This resets the echo device's volume to the default value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Notifications - This clears all notifications from your echo device.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Lists - This clears all to-do items from your echo device.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Settings - This internally syncs the room's profile (if the device is assigned to
    /// a room), contacts, address books, delegation access for account linking, and communications
    /// (if enabled on the room profile).
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartDeviceSyncRequest : AmazonAlexaForBusinessRequest
    {
        private string _deviceArn;
        private List<string> _features = new List<string>();
        private string _roomArn;

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The ARN of the device to sync. Required.
        /// </para>
        /// </summary>
        public string DeviceArn
        {
            get { return this._deviceArn; }
            set { this._deviceArn = value; }
        }

        // Check to see if DeviceArn property is set
        internal bool IsSetDeviceArn()
        {
            return this._deviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// Request structure to start the device sync. Required.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null && this._features.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoomArn. 
        /// <para>
        /// The ARN of the room with which the device to sync is associated. Required.
        /// </para>
        /// </summary>
        public string RoomArn
        {
            get { return this._roomArn; }
            set { this._roomArn = value; }
        }

        // Check to see if RoomArn property is set
        internal bool IsSetRoomArn()
        {
            return this._roomArn != null;
        }

    }
}