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
    /// Container for the parameters to the CreateWorkflow operation. Creates a new workflow
    /// in Amazon Managed Workflows for Apache Airflow Serverless. This operation initializes
    /// a workflow with the specified configuration including the workflow definition, execution
    /// role, and optional settings for encryption, logging, and networking. You must provide
    /// the workflow definition as a YAML file stored in Amazon S3 that defines the DAG structure
    /// using supported Amazon Web Services operators. Amazon Managed Workflows for Apache
    /// Airflow Serverless automatically creates the first version of the workflow and sets
    /// up the necessary execution environment with multi-tenant isolation and security controls.
    /// </summary>
    public partial class CreateWorkflowRequest : AmazonMWAAServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. This token prevents duplicate workflow creation requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The location of code artifacts in Amazon S3 for the workflow. The service copies the
        /// code from this location at the time of the request.
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
        /// The Amazon S3 location where the workflow definition file is stored. This must point
        /// to a valid YAML file that defines the workflow structure using supported Amazon Web
        /// Services operators and tasks. Amazon Managed Workflows for Apache Airflow Serverless
        /// takes a snapshot of the definition at creation time, so subsequent changes to the
        /// Amazon S3 object will not affect the workflow unless you create a new version. In
        /// your YAML definition, include task dependencies, scheduling information, and operator
        /// configurations that are compatible with the Amazon Managed Workflows for Apache Airflow
        /// Serverless execution environment.
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
        /// An optional description of the workflow that you can use to provide additional context
        /// about the workflow's purpose and functionality.
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
        /// The configuration for encrypting workflow data at rest and in transit. Specifies the
        /// encryption type and optional KMS key for customer-managed encryption.
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
        /// you want to use for this workflow. This determines the feature set, supported operators,
        /// and execution environment capabilities available to your workflow. Amazon Managed
        /// Workflows for Apache Airflow Serverless maintains backward compatibility across versions
        /// while introducing new features and improvements. Currently supports version 1 with
        /// plans for additional versions as the service evolves.
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
        /// The configuration for workflow logging. Specifies the CloudWatch log group where workflow
        /// execution logs are stored. Amazon Managed Workflows for Apache Airflow Serverless
        /// automatically exports worker logs and task-level information to the specified log
        /// group in your account using remote logging functionality. This provides comprehensive
        /// observability for debugging and monitoring workflow execution across the distributed,
        /// serverless environment.
        /// </para>
        /// </summary>
        public LoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workflow. You must use unique workflow names within your Amazon Web
        /// Services account. The service generates a unique identifier that is appended to ensure
        /// temporal uniqueness across the account lifecycle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// Network configuration for the workflow execution environment, including VPC security
        /// groups and subnets for secure network access. When specified, Amazon Managed Workflows
        /// for Apache Airflow Serverless deploys ECS worker tasks in your customer VPC to provide
        /// secure connectivity to your resources. If not specified, tasks run in the service's
        /// default worker VPC with network isolation from other customers. This configuration
        /// enables secure access to VPC-only resources like RDS databases or private endpoints.
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
        /// Airflow Serverless assumes when executing the workflow. This role must have the necessary
        /// permissions to access the required Amazon Web Services services and resources that
        /// your workflow tasks will interact with. The role is used for task execution in the
        /// isolated, multi-tenant environment and should follow the principle of least privilege.
        /// Amazon Managed Workflows for Apache Airflow Serverless validates role access during
        /// workflow creation but runtime permission checks are performed by the target services.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tags to assign to the workflow resource. Tags are key-value pairs that are
        /// used for resource organization and cost allocation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
    }
}
