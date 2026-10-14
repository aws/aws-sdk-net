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

namespace Amazon.MWAAServerless.Model
{
    /// <summary>
    /// Summary information about a workflow run, including basic identification and status
    /// information.
    /// </summary>
    public partial class WorkflowRunSummary
    {
        /// <summary>
        /// Gets and sets the property RunDetailSummary. 
        /// <para>
        /// Summary details about the workflow run execution.
        /// </para>
        /// </summary>
        public RunDetailSummary RunDetailSummary { get; set; }

        /// <summary>
        /// Checks to see if the RunDetailSummary property is set.
        /// </summary>
        internal bool IsSetRunDetailSummary() => this.RunDetailSummary != null;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The unique identifier of the workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property RunType. 
        /// <para>
        /// The type of workflow run.
        /// </para>
        /// </summary>
        public RunType RunType { get; set; }

        /// <summary>
        /// Checks to see if the RunType property is set.
        /// </summary>
        internal bool IsSetRunType() => this.RunType != null;

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow that contains this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string WorkflowArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowArn property is set.
        /// </summary>
        internal bool IsSetWorkflowArn() => this.WorkflowArn != null;

        /// <summary>
        /// Gets and sets the property WorkflowVersion. 
        /// <para>
        /// The version of the workflow used for this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string WorkflowVersion { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowVersion property is set.
        /// </summary>
        internal bool IsSetWorkflowVersion() => this.WorkflowVersion != null;
    }
}
