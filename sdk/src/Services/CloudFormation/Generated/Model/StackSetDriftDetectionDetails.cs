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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Detailed information about the drift status of the stack set.
    /// 
    ///  
    /// <para>
    /// For stack sets, contains information about the last <i>completed</i> drift operation
    /// performed on the stack set. Information about drift operations in-progress is not
    /// included. 
    /// </para>
    ///  
    /// <para>
    /// For stack set operations, includes information about drift operations currently being
    /// performed on the stack set.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-drift.html">Detecting
    /// Unmanaged Changes in Stack Sets</a> in the <i>AWS CloudFormation User Guide</i>.
    /// </para>
    /// </summary>
    public partial class StackSetDriftDetectionDetails
    {
        private StackSetDriftDetectionStatus _driftDetectionStatus;
        private int? _driftedStackInstancesCount;
        private StackSetDriftStatus _driftStatus;
        private int? _failedStackInstancesCount;
        private int? _inProgressStackInstancesCount;
        private int? _inSyncStackInstancesCount;
        private DateTime? _lastDriftCheckTimestamp;
        private int? _totalStackInstancesCount;

        /// <summary>
        /// Gets and sets the property DriftDetectionStatus. 
        /// <para>
        /// The status of the stack set drift detection operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>COMPLETED</code>: The drift detection operation completed without failing on
        /// any stack instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code>: The drift detection operation exceeded the specified failure
        /// tolerance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PARTIAL_SUCCESS</code>: The drift detection operation completed without exceeding
        /// the failure tolerance for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_PROGRESS</code>: The drift detection operation is currently being performed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STOPPED</code>: The user has cancelled the drift detection operation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackSetDriftDetectionStatus DriftDetectionStatus
        {
            get { return this._driftDetectionStatus; }
            set { this._driftDetectionStatus = value; }
        }

        // Check to see if DriftDetectionStatus property is set
        internal bool IsSetDriftDetectionStatus()
        {
            return this._driftDetectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DriftedStackInstancesCount. 
        /// <para>
        /// The number of stack instances that have drifted from the expected template and parameter
        /// configuration of the stack set. A stack instance is considered to have drifted if
        /// one or more of the resources in the associated stack do not match their expected configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int DriftedStackInstancesCount
        {
            get { return this._driftedStackInstancesCount.GetValueOrDefault(); }
            set { this._driftedStackInstancesCount = value; }
        }

        // Check to see if DriftedStackInstancesCount property is set
        internal bool IsSetDriftedStackInstancesCount()
        {
            return this._driftedStackInstancesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DriftStatus. 
        /// <para>
        /// Status of the stack set's actual configuration compared to its expected template and
        /// parameter configuration. A stack set is considered to have drifted if one or more
        /// of its stack instances have drifted from their expected template and parameter configuration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DRIFTED</code>: One or more of the stack instances belonging to the stack set
        /// stack differs from the expected template and parameter configuration. A stack instance
        /// is considered to have drifted if one or more of the resources in the associated stack
        /// have drifted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_CHECKED</code>: AWS CloudFormation has not checked the stack set for drift.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_SYNC</code>: All of the stack instances belonging to the stack set stack
        /// match from the expected template and parameter configuration.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackSetDriftStatus DriftStatus
        {
            get { return this._driftStatus; }
            set { this._driftStatus = value; }
        }

        // Check to see if DriftStatus property is set
        internal bool IsSetDriftStatus()
        {
            return this._driftStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FailedStackInstancesCount. 
        /// <para>
        /// The number of stack instances for which the drift detection operation failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int FailedStackInstancesCount
        {
            get { return this._failedStackInstancesCount.GetValueOrDefault(); }
            set { this._failedStackInstancesCount = value; }
        }

        // Check to see if FailedStackInstancesCount property is set
        internal bool IsSetFailedStackInstancesCount()
        {
            return this._failedStackInstancesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InProgressStackInstancesCount. 
        /// <para>
        /// The number of stack instances that are currently being checked for drift.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int InProgressStackInstancesCount
        {
            get { return this._inProgressStackInstancesCount.GetValueOrDefault(); }
            set { this._inProgressStackInstancesCount = value; }
        }

        // Check to see if InProgressStackInstancesCount property is set
        internal bool IsSetInProgressStackInstancesCount()
        {
            return this._inProgressStackInstancesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InSyncStackInstancesCount. 
        /// <para>
        /// The number of stack instances which match the expected template and parameter configuration
        /// of the stack set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int InSyncStackInstancesCount
        {
            get { return this._inSyncStackInstancesCount.GetValueOrDefault(); }
            set { this._inSyncStackInstancesCount = value; }
        }

        // Check to see if InSyncStackInstancesCount property is set
        internal bool IsSetInSyncStackInstancesCount()
        {
            return this._inSyncStackInstancesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastDriftCheckTimestamp. 
        /// <para>
        /// Most recent time when CloudFormation performed a drift detection operation on the
        /// stack set. This value will be <code>NULL</code> for any stack set on which drift detection
        /// has not yet been performed.
        /// </para>
        /// </summary>
        public DateTime LastDriftCheckTimestamp
        {
            get { return this._lastDriftCheckTimestamp.GetValueOrDefault(); }
            set { this._lastDriftCheckTimestamp = value; }
        }

        // Check to see if LastDriftCheckTimestamp property is set
        internal bool IsSetLastDriftCheckTimestamp()
        {
            return this._lastDriftCheckTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalStackInstancesCount. 
        /// <para>
        /// The total number of stack instances belonging to this stack set. 
        /// </para>
        ///  
        /// <para>
        /// The total number of stack instances is equal to the total of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Stack instances that match the stack set configuration. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stack instances that have drifted from the stack set configuration. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stack instances where the drift detection operation has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stack instances currently being checked for drift.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0)]
        public int TotalStackInstancesCount
        {
            get { return this._totalStackInstancesCount.GetValueOrDefault(); }
            set { this._totalStackInstancesCount = value; }
        }

        // Check to see if TotalStackInstancesCount property is set
        internal bool IsSetTotalStackInstancesCount()
        {
            return this._totalStackInstancesCount.HasValue; 
        }

    }
}