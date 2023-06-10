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
    /// Container for the parameters to the CreateWorkflow operation.
    /// Create a workflow to orchestrate your migrations.
    /// </summary>
    public partial class CreateWorkflowRequest : AmazonMigrationHubOrchestratorRequest
    {
        private string _applicationConfigurationId;
        private string _description;
        private Dictionary<string, StepInput> _inputParameters = new Dictionary<string, StepInput>();
        private string _name;
        private List<string> _stepTargets = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _templateId;

        /// <summary>
        /// Gets and sets the property ApplicationConfigurationId. 
        /// <para>
        /// The configuration ID of the application configured in Application Discovery Service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ApplicationConfigurationId
        {
            get { return this._applicationConfigurationId; }
            set { this._applicationConfigurationId = value; }
        }

        // Check to see if ApplicationConfigurationId property is set
        internal bool IsSetApplicationConfigurationId()
        {
            return this._applicationConfigurationId != null;
        }

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
        /// Gets and sets the property InputParameters. 
        /// <para>
        /// The input parameters required to create a migration workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add on a migration workflow.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The ID of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

    }
}