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
 * Do not modify this file. This file is generated from the migrationhuborchestrator-2021-08-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorkflow operation.
    /// Update a migration workflow.
    /// </summary>
    public partial class UpdateWorkflowRequest : AmazonMigrationHubOrchestratorRequest
    {
        private string _description;
        private string _id;
        private Dictionary<string, StepInput> _inputParameters = new Dictionary<string, StepInput>();
        private string _name;
        private List<string> _stepTargets = new List<string>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the migration workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the migration workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InputParameters. 
        /// <para>
        /// The input parameters required to update a migration workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, StepInput> InputParameters
        {
            get { return this._inputParameters; }
            set { this._inputParameters = value; }
        }

        // Check to see if InputParameters property is set
        internal bool IsSetInputParameters()
        {
            return this._inputParameters != null && this._inputParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the migration workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property StepTargets. 
        /// <para>
        /// The servers on which a step will be run.
        /// </para>
        /// </summary>
        public List<string> StepTargets
        {
            get { return this._stepTargets; }
            set { this._stepTargets = value; }
        }

        // Check to see if StepTargets property is set
        internal bool IsSetStepTargets()
        {
            return this._stepTargets != null && this._stepTargets.Count > 0; 
        }

    }
}