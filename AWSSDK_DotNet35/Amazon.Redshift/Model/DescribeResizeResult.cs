/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Describes the result of a cluster resize operation.</para>
    /// </summary>
    public partial class DescribeResizeResult : AmazonWebServiceResponse
    {
        
        private string targetNodeType;
        private int? targetNumberOfNodes;
        private string targetClusterType;
        private string status;
        private List<string> importTablesCompleted = new List<string>();
        private List<string> importTablesInProgress = new List<string>();
        private List<string> importTablesNotStarted = new List<string>();
        private double? avgResizeRateInMegaBytesPerSecond;
        private long? totalResizeDataInMegaBytes;
        private long? progressInMegaBytes;
        private long? elapsedTimeInSeconds;
        private long? estimatedTimeToCompletionInSeconds;


        /// <summary>
        /// The node type that the cluster will have after the resize operation is complete.
        ///  
        /// </summary>
        public string TargetNodeType
        {
            get { return this.targetNodeType; }
            set { this.targetNodeType = value; }
        }

        // Check to see if TargetNodeType property is set
        internal bool IsSetTargetNodeType()
        {
            return this.targetNodeType != null;
        }

        /// <summary>
        /// The number of nodes that the cluster will have after the resize operation is complete.
        ///  
        /// </summary>
        public int TargetNumberOfNodes
        {
            get { return this.targetNumberOfNodes ?? default(int); }
            set { this.targetNumberOfNodes = value; }
        }

        // Check to see if TargetNumberOfNodes property is set
        internal bool IsSetTargetNumberOfNodes()
        {
            return this.targetNumberOfNodes.HasValue;
        }

        /// <summary>
        /// The cluster type after the resize operation is complete. Valid Values: <c>multi-node</c> | <c>single-node</c>
        ///  
        /// </summary>
        public string TargetClusterType
        {
            get { return this.targetClusterType; }
            set { this.targetClusterType = value; }
        }

        // Check to see if TargetClusterType property is set
        internal bool IsSetTargetClusterType()
        {
            return this.targetClusterType != null;
        }

        /// <summary>
        /// The status of the resize operation. Valid Values: <c>NONE</c> | <c>IN_PROGRESS</c> | <c>FAILED</c> | <c>SUCCEEDED</c>
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The names of tables that have been completely imported . Valid Values: List of table names.
        ///  
        /// </summary>
        public List<string> ImportTablesCompleted
        {
            get { return this.importTablesCompleted; }
            set { this.importTablesCompleted = value; }
        }

        // Check to see if ImportTablesCompleted property is set
        internal bool IsSetImportTablesCompleted()
        {
            return this.importTablesCompleted.Count > 0;
        }

        /// <summary>
        /// The names of tables that are being currently imported. Valid Values: List of table names.
        ///  
        /// </summary>
        public List<string> ImportTablesInProgress
        {
            get { return this.importTablesInProgress; }
            set { this.importTablesInProgress = value; }
        }

        // Check to see if ImportTablesInProgress property is set
        internal bool IsSetImportTablesInProgress()
        {
            return this.importTablesInProgress.Count > 0;
        }

        /// <summary>
        /// The names of tables that have not been yet imported. Valid Values: List of table names
        ///  
        /// </summary>
        public List<string> ImportTablesNotStarted
        {
            get { return this.importTablesNotStarted; }
            set { this.importTablesNotStarted = value; }
        }

        // Check to see if ImportTablesNotStarted property is set
        internal bool IsSetImportTablesNotStarted()
        {
            return this.importTablesNotStarted.Count > 0;
        }

        /// <summary>
        /// The average rate of the resize operation over the last few minutes, measured in megabytes per second. After the resize operation completes,
        /// this value shows the average rate of the entire resize operation.
        ///  
        /// </summary>
        public double AvgResizeRateInMegaBytesPerSecond
        {
            get { return this.avgResizeRateInMegaBytesPerSecond ?? default(double); }
            set { this.avgResizeRateInMegaBytesPerSecond = value; }
        }

        // Check to see if AvgResizeRateInMegaBytesPerSecond property is set
        internal bool IsSetAvgResizeRateInMegaBytesPerSecond()
        {
            return this.avgResizeRateInMegaBytesPerSecond.HasValue;
        }

        /// <summary>
        /// The estimated total amount of data, in megabytes, on the cluster before the resize operation began.
        ///  
        /// </summary>
        public long TotalResizeDataInMegaBytes
        {
            get { return this.totalResizeDataInMegaBytes ?? default(long); }
            set { this.totalResizeDataInMegaBytes = value; }
        }

        // Check to see if TotalResizeDataInMegaBytes property is set
        internal bool IsSetTotalResizeDataInMegaBytes()
        {
            return this.totalResizeDataInMegaBytes.HasValue;
        }

        /// <summary>
        /// While the resize operation is in progress, this value shows the current amount of data, in megabytes, that has been processed so far. When
        /// the resize operation is complete, this value shows the total amount of data, in megabytes, on the cluster, which may be more or less than
        /// TotalResizeDataInMegaBytes (the estimated total amount of data before resize).
        ///  
        /// </summary>
        public long ProgressInMegaBytes
        {
            get { return this.progressInMegaBytes ?? default(long); }
            set { this.progressInMegaBytes = value; }
        }

        // Check to see if ProgressInMegaBytes property is set
        internal bool IsSetProgressInMegaBytes()
        {
            return this.progressInMegaBytes.HasValue;
        }

        /// <summary>
        /// The amount of seconds that have elapsed since the resize operation began. After the resize operation completes, this value shows the total
        /// actual time, in seconds, for the resize operation.
        ///  
        /// </summary>
        public long ElapsedTimeInSeconds
        {
            get { return this.elapsedTimeInSeconds ?? default(long); }
            set { this.elapsedTimeInSeconds = value; }
        }

        // Check to see if ElapsedTimeInSeconds property is set
        internal bool IsSetElapsedTimeInSeconds()
        {
            return this.elapsedTimeInSeconds.HasValue;
        }

        /// <summary>
        /// The estimated time remaining, in seconds, until the resize operation is complete. This value is calculated based on the average resize rate
        /// and the estimated amount of data remaining to be processed. Once the resize operation is complete, this value will be 0.
        ///  
        /// </summary>
        public long EstimatedTimeToCompletionInSeconds
        {
            get { return this.estimatedTimeToCompletionInSeconds ?? default(long); }
            set { this.estimatedTimeToCompletionInSeconds = value; }
        }

        // Check to see if EstimatedTimeToCompletionInSeconds property is set
        internal bool IsSetEstimatedTimeToCompletionInSeconds()
        {
            return this.estimatedTimeToCompletionInSeconds.HasValue;
        }
    }
}
