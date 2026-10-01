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
    /// An object of shape <c>BaselineOperation</c>, returning details about the specified
    /// <c>Baseline</c> operation ID.
    /// </summary>
    public partial class BaselineOperation
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the operation (if applicable), in ISO 8601 format.
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
        /// An enumerated type (<c>enum</c>) with possible values of <c>ENABLE_BASELINE</c>, <c>DISABLE_BASELINE</c>,
        /// <c>UPDATE_ENABLED_BASELINE</c>, or <c>RESET_ENABLED_BASELINE</c>.
        /// </para>
        /// </summary>
        public BaselineOperationType OperationType { get; set; }

        /// <summary>
        /// Checks to see if the OperationType property is set.
        /// </summary>
        internal bool IsSetOperationType() => this.OperationType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the operation, in ISO 8601 format.
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
        /// An enumerated type (<c>enum</c>) with possible values of <c>SUCCEEDED</c>, <c>FAILED</c>,
        /// or <c>IN_PROGRESS</c>.
        /// </para>
        /// </summary>
        public BaselineOperationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A status message that gives more information about the operation's status, if applicable.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
