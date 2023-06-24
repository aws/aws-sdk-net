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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeFeatureGroup operation.
    /// </summary>
    public partial class DescribeFeatureGroupResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _description;
        private string _eventTimeFeatureName;
        private string _failureReason;
        private List<FeatureDefinition> _featureDefinitions = new List<FeatureDefinition>();
        private string _featureGroupArn;
        private string _featureGroupName;
        private FeatureGroupStatus _featureGroupStatus;
        private DateTime? _lastModifiedTime;
        private LastUpdateStatus _lastUpdateStatus;
        private string _nextToken;
        private OfflineStoreConfig _offlineStoreConfig;
        private OfflineStoreStatus _offlineStoreStatus;
        private OnlineStoreConfig _onlineStoreConfig;
        private long? _onlineStoreTotalSizeBytes;
        private string _recordIdentifierFeatureName;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp indicating when SageMaker created the <code>FeatureGroup</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A free form description of the feature group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// Gets and sets the property EventTimeFeatureName. 
        /// <para>
        /// The name of the feature that stores the <code>EventTime</code> of a Record in a <code>FeatureGroup</code>.
        /// </para>
        ///  
        /// <para>
        ///  An <code>EventTime</code> is a point in time when a new event occurs that corresponds
        /// to the creation or update of a <code>Record</code> in a <code>FeatureGroup</code>.
        /// All <code>Records</code> in the <code>FeatureGroup</code> have a corresponding <code>EventTime</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EventTimeFeatureName
        {
            get { return this._eventTimeFeatureName; }
            set { this._eventTimeFeatureName = value; }
        }

        // Check to see if EventTimeFeatureName property is set
        internal bool IsSetEventTimeFeatureName()
        {
            return this._eventTimeFeatureName != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason that the <code>FeatureGroup</code> failed to be replicated in the <code>OfflineStore</code>.
        /// This is failure can occur because:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>FeatureGroup</code> could not be created in the <code>OfflineStore</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>FeatureGroup</code> could not be deleted from the <code>OfflineStore</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureDefinitions. 
        /// <para>
        /// A list of the <code>Features</code> in the <code>FeatureGroup</code>. Each feature
        /// is defined by a <code>FeatureName</code> and <code>FeatureType</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2500)]
        public List<FeatureDefinition> FeatureDefinitions
        {
            get { return this._featureDefinitions; }
            set { this._featureDefinitions = value; }
        }

        // Check to see if FeatureDefinitions property is set
        internal bool IsSetFeatureDefinitions()
        {
            return this._featureDefinitions != null && this._featureDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <code>FeatureGroup</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string FeatureGroupArn
        {
            get { return this._featureGroupArn; }
            set { this._featureGroupArn = value; }
        }

        // Check to see if FeatureGroupArn property is set
        internal bool IsSetFeatureGroupArn()
        {
            return this._featureGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// he name of the <code>FeatureGroup</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FeatureGroupName
        {
            get { return this._featureGroupName; }
            set { this._featureGroupName = value; }
        }

        // Check to see if FeatureGroupName property is set
        internal bool IsSetFeatureGroupName()
        {
            return this._featureGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupStatus. 
        /// <para>
        /// The status of the feature group.
        /// </para>
        /// </summary>
        public FeatureGroupStatus FeatureGroupStatus
        {
            get { return this._featureGroupStatus; }
            set { this._featureGroupStatus = value; }
        }

        // Check to see if FeatureGroupStatus property is set
        internal bool IsSetFeatureGroupStatus()
        {
            return this._featureGroupStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp indicating when the feature group was last updated.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateStatus. 
        /// <para>
        /// A value indicating whether the update made to the feature group was successful.
        /// </para>
        /// </summary>
        public LastUpdateStatus LastUpdateStatus
        {
            get { return this._lastUpdateStatus; }
            set { this._lastUpdateStatus = value; }
        }

        // Check to see if LastUpdateStatus property is set
        internal bool IsSetLastUpdateStatus()
        {
            return this._lastUpdateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to resume pagination of the list of <code>Features</code> (<code>FeatureDefinitions</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property OfflineStoreConfig. 
        /// <para>
        /// The configuration of the offline store. It includes the following configurations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon S3 location of the offline store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Configuration of the Glue data catalog.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Table format of the offline store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Option to disable the automatic creation of a Glue table for the offline store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Encryption configuration.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OfflineStoreConfig OfflineStoreConfig
        {
            get { return this._offlineStoreConfig; }
            set { this._offlineStoreConfig = value; }
        }

        // Check to see if OfflineStoreConfig property is set
        internal bool IsSetOfflineStoreConfig()
        {
            return this._offlineStoreConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OfflineStoreStatus. 
        /// <para>
        /// The status of the <code>OfflineStore</code>. Notifies you if replicating data into
        /// the <code>OfflineStore</code> has failed. Returns either: <code>Active</code> or <code>Blocked</code>
        /// 
        /// </para>
        /// </summary>
        public OfflineStoreStatus OfflineStoreStatus
        {
            get { return this._offlineStoreStatus; }
            set { this._offlineStoreStatus = value; }
        }

        // Check to see if OfflineStoreStatus property is set
        internal bool IsSetOfflineStoreStatus()
        {
            return this._offlineStoreStatus != null;
        }

        /// <summary>
        /// Gets and sets the property OnlineStoreConfig. 
        /// <para>
        /// The configuration for the <code>OnlineStore</code>.
        /// </para>
        /// </summary>
        public OnlineStoreConfig OnlineStoreConfig
        {
            get { return this._onlineStoreConfig; }
            set { this._onlineStoreConfig = value; }
        }

        // Check to see if OnlineStoreConfig property is set
        internal bool IsSetOnlineStoreConfig()
        {
            return this._onlineStoreConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OnlineStoreTotalSizeBytes. 
        /// <para>
        /// The size of the <code>OnlineStore</code> in bytes.
        /// </para>
        /// </summary>
        public long OnlineStoreTotalSizeBytes
        {
            get { return this._onlineStoreTotalSizeBytes.GetValueOrDefault(); }
            set { this._onlineStoreTotalSizeBytes = value; }
        }

        // Check to see if OnlineStoreTotalSizeBytes property is set
        internal bool IsSetOnlineStoreTotalSizeBytes()
        {
            return this._onlineStoreTotalSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordIdentifierFeatureName. 
        /// <para>
        /// The name of the <code>Feature</code> used for <code>RecordIdentifier</code>, whose
        /// value uniquely identifies a record stored in the feature store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string RecordIdentifierFeatureName
        {
            get { return this._recordIdentifierFeatureName; }
            set { this._recordIdentifierFeatureName = value; }
        }

        // Check to see if RecordIdentifierFeatureName property is set
        internal bool IsSetRecordIdentifierFeatureName()
        {
            return this._recordIdentifierFeatureName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM execution role used to persist data into
        /// the OfflineStore if an OfflineStoreConfig is provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}