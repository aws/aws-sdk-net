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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about an action declaration.
    /// </summary>
    public partial class ActionDeclaration
    {
        /// <summary>
        /// Gets and sets the property ActionTypeId. 
        /// <para>
        /// Specifies the action type and the provider of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionTypeId ActionTypeId { get; set; }

        /// <summary>
        /// Checks to see if the ActionTypeId property is set.
        /// </summary>
        internal bool IsSetActionTypeId() => this.ActionTypeId != null;

        /// <summary>
        /// Gets and sets the property Commands. 
        /// <para>
        /// The shell commands to run with your compute action in CodePipeline. All commands are
        /// supported except multi-line formats. While CodeBuild logs and permissions are used,
        /// you do not need to create any resources in CodeBuild.
        /// </para>
        ///  <note> 
        /// <para>
        /// Using compute time for this action will incur separate charges in CodeBuild.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> Commands { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Commands property is set.
        /// </summary>
        internal bool IsSetCommands() => this.Commands != null && (this.Commands.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The action's configuration. These are key-value pairs that specify input values for
        /// an action. For more information, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html#action-requirements">Action
        /// Structure Requirements in CodePipeline </a>. For the list of configuration properties
        /// for the CloudFormation action type in CodePipeline, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/continuous-delivery-codepipeline-action-reference.html">Configuration
        /// Properties Reference</a> in the <i> CloudFormation User Guide</i>. For template snippets
        /// with examples, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/continuous-delivery-codepipeline-parameter-override-functions.html">Using
        /// Parameter Override Functions with CodePipeline Pipelines</a> in the <i> CloudFormation
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The values can be represented in either JSON or YAML format. For example, the JSON
        /// configuration item format is as follows: 
        /// </para>
        ///  
        /// <para>
        ///  <i>JSON:</i> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"Configuration" : { Key : Value },</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Configuration { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null && (this.Configuration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// The environment variables for the action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<EnvironmentVariable> EnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new List<EnvironmentVariable>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetEnvironmentVariables() => this.EnvironmentVariables != null && (this.EnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InputArtifacts. 
        /// <para>
        /// The name or ID of the artifact consumed by the action, such as a test or build artifact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputArtifact> InputArtifacts { get; set; } = AWSConfigs.InitializeCollections ? new List<InputArtifact>() : null;

        /// <summary>
        /// Checks to see if the InputArtifacts property is set.
        /// </summary>
        internal bool IsSetInputArtifacts() => this.InputArtifacts != null && (this.InputArtifacts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The action declaration's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The variable namespace associated with the action. All variables produced as output
        /// by this action fall under this namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property OutputArtifacts. 
        /// <para>
        /// The name or ID of the result of the action declaration, such as a test or build artifact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputArtifact> OutputArtifacts { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputArtifact>() : null;

        /// <summary>
        /// Checks to see if the OutputArtifacts property is set.
        /// </summary>
        internal bool IsSetOutputArtifacts() => this.OutputArtifacts != null && (this.OutputArtifacts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputVariables. 
        /// <para>
        /// The list of variables that are to be exported from the compute action. This is specifically
        /// CodeBuild environment variables as used for that action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public List<string> OutputVariables { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OutputVariables property is set.
        /// </summary>
        internal bool IsSetOutputVariables() => this.OutputVariables != null && (this.OutputVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The action declaration's Amazon Web Services Region, such as us-east-1.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 30)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM service role that performs the declared action. This is assumed
        /// through the roleArn for the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property RunOrder. 
        /// <para>
        /// The order in which actions are run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 999)]
        public int? RunOrder { get; set; }

        /// <summary>
        /// Checks to see if the RunOrder property is set.
        /// </summary>
        internal bool IsSetRunOrder() => this.RunOrder.HasValue;

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// A timeout duration in minutes that can be applied against the ActionType’s default
        /// timeout value specified in <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/limits.html">Quotas
        /// for CodePipeline </a>. This attribute is available only to the manual approval ActionType.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 86400)]
        public int? TimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetTimeoutInMinutes() => this.TimeoutInMinutes.HasValue;
    }
}
