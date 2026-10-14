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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time a <c>FeatureGroup</c> was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A free form description of a <c>FeatureGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        [AWSProperty(Min = 1, Max = 64)]
        public string EventTimeFeatureName { get; set; }

        /// <summary>
        /// Checks to see if the EventTimeFeatureName property is set.
        /// </summary>
        internal bool IsSetEventTimeFeatureName() => this.EventTimeFeatureName != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason that the <c>FeatureGroup</c> failed to be replicated in the <c>OfflineStore</c>.
        /// This is failure may be due to a failure to create a <c>FeatureGroup</c> in or delete
        /// a <c>FeatureGroup</c> from the <c>OfflineStore</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2500)]
        public List<FeatureDefinition> FeatureDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<FeatureDefinition>() : null;

        /// <summary>
        /// Checks to see if the FeatureDefinitions property is set.
        /// </summary>
        internal bool IsSetFeatureDefinitions() => this.FeatureDefinitions != null && (this.FeatureDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FeatureGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a <c>FeatureGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FeatureGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the FeatureGroupArn property is set.
        /// </summary>
        internal bool IsSetFeatureGroupArn() => this.FeatureGroupArn != null;

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name of the <c>FeatureGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FeatureGroupName { get; set; }

        /// <summary>
        /// Checks to see if the FeatureGroupName property is set.
        /// </summary>
        internal bool IsSetFeatureGroupName() => this.FeatureGroupName != null;

        /// <summary>
        /// Gets and sets the property FeatureGroupStatus. 
        /// <para>
        /// A <c>FeatureGroup</c> status.
        /// </para>
        /// </summary>
        public FeatureGroupStatus FeatureGroupStatus { get; set; }

        /// <summary>
        /// Checks to see if the FeatureGroupStatus property is set.
        /// </summary>
        internal bool IsSetFeatureGroupStatus() => this.FeatureGroupStatus != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp indicating the last time you updated the feature group.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateStatus. 
        /// <para>
        /// A value that indicates whether the feature group was updated successfully.
        /// </para>
        /// </summary>
        public LastUpdateStatus LastUpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateStatus property is set.
        /// </summary>
        internal bool IsSetLastUpdateStatus() => this.LastUpdateStatus != null;

        /// <summary>
        /// Gets and sets the property OfflineStoreConfig.
        /// </summary>
        public OfflineStoreConfig OfflineStoreConfig { get; set; }

        /// <summary>
        /// Checks to see if the OfflineStoreConfig property is set.
        /// </summary>
        internal bool IsSetOfflineStoreConfig() => this.OfflineStoreConfig != null;

        /// <summary>
        /// Gets and sets the property OfflineStoreStatus.
        /// </summary>
        public OfflineStoreStatus OfflineStoreStatus { get; set; }

        /// <summary>
        /// Checks to see if the OfflineStoreStatus property is set.
        /// </summary>
        internal bool IsSetOfflineStoreStatus() => this.OfflineStoreStatus != null;

        /// <summary>
        /// Gets and sets the property OnlineStoreConfig.
        /// </summary>
        public OnlineStoreConfig OnlineStoreConfig { get; set; }

        /// <summary>
        /// Checks to see if the OnlineStoreConfig property is set.
        /// </summary>
        internal bool IsSetOnlineStoreConfig() => this.OnlineStoreConfig != null;

        /// <summary>
        /// Gets and sets the property RecordIdentifierFeatureName. 
        /// <para>
        /// The name of the <c>Feature</c> whose value uniquely identifies a <c>Record</c> defined
        /// in the <c>FeatureGroup</c> <c>FeatureDefinitions</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string RecordIdentifierFeatureName { get; set; }

        /// <summary>
        /// Checks to see if the RecordIdentifierFeatureName property is set.
        /// </summary>
        internal bool IsSetRecordIdentifierFeatureName() => this.RecordIdentifierFeatureName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM execution role used to create the feature
        /// group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags used to define a <c>FeatureGroup</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
