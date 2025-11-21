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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// A description of the application operation that provides information about the updates
    /// that were made to the application.
    /// </summary>
    public partial class ApplicationOperationInfoDetails
    {
        private ApplicationVersionChangeDetails _applicationVersionChangeDetails;
        private DateTime? _endTime;
        private string _operation;
        private OperationFailureDetails _operationFailureDetails;
        private OperationStatus _operationStatus;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property ApplicationVersionChangeDetails.
        /// </summary>
        public ApplicationVersionChangeDetails ApplicationVersionChangeDetails
        {
            get { return this._applicationVersionChangeDetails; }
            set { this._applicationVersionChangeDetails = value; }
        }

        // Check to see if ApplicationVersionChangeDetails property is set
        internal bool IsSetApplicationVersionChangeDetails()
        {
            return this._applicationVersionChangeDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp that indicates when the operation finished.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Operation.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property OperationFailureDetails.
        /// </summary>
        public OperationFailureDetails OperationFailureDetails
        {
            get { return this._operationFailureDetails; }
            set { this._operationFailureDetails = value; }
        }

        // Check to see if OperationFailureDetails property is set
        internal bool IsSetOperationFailureDetails()
        {
            return this._operationFailureDetails != null;
        }

        /// <summary>
        /// Gets and sets the property OperationStatus.
        /// </summary>
        [AWSProperty(Required=true)]
        public OperationStatus OperationStatus
        {
            get { return this._operationStatus; }
            set { this._operationStatus = value; }
        }

        // Check to see if OperationStatus property is set
        internal bool IsSetOperationStatus()
        {
            return this._operationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp that indicates when the operation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}