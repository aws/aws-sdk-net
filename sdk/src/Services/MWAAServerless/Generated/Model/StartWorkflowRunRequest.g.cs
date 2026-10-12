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
    /// Container for the parameters to the StartWorkflowRun operation. Starts a new execution
    /// of a workflow. This operation creates a workflow run that executes the tasks that
    /// are defined in the workflow. Amazon Managed Workflows for Apache Airflow Serverless
    /// schedules the workflow execution across its managed Airflow environment, automatically
    /// scaling ECS worker tasks based on the workload. The service handles task isolation,
    /// dependency resolution, and provides comprehensive monitoring and logging throughout
    /// the execution lifecycle.
    /// </summary>
    public partial class StartWorkflowRunRequest : AmazonMWAAServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. This token prevents duplicate workflow run requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property OverrideParameters. 
        /// <para>
        /// Optional parameters to override default workflow parameters for this specific run.
        /// These parameters are passed to the workflow during execution and can be used to customize
        /// behavior without modifying the workflow definition. Parameters are made available
        /// as environment variables to tasks and you can reference them within the YAML workflow
        /// definition using standard parameter substitution syntax.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, Amazon.Runtime.Documents.Document> OverrideParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Checks to see if the OverrideParameters property is set.
        /// </summary>
        internal bool IsSetOverrideParameters() => this.OverrideParameters != null && (this.OverrideParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow you want to run.
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
        /// Optional. The specific version of the workflow to execute. If not specified, the latest
        /// version is used.
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
