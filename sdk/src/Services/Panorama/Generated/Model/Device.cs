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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Panorama.Model
{
    /// <summary>
    /// A device.
    /// </summary>
    public partial class Device
    {
        private DeviceBrand _brand;
        private DateTime? _createdTime;
        private string _deviceId;
        private DateTime? _lastUpdatedTime;
        private DateTime? _leaseExpirationTime;
        private string _name;
        private DeviceStatus _provisioningStatus;

        /// <summary>
        /// Gets and sets the property Brand. 
        /// <para>
        /// The device's maker.
        /// </para>
        /// </summary>
        public DeviceBrand Brand
        {
            get { return this._brand; }
            set { this._brand = value; }
        }

        // Check to see if Brand property is set
        internal bool IsSetBrand()
        {
            return this._brand != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// When the device was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The device's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// When the device was updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LeaseExpirationTime. 
        /// <para>
        /// The device's lease expiration time.
        /// </para>
        /// </summary>
        public DateTime LeaseExpirationTime
        {
            get { return this._leaseExpirationTime.GetValueOrDefault(); }
            set { this._leaseExpirationTime = value; }
        }

        // Check to see if LeaseExpirationTime property is set
        internal bool IsSetLeaseExpirationTime()
        {
            return this._leaseExpirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The device's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ProvisioningStatus. 
        /// <para>
        /// The device's provisioning status.
        /// </para>
        /// </summary>
        public DeviceStatus ProvisioningStatus
        {
            get { return this._provisioningStatus; }
            set { this._provisioningStatus = value; }
        }

        // Check to see if ProvisioningStatus property is set
        internal bool IsSetProvisioningStatus()
        {
            return this._provisioningStatus != null;
        }

    }
}