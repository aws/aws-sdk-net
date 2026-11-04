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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the CancelResize operation.
    /// </summary>
    public partial class CancelResizeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AvgResizeRateInMegaBytesPerSecond. 
        /// <para>
        /// The average rate of the resize operation over the last few minutes, measured in megabytes
        /// per second. After the resize operation completes, this value shows the average rate
        /// of the entire resize operation.
        /// </para>
        /// </summary>
        public double? AvgResizeRateInMegaBytesPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the AvgResizeRateInMegaBytesPerSecond property is set.
        /// </summary>
        internal bool IsSetAvgResizeRateInMegaBytesPerSecond() => this.AvgResizeRateInMegaBytesPerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property DataTransferProgressPercent. 
        /// <para>
        /// The percent of data transferred from source cluster to target cluster.
        /// </para>
        /// </summary>
        public double? DataTransferProgressPercent { get; set; }

        /// <summary>
        /// Checks to see if the DataTransferProgressPercent property is set.
        /// </summary>
        internal bool IsSetDataTransferProgressPercent() => this.DataTransferProgressPercent.HasValue;

        /// <summary>
        /// Gets and sets the property ElapsedTimeInSeconds. 
        /// <para>
        /// The amount of seconds that have elapsed since the resize operation began. After the
        /// resize operation completes, this value shows the total actual time, in seconds, for
        /// the resize operation.
        /// </para>
        /// </summary>
        public long? ElapsedTimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ElapsedTimeInSeconds property is set.
        /// </summary>
        internal bool IsSetElapsedTimeInSeconds() => this.ElapsedTimeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedTimeToCompletionInSeconds. 
        /// <para>
        /// The estimated time remaining, in seconds, until the resize operation is complete.
        /// This value is calculated based on the average resize rate and the estimated amount
        /// of data remaining to be processed. Once the resize operation is complete, this value
        /// will be 0.
        /// </para>
        /// </summary>
        public long? EstimatedTimeToCompletionInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedTimeToCompletionInSeconds property is set.
        /// </summary>
        internal bool IsSetEstimatedTimeToCompletionInSeconds() => this.EstimatedTimeToCompletionInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ImportTablesCompleted. 
        /// <para>
        /// The names of tables that have been completely imported .
        /// </para>
        ///  
        /// <para>
        /// Valid Values: List of table names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImportTablesCompleted { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImportTablesCompleted property is set.
        /// </summary>
        internal bool IsSetImportTablesCompleted() => this.ImportTablesCompleted != null && (this.ImportTablesCompleted.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImportTablesInProgress. 
        /// <para>
        /// The names of tables that are being currently imported.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: List of table names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImportTablesInProgress { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImportTablesInProgress property is set.
        /// </summary>
        internal bool IsSetImportTablesInProgress() => this.ImportTablesInProgress != null && (this.ImportTablesInProgress.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImportTablesNotStarted. 
        /// <para>
        /// The names of tables that have not been yet imported.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: List of table names
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImportTablesNotStarted { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImportTablesNotStarted property is set.
        /// </summary>
        internal bool IsSetImportTablesNotStarted() => this.ImportTablesNotStarted != null && (this.ImportTablesNotStarted.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An optional string to provide additional details about the resize action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ProgressInMegaBytes. 
        /// <para>
        /// While the resize operation is in progress, this value shows the current amount of
        /// data, in megabytes, that has been processed so far. When the resize operation is complete,
        /// this value shows the total amount of data, in megabytes, on the cluster, which may
        /// be more or less than TotalResizeDataInMegaBytes (the estimated total amount of data
        /// before resize).
        /// </para>
        /// </summary>
        public long? ProgressInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the ProgressInMegaBytes property is set.
        /// </summary>
        internal bool IsSetProgressInMegaBytes() => this.ProgressInMegaBytes.HasValue;

        /// <summary>
        /// Gets and sets the property ResizeType. 
        /// <para>
        /// An enum with possible values of <c>ClassicResize</c> and <c>ElasticResize</c>. These
        /// values describe the type of resize operation being performed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ResizeType { get; set; }

        /// <summary>
        /// Checks to see if the ResizeType property is set.
        /// </summary>
        internal bool IsSetResizeType() => this.ResizeType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the resize operation.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>NONE</c> | <c>IN_PROGRESS</c> | <c>FAILED</c> | <c>SUCCEEDED</c>
        /// | <c>CANCELLING</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetClusterType. 
        /// <para>
        /// The cluster type after the resize operation is complete.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>multi-node</c> | <c>single-node</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string TargetClusterType { get; set; }

        /// <summary>
        /// Checks to see if the TargetClusterType property is set.
        /// </summary>
        internal bool IsSetTargetClusterType() => this.TargetClusterType != null;

        /// <summary>
        /// Gets and sets the property TargetEncryptionType. 
        /// <para>
        /// The type of encryption for the cluster after the resize is complete.
        /// </para>
        ///  
        /// <para>
        /// Possible values are <c>KMS</c> and <c>None</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string TargetEncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the TargetEncryptionType property is set.
        /// </summary>
        internal bool IsSetTargetEncryptionType() => this.TargetEncryptionType != null;

        /// <summary>
        /// Gets and sets the property TargetNodeType. 
        /// <para>
        /// The node type that the cluster will have after the resize operation is complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string TargetNodeType { get; set; }

        /// <summary>
        /// Checks to see if the TargetNodeType property is set.
        /// </summary>
        internal bool IsSetTargetNodeType() => this.TargetNodeType != null;

        /// <summary>
        /// Gets and sets the property TargetNumberOfNodes. 
        /// <para>
        /// The number of nodes that the cluster will have after the resize operation is complete.
        /// </para>
        /// </summary>
        public int? TargetNumberOfNodes { get; set; }

        /// <summary>
        /// Checks to see if the TargetNumberOfNodes property is set.
        /// </summary>
        internal bool IsSetTargetNumberOfNodes() => this.TargetNumberOfNodes.HasValue;

        /// <summary>
        /// Gets and sets the property TotalResizeDataInMegaBytes. 
        /// <para>
        /// The estimated total amount of data, in megabytes, on the cluster before the resize
        /// operation began.
        /// </para>
        /// </summary>
        public long? TotalResizeDataInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalResizeDataInMegaBytes property is set.
        /// </summary>
        internal bool IsSetTotalResizeDataInMegaBytes() => this.TotalResizeDataInMegaBytes.HasValue;
    }
}
