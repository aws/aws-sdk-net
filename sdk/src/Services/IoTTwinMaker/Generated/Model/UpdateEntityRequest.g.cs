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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEntity operation. Updates an entity.
    /// </summary>
    public partial class UpdateEntityRequest : AmazonIoTTwinMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ComponentUpdates. 
        /// <para>
        /// An object that maps strings to the component updates in the request. Each string in
        /// the mapping must be unique to this object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentUpdateRequest> ComponentUpdates { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentUpdateRequest>() : null;

        /// <summary>
        /// Checks to see if the ComponentUpdates property is set.
        /// </summary>
        internal bool IsSetComponentUpdates() => this.ComponentUpdates != null && (this.ComponentUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CompositeComponentUpdates. 
        /// <para>
        /// This is an object that maps strings to <c>compositeComponent</c> updates in the request.
        /// Each key of the map represents the <c>componentPath</c> of the <c>compositeComponent</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, CompositeComponentUpdateRequest> CompositeComponentUpdates { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CompositeComponentUpdateRequest>() : null;

        /// <summary>
        /// Checks to see if the CompositeComponentUpdates property is set.
        /// </summary>
        internal bool IsSetCompositeComponentUpdates() => this.CompositeComponentUpdates != null && (this.CompositeComponentUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The ID of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property EntityName. 
        /// <para>
        /// The name of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string EntityName { get; set; }

        /// <summary>
        /// Checks to see if the EntityName property is set.
        /// </summary>
        internal bool IsSetEntityName() => this.EntityName != null;

        /// <summary>
        /// Gets and sets the property ParentEntityUpdate. 
        /// <para>
        /// An object that describes the update request for a parent entity.
        /// </para>
        /// </summary>
        public ParentEntityUpdateRequest ParentEntityUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ParentEntityUpdate property is set.
        /// </summary>
        internal bool IsSetParentEntityUpdate() => this.ParentEntityUpdate != null;

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace that contains the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceId() => this.WorkspaceId != null;
    }
}
