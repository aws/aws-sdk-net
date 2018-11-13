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

/*
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the DescribeStackDriftDetectionStatus operation.
    /// </summary>
    public partial class DescribeStackDriftDetectionStatusResponse : AmazonWebServiceResponse
    {
        private StackDriftDetectionStatus _detectionStatus;
        private string _detectionStatusReason;
        private int? _driftedStackResourceCount;
        private string _stackDriftDetectionId;
        private StackDriftStatus _stackDriftStatus;
        private string _stackId;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property DetectionStatus. 
        /// <para>
        /// The status of the stack drift detection operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DETECTION_COMPLETE</code>: The stack drift detection operation has successfully
        /// completed for all resources in the stack that support drift detection. (Resources
        /// that do not currently support stack detection remain unchecked.)
        /// </para>
        ///  
        /// <para>
        /// If you specified logical resource IDs for AWS CloudFormation to use as a filter for
        /// the stack drift detection operation, only the resources with those logical IDs are
        /// checked for drift.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DETECTION_FAILED</code>: The stack drift detection operation has failed for
        /// at least one resource in the stack. Results will be available for resources on which
        /// AWS CloudFormation successfully completed drift detection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DETECTION_IN_PROGRESS</code>: The stack drift detection operation is currently
        /// in progress.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackDriftDetectionStatus DetectionStatus
        {
            get { return this._detectionStatus; }
            set { this._detectionStatus = value; }
        }

        // Check to see if DetectionStatus property is set
        internal bool IsSetDetectionStatus()
        {
            return this._detectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DetectionStatusReason. 
        /// <para>
        /// The reason the stack drift detection operation has its current status.
        /// </para>
        /// </summary>
        public string DetectionStatusReason
        {
            get { return this._detectionStatusReason; }
            set { this._detectionStatusReason = value; }
        }

        // Check to see if DetectionStatusReason property is set
        internal bool IsSetDetectionStatusReason()
        {
            return this._detectionStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property DriftedStackResourceCount. 
        /// <para>
        /// Total number of stack resources that have drifted. This is NULL until the drift detection
        /// operation reaches a status of <code>DETECTION_COMPLETE</code>. This value will be
        /// 0 for stacks whose drift status is <code>IN_SYNC</code>.
        /// </para>
        /// </summary>
        public int DriftedStackResourceCount
        {
            get { return this._driftedStackResourceCount.GetValueOrDefault(); }
            set { this._driftedStackResourceCount = value; }
        }

        // Check to see if DriftedStackResourceCount property is set
        internal bool IsSetDriftedStackResourceCount()
        {
            return this._driftedStackResourceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackDriftDetectionId. 
        /// <para>
        /// The ID of the drift detection results of this operation. 
        /// </para>
        ///  
        /// <para>
        /// AWS CloudFormation generates new results, with a new drift detection ID, each time
        /// this operation is run. However, the number of reports AWS CloudFormation retains for
        /// any given stack, and for how long, may vary.
        /// </para>
        /// </summary>
        public string StackDriftDetectionId
        {
            get { return this._stackDriftDetectionId; }
            set { this._stackDriftDetectionId = value; }
        }

        // Check to see if StackDriftDetectionId property is set
        internal bool IsSetStackDriftDetectionId()
        {
            return this._stackDriftDetectionId != null;
        }

        /// <summary>
        /// Gets and sets the property StackDriftStatus. 
        /// <para>
        /// Status of the stack's actual configuration compared to its expected configuration.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DRIFTED</code>: The stack differs from its expected template configuration.
        /// A stack is considered to have drifted if one or more of its resources have drifted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_CHECKED</code>: AWS CloudFormation has not checked if the stack differs
        /// from its expected template configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_SYNC</code>: The stack's actual configuration matches its expected template
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UNKNOWN</code>: This value is reserved for future use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackDriftStatus StackDriftStatus
        {
            get { return this._stackDriftStatus; }
            set { this._stackDriftStatus = value; }
        }

        // Check to see if StackDriftStatus property is set
        internal bool IsSetStackDriftStatus()
        {
            return this._stackDriftStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The ID of the stack.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time at which the stack drift detection operation was initiated.
        /// </para>
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}