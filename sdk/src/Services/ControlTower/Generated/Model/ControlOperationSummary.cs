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
    /// A summary of information about the specified control operation.
    /// </summary>
    public partial class ControlOperationSummary
    {
        private string _controlIdentifier;
        private string _enabledControlIdentifier;
        private DateTime? _endTime;
        private string _operationIdentifier;
        private ControlOperationType _operationType;
        private DateTime? _startTime;
        private ControlOperationStatus _status;
        private string _statusMessage;
        private string _targetIdentifier;

        /// <summary>
        /// Gets and sets the property ControlIdentifier. 
        /// <para>
        /// The <c>controlIdentifier</c> of a control.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ControlIdentifier
        {
            get { return this._controlIdentifier; }
            set { this._controlIdentifier = value; }
        }

        // Check to see if ControlIdentifier property is set
        internal bool IsSetControlIdentifier()
        {
            return this._controlIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnabledControlIdentifier. 
        /// <para>
        /// The <c>controlIdentifier</c> of an enabled control.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string EnabledControlIdentifier
        {
            get { return this._enabledControlIdentifier; }
            set { this._enabledControlIdentifier = value; }
        }

        // Check to see if EnabledControlIdentifier property is set
        internal bool IsSetEnabledControlIdentifier()
        {
            return this._enabledControlIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the control operation was completed.
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
        /// The unique identifier of a control operation.
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
        /// The type of operation.
        /// </para>
        /// </summary>
        public ControlOperationType OperationType
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
        /// The time at which a control operation began.
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
        /// The status of the specified control operation.
        /// </para>
        /// </summary>
        public ControlOperationStatus Status
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
        /// A speficic message displayed as part of the control status.
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

        /// <summary>
        /// Gets and sets the property TargetIdentifier. 
        /// <para>
        /// The unique identifier of the target of a control operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string TargetIdentifier
        {
            get { return this._targetIdentifier; }
            set { this._targetIdentifier = value; }
        }

        // Check to see if TargetIdentifier property is set
        internal bool IsSetTargetIdentifier()
        {
            return this._targetIdentifier != null;
        }

    }
}