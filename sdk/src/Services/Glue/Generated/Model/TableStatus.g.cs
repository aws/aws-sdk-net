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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure containing information about the state of an asynchronous change to a
    /// table.
    /// </summary>
    public partial class TableStatus
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Indicates which action was called on the table, currently only <c>CREATE</c> or <c>UPDATE</c>.
        /// </para>
        /// </summary>
        public ResourceAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// A <c>StatusDetails</c> object with information about the requested change.
        /// </para>
        /// </summary>
        public StatusDetails Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An error that will only appear when the state is "FAILED". This is a parent level
        /// exception message, there may be different <c>Error</c>s for each dialect.
        /// </para>
        /// </summary>
        public ErrorDetail Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// An ISO 8601 formatted date string indicating the time that the change was initiated.
        /// </para>
        /// </summary>
        public DateTime? RequestTime { get; set; }

        /// <summary>
        /// Checks to see if the RequestTime property is set.
        /// </summary>
        internal bool IsSetRequestTime() => this.RequestTime.HasValue;

        /// <summary>
        /// Gets and sets the property RequestedBy. 
        /// <para>
        /// The ARN of the user who requested the asynchronous change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RequestedBy { get; set; }

        /// <summary>
        /// Checks to see if the RequestedBy property is set.
        /// </summary>
        internal bool IsSetRequestedBy() => this.RequestedBy != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// A generic status for the change in progress, such as QUEUED, IN_PROGRESS, SUCCESS,
        /// or FAILED.
        /// </para>
        /// </summary>
        public ResourceState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// An ISO 8601 formatted date string indicating the time that the state was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The ARN of the user to last manually alter the asynchronous change (requesting cancellation,
        /// etc).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;
    }
}
