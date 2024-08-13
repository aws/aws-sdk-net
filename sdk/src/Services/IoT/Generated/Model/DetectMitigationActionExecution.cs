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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes which mitigation actions should be executed.
    /// </summary>
    public partial class DetectMitigationActionExecution
    {
        private string _actionName;
        private string _errorCode;
        private DateTime? _executionEndDate;
        private DateTime? _executionStartDate;
        private string _message;
        private DetectMitigationActionExecutionStatus _status;
        private string _taskId;
        private string _thingName;
        private string _violationId;

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        ///  The friendly name that uniquely identifies the mitigation action. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  The error code of a mitigation action. 
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionEndDate. 
        /// <para>
        ///  The date a mitigation action ended. 
        /// </para>
        /// </summary>
        public DateTime? ExecutionEndDate
        {
            get { return this._executionEndDate; }
            set { this._executionEndDate = value; }
        }

        // Check to see if ExecutionEndDate property is set
        internal bool IsSetExecutionEndDate()
        {
            return this._executionEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionStartDate. 
        /// <para>
        ///  The date a mitigation action was started. 
        /// </para>
        /// </summary>
        public DateTime? ExecutionStartDate
        {
            get { return this._executionStartDate; }
            set { this._executionStartDate = value; }
        }

        // Check to see if ExecutionStartDate property is set
        internal bool IsSetExecutionStartDate()
        {
            return this._executionStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        ///  The message of a mitigation action. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of a mitigation action. 
        /// </para>
        /// </summary>
        public DetectMitigationActionExecutionStatus Status
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
        /// Gets and sets the property TaskId. 
        /// <para>
        ///  The unique identifier of the task. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        ///  The name of the thing. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

        /// <summary>
        /// Gets and sets the property ViolationId. 
        /// <para>
        ///  The unique identifier of the violation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ViolationId
        {
            get { return this._violationId; }
            set { this._violationId = value; }
        }

        // Check to see if ViolationId property is set
        internal bool IsSetViolationId()
        {
            return this._violationId != null;
        }

    }
}