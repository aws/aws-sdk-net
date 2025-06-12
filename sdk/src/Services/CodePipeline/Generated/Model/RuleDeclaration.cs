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
    /// Represents information about the rule to be created for an associated condition. An
    /// example would be creating a new rule for an entry condition, such as a rule that checks
    /// for a test result before allowing the run to enter the deployment stage. For more
    /// information about conditions, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/stage-conditions.html">Stage
    /// conditions</a> and <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/concepts-how-it-works-conditions.html">How
    /// do stage conditions work?</a>. For more information about rules, see the <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/rule-reference.html">CodePipeline
    /// rule reference</a>.
    /// </summary>
    public partial class RuleDeclaration
    {
        private List<string> _commands = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _configuration = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<InputArtifact> _inputArtifacts = AWSConfigs.InitializeCollections ? new List<InputArtifact>() : null;
        private string _name;
        private string _region;
        private string _roleArn;
        private RuleTypeId _ruleTypeId;
        private int? _timeoutInMinutes;

        /// <summary>
        /// Gets and sets the property Commands. 
        /// <para>
        /// The shell commands to run with your commands rule in CodePipeline. All commands are
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
        /// The action configuration fields for the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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
        /// Gets and sets the property InputArtifacts. 
        /// <para>
        /// The input artifacts fields for the rule, such as specifying an input file for the
        /// rule.
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
        /// The name of the rule that is created for the condition, such as <c>VariableCheck</c>.
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region for the condition associated with the rule.
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
        /// The pipeline role ARN associated with the rule.
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
        /// Gets and sets the property RuleTypeId. 
        /// <para>
        /// The ID for the rule type, which is made up of the combined values for category, owner,
        /// provider, and version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleTypeId RuleTypeId
        {
            get { return this._ruleTypeId; }
            set { this._ruleTypeId = value; }
        }

        // Check to see if RuleTypeId property is set
        internal bool IsSetRuleTypeId()
        {
            return this._ruleTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// The action timeout for the rule.
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