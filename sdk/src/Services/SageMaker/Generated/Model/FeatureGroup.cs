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
        private List<FeatureDefinition> _featureDefinitions = new List<FeatureDefinition>();
        private string _featureGroupArn;
        private string _featureGroupName;
        private FeatureGroupStatus _featureGroupStatus;
        private OfflineStoreConfig _offlineStoreConfig;
        private OfflineStoreStatus _offlineStoreStatus;
        private OnlineStoreConfig _onlineStoreConfig;
        private string _recordIdentifierFeatureName;
        private string _roleArn;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time a <code>FeatureGroup</code> was created.
        /// </para>
        /// </summary>
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
        /// A free form description of a <code>FeatureGroup</code>.
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
        /// A <code>EventTime</code> is point in time when a new event occurs that corresponds
        /// to the creation or update of a <code>Record</code> in <code>FeatureGroup</code>. All
        /// <code>Records</code> in the <code>FeatureGroup</code> must have a corresponding <code>EventTime</code>.
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
        /// The reason that the <code>FeatureGroup</code> failed to be replicated in the <code>OfflineStore</code>.
        /// This is failure may be due to a failure to create a <code>FeatureGroup</code> in or
        /// delete a <code>FeatureGroup</code> from the <code>OfflineStore</code>.
        /// </para>
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
        /// A list of <code>Feature</code>s. Each <code>Feature</code> must include a <code>FeatureName</code>
        /// and a <code>FeatureType</code>. 
        /// </para>
        ///  
        /// <para>
        /// Valid <code>FeatureType</code>s are <code>Integral</code>, <code>Fractional</code>
        /// and <code>String</code>. 
        /// </para>
        ///  
        /// <para>
        ///  <code>FeatureName</code>s cannot be any of the following: <code>is_deleted</code>,
        /// <code>write_time</code>, <code>api_invocation_time</code>.
        /// </para>
        ///  
        /// <para>
        /// You can create up to 2,500 <code>FeatureDefinition</code>s per <code>FeatureGroup</code>.
        /// </para>
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
            return this._featureDefinitions != null && this._featureDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a <code>FeatureGroup</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// The name of the <code>FeatureGroup</code>.
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
        /// A <code>FeatureGroup</code> status.
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
        /// The name of the <code>Feature</code> whose value uniquely identifies a <code>Record</code>
        /// defined in the <code>FeatureGroup</code> <code>FeatureDefinitions</code>.
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
        /// Tags used to define a <code>FeatureGroup</code>.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}