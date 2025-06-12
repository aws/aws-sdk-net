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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// The summary of the step.
    /// </summary>
    public partial class TemplateStepSummary
    {
        private string _id;
        private string _name;
        private List<string> _next = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Owner _owner;
        private List<string> _previous = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private StepActionType _stepActionType;
        private string _stepGroupId;
        private TargetType _targetType;
        private string _templateId;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the step.
        /// </para>
        /// </summary>
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
        /// The name of the step.
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
        /// Gets and sets the property Next. 
        /// <para>
        /// The next step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Next
        {
            get { return this._next; }
            set { this._next = value; }
        }

        // Check to see if Next property is set
        internal bool IsSetNext()
        {
            return this._next != null && (this._next.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the step.
        /// </para>
        /// </summary>
        public Owner Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Previous. 
        /// <para>
        /// The previous step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Previous
        {
            get { return this._previous; }
            set { this._previous = value; }
        }

        // Check to see if Previous property is set
        internal bool IsSetPrevious()
        {
            return this._previous != null && (this._previous.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StepActionType. 
        /// <para>
        /// The action type of the step. You must run and update the status of a manual step for
        /// the workflow to continue after the completion of the step.
        /// </para>
        /// </summary>
        public StepActionType StepActionType
        {
            get { return this._stepActionType; }
            set { this._stepActionType = value; }
        }

        // Check to see if StepActionType property is set
        internal bool IsSetStepActionType()
        {
            return this._stepActionType != null;
        }

        /// <summary>
        /// Gets and sets the property StepGroupId. 
        /// <para>
        /// The ID of the step group.
        /// </para>
        /// </summary>
        public string StepGroupId
        {
            get { return this._stepGroupId; }
            set { this._stepGroupId = value; }
        }

        // Check to see if StepGroupId property is set
        internal bool IsSetStepGroupId()
        {
            return this._stepGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The servers on which to run the script.
        /// </para>
        /// </summary>
        public TargetType TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
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

    }
}