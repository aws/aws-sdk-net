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

#pragma warning disable CS0612,CS0618,CS1570
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
        ///  <c>DETECTION_COMPLETE</c>: The stack drift detection operation has successfully completed
        /// for all resources in the stack that support drift detection. (Resources that don't
        /// currently support stack detection remain unchecked.)
        /// </para>
        ///  
        /// <para>
        /// If you specified logical resource IDs for CloudFormation to use as a filter for the
        /// stack drift detection operation, only the resources with those logical IDs are checked
        /// for drift.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DETECTION_FAILED</c>: The stack drift detection operation has failed for at least
        /// one resource in the stack. Results will be available for resources on which CloudFormation
        /// successfully completed drift detection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DETECTION_IN_PROGRESS</c>: The stack drift detection operation is currently in
        /// progress.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// operation reaches a status of <c>DETECTION_COMPLETE</c>. This value will be 0 for
        /// stacks whose drift status is <c>IN_SYNC</c>.
        /// </para>
        /// </summary>
        public int? DriftedStackResourceCount
        {
            get { return this._driftedStackResourceCount; }
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
        /// CloudFormation generates new results, with a new drift detection ID, each time this
        /// operation is run. However, the number of reports CloudFormation retains for any given
        /// stack, and for how long, may vary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
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
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DRIFTED</c>: The stack differs from its expected template configuration. A stack
        /// is considered to have drifted if one or more of its resources have drifted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_CHECKED</c>: CloudFormation hasn't checked if the stack differs from its expected
        /// template configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_SYNC</c>: The stack's actual configuration matches its expected template configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNKNOWN</c>: CloudFormation could not run drift detection for a resource in the
        /// stack. See the <c>DetectionStatusReason</c> for details.
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}