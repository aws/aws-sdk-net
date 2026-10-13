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
    /// This is the response object from the DescribeFeatureGroup operation.
    /// </summary>
    public partial class DescribeFeatureGroupResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp indicating when SageMaker created the <c>FeatureGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A free form description of the feature group.
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
        ///  An <c>EventTime</c> is a point in time when a new event occurs that corresponds to
        /// the creation or update of a <c>Record</c> in a <c>FeatureGroup</c>. All <c>Records</c>
        /// in the <c>FeatureGroup</c> have a corresponding <c>EventTime</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EventTimeFeatureName { get; set; }

        /// <summary>
        /// Checks to see if the EventTimeFeatureName property is set.
        /// </summary>
        internal bool IsSetEventTimeFeatureName() => this.EventTimeFeatureName != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason that the <c>FeatureGroup</c> failed to be replicated in the <c>OfflineStore</c>.
        /// This is failure can occur because:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>FeatureGroup</c> could not be created in the <c>OfflineStore</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>FeatureGroup</c> could not be deleted from the <c>OfflineStore</c>.
        /// </para>
        ///  </li> </ul>
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
        /// A list of the <c>Features</c> in the <c>FeatureGroup</c>. Each feature is defined
        /// by a <c>FeatureName</c> and <c>FeatureType</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2500)]
        public List<FeatureDefinition> FeatureDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<FeatureDefinition>() : null;

        /// <summary>
        /// Checks to see if the FeatureDefinitions property is set.
        /// </summary>
        internal bool IsSetFeatureDefinitions() => this.FeatureDefinitions != null && (this.FeatureDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FeatureGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>FeatureGroup</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string FeatureGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the FeatureGroupArn property is set.
        /// </summary>
        internal bool IsSetFeatureGroupArn() => this.FeatureGroupArn != null;

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// he name of the <c>FeatureGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string FeatureGroupName { get; set; }

        /// <summary>
        /// Checks to see if the FeatureGroupName property is set.
        /// </summary>
        internal bool IsSetFeatureGroupName() => this.FeatureGroupName != null;

        /// <summary>
        /// Gets and sets the property FeatureGroupStatus. 
        /// <para>
        /// The status of the feature group.
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
        /// A timestamp indicating when the feature group was last updated.
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
        /// A value indicating whether the update made to the feature group was successful.
        /// </para>
        /// </summary>
        public LastUpdateStatus LastUpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateStatus property is set.
        /// </summary>
        internal bool IsSetLastUpdateStatus() => this.LastUpdateStatus != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to resume pagination of the list of <c>Features</c> (<c>FeatureDefinitions</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

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
        public OfflineStoreConfig OfflineStoreConfig { get; set; }

        /// <summary>
        /// Checks to see if the OfflineStoreConfig property is set.
        /// </summary>
        internal bool IsSetOfflineStoreConfig() => this.OfflineStoreConfig != null;

        /// <summary>
        /// Gets and sets the property OfflineStoreStatus. 
        /// <para>
        /// The status of the <c>OfflineStore</c>. Notifies you if replicating data into the <c>OfflineStore</c>
        /// has failed. Returns either: <c>Active</c> or <c>Blocked</c> 
        /// </para>
        /// </summary>
        public OfflineStoreStatus OfflineStoreStatus { get; set; }

        /// <summary>
        /// Checks to see if the OfflineStoreStatus property is set.
        /// </summary>
        internal bool IsSetOfflineStoreStatus() => this.OfflineStoreStatus != null;

        /// <summary>
        /// Gets and sets the property OnlineStoreConfig. 
        /// <para>
        /// The configuration for the <c>OnlineStore</c>.
        /// </para>
        /// </summary>
        public OnlineStoreConfig OnlineStoreConfig { get; set; }

        /// <summary>
        /// Checks to see if the OnlineStoreConfig property is set.
        /// </summary>
        internal bool IsSetOnlineStoreConfig() => this.OnlineStoreConfig != null;

        /// <summary>
        /// Gets and sets the property OnlineStoreTotalSizeBytes. 
        /// <para>
        /// The size of the <c>OnlineStore</c> in bytes.
        /// </para>
        /// </summary>
        public long? OnlineStoreTotalSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the OnlineStoreTotalSizeBytes property is set.
        /// </summary>
        internal bool IsSetOnlineStoreTotalSizeBytes() => this.OnlineStoreTotalSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property RecordIdentifierFeatureName. 
        /// <para>
        /// The name of the <c>Feature</c> used for <c>RecordIdentifier</c>, whose value uniquely
        /// identifies a record stored in the feature store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string RecordIdentifierFeatureName { get; set; }

        /// <summary>
        /// Checks to see if the RecordIdentifierFeatureName property is set.
        /// </summary>
        internal bool IsSetRecordIdentifierFeatureName() => this.RecordIdentifierFeatureName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM execution role used to persist data into
        /// the OfflineStore if an OfflineStoreConfig is provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property ThroughputConfig.
        /// </summary>
        public ThroughputConfigDescription ThroughputConfig { get; set; }

        /// <summary>
        /// Checks to see if the ThroughputConfig property is set.
        /// </summary>
        internal bool IsSetThroughputConfig() => this.ThroughputConfig != null;
    }
}
