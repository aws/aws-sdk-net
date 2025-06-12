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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// A device.
    /// </summary>
    public partial class Device
    {
        private DeviceBrand _brand;
        private DateTime? _createdTime;
        private string _currentSoftware;
        private string _description;
        private DeviceAggregatedStatus _deviceAggregatedStatus;
        private string _deviceId;
        private DateTime? _lastUpdatedTime;
        private LatestDeviceJob _latestDeviceJob;
        private DateTime? _leaseExpirationTime;
        private string _name;
        private DeviceStatus _provisioningStatus;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DeviceType _type;

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
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentSoftware. 
        /// <para>
        /// A device's current software.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CurrentSoftware
        {
            get { return this._currentSoftware; }
            set { this._currentSoftware = value; }
        }

        // Check to see if CurrentSoftware property is set
        internal bool IsSetCurrentSoftware()
        {
            return this._currentSoftware != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property DeviceAggregatedStatus. 
        /// <para>
        /// A device's aggregated status. Including the device's connection status, provisioning
        /// status, and lease status.
        /// </para>
        /// </summary>
        public DeviceAggregatedStatus DeviceAggregatedStatus
        {
            get { return this._deviceAggregatedStatus; }
            set { this._deviceAggregatedStatus = value; }
        }

        // Check to see if DeviceAggregatedStatus property is set
        internal bool IsSetDeviceAggregatedStatus()
        {
            return this._deviceAggregatedStatus != null;
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
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestDeviceJob. 
        /// <para>
        /// A device's latest job. Includes the target image version, and the update job status.
        /// </para>
        /// </summary>
        public LatestDeviceJob LatestDeviceJob
        {
            get { return this._latestDeviceJob; }
            set { this._latestDeviceJob = value; }
        }

        // Check to see if LatestDeviceJob property is set
        internal bool IsSetLatestDeviceJob()
        {
            return this._latestDeviceJob != null;
        }

        /// <summary>
        /// Gets and sets the property LeaseExpirationTime. 
        /// <para>
        /// The device's lease expiration time.
        /// </para>
        /// </summary>
        public DateTime? LeaseExpirationTime
        {
            get { return this._leaseExpirationTime; }
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The device's tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The device's type.
        /// </para>
        /// </summary>
        public DeviceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}