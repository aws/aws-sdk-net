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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Specifies information about the past flow run instances for a given flow.
    /// </summary>
    public partial class ExecutionRecord
    {
        /// <summary>
        /// Gets and sets the property DataPullEndTime. 
        /// <para>
        ///  The timestamp that indicates the last new or updated record to be transferred in
        /// the flow run. 
        /// </para>
        /// </summary>
        public DateTime? DataPullEndTime { get; set; }

        /// <summary>
        /// Checks to see if the DataPullEndTime property is set.
        /// </summary>
        internal bool IsSetDataPullEndTime() => this.DataPullEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataPullStartTime. 
        /// <para>
        ///  The timestamp that determines the first new or updated record to be transferred in
        /// the flow run. 
        /// </para>
        /// </summary>
        public DateTime? DataPullStartTime { get; set; }

        /// <summary>
        /// Checks to see if the DataPullStartTime property is set.
        /// </summary>
        internal bool IsSetDataPullStartTime() => this.DataPullStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        ///  Specifies the identifier of the given flow run. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property ExecutionResult. 
        /// <para>
        ///  Describes the result of the given flow run. 
        /// </para>
        /// </summary>
        public ExecutionResult ExecutionResult { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionResult property is set.
        /// </summary>
        internal bool IsSetExecutionResult() => this.ExecutionResult != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        ///  Specifies the flow run status and whether it is in progress, has completed successfully,
        /// or has failed. 
        /// </para>
        /// </summary>
        public ExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        ///  Specifies the time of the most recent update. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MetadataCatalogDetails. 
        /// <para>
        /// Describes the metadata catalog, metadata table, and data partitions that Amazon AppFlow
        /// used for the associated flow run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetadataCatalogDetail> MetadataCatalogDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<MetadataCatalogDetail>() : null;

        /// <summary>
        /// Checks to see if the MetadataCatalogDetails property is set.
        /// </summary>
        internal bool IsSetMetadataCatalogDetails() => this.MetadataCatalogDetails != null && (this.MetadataCatalogDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        ///  Specifies the start time of the flow run. 
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;
    }
}
