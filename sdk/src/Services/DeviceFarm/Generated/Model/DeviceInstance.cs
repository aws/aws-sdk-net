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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the device instance.
    /// </summary>
    public partial class DeviceInstance
    {
        private string _arn;
        private string _deviceArn;
        private InstanceProfile _instanceProfile;
        private List<string> _labels = new List<string>();
        private InstanceStatus _status;
        private string _udid;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device instance.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device.
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
        /// Gets and sets the property InstanceProfile. 
        /// <para>
        /// A object containing information about the instance profile.
        /// </para>
        /// </summary>
        public InstanceProfile InstanceProfile
        {
            get { return this._instanceProfile; }
            set { this._instanceProfile = value; }
        }

        // Check to see if InstanceProfile property is set
        internal bool IsSetInstanceProfile()
        {
            return this._instanceProfile != null;
        }

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// An array of strings describing the device instance.
        /// </para>
        /// </summary>
        public List<string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && this._labels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the device instance. Valid values are listed below.
        /// </para>
        /// </summary>
        public InstanceStatus Status
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
        /// Gets and sets the property Udid. 
        /// <para>
        /// Unique device identifier for the device instance.
        /// </para>
        /// </summary>
        public string Udid
        {
            get { return this._udid; }
            set { this._udid = value; }
        }

        // Check to see if Udid property is set
        internal bool IsSetUdid()
        {
            return this._udid != null;
        }

    }
}