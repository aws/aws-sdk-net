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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// This is the response object from the GetEntity operation.
    /// </summary>
    public partial class GetEntityResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private Dictionary<string, ComponentResponse> _components = new Dictionary<string, ComponentResponse>();
        private DateTime? _creationDateTime;
        private string _description;
        private string _entityId;
        private string _entityName;
        private bool? _hasChildEntities;
        private string _parentEntityId;
        private Status _status;
        private string _syncSource;
        private DateTime? _updateDateTime;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property Components. 
        /// <para>
        /// An object that maps strings to the components in the entity. Each string in the mapping
        /// must be unique to this object.
        /// </para>
        /// </summary>
        public Dictionary<string, ComponentResponse> Components
        {
            get { return this._components; }
            set { this._components = value; }
        }

        // Check to see if Components property is set
        internal bool IsSetComponents()
        {
            return this._components != null && this._components.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time when the entity was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationDateTime
        {
            get { return this._creationDateTime.GetValueOrDefault(); }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The ID of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property EntityName. 
        /// <para>
        /// The name of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string EntityName
        {
            get { return this._entityName; }
            set { this._entityName = value; }
        }

        // Check to see if EntityName property is set
        internal bool IsSetEntityName()
        {
            return this._entityName != null;
        }

        /// <summary>
        /// Gets and sets the property HasChildEntities. 
        /// <para>
        /// A Boolean value that specifies whether the entity has associated child entities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool HasChildEntities
        {
            get { return this._hasChildEntities.GetValueOrDefault(); }
            set { this._hasChildEntities = value; }
        }

        // Check to see if HasChildEntities property is set
        internal bool IsSetHasChildEntities()
        {
            return this._hasChildEntities.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParentEntityId. 
        /// <para>
        /// The ID of the parent entity for this entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ParentEntityId
        {
            get { return this._parentEntityId; }
            set { this._parentEntityId = value; }
        }

        // Check to see if ParentEntityId property is set
        internal bool IsSetParentEntityId()
        {
            return this._parentEntityId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Status
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
        /// Gets and sets the property SyncSource. 
        /// <para>
        /// The syncSource of the sync job, if this entity was created by a sync job.
        /// </para>
        /// </summary>
        public string SyncSource
        {
            get { return this._syncSource; }
            set { this._syncSource = value; }
        }

        // Check to see if SyncSource property is set
        internal bool IsSetSyncSource()
        {
            return this._syncSource != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateDateTime. 
        /// <para>
        /// The date and time when the entity was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdateDateTime
        {
            get { return this._updateDateTime.GetValueOrDefault(); }
            set { this._updateDateTime = value; }
        }

        // Check to see if UpdateDateTime property is set
        internal bool IsSetUpdateDateTime()
        {
            return this._updateDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}