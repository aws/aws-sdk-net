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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKxVolume operation.
    /// Creates a new volume with a specific amount of throughput and storage capacity.
    /// </summary>
    public partial class CreateKxVolumeRequest : AmazonFinspaceRequest
    {
        private List<string> _availabilityZoneIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private KxAzMode _azMode;
        private string _clientToken;
        private string _description;
        private string _environmentId;
        private KxNAS1Configuration _nas1Configuration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _volumeName;
        private KxVolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneIds. 
        /// <para>
        /// The identifier of the availability zones.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AvailabilityZoneIds
        {
            get { return this._availabilityZoneIds; }
            set { this._availabilityZoneIds = value; }
        }

        // Check to see if AvailabilityZoneIds property is set
        internal bool IsSetAvailabilityZoneIds()
        {
            return this._availabilityZoneIds != null && (this._availabilityZoneIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AzMode. 
        /// <para>
        /// The number of availability zones you want to assign per volume. Currently, FinSpace
        /// only supports <c>SINGLE</c> for volumes. This places dataview in a single AZ.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KxAzMode AzMode
        {
            get { return this._azMode; }
            set { this._azMode = value; }
        }

        // Check to see if AzMode property is set
        internal bool IsSetAzMode()
        {
            return this._azMode != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures idempotency. This token expires in 10 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the volume. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique identifier for the kdb environment, whose clusters can attach to the volume.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property Nas1Configuration. 
        /// <para>
        ///  Specifies the configuration for the Network attached storage (NAS_1) file system
        /// volume. This parameter is required when you choose <c>volumeType</c> as <i>NAS_1</i>.
        /// </para>
        /// </summary>
        public KxNAS1Configuration Nas1Configuration
        {
            get { return this._nas1Configuration; }
            set { this._nas1Configuration = value; }
        }

        // Check to see if Nas1Configuration property is set
        internal bool IsSetNas1Configuration()
        {
            return this._nas1Configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of key-value pairs to label the volume. You can add up to 50 tags to a volume.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property VolumeName. 
        /// <para>
        /// A unique identifier for the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string VolumeName
        {
            get { return this._volumeName; }
            set { this._volumeName = value; }
        }

        // Check to see if VolumeName property is set
        internal bool IsSetVolumeName()
        {
            return this._volumeName != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        ///  The type of file system volume. Currently, FinSpace only supports <c>NAS_1</c> volume
        /// type. When you select <c>NAS_1</c> volume type, you must also provide <c>nas1Configuration</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KxVolumeType VolumeType
        {
            get { return this._volumeType; }
            set { this._volumeType = value; }
        }

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this._volumeType != null;
        }

    }
}