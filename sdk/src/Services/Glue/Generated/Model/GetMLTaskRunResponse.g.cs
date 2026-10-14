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
    /// This is the response object from the GetMLTaskRun operation.
    /// </summary>
    public partial class GetMLTaskRunResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The date and time when this task run was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Checks to see if the CompletedOn property is set.
        /// </summary>
        internal bool IsSetCompletedOn() => this.CompletedOn.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorString. 
        /// <para>
        /// The error strings that are associated with the task run.
        /// </para>
        /// </summary>
        public string ErrorString { get; set; }

        /// <summary>
        /// Checks to see if the ErrorString property is set.
        /// </summary>
        internal bool IsSetErrorString() => this.ErrorString != null;

        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// The amount of time (in seconds) that the task run consumed resources.
        /// </para>
        /// </summary>
        public int? ExecutionTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTime property is set.
        /// </summary>
        internal bool IsSetExecutionTime() => this.ExecutionTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// The date and time when this task run was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedOn { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedOn property is set.
        /// </summary>
        internal bool IsSetLastModifiedOn() => this.LastModifiedOn.HasValue;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The names of the log groups that are associated with the task run.
        /// </para>
        /// </summary>
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// The list of properties that are associated with the task run.
        /// </para>
        /// </summary>
        public TaskRunProperties Properties { get; set; }

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null;

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The date and time when this task run started.
        /// </para>
        /// </summary>
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Checks to see if the StartedOn property is set.
        /// </summary>
        internal bool IsSetStartedOn() => this.StartedOn.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status for this task run.
        /// </para>
        /// </summary>
        public TaskStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskRunId. 
        /// <para>
        /// The unique run identifier associated with this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TaskRunId { get; set; }

        /// <summary>
        /// Checks to see if the TaskRunId property is set.
        /// </summary>
        internal bool IsSetTaskRunId() => this.TaskRunId != null;

        /// <summary>
        /// Gets and sets the property TransformId. 
        /// <para>
        /// The unique identifier of the task run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TransformId { get; set; }

        /// <summary>
        /// Checks to see if the TransformId property is set.
        /// </summary>
        internal bool IsSetTransformId() => this.TransformId != null;
    }
}
