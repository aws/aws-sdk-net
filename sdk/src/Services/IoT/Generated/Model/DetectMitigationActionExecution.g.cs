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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        ///  The friendly name that uniquely identifies the mitigation action. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string ActionName { get; set; }

        /// <summary>
        /// Checks to see if the ActionName property is set.
        /// </summary>
        internal bool IsSetActionName() => this.ActionName != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  The error code of a mitigation action. 
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ExecutionEndDate. 
        /// <para>
        ///  The date a mitigation action ended. 
        /// </para>
        /// </summary>
        public DateTime? ExecutionEndDate { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionEndDate property is set.
        /// </summary>
        internal bool IsSetExecutionEndDate() => this.ExecutionEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionStartDate. 
        /// <para>
        ///  The date a mitigation action was started. 
        /// </para>
        /// </summary>
        public DateTime? ExecutionStartDate { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStartDate property is set.
        /// </summary>
        internal bool IsSetExecutionStartDate() => this.ExecutionStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        ///  The message of a mitigation action. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of a mitigation action. 
        /// </para>
        /// </summary>
        public DetectMitigationActionExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        ///  The unique identifier of the task. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        ///  The name of the thing. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingName { get; set; }

        /// <summary>
        /// Checks to see if the ThingName property is set.
        /// </summary>
        internal bool IsSetThingName() => this.ThingName != null;

        /// <summary>
        /// Gets and sets the property ViolationId. 
        /// <para>
        ///  The unique identifier of the violation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ViolationId { get; set; }

        /// <summary>
        /// Checks to see if the ViolationId property is set.
        /// </summary>
        internal bool IsSetViolationId() => this.ViolationId != null;
    }
}
