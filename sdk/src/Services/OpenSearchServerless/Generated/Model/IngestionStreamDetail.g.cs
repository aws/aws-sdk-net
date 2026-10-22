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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Details about an ingestion stream.
    /// </summary>
    public partial class IngestionStreamDetail
    {
        /// <summary>
        /// Gets and sets the property ActiveAlerts. 
        /// <para>
        /// Active alerts about operational issues that currently affect the ingestion stream.
        /// Alerts are cleared when the issue is resolved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<IngestionAlert> ActiveAlerts { get; set; } = AWSConfigs.InitializeCollections ? new List<IngestionAlert>() : null;

        /// <summary>
        /// Checks to see if the ActiveAlerts property is set.
        /// </summary>
        internal bool IsSetActiveAlerts() => this.ActiveAlerts != null && (this.ActiveAlerts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ingestion stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// The unique identifier of the collection that the ingestion stream belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 40)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Checks to see if the CollectionId property is set.
        /// </summary>
        internal bool IsSetCollectionId() => this.CollectionId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the ingestion stream was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FailureIndexName. 
        /// <para>
        /// The name of the index where documents that fail to be ingested are recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string FailureIndexName { get; set; }

        /// <summary>
        /// Checks to see if the FailureIndexName property is set.
        /// </summary>
        internal bool IsSetFailureIndexName() => this.FailureIndexName != null;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// The reasons that the ingestion stream reached a terminal failure state, if applicable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<IngestionFailureReason> FailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<IngestionFailureReason>() : null;

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null && (this.FailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the index that documents are ingested into.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property IngestionStreamId. 
        /// <para>
        /// The unique identifier of the ingestion stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 64)]
        public string IngestionStreamId { get; set; }

        /// <summary>
        /// Checks to see if the IngestionStreamId property is set.
        /// </summary>
        internal bool IsSetIngestionStreamId() => this.IngestionStreamId != null;

        /// <summary>
        /// Gets and sets the property IngestionStreamName. 
        /// <para>
        /// The name of the ingestion stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 32)]
        public string IngestionStreamName { get; set; }

        /// <summary>
        /// Checks to see if the IngestionStreamName property is set.
        /// </summary>
        internal bool IsSetIngestionStreamName() => this.IngestionStreamName != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision number of the ingestion stream.
        /// </para>
        /// </summary>
        public long? Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that OpenSearch Serverless assumes
        /// to read data from the source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon S3 source that the ingestion stream ingests data from.
        /// </para>
        /// </summary>
        public IngestionStreamSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current processing state of the ingestion stream. For example, <c>STARTING</c>
        /// or <c>INGESTION_IN_PROGRESS</c>.
        /// </para>
        /// </summary>
        public IngestionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Processing statistics for the ingestion stream, such as the number of Amazon S3 objects
        /// discovered, ingested, and failed.
        /// </para>
        /// </summary>
        public IngestionStatistics Statistics { get; set; }

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current lifecycle status of the ingestion stream. For example, <c>CREATING</c>,
        /// <c>ACTIVE</c>, or <c>DELETING</c>.
        /// </para>
        /// </summary>
        public IngestionStreamStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the ingestion stream was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
