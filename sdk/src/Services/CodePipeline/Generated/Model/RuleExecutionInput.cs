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
    /// Input information used for a rule execution.
    /// </summary>
    public partial class RuleExecutionInput
    {
        private Dictionary<string, string> _configuration = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<ArtifactDetail> _inputArtifacts = AWSConfigs.InitializeCollections ? new List<ArtifactDetail>() : null;
        private string _region;
        private Dictionary<string, string> _resolvedConfiguration = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _roleArn;
        private RuleTypeId _ruleTypeId;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Configuration data for a rule execution, such as the resolved values for that run.
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
        /// Details of input artifacts of the rule that correspond to the rule execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ArtifactDetail> InputArtifacts
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region for the rule, such as us-east-1.
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
        /// Gets and sets the property ResolvedConfiguration. 
        /// <para>
        /// Configuration data for a rule execution with all variable references replaced with
        /// their real values for the execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ResolvedConfiguration
        {
            get { return this._resolvedConfiguration; }
            set { this._resolvedConfiguration = value; }
        }

        // Check to see if ResolvedConfiguration property is set
        internal bool IsSetResolvedConfiguration()
        {
            return this._resolvedConfiguration != null && (this._resolvedConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM service role that performs the declared rule. This is assumed through
        /// the roleArn for the pipeline.
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
        /// provider, and version. For more information about conditions, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/stage-conditions.html">Stage
        /// conditions</a>. For more information about rules, see the <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/rule-reference.html">CodePipeline
        /// rule reference</a>.
        /// </para>
        /// </summary>
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

    }
}