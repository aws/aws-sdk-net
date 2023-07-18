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
    /// The information that DataSync Discovery collects about an on-premises storage system
    /// cluster.
    /// </summary>
    public partial class NetAppONTAPCluster
    {
        private long? _cifsShareCount;
        private long? _clusterBlockStorageLogicalUsed;
        private long? _clusterBlockStorageSize;
        private long? _clusterBlockStorageUsed;
        private string _clusterName;
        private long? _lunCount;
        private MaxP95Performance _maxP95Performance;
        private long? _nfsExportedVolumes;
        private List<Recommendation> _recommendations = new List<Recommendation>();
        private RecommendationStatus _recommendationStatus;
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property CifsShareCount. 
        /// <para>
        /// The number of CIFS shares in the cluster.
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
        /// Gets and sets the property ClusterBlockStorageLogicalUsed. 
        /// <para>
        /// The storage space that's being used in the cluster without accounting for compression
        /// or deduplication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long ClusterBlockStorageLogicalUsed
        {
            get { return this._clusterBlockStorageLogicalUsed.GetValueOrDefault(); }
            set { this._clusterBlockStorageLogicalUsed = value; }
        }

        // Check to see if ClusterBlockStorageLogicalUsed property is set
        internal bool IsSetClusterBlockStorageLogicalUsed()
        {
            return this._clusterBlockStorageLogicalUsed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterBlockStorageSize. 
        /// <para>
        /// The total storage space that's available in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long ClusterBlockStorageSize
        {
            get { return this._clusterBlockStorageSize.GetValueOrDefault(); }
            set { this._clusterBlockStorageSize = value; }
        }

        // Check to see if ClusterBlockStorageSize property is set
        internal bool IsSetClusterBlockStorageSize()
        {
            return this._clusterBlockStorageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterBlockStorageUsed. 
        /// <para>
        /// The storage space that's being used in a cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long ClusterBlockStorageUsed
        {
            get { return this._clusterBlockStorageUsed.GetValueOrDefault(); }
            set { this._clusterBlockStorageUsed = value; }
        }

        // Check to see if ClusterBlockStorageUsed property is set
        internal bool IsSetClusterBlockStorageUsed()
        {
            return this._clusterBlockStorageUsed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property LunCount. 
        /// <para>
        /// The number of LUNs (logical unit numbers) in the cluster.
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
        /// The performance data that DataSync Discovery collects about the cluster.
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
        /// The number of NFS volumes in the cluster.
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
        /// cluster. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-understand-recommendations.html">Recommendations
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
        /// Indicates whether DataSync Discovery recommendations for the cluster are ready to
        /// view, incomplete, or can't be determined.
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
        /// The universally unique identifier (UUID) of the cluster.
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

    }
}