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
    /// This is the response object from the GetEntity operation.
    /// </summary>
    public partial class GetEntityResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AreAllComponentsReturned. 
        /// <para>
        /// This flag notes whether all components are returned in the API response. The maximum
        /// number of components returned is 30.
        /// </para>
        /// </summary>
        public bool? AreAllComponentsReturned { get; set; }

        /// <summary>
        /// Checks to see if the AreAllComponentsReturned property is set.
        /// </summary>
        internal bool IsSetAreAllComponentsReturned() => this.AreAllComponentsReturned.HasValue;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Components. 
        /// <para>
        /// An object that maps strings to the components in the entity. Each string in the mapping
        /// must be unique to this object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentResponse> Components { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentResponse>() : null;

        /// <summary>
        /// Checks to see if the Components property is set.
        /// </summary>
        internal bool IsSetComponents() => this.Components != null && (this.Components.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time when the entity was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

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
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string EntityName { get; set; }

        /// <summary>
        /// Checks to see if the EntityName property is set.
        /// </summary>
        internal bool IsSetEntityName() => this.EntityName != null;

        /// <summary>
        /// Gets and sets the property HasChildEntities. 
        /// <para>
        /// A Boolean value that specifies whether the entity has associated child entities.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? HasChildEntities { get; set; }

        /// <summary>
        /// Checks to see if the HasChildEntities property is set.
        /// </summary>
        internal bool IsSetHasChildEntities() => this.HasChildEntities.HasValue;

        /// <summary>
        /// Gets and sets the property ParentEntityId. 
        /// <para>
        /// The ID of the parent entity for this entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ParentEntityId { get; set; }

        /// <summary>
        /// Checks to see if the ParentEntityId property is set.
        /// </summary>
        internal bool IsSetParentEntityId() => this.ParentEntityId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SyncSource. 
        /// <para>
        /// The syncSource of the sync job, if this entity was created by a sync job.
        /// </para>
        /// </summary>
        public string SyncSource { get; set; }

        /// <summary>
        /// Checks to see if the SyncSource property is set.
        /// </summary>
        internal bool IsSetSyncSource() => this.SyncSource != null;

        /// <summary>
        /// Gets and sets the property UpdateDateTime. 
        /// <para>
        /// The date and time when the entity was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateDateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDateTime property is set.
        /// </summary>
        internal bool IsSetUpdateDateTime() => this.UpdateDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace.
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
