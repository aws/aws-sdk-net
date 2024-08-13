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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// An object of shape <c>BaselineOperation</c>, returning details about the specified
    /// <c>Baseline</c> operation ID.
    /// </summary>
    public partial class BaselineOperation
    {
        private DateTime? _endTime;
        private string _operationIdentifier;
        private BaselineOperationType _operationType;
        private DateTime? _startTime;
        private BaselineOperationStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the operation (if applicable), in ISO 8601 format.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OperationIdentifier. 
        /// <para>
        /// The identifier of the specified operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string OperationIdentifier
        {
            get { return this._operationIdentifier; }
            set { this._operationIdentifier = value; }
        }

        // Check to see if OperationIdentifier property is set
        internal bool IsSetOperationIdentifier()
        {
            return this._operationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// An enumerated type (<c>enum</c>) with possible values of <c>ENABLE_BASELINE</c>, <c>DISABLE_BASELINE</c>,
        /// <c>UPDATE_ENABLED_BASELINE</c>, or <c>RESET_ENABLED_BASELINE</c>.
        /// </para>
        /// </summary>
        public BaselineOperationType OperationType
        {
            get { return this._operationType; }
            set { this._operationType = value; }
        }

        // Check to see if OperationType property is set
        internal bool IsSetOperationType()
        {
            return this._operationType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the operation, in ISO 8601 format.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// An enumerated type (<c>enum</c>) with possible values of <c>SUCCEEDED</c>, <c>FAILED</c>,
        /// or <c>IN_PROGRESS</c>.
        /// </para>
        /// </summary>
        public BaselineOperationStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A status message that gives more information about the operation's status, if applicable.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}