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
    /// Container for the parameters to the DeleteWorkflow operation. Deletes a workflow and
    /// all its versions. This operation permanently removes the workflow and cannot be undone.
    /// Amazon Managed Workflows for Apache Airflow Serverless ensures that all associated
    /// resources are properly cleaned up, including stopping any running executions, removing
    /// scheduled triggers, and cleaning up execution history. The deletion process respects
    /// the multi-tenant isolation boundaries and ensures that no residual data or configurations
    /// remain that could affect other customers or workflows.
    /// </summary>
    public partial class DeleteWorkflowRequest : AmazonMWAAServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string WorkflowArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowArn property is set.
        /// </summary>
        internal bool IsSetWorkflowArn() => this.WorkflowArn != null;

        /// <summary>
        /// Gets and sets the property WorkflowVersion. 
        /// <para>
        /// Optional. The specific version of the workflow to delete. If not specified, all versions
        /// of the workflow are deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string WorkflowVersion { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowVersion property is set.
        /// </summary>
        internal bool IsSetWorkflowVersion() => this.WorkflowVersion != null;
    }
}
