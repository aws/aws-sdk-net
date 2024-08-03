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
    /// for a test result before allowing the run to enter the deployment stage.
    /// </summary>
    public partial class RuleDeclaration
    {
        private Dictionary<string, string> _configuration = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<InputArtifact> _inputArtifacts = AWSConfigs.InitializeCollections ? new List<InputArtifact>() : null;
        private string _name;
        private string _region;
        private string _roleArn;
        private RuleTypeId _ruleTypeId;
        private int? _timeoutInMinutes;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The action configuration fields for the rule.
        /// </para>
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
        /// The name of the rule that is created for the condition, such as CheckAllResults.
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