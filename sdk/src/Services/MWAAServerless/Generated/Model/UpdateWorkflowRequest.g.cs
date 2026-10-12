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
    /// Container for the parameters to the UpdateWorkflow operation. Updates an existing
    /// workflow with new configuration settings. This operation allows you to modify the
    /// workflow definition, role, and other settings. When you update a workflow, Amazon
    /// Managed Workflows for Apache Airflow Serverless automatically creates a new version
    /// with the updated configuration and disables scheduling on all previous versions to
    /// ensure only one version is actively scheduled at a time. The update operation maintains
    /// workflow history while providing a clean transition to the new configuration.
    /// </summary>
    public partial class UpdateWorkflowRequest : AmazonMWAAServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The location of code artifacts in Amazon S3 for the updated workflow. The service
        /// copies the code from this location at the time of the request.
        /// </para>
        /// </summary>
        public Code Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property DefinitionS3Location. 
        /// <para>
        /// The Amazon S3 location where the updated workflow definition file is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DefinitionS3Location DefinitionS3Location { get; set; }

        /// <summary>
        /// Checks to see if the DefinitionS3Location property is set.
        /// </summary>
        internal bool IsSetDefinitionS3Location() => this.DefinitionS3Location != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An updated description for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the Amazon Managed Workflows for Apache Airflow Serverless engine that
        /// you want to use for the updated workflow.
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
        /// Updated logging configuration for the workflow.
        /// </para>
        /// </summary>
        public LoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// Updated network configuration for the workflow execution environment.
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
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon Managed Workflows for Apache
        /// Airflow Serverless assumes when it executes the updated workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

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
        /// The Amazon Resource Name (ARN) of the workflow you want to update.
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
