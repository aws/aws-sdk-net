/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        private List<OutputArtifact> _outputArtifacts = new List<OutputArtifact>();
        private string _roleArn;
        private int? _runOrder;

        /// <summary>
        /// Gets and sets the property ActionTypeId. 
        /// <para>
        /// The configuration information for the action type.
        /// </para>
        /// </summary>
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
        /// The action declaration's configuration.
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM service role that will perform the declared action. This is assumed
        /// through the roleArn for the pipeline.
        /// </para>
        /// </summary>
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