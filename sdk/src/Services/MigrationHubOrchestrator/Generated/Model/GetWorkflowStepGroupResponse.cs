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
    /// This is the response object from the GetWorkflowStepGroup operation.
    /// </summary>
    public partial class GetWorkflowStepGroupResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _description;
        private DateTime? _endTime;
        private string _id;
        private DateTime? _lastModifiedTime;
        private string _name;
        private List<string> _next = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Owner _owner;
        private List<string> _previous = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private StepGroupStatus _status;
        private List<Tool> _tools = AWSConfigs.InitializeCollections ? new List<Tool>() : null;
        private string _workflowId;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the step group was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
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
        /// The description of the step group.
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the step group ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the step group.
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time at which the step group was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the step group.
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
        /// The next step group.
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
        /// The owner of the step group.
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
        /// The previous step group.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the step group.
        /// </para>
        /// </summary>
        public StepGroupStatus Status
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
        /// Gets and sets the property Tools. 
        /// <para>
        /// List of AWS services utilized in a migration workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tool> Tools
        {
            get { return this._tools; }
            set { this._tools = value; }
        }

        // Check to see if Tools property is set
        internal bool IsSetTools()
        {
            return this._tools != null && (this._tools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The ID of the migration workflow.
        /// </para>
        /// </summary>
        public string WorkflowId
        {
            get { return this._workflowId; }
            set { this._workflowId = value; }
        }

        // Check to see if WorkflowId property is set
        internal bool IsSetWorkflowId()
        {
            return this._workflowId != null;
        }

    }
}