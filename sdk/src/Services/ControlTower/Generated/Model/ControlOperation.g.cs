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

namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// An operation performed by the control.
    /// </summary>
    public partial class ControlOperation
    {
        /// <summary>
        /// Gets and sets the property ControlIdentifier. 
        /// <para>
        /// The <c>controlIdentifier</c> of the control for the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ControlIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ControlIdentifier property is set.
        /// </summary>
        internal bool IsSetControlIdentifier() => this.ControlIdentifier != null;

        /// <summary>
        /// Gets and sets the property EnabledControlIdentifier. 
        /// <para>
        /// The <c>controlIdentifier</c> of the enabled control.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string EnabledControlIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnabledControlIdentifier property is set.
        /// </summary>
        internal bool IsSetEnabledControlIdentifier() => this.EnabledControlIdentifier != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that the operation finished.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property OperationIdentifier. 
        /// <para>
        /// The identifier of the specified operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string OperationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OperationIdentifier property is set.
        /// </summary>
        internal bool IsSetOperationIdentifier() => this.OperationIdentifier != null;

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// One of <c>ENABLE_CONTROL</c> or <c>DISABLE_CONTROL</c>.
        /// </para>
        /// </summary>
        public ControlOperationType OperationType { get; set; }

        /// <summary>
        /// Checks to see if the OperationType property is set.
        /// </summary>
        internal bool IsSetOperationType() => this.OperationType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time that the operation began.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// One of <c>IN_PROGRESS</c>, <c>SUCEEDED</c>, or <c>FAILED</c>.
        /// </para>
        /// </summary>
        public ControlOperationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// If the operation result is <c>FAILED</c>, this string contains a message explaining
        /// why the operation failed.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property TargetIdentifier. 
        /// <para>
        /// The target upon which the control operation is working.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string TargetIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TargetIdentifier property is set.
        /// </summary>
        internal bool IsSetTargetIdentifier() => this.TargetIdentifier != null;
    }
}
