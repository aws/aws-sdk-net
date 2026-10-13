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

namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Task object encapsulating task information.
    /// </summary>
    public partial class Task
    {
        /// <summary>
        /// Gets and sets the property ProgressPercent. 
        /// <para>
        /// Indication of the percentage completion of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? ProgressPercent { get; set; }

        /// <summary>
        /// Checks to see if the ProgressPercent property is set.
        /// </summary>
        internal bool IsSetProgressPercent() => this.ProgressPercent.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the task - Not Started, In-Progress, Complete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetail. 
        /// <para>
        /// Details of task status as notified by a migration tool. A tool might use this field
        /// to provide clarifying information about the status that is unique to that tool or
        /// that explains an error state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2500)]
        public string StatusDetail { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetail property is set.
        /// </summary>
        internal bool IsSetStatusDetail() => this.StatusDetail != null;
    }
}
