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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The information that DataSync Discovery collects about a volume in your on-premises
    /// storage system.
    /// </summary>
    public partial class NetAppONTAPVolume
    {
        private long? _capacityProvisioned;
        private long? _capacityUsed;
        private long? _cifsShareCount;
        private long? _logicalCapacityUsed;
        private long? _lunCount;
        private MaxP95Performance _maxP95Performance;
        private bool? _nfsExported;
        private List<Recommendation> _recommendations = new List<Recommendation>();
        private RecommendationStatus _recommendationStatus;
        private string _resourceId;
        private string _securityStyle;
        private long? _snapshotCapacityUsed;
        private string _svmName;
        private string _svmUuid;
        private string _volumeName;

        /// <summary>
        /// Gets and sets the property CapacityProvisioned. 
        /// <para>
        /// The total storage space that's available in the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long CapacityProvisioned
        {
            get { return this._capacityProvisioned.GetValueOrDefault(); }
            set { this._capacityProvisioned = value; }
        }

        // Check to see if CapacityProvisioned property is set
        internal bool IsSetCapacityProvisioned()
        {
            return this._capacityProvisioned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CapacityUsed. 
        /// <para>
        /// The storage space that's being used in the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long CapacityUsed
        {
            get { return this._capacityUsed.GetValueOrDefault(); }
            set { this._capacityUsed = value; }
        }

        // Check to see if CapacityUsed property is set
        internal bool IsSetCapacityUsed()
        {
            return this._capacityUsed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CifsShareCount. 
        /// <para>
        /// The number of CIFS shares in the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long CifsShareCount
        {
            get { return this._cifsShareCount.GetValueOrDefault(); }
            set { this._cifsShareCount = value; }
        }

        // Check to see if CifsShareCount property is set
        internal bool IsSetCifsShareCount()
        {
            return this._cifsShareCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogicalCapacityUsed. 
        /// <para>
        /// The storage space that's being used in the volume without accounting for compression
        /// or deduplication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long LogicalCapacityUsed
        {
            get { return this._logicalCapacityUsed.GetValueOrDefault(); }
            set { this._logicalCapacityUsed = value; }
        }

        // Check to see if LogicalCapacityUsed property is set
        internal bool IsSetLogicalCapacityUsed()
        {
            return this._logicalCapacityUsed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LunCount. 
        /// <para>
        /// The number of LUNs (logical unit numbers) in the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long LunCount
        {
            get { return this._lunCount.GetValueOrDefault(); }
            set { this._lunCount = value; }
        }

        // Check to see if LunCount property is set
        internal bool IsSetLunCount()
        {
            return this._lunCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxP95Performance. 
        /// <para>
        /// The performance data that DataSync Discovery collects about the volume.
        /// </para>
        /// </summary>
        public MaxP95Performance MaxP95Performance
        {
            get { return this._maxP95Performance; }
            set { this._maxP95Performance = value; }
        }

        // Check to see if MaxP95Performance property is set
        internal bool IsSetMaxP95Performance()
        {
            return this._maxP95Performance != null;
        }

        /// <summary>
        /// Gets and sets the property NfsExported. 
        /// <para>
        /// The number of NFS volumes in the volume.
        /// </para>
        /// </summary>
        public bool NfsExported
        {
            get { return this._nfsExported.GetValueOrDefault(); }
            set { this._nfsExported = value; }
        }

        // Check to see if NfsExported property is set
        internal bool IsSetNfsExported()
        {
            return this._nfsExported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Recommendations. 
        /// <para>
        /// The Amazon Web Services storage services that DataSync Discovery recommends for the
        /// volume. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-understand-recommendations.html">Recommendations
        /// provided by DataSync Discovery</a>.
        /// </para>
        /// </summary>
        public List<Recommendation> Recommendations
        {
            get { return this._recommendations; }
            set { this._recommendations = value; }
        }

        // Check to see if Recommendations property is set
        internal bool IsSetRecommendations()
        {
            return this._recommendations != null && this._recommendations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RecommendationStatus. 
        /// <para>
        /// Indicates whether DataSync Discovery recommendations for the volume are ready to view,
        /// incomplete, or can't be determined.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-job-statuses.html#recommendation-statuses-table">Recommendation
        /// statuses</a>.
        /// </para>
        /// </summary>
        public RecommendationStatus RecommendationStatus
        {
            get { return this._recommendationStatus; }
            set { this._recommendationStatus = value; }
        }

        // Check to see if RecommendationStatus property is set
        internal bool IsSetRecommendationStatus()
        {
            return this._recommendationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The universally unique identifier (UUID) of the volume.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityStyle. 
        /// <para>
        /// The volume's security style (such as Unix or NTFS).
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string SecurityStyle
        {
            get { return this._securityStyle; }
            set { this._securityStyle = value; }
        }

        // Check to see if SecurityStyle property is set
        internal bool IsSetSecurityStyle()
        {
            return this._securityStyle != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotCapacityUsed. 
        /// <para>
        /// The amount of storage in the volume that's being used for snapshots.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long SnapshotCapacityUsed
        {
            get { return this._snapshotCapacityUsed.GetValueOrDefault(); }
            set { this._snapshotCapacityUsed = value; }
        }

        // Check to see if SnapshotCapacityUsed property is set
        internal bool IsSetSnapshotCapacityUsed()
        {
            return this._snapshotCapacityUsed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SvmName. 
        /// <para>
        /// The name of the SVM associated with the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string SvmName
        {
            get { return this._svmName; }
            set { this._svmName = value; }
        }

        // Check to see if SvmName property is set
        internal bool IsSetSvmName()
        {
            return this._svmName != null;
        }

        /// <summary>
        /// Gets and sets the property SvmUuid. 
        /// <para>
        /// The UUID of the storage virtual machine (SVM) associated with the volume.
        /// </para>
        /// </summary>
        public string SvmUuid
        {
            get { return this._svmUuid; }
            set { this._svmUuid = value; }
        }

        // Check to see if SvmUuid property is set
        internal bool IsSetSvmUuid()
        {
            return this._svmUuid != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeName. 
        /// <para>
        /// The name of the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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

    }
}