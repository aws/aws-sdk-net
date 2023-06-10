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
    /// This is the response object from the CreateWorkflow operation.
    /// </summary>
    public partial class CreateWorkflowResponse : AmazonWebServiceResponse
    {
        private string _adsApplicationConfigurationId;
        private string _arn;
        private DateTime? _creationTime;
        private string _description;
        private string _id;
        private string _name;
        private MigrationWorkflowStatusEnum _status;
        private List<string> _stepTargets = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _templateId;
        private Dictionary<string, StepInput> _workflowInputs = new Dictionary<string, StepInput>();

        /// <summary>
        /// Gets and sets the property AdsApplicationConfigurationId. 
        /// <para>
        /// The configuration ID of the application configured in Application Discovery Service.
        /// </para>
        /// </summary>
        public string AdsApplicationConfigurationId
        {
            get { return this._adsApplicationConfigurationId; }
            set { this._adsApplicationConfigurationId = value; }
        }

        // Check to see if AdsApplicationConfigurationId property is set
        internal bool IsSetAdsApplicationConfigurationId()
        {
            return this._adsApplicationConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the migration workflow.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the migration workflow was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the migration workflow.
        /// </para>
        /// </summary>
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
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the migration workflow.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the migration workflow.
        /// </para>
        /// </summary>
        public MigrationWorkflowStatusEnum Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
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

        /// <summary>
        /// Gets and sets the property WorkflowInputs. 
        /// <para>
        /// The inputs for creating a migration workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, StepInput> WorkflowInputs
        {
            get { return this._workflowInputs; }
            set { this._workflowInputs = value; }
        }

        // Check to see if WorkflowInputs property is set
        internal bool IsSetWorkflowInputs()
        {
            return this._workflowInputs != null && this._workflowInputs.Count > 0; 
        }

    }
}