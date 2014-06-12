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
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes the result of a cluster resize operation.
    /// </summary>
    public partial class DescribeResizeResult
    {
        private double? _avgResizeRateInMegaBytesPerSecond;
        private long? _elapsedTimeInSeconds;
        private long? _estimatedTimeToCompletionInSeconds;
        private List<string> _importTablesCompleted = new List<string>();
        private List<string> _importTablesInProgress = new List<string>();
        private List<string> _importTablesNotStarted = new List<string>();
        private long? _progressInMegaBytes;
        private string _status;
        private string _targetClusterType;
        private string _targetNodeType;
        private int? _targetNumberOfNodes;
        private long? _totalResizeDataInMegaBytes;


        /// <summary>
        /// Gets and sets the property AvgResizeRateInMegaBytesPerSecond. 
        /// <para>
        /// The average rate of the resize operation over the last few minutes, measured in megabytes
        /// per second.             After the resize operation completes, this value shows the
        /// average rate of the entire resize operation.
        /// </para>
        /// </summary>
        public double AvgResizeRateInMegaBytesPerSecond
        {
            get { return this._avgResizeRateInMegaBytesPerSecond.GetValueOrDefault(); }
            set { this._avgResizeRateInMegaBytesPerSecond = value; }
        }


        /// <summary>
        /// Sets the AvgResizeRateInMegaBytesPerSecond property
        /// </summary>
        /// <param name="avgResizeRateInMegaBytesPerSecond">The value to set for the AvgResizeRateInMegaBytesPerSecond property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithAvgResizeRateInMegaBytesPerSecond(double avgResizeRateInMegaBytesPerSecond)
        {
            this._avgResizeRateInMegaBytesPerSecond = avgResizeRateInMegaBytesPerSecond;
            return this;
        }

        // Check to see if AvgResizeRateInMegaBytesPerSecond property is set
        internal bool IsSetAvgResizeRateInMegaBytesPerSecond()
        {
            return this._avgResizeRateInMegaBytesPerSecond.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ElapsedTimeInSeconds. 
        /// <para>
        /// The amount of seconds that have elapsed since the resize operation began.        
        ///     After the resize operation completes, this value shows the total actual time,
        /// in seconds, for the resize operation. 
        /// </para>
        /// </summary>
        public long ElapsedTimeInSeconds
        {
            get { return this._elapsedTimeInSeconds.GetValueOrDefault(); }
            set { this._elapsedTimeInSeconds = value; }
        }


        /// <summary>
        /// Sets the ElapsedTimeInSeconds property
        /// </summary>
        /// <param name="elapsedTimeInSeconds">The value to set for the ElapsedTimeInSeconds property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithElapsedTimeInSeconds(long elapsedTimeInSeconds)
        {
            this._elapsedTimeInSeconds = elapsedTimeInSeconds;
            return this;
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
        /// This value is calculated based on the average resize rate             and the estimated
        /// amount of data remaining to be processed. Once the resize operation is complete, this
        /// value will be 0. 
        /// </para>
        /// </summary>
        public long EstimatedTimeToCompletionInSeconds
        {
            get { return this._estimatedTimeToCompletionInSeconds.GetValueOrDefault(); }
            set { this._estimatedTimeToCompletionInSeconds = value; }
        }


        /// <summary>
        /// Sets the EstimatedTimeToCompletionInSeconds property
        /// </summary>
        /// <param name="estimatedTimeToCompletionInSeconds">The value to set for the EstimatedTimeToCompletionInSeconds property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithEstimatedTimeToCompletionInSeconds(long estimatedTimeToCompletionInSeconds)
        {
            this._estimatedTimeToCompletionInSeconds = estimatedTimeToCompletionInSeconds;
            return this;
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
        /// </summary>
        public List<string> ImportTablesCompleted
        {
            get { return this._importTablesCompleted; }
            set { this._importTablesCompleted = value; }
        }

        /// <summary>
        /// Sets the ImportTablesCompleted property
        /// </summary>
        /// <param name="importTablesCompleted">The values to add to the ImportTablesCompleted collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithImportTablesCompleted(params string[] importTablesCompleted)
        {
            foreach (var element in importTablesCompleted)
            {
                this._importTablesCompleted.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the ImportTablesCompleted property
        /// </summary>
        /// <param name="importTablesCompleted">The values to add to the ImportTablesCompleted collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithImportTablesCompleted(IEnumerable<string> importTablesCompleted)
        {
            foreach (var element in importTablesCompleted)
            {
                this._importTablesCompleted.Add(element);
            }
            return this;
        }
        // Check to see if ImportTablesCompleted property is set
        internal bool IsSetImportTablesCompleted()
        {
            return this._importTablesCompleted != null && this._importTablesCompleted.Count > 0; 
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
        /// </summary>
        public List<string> ImportTablesInProgress
        {
            get { return this._importTablesInProgress; }
            set { this._importTablesInProgress = value; }
        }

        /// <summary>
        /// Sets the ImportTablesInProgress property
        /// </summary>
        /// <param name="importTablesInProgress">The values to add to the ImportTablesInProgress collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithImportTablesInProgress(params string[] importTablesInProgress)
        {
            foreach (var element in importTablesInProgress)
            {
                this._importTablesInProgress.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the ImportTablesInProgress property
        /// </summary>
        /// <param name="importTablesInProgress">The values to add to the ImportTablesInProgress collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithImportTablesInProgress(IEnumerable<string> importTablesInProgress)
        {
            foreach (var element in importTablesInProgress)
            {
                this._importTablesInProgress.Add(element);
            }
            return this;
        }
        // Check to see if ImportTablesInProgress property is set
        internal bool IsSetImportTablesInProgress()
        {
            return this._importTablesInProgress != null && this._importTablesInProgress.Count > 0; 
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
        /// </summary>
        public List<string> ImportTablesNotStarted
        {
            get { return this._importTablesNotStarted; }
            set { this._importTablesNotStarted = value; }
        }

        /// <summary>
        /// Sets the ImportTablesNotStarted property
        /// </summary>
        /// <param name="importTablesNotStarted">The values to add to the ImportTablesNotStarted collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithImportTablesNotStarted(params string[] importTablesNotStarted)
        {
            foreach (var element in importTablesNotStarted)
            {
                this._importTablesNotStarted.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the ImportTablesNotStarted property
        /// </summary>
        /// <param name="importTablesNotStarted">The values to add to the ImportTablesNotStarted collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithImportTablesNotStarted(IEnumerable<string> importTablesNotStarted)
        {
            foreach (var element in importTablesNotStarted)
            {
                this._importTablesNotStarted.Add(element);
            }
            return this;
        }
        // Check to see if ImportTablesNotStarted property is set
        internal bool IsSetImportTablesNotStarted()
        {
            return this._importTablesNotStarted != null && this._importTablesNotStarted.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property ProgressInMegaBytes. 
        /// <para>
        /// While the resize operation is in progress, this value shows the current amount of
        /// data, in megabytes, that has been processed so far.             When the resize operation
        /// is complete, this value shows the total amount of data, in megabytes, on the cluster,
        ///             which may be more or less than TotalResizeDataInMegaBytes (the estimated
        /// total amount of data before resize). 
        /// </para>
        /// </summary>
        public long ProgressInMegaBytes
        {
            get { return this._progressInMegaBytes.GetValueOrDefault(); }
            set { this._progressInMegaBytes = value; }
        }


        /// <summary>
        /// Sets the ProgressInMegaBytes property
        /// </summary>
        /// <param name="progressInMegaBytes">The value to set for the ProgressInMegaBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithProgressInMegaBytes(long progressInMegaBytes)
        {
            this._progressInMegaBytes = progressInMegaBytes;
            return this;
        }

        // Check to see if ProgressInMegaBytes property is set
        internal bool IsSetProgressInMegaBytes()
        {
            return this._progressInMegaBytes.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the resize operation.
        /// </para>
        ///         
        /// <para>
        /// Valid Values: <code>NONE</code> | <code>IN_PROGRESS</code> | <code>FAILED</code> |
        /// <code>SUCCEEDED</code>
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithStatus(string status)
        {
            this._status = status;
            return this;
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
        /// Valid Values: <code>multi-node</code> | <code>single-node</code>
        /// </para>
        /// </summary>
        public string TargetClusterType
        {
            get { return this._targetClusterType; }
            set { this._targetClusterType = value; }
        }


        /// <summary>
        /// Sets the TargetClusterType property
        /// </summary>
        /// <param name="targetClusterType">The value to set for the TargetClusterType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithTargetClusterType(string targetClusterType)
        {
            this._targetClusterType = targetClusterType;
            return this;
        }

        // Check to see if TargetClusterType property is set
        internal bool IsSetTargetClusterType()
        {
            return this._targetClusterType != null;
        }


        /// <summary>
        /// Gets and sets the property TargetNodeType. 
        /// <para>
        /// The node type that the cluster will have after the resize operation is complete.
        /// </para>
        /// </summary>
        public string TargetNodeType
        {
            get { return this._targetNodeType; }
            set { this._targetNodeType = value; }
        }


        /// <summary>
        /// Sets the TargetNodeType property
        /// </summary>
        /// <param name="targetNodeType">The value to set for the TargetNodeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithTargetNodeType(string targetNodeType)
        {
            this._targetNodeType = targetNodeType;
            return this;
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
        public int TargetNumberOfNodes
        {
            get { return this._targetNumberOfNodes.GetValueOrDefault(); }
            set { this._targetNumberOfNodes = value; }
        }


        /// <summary>
        /// Sets the TargetNumberOfNodes property
        /// </summary>
        /// <param name="targetNumberOfNodes">The value to set for the TargetNumberOfNodes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithTargetNumberOfNodes(int targetNumberOfNodes)
        {
            this._targetNumberOfNodes = targetNumberOfNodes;
            return this;
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
        public long TotalResizeDataInMegaBytes
        {
            get { return this._totalResizeDataInMegaBytes.GetValueOrDefault(); }
            set { this._totalResizeDataInMegaBytes = value; }
        }


        /// <summary>
        /// Sets the TotalResizeDataInMegaBytes property
        /// </summary>
        /// <param name="totalResizeDataInMegaBytes">The value to set for the TotalResizeDataInMegaBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeResizeResult WithTotalResizeDataInMegaBytes(long totalResizeDataInMegaBytes)
        {
            this._totalResizeDataInMegaBytes = totalResizeDataInMegaBytes;
            return this;
        }

        // Check to see if TotalResizeDataInMegaBytes property is set
        internal bool IsSetTotalResizeDataInMegaBytes()
        {
            return this._totalResizeDataInMegaBytes.HasValue; 
        }

    }
}