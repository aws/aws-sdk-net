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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
        private ActionTypeId _actionTypeId;
        private List<string> _commands = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _configuration = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<EnvironmentVariable> _environmentVariables = AWSConfigs.InitializeCollections ? new List<EnvironmentVariable>() : null;
        private List<InputArtifact> _inputArtifacts = AWSConfigs.InitializeCollections ? new List<InputArtifact>() : null;
        private string _name;
        private string _awsNamespace;
        private List<OutputArtifact> _outputArtifacts = AWSConfigs.InitializeCollections ? new List<OutputArtifact>() : null;
        private List<string> _outputVariables = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _region;
        private string _roleArn;
        private int? _runOrder;
        private int? _timeoutInMinutes;

        /// <summary>
        /// Gets and sets the property ActionTypeId. 
        /// <para>
        /// Specifies the action type and the provider of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionTypeId ActionTypeId
        {
            get { return this._actionTypeId; }
            set { this._actionTypeId = value; }
        }

        // Check to see if ActionTypeId property is set
        internal bool IsSetActionTypeId()
        {
            return this._actionTypeId != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> Commands
        {
            get { return this._commands; }
            set { this._commands = value; }
        }

        // Check to see if Commands property is set
        internal bool IsSetCommands()
        {
            return this._commands != null && (this._commands.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The action's configuration. These are key-value pairs that specify input values for
        /// an action. For more information, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html#action-requirements">Action
        /// Structure Requirements in CodePipeline</a>. For the list of configuration properties
        /// for the CloudFormation action type in CodePipeline, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/continuous-delivery-codepipeline-action-reference.html">Configuration
        /// Properties Reference</a> in the <i>CloudFormation User Guide</i>. For template snippets
        /// with examples, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/continuous-delivery-codepipeline-parameter-override-functions.html">Using
        /// Parameter Override Functions with CodePipeline Pipelines</a> in the <i>CloudFormation
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null && (this._configuration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// The environment variables for the action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<EnvironmentVariable> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InputArtifacts. 
        /// <para>
        /// The name or ID of the artifact consumed by the action, such as a test or build artifact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputArtifact> InputArtifacts
        {
            get { return this._inputArtifacts; }
            set { this._inputArtifacts = value; }
        }

        // Check to see if InputArtifacts property is set
        internal bool IsSetInputArtifacts()
        {
            return this._inputArtifacts != null && (this._inputArtifacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The action declaration's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The variable namespace associated with the action. All variables produced as output
        /// by this action fall under this namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property OutputArtifacts. 
        /// <para>
        /// The name or ID of the result of the action declaration, such as a test or build artifact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputArtifact> OutputArtifacts
        {
            get { return this._outputArtifacts; }
            set { this._outputArtifacts = value; }
        }

        // Check to see if OutputArtifacts property is set
        internal bool IsSetOutputArtifacts()
        {
            return this._outputArtifacts != null && (this._outputArtifacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutputVariables. 
        /// <para>
        /// The list of variables that are to be exported from the compute action. This is specifically
        /// CodeBuild environment variables as used for that action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public List<string> OutputVariables
        {
            get { return this._outputVariables; }
            set { this._outputVariables = value; }
        }

        // Check to see if OutputVariables property is set
        internal bool IsSetOutputVariables()
        {
            return this._outputVariables != null && (this._outputVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The action declaration's Amazon Web Services Region, such as us-east-1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=30)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM service role that performs the declared action. This is assumed
        /// through the roleArn for the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// Gets and sets the property RunOrder. 
        /// <para>
        /// The order in which actions are run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=999)]
        public int? RunOrder
        {
            get { return this._runOrder; }
            set { this._runOrder = value; }
        }

        // Check to see if RunOrder property is set
        internal bool IsSetRunOrder()
        {
            return this._runOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// A timeout duration in minutes that can be applied against the ActionType’s default
        /// timeout value specified in <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/limits.html">Quotas
        /// for CodePipeline </a>. This attribute is available only to the manual approval ActionType.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=86400)]
        public int? TimeoutInMinutes
        {
            get { return this._timeoutInMinutes; }
            set { this._timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this._timeoutInMinutes.HasValue; 
        }

    }
}