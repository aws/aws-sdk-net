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
 * Do not modify this file. This file is generated from the mwaa-serverless-2024-07-26.normal.json service model.
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
    /// Container for the parameters to the GetTaskInstance operation.
    /// Retrieves detailed information about a specific task instance within a workflow run.
    /// Task instances represent individual tasks that are executed as part of a workflow
    /// in the Amazon Managed Workflows for Apache Airflow Serverless environment. Each task
    /// instance runs in an isolated ECS container with dedicated resources and security boundaries.
    /// The service tracks task execution state, retry attempts, and provides detailed timing
    /// and error information for troubleshooting and monitoring purposes.
    /// </summary>
    public partial class GetTaskInstanceRequest : AmazonMWAAServerlessRequest
    {
        private string _runId;
        private string _taskInstanceId;
        private string _workflowArn;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The unique identifier of the workflow run that contains the task instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string RunId
        {
            get { return this._runId; }
            set { this._runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this._runId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskInstanceId. 
        /// <para>
        /// The unique identifier of the task instance to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TaskInstanceId
        {
            get { return this._taskInstanceId; }
            set { this._taskInstanceId = value; }
        }

        // Check to see if TaskInstanceId property is set
        internal bool IsSetTaskInstanceId()
        {
            return this._taskInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow that contains the task instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string WorkflowArn
        {
            get { return this._workflowArn; }
            set { this._workflowArn = value; }
        }

        // Check to see if WorkflowArn property is set
        internal bool IsSetWorkflowArn()
        {
            return this._workflowArn != null;
        }

    }
}