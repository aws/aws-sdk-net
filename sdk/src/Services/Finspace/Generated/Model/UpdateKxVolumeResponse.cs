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

namespace Amazon.Finspace.Model
{
    /// <summary>
    /// This is the response object from the UpdateKxVolume operation.
    /// </summary>
    public partial class UpdateKxVolumeResponse : AmazonWebServiceResponse
    {
        private List<KxAttachedCluster> _attachedClusters = AWSConfigs.InitializeCollections ? new List<KxAttachedCluster>() : null;
        private List<string> _availabilityZoneIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private KxAzMode _azMode;
        private DateTime? _createdTimestamp;
        private string _description;
        private string _environmentId;
        private DateTime? _lastModifiedTimestamp;
        private KxNAS1Configuration _nas1Configuration;
        private KxVolumeStatus _status;
        private string _statusReason;
        private string _volumeArn;
        private string _volumeName;
        private KxVolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property AttachedClusters. 
        /// <para>
        ///  Specifies the clusters that a volume is attached to. 
        /// </para>
        /// </summary>
        public List<KxAttachedCluster> AttachedClusters
        {
            get { return this._attachedClusters; }
            set { this._attachedClusters = value; }
        }

        // Check to see if AttachedClusters property is set
        internal bool IsSetAttachedClusters()
        {
            return this._attachedClusters != null && (this._attachedClusters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneIds. 
        /// <para>
        /// The identifier of the availability zones.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        ///  The timestamp at which the volume was created in FinSpace. The value is determined
        /// as epoch time in milliseconds. For example, the value for Monday, November 1, 2021
        /// 12:00:00 PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description for the volume. 
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
        /// A unique identifier for the kdb environment where you want to update the volume. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        /// The last time that the volume was updated in FinSpace. The value is determined as
        /// epoch time in milliseconds. For example, the value for Monday, November 1, 2021 12:00:00
        /// PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp.GetValueOrDefault(); }
            set { this._lastModifiedTimestamp = value; }
        }

        // Check to see if LastModifiedTimestamp property is set
        internal bool IsSetLastModifiedTimestamp()
        {
            return this._lastModifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Nas1Configuration. 
        /// <para>
        ///  Specifies the configuration for the Network attached storage (NAS_1) file system
        /// volume.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the volume.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATING – The volume creation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_FAILED – The volume creation has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVE – The volume is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UPDATING – The volume is in the process of being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UPDATE_FAILED – The update action failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UPDATED – The volume is successfully updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING – The volume is in the process of being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE_FAILED – The system failed to delete the volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETED – The volume is successfully deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public KxVolumeStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The error message when a failed state occurs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeArn. 
        /// <para>
        ///  The ARN identifier of the volume. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string VolumeArn
        {
            get { return this._volumeArn; }
            set { this._volumeArn = value; }
        }

        // Check to see if VolumeArn property is set
        internal bool IsSetVolumeArn()
        {
            return this._volumeArn != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeName. 
        /// <para>
        /// A unique identifier for the volume that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
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
        /// type. 
        /// </para>
        /// </summary>
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