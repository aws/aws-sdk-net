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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
    /// Describes the result of a cluster resize operation.
    /// </summary>
    public partial class DescribeResizeResponse : AmazonWebServiceResponse
    {
        private double? _avgResizeRateInMegaBytesPerSecond;
        private double? _dataTransferProgressPercent;
        private long? _elapsedTimeInSeconds;
        private long? _estimatedTimeToCompletionInSeconds;
        private List<string> _importTablesCompleted = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _importTablesInProgress = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _importTablesNotStarted = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _message;
        private long? _progressInMegaBytes;
        private string _resizeType;
        private string _status;
        private string _targetClusterType;
        private string _targetEncryptionType;
        private string _targetNodeType;
        private int? _targetNumberOfNodes;
        private long? _totalResizeDataInMegaBytes;

        /// <summary>
        /// Gets and sets the property AvgResizeRateInMegaBytesPerSecond. 
        /// <para>
        /// The average rate of the resize operation over the last few minutes, measured in megabytes
        /// per second. After the resize operation completes, this value shows the average rate
        /// of the entire resize operation.
        /// </para>
        /// </summary>
        public double? AvgResizeRateInMegaBytesPerSecond
        {
            get { return this._avgResizeRateInMegaBytesPerSecond; }
            set { this._avgResizeRateInMegaBytesPerSecond = value; }
        }

        // Check to see if AvgResizeRateInMegaBytesPerSecond property is set
        internal bool IsSetAvgResizeRateInMegaBytesPerSecond()
        {
            return this._avgResizeRateInMegaBytesPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataTransferProgressPercent. 
        /// <para>
        /// The percent of data transferred from source cluster to target cluster.
        /// </para>
        /// </summary>
        public double? DataTransferProgressPercent
        {
            get { return this._dataTransferProgressPercent; }
            set { this._dataTransferProgressPercent = value; }
        }

        // Check to see if DataTransferProgressPercent property is set
        internal bool IsSetDataTransferProgressPercent()
        {
            return this._dataTransferProgressPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ElapsedTimeInSeconds. 
        /// <para>
        /// The amount of seconds that have elapsed since the resize operation began. After the
        /// resize operation completes, this value shows the total actual time, in seconds, for
        /// the resize operation.
        /// </para>
        /// </summary>
        public long? ElapsedTimeInSeconds
        {
            get { return this._elapsedTimeInSeconds; }
            set { this._elapsedTimeInSeconds = value; }
        }

        // Check to see if ElapsedTimeInSeconds property is set
        internal bool IsSetElapsedTimeInSeconds()
        {
            return this._elapsedTimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedTimeToCompletionInSeconds. 
        /// <para>
        /// The estimated time remaining, in seconds, until the resize operation is complete.
        /// This value is calculated based on the average resize rate and the estimated amount
        /// of data remaining to be processed. Once the resize operation is complete, this value
        /// will be 0.
        /// </para>
        /// </summary>
        public long? EstimatedTimeToCompletionInSeconds
        {
            get { return this._estimatedTimeToCompletionInSeconds; }
            set { this._estimatedTimeToCompletionInSeconds = value; }
        }

        // Check to see if EstimatedTimeToCompletionInSeconds property is set
        internal bool IsSetEstimatedTimeToCompletionInSeconds()
        {
            return this._estimatedTimeToCompletionInSeconds.HasValue; 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImportTablesCompleted
        {
            get { return this._importTablesCompleted; }
            set { this._importTablesCompleted = value; }
        }

        // Check to see if ImportTablesCompleted property is set
        internal bool IsSetImportTablesCompleted()
        {
            return this._importTablesCompleted != null && (this._importTablesCompleted.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImportTablesInProgress
        {
            get { return this._importTablesInProgress; }
            set { this._importTablesInProgress = value; }
        }

        // Check to see if ImportTablesInProgress property is set
        internal bool IsSetImportTablesInProgress()
        {
            return this._importTablesInProgress != null && (this._importTablesInProgress.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImportTablesNotStarted
        {
            get { return this._importTablesNotStarted; }
            set { this._importTablesNotStarted = value; }
        }

        // Check to see if ImportTablesNotStarted property is set
        internal bool IsSetImportTablesNotStarted()
        {
            return this._importTablesNotStarted != null && (this._importTablesNotStarted.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An optional string to provide additional details about the resize action.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

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
        public long? ProgressInMegaBytes
        {
            get { return this._progressInMegaBytes; }
            set { this._progressInMegaBytes = value; }
        }

        // Check to see if ProgressInMegaBytes property is set
        internal bool IsSetProgressInMegaBytes()
        {
            return this._progressInMegaBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResizeType. 
        /// <para>
        /// An enum with possible values of <c>ClassicResize</c> and <c>ElasticResize</c>. These
        /// values describe the type of resize operation being performed. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ResizeType
        {
            get { return this._resizeType; }
            set { this._resizeType = value; }
        }

        // Check to see if ResizeType property is set
        internal bool IsSetResizeType()
        {
            return this._resizeType != null;
        }

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
        [AWSProperty(Max=2147483647)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

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
        [AWSProperty(Max=2147483647)]
        public string TargetClusterType
        {
            get { return this._targetClusterType; }
            set { this._targetClusterType = value; }
        }

        // Check to see if TargetClusterType property is set
        internal bool IsSetTargetClusterType()
        {
            return this._targetClusterType != null;
        }

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
        [AWSProperty(Max=2147483647)]
        public string TargetEncryptionType
        {
            get { return this._targetEncryptionType; }
            set { this._targetEncryptionType = value; }
        }

        // Check to see if TargetEncryptionType property is set
        internal bool IsSetTargetEncryptionType()
        {
            return this._targetEncryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetNodeType. 
        /// <para>
        /// The node type that the cluster will have after the resize operation is complete.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string TargetNodeType
        {
            get { return this._targetNodeType; }
            set { this._targetNodeType = value; }
        }

        // Check to see if TargetNodeType property is set
        internal bool IsSetTargetNodeType()
        {
            return this._targetNodeType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetNumberOfNodes. 
        /// <para>
        /// The number of nodes that the cluster will have after the resize operation is complete.
        /// </para>
        /// </summary>
        public int? TargetNumberOfNodes
        {
            get { return this._targetNumberOfNodes; }
            set { this._targetNumberOfNodes = value; }
        }

        // Check to see if TargetNumberOfNodes property is set
        internal bool IsSetTargetNumberOfNodes()
        {
            return this._targetNumberOfNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalResizeDataInMegaBytes. 
        /// <para>
        /// The estimated total amount of data, in megabytes, on the cluster before the resize
        /// operation began.
        /// </para>
        /// </summary>
        public long? TotalResizeDataInMegaBytes
        {
            get { return this._totalResizeDataInMegaBytes; }
            set { this._totalResizeDataInMegaBytes = value; }
        }

        // Check to see if TotalResizeDataInMegaBytes property is set
        internal bool IsSetTotalResizeDataInMegaBytes()
        {
            return this._totalResizeDataInMegaBytes.HasValue; 
        }

    }
}