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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Amazon SageMaker Feature Store stores features in a collection called Feature Group.
    /// A Feature Group can be visualized as a table which has rows, with a unique identifier
    /// for each row where each column in the table is a feature. In principle, a Feature
    /// Group is composed of features and values per features.
    /// </summary>
    public partial class FeatureGroup
    {
        private DateTime? _creationTime;
        private string _description;
        private string _eventTimeFeatureName;
        private string _failureReason;
        private List<FeatureDefinition> _featureDefinitions = AWSConfigs.InitializeCollections ? new List<FeatureDefinition>() : null;
        private string _featureGroupArn;
        private string _featureGroupName;
        private FeatureGroupStatus _featureGroupStatus;
        private DateTime? _lastModifiedTime;
        private LastUpdateStatus _lastUpdateStatus;
        private OfflineStoreConfig _offlineStoreConfig;
        private OfflineStoreStatus _offlineStoreStatus;
        private OnlineStoreConfig _onlineStoreConfig;
        private string _recordIdentifierFeatureName;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time a <c>FeatureGroup</c> was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
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
        /// A free form description of a <c>FeatureGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
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
        /// The name of the feature that stores the <c>EventTime</c> of a Record in a <c>FeatureGroup</c>.
        /// </para>
        ///  
        /// <para>
        /// A <c>EventTime</c> is point in time when a new event occurs that corresponds to the
        /// creation or update of a <c>Record</c> in <c>FeatureGroup</c>. All <c>Records</c> in
        /// the <c>FeatureGroup</c> must have a corresponding <c>EventTime</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// The reason that the <c>FeatureGroup</c> failed to be replicated in the <c>OfflineStore</c>.
        /// This is failure may be due to a failure to create a <c>FeatureGroup</c> in or delete
        /// a <c>FeatureGroup</c> from the <c>OfflineStore</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// A list of <c>Feature</c>s. Each <c>Feature</c> must include a <c>FeatureName</c> and
        /// a <c>FeatureType</c>. 
        /// </para>
        ///  
        /// <para>
        /// Valid <c>FeatureType</c>s are <c>Integral</c>, <c>Fractional</c> and <c>String</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>FeatureName</c>s cannot be any of the following: <c>is_deleted</c>, <c>write_time</c>,
        /// <c>api_invocation_time</c>.
        /// </para>
        ///  
        /// <para>
        /// You can create up to 2,500 <c>FeatureDefinition</c>s per <c>FeatureGroup</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2500)]
        public List<FeatureDefinition> FeatureDefinitions
        {
            get { return this._featureDefinitions; }
            set { this._featureDefinitions = value; }
        }

        // Check to see if FeatureDefinitions property is set
        internal bool IsSetFeatureDefinitions()
        {
            return this._featureDefinitions != null && (this._featureDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a <c>FeatureGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// The name of the <c>FeatureGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// A <c>FeatureGroup</c> status.
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
        /// A timestamp indicating the last time you updated the feature group.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
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
        /// A value that indicates whether the feature group was updated successfully.
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
        /// Gets and sets the property OfflineStoreConfig.
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
        /// Gets and sets the property RecordIdentifierFeatureName. 
        /// <para>
        /// The name of the <c>Feature</c> whose value uniquely identifies a <c>Record</c> defined
        /// in the <c>FeatureGroup</c> <c>FeatureDefinitions</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// The Amazon Resource Name (ARN) of the IAM execution role used to create the feature
        /// group.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags used to define a <c>FeatureGroup</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}