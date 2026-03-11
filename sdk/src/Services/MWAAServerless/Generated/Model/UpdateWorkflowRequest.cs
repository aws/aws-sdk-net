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
    /// Container for the parameters to the UpdateWorkflow operation.
    /// Updates an existing workflow with new configuration settings. This operation allows
    /// you to modify the workflow definition, role, and other settings. When you update a
    /// workflow, Amazon Managed Workflows for Apache Airflow Serverless automatically creates
    /// a new version with the updated configuration and disables scheduling on all previous
    /// versions to ensure only one version is actively scheduled at a time. The update operation
    /// maintains workflow history while providing a clean transition to the new configuration.
    /// </summary>
    public partial class UpdateWorkflowRequest : AmazonMWAAServerlessRequest
    {
        private DefinitionS3Location _definitionS3Location;
        private string _description;
        private int? _engineVersion;
        private LoggingConfiguration _loggingConfiguration;
        private NetworkConfiguration _networkConfiguration;
        private string _roleArn;
        private string _triggerMode;
        private string _workflowArn;

        /// <summary>
        /// Gets and sets the property DefinitionS3Location. 
        /// <para>
        /// The Amazon S3 location where the updated workflow definition file is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// An updated description for the workflow.
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the Amazon Managed Workflows for Apache Airflow Serverless engine that
        /// you want to use for the updated workflow.
        /// </para>
        /// </summary>
        public int? EngineVersion
        {
            get { return this._engineVersion; }
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
        /// Updated logging configuration for the workflow.
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
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// Updated network configuration for the workflow execution environment.
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
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon Managed Workflows for Apache
        /// Airflow Serverless assumes when it executes the updated workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// The Amazon Resource Name (ARN) of the workflow you want to update.
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