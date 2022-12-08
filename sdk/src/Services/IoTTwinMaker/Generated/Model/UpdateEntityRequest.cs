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
    /// Container for the parameters to the UpdateEntity operation.
    /// Updates an entity.
    /// </summary>
    public partial class UpdateEntityRequest : AmazonIoTTwinMakerRequest
    {
        private Dictionary<string, ComponentUpdateRequest> _componentUpdates = new Dictionary<string, ComponentUpdateRequest>();
        private string _description;
        private string _entityId;
        private string _entityName;
        private ParentEntityUpdateRequest _parentEntityUpdate;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property ComponentUpdates. 
        /// <para>
        /// An object that maps strings to the component updates in the request. Each string in
        /// the mapping must be unique to this object.
        /// </para>
        /// </summary>
        public Dictionary<string, ComponentUpdateRequest> ComponentUpdates
        {
            get { return this._componentUpdates; }
            set { this._componentUpdates = value; }
        }

        // Check to see if ComponentUpdates property is set
        internal bool IsSetComponentUpdates()
        {
            return this._componentUpdates != null && this._componentUpdates.Count > 0; 
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
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property ParentEntityUpdate. 
        /// <para>
        /// An object that describes the update request for a parent entity.
        /// </para>
        /// </summary>
        public ParentEntityUpdateRequest ParentEntityUpdate
        {
            get { return this._parentEntityUpdate; }
            set { this._parentEntityUpdate = value; }
        }

        // Check to see if ParentEntityUpdate property is set
        internal bool IsSetParentEntityUpdate()
        {
            return this._parentEntityUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace that contains the entity.
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