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
    /// The information that DataSync Discovery collects about a storage virtual machine (SVM)
    /// in your on-premises storage system.
    /// </summary>
    public partial class NetAppONTAPSVM
    {
        private long? _cifsShareCount;
        private string _clusterUuid;
        private List<string> _enabledProtocols = new List<string>();
        private long? _lunCount;
        private MaxP95Performance _maxP95Performance;
        private long? _nfsExportedVolumes;
        private List<Recommendation> _recommendations = new List<Recommendation>();
        private RecommendationStatus _recommendationStatus;
        private string _resourceId;
        private string _svmName;
        private long? _totalCapacityProvisioned;
        private long? _totalCapacityUsed;
        private long? _totalLogicalCapacityUsed;
        private long? _totalSnapshotCapacityUsed;

        /// <summary>
        /// Gets and sets the property CifsShareCount. 
        /// <para>
        /// The number of CIFS shares in the SVM.
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
        /// Gets and sets the property ClusterUuid. 
        /// <para>
        /// The universally unique identifier (UUID) of the cluster associated with the SVM.
        /// </para>
        /// </summary>
        public string ClusterUuid
        {
            get { return this._clusterUuid; }
            set { this._clusterUuid = value; }
        }

        // Check to see if ClusterUuid property is set
        internal bool IsSetClusterUuid()
        {
            return this._clusterUuid != null;
        }

        /// <summary>
        /// Gets and sets the property EnabledProtocols. 
        /// <para>
        /// The data transfer protocols (such as NFS) configured for the SVM.
        /// </para>
        /// </summary>
        public List<string> EnabledProtocols
        {
            get { return this._enabledProtocols; }
            set { this._enabledProtocols = value; }
        }

        // Check to see if EnabledProtocols property is set
        internal bool IsSetEnabledProtocols()
        {
            return this._enabledProtocols != null && this._enabledProtocols.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LunCount. 
        /// <para>
        /// The number of LUNs (logical unit numbers) in the SVM.
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
        /// The performance data that DataSync Discovery collects about the SVM.
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
        /// Gets and sets the property NfsExportedVolumes. 
        /// <para>
        /// The number of NFS volumes in the SVM.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long NfsExportedVolumes
        {
            get { return this._nfsExportedVolumes.GetValueOrDefault(); }
            set { this._nfsExportedVolumes = value; }
        }

        // Check to see if NfsExportedVolumes property is set
        internal bool IsSetNfsExportedVolumes()
        {
            return this._nfsExportedVolumes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Recommendations. 
        /// <para>
        /// The Amazon Web Services storage services that DataSync Discovery recommends for the
        /// SVM. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-understand-recommendations.html">Recommendations
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
        /// Indicates whether DataSync Discovery recommendations for the SVM are ready to view,
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
        /// The UUID of the SVM.
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
        /// Gets and sets the property SvmName. 
        /// <para>
        /// The name of the SVM
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
        /// Gets and sets the property TotalCapacityProvisioned. 
        /// <para>
        /// The total storage space that's available in the SVM.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long TotalCapacityProvisioned
        {
            get { return this._totalCapacityProvisioned.GetValueOrDefault(); }
            set { this._totalCapacityProvisioned = value; }
        }

        // Check to see if TotalCapacityProvisioned property is set
        internal bool IsSetTotalCapacityProvisioned()
        {
            return this._totalCapacityProvisioned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalCapacityUsed. 
        /// <para>
        /// The storage space that's being used in the SVM.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long TotalCapacityUsed
        {
            get { return this._totalCapacityUsed.GetValueOrDefault(); }
            set { this._totalCapacityUsed = value; }
        }

        // Check to see if TotalCapacityUsed property is set
        internal bool IsSetTotalCapacityUsed()
        {
            return this._totalCapacityUsed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalLogicalCapacityUsed. 
        /// <para>
        /// The storage space that's being used in the SVM without accounting for compression
        /// or deduplication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long TotalLogicalCapacityUsed
        {
            get { return this._totalLogicalCapacityUsed.GetValueOrDefault(); }
            set { this._totalLogicalCapacityUsed = value; }
        }

        // Check to see if TotalLogicalCapacityUsed property is set
        internal bool IsSetTotalLogicalCapacityUsed()
        {
            return this._totalLogicalCapacityUsed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalSnapshotCapacityUsed. 
        /// <para>
        /// The amount of storage in the SVM that's being used for snapshots.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long TotalSnapshotCapacityUsed
        {
            get { return this._totalSnapshotCapacityUsed.GetValueOrDefault(); }
            set { this._totalSnapshotCapacityUsed = value; }
        }

        // Check to see if TotalSnapshotCapacityUsed property is set
        internal bool IsSetTotalSnapshotCapacityUsed()
        {
            return this._totalSnapshotCapacityUsed.HasValue; 
        }

    }
}