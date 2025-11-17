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
    /// This is the response object from the GetWorkflow operation.
    /// </summary>
    public partial class GetWorkflowResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private DefinitionS3Location _definitionS3Location;
        private string _description;
        private EncryptionConfiguration _encryptionConfiguration;
        private int? _engineVersion;
        private LoggingConfiguration _loggingConfiguration;
        private DateTime? _modifiedAt;
        private string _name;
        private NetworkConfiguration _networkConfiguration;
        private string _roleArn;
        private ScheduleConfiguration _scheduleConfiguration;
        private string _triggerMode;
        private string _workflowArn;
        private string _workflowDefinition;
        private WorkflowStatus _workflowStatus;
        private string _workflowVersion;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the workflow was created, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefinitionS3Location. 
        /// <para>
        /// The Amazon S3 location of the workflow definition file.
        /// </para>
        /// </summary>
        public DefinitionS3Location DefinitionS3Location
        {
            get { return this._definitionS3Location; }
            set { this._definitionS3Location = value; }
        }

        // Check to see if DefinitionS3Location property is set
        internal bool IsSetDefinitionS3Location()
        {
            return this._definitionS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for the workflow.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the Amazon Managed Workflows for Apache Airflow Serverless engine that
        /// this workflow uses.
        /// </para>
        /// </summary>
        public int EngineVersion
        {
            get { return this._engineVersion.GetValueOrDefault(); }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The logging configuration for the workflow.
        /// </para>
        /// </summary>
        public LoggingConfiguration LoggingConfiguration
        {
            get { return this._loggingConfiguration; }
            set { this._loggingConfiguration = value; }
        }

        // Check to see if LoggingConfiguration property is set
        internal bool IsSetLoggingConfiguration()
        {
            return this._loggingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The timestamp when the workflow was last modified, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime ModifiedAt
        {
            get { return this._modifiedAt.GetValueOrDefault(); }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the workflow execution environment.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used for workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

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
        public ScheduleConfiguration ScheduleConfiguration
        {
            get { return this._scheduleConfiguration; }
            set { this._scheduleConfiguration = value; }
        }

        // Check to see if ScheduleConfiguration property is set
        internal bool IsSetScheduleConfiguration()
        {
            return this._scheduleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerMode. 
        /// <para>
        /// The trigger mode for the workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TriggerMode
        {
            get { return this._triggerMode; }
            set { this._triggerMode = value; }
        }

        // Check to see if TriggerMode property is set
        internal bool IsSetTriggerMode()
        {
            return this._triggerMode != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow.
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

        /// <summary>
        /// Gets and sets the property WorkflowDefinition. 
        /// <para>
        /// The workflow definition content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string WorkflowDefinition
        {
            get { return this._workflowDefinition; }
            set { this._workflowDefinition = value; }
        }

        // Check to see if WorkflowDefinition property is set
        internal bool IsSetWorkflowDefinition()
        {
            return this._workflowDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowStatus. 
        /// <para>
        /// The current status of the workflow.
        /// </para>
        /// </summary>
        public WorkflowStatus WorkflowStatus
        {
            get { return this._workflowStatus; }
            set { this._workflowStatus = value; }
        }

        // Check to see if WorkflowStatus property is set
        internal bool IsSetWorkflowStatus()
        {
            return this._workflowStatus != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowVersion. 
        /// <para>
        /// The version identifier of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=32)]
        public string WorkflowVersion
        {
            get { return this._workflowVersion; }
            set { this._workflowVersion = value; }
        }

        // Check to see if WorkflowVersion property is set
        internal bool IsSetWorkflowVersion()
        {
            return this._workflowVersion != null;
        }

    }
}