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
    /// Container for the parameters to the StopWorkflowRun operation. Stops a running workflow
    /// execution. This operation terminates all running tasks and prevents new tasks from
    /// starting. Amazon Managed Workflows for Apache Airflow Serverless gracefully shuts
    /// down the workflow execution by stopping task scheduling and terminating active ECS
    /// worker containers. The operation transitions the workflow run to a <c>STOPPING</c>
    /// state and then to <c>STOPPED</c> once all cleanup is complete. In-flight tasks may
    /// complete or be terminated depending on their current execution state.
    /// </summary>
    public partial class StopWorkflowRunRequest : AmazonMWAAServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The unique identifier of the workflow run to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow that contains the run you want to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string WorkflowArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowArn property is set.
        /// </summary>
        internal bool IsSetWorkflowArn() => this.WorkflowArn != null;
    }
}
