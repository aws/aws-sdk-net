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
    /// This is the response object from the GetWorkflow operation.
    /// </summary>
    public partial class GetWorkflowResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The Amazon S3 location of the code artifacts provided during workflow creation or
        /// update.
        /// </para>
        /// </summary>
        public Code Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property CodeSnapshottedAt. 
        /// <para>
        /// The time at which the code artifacts were copied for this workflow, in ISO 8601 date-time
        /// format.
        /// </para>
        /// </summary>
        public DateTime? CodeSnapshottedAt { get; set; }

        /// <summary>
        /// Checks to see if the CodeSnapshottedAt property is set.
        /// </summary>
        internal bool IsSetCodeSnapshottedAt() => this.CodeSnapshottedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the workflow was created, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DefinitionS3Location. 
        /// <para>
        /// The Amazon S3 location of the workflow definition file.
        /// </para>
        /// </summary>
        public DefinitionS3Location DefinitionS3Location { get; set; }

        /// <summary>
        /// Checks to see if the DefinitionS3Location property is set.
        /// </summary>
        internal bool IsSetDefinitionS3Location() => this.DefinitionS3Location != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for the workflow.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the Amazon Managed Workflows for Apache Airflow Serverless engine that
        /// this workflow uses.
        /// </para>
        /// </summary>
        public int? EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion.HasValue;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The logging configuration for the workflow.
        /// </para>
        /// </summary>
        public LoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The timestamp when the workflow was last modified, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the workflow execution environment.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used for workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// The schedule configuration for the workflow, including cron expressions for automated
        /// execution. Amazon Managed Workflows for Apache Airflow Serverless uses EventBridge
        /// Scheduler for cost-effective, timezone-aware scheduling. When a workflow includes
        /// schedule information in its YAML definition, the service automatically configures
        /// the appropriate triggers for automated execution. Only one version of a workflow can
        /// have an active schedule at any given time.
        /// </para>
        /// </summary>
        public ScheduleConfiguration ScheduleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleConfiguration property is set.
        /// </summary>
        internal bool IsSetScheduleConfiguration() => this.ScheduleConfiguration != null;

        /// <summary>
        /// Gets and sets the property TriggerMode. 
        /// <para>
        /// The trigger mode for the workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TriggerMode { get; set; }

        /// <summary>
        /// Checks to see if the TriggerMode property is set.
        /// </summary>
        internal bool IsSetTriggerMode() => this.TriggerMode != null;

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string WorkflowArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowArn property is set.
        /// </summary>
        internal bool IsSetWorkflowArn() => this.WorkflowArn != null;

        /// <summary>
        /// Gets and sets the property WorkflowDefinition. 
        /// <para>
        /// The workflow definition content.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string WorkflowDefinition { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowDefinition property is set.
        /// </summary>
        internal bool IsSetWorkflowDefinition() => this.WorkflowDefinition != null;

        /// <summary>
        /// Gets and sets the property WorkflowStatus. 
        /// <para>
        /// The current status of the workflow.
        /// </para>
        /// </summary>
        public WorkflowStatus WorkflowStatus { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowStatus property is set.
        /// </summary>
        internal bool IsSetWorkflowStatus() => this.WorkflowStatus != null;

        /// <summary>
        /// Gets and sets the property WorkflowVersion. 
        /// <para>
        /// The version identifier of the workflow.
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
