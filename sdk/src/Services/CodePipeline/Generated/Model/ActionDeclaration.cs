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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about an action declaration.
    /// </summary>
    public partial class ActionDeclaration
    {
        private ActionTypeId _actionTypeId;
        private Dictionary<string, string> _configuration = new Dictionary<string, string>();
        private List<InputArtifact> _inputArtifacts = new List<InputArtifact>();
        private string _name;
        private string _awsNamespace;
        private List<OutputArtifact> _outputArtifacts = new List<OutputArtifact>();
        private string _region;
        private string _roleArn;
        private int? _runOrder;

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
        ///  <code>"Configuration" : { Key : Value },</code> 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null && this._configuration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputArtifacts. 
        /// <para>
        /// The name or ID of the artifact consumed by the action, such as a test or build artifact.
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
            return this._inputArtifacts != null && this._inputArtifacts.Count > 0; 
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
        /// </summary>
        public List<OutputArtifact> OutputArtifacts
        {
            get { return this._outputArtifacts; }
            set { this._outputArtifacts = value; }
        }

        // Check to see if OutputArtifacts property is set
        internal bool IsSetOutputArtifacts()
        {
            return this._outputArtifacts != null && this._outputArtifacts.Count > 0; 
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
        public int RunOrder
        {
            get { return this._runOrder.GetValueOrDefault(); }
            set { this._runOrder = value; }
        }

        // Check to see if RunOrder property is set
        internal bool IsSetRunOrder()
        {
            return this._runOrder.HasValue; 
        }

    }
}