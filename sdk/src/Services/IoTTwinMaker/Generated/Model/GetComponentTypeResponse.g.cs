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
    /// This is the response object from the GetComponentType operation.
    /// </summary>
    public partial class GetComponentTypeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the component type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ComponentTypeId. 
        /// <para>
        /// The ID of the component type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ComponentTypeId { get; set; }

        /// <summary>
        /// Checks to see if the ComponentTypeId property is set.
        /// </summary>
        internal bool IsSetComponentTypeId() => this.ComponentTypeId != null;

        /// <summary>
        /// Gets and sets the property ComponentTypeName. 
        /// <para>
        /// The component type name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ComponentTypeName { get; set; }

        /// <summary>
        /// Checks to see if the ComponentTypeName property is set.
        /// </summary>
        internal bool IsSetComponentTypeName() => this.ComponentTypeName != null;

        /// <summary>
        /// Gets and sets the property CompositeComponentTypes. 
        /// <para>
        /// This is an object that maps strings to <c>compositeComponentTypes</c> of the <c>componentType</c>.
        /// <c>CompositeComponentType</c> is referenced by <c>componentTypeId</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, CompositeComponentTypeResponse> CompositeComponentTypes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CompositeComponentTypeResponse>() : null;

        /// <summary>
        /// Checks to see if the CompositeComponentTypes property is set.
        /// </summary>
        internal bool IsSetCompositeComponentTypes() => this.CompositeComponentTypes != null && (this.CompositeComponentTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time when the component type was created.
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
        /// The description of the component type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExtendsFrom. 
        /// <para>
        /// The name of the parent component type that this component type extends.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExtendsFrom { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExtendsFrom property is set.
        /// </summary>
        internal bool IsSetExtendsFrom() => this.ExtendsFrom != null && (this.ExtendsFrom.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Functions. 
        /// <para>
        /// An object that maps strings to the functions in the component type. Each string in
        /// the mapping must be unique to this object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, FunctionResponse> Functions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, FunctionResponse>() : null;

        /// <summary>
        /// Checks to see if the Functions property is set.
        /// </summary>
        internal bool IsSetFunctions() => this.Functions != null && (this.Functions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsAbstract. 
        /// <para>
        /// A Boolean value that specifies whether the component type is abstract.
        /// </para>
        /// </summary>
        public bool? IsAbstract { get; set; }

        /// <summary>
        /// Checks to see if the IsAbstract property is set.
        /// </summary>
        internal bool IsSetIsAbstract() => this.IsAbstract.HasValue;

        /// <summary>
        /// Gets and sets the property IsSchemaInitialized. 
        /// <para>
        /// A Boolean value that specifies whether the component type has a schema initializer
        /// and that the schema initializer has run.
        /// </para>
        /// </summary>
        public bool? IsSchemaInitialized { get; set; }

        /// <summary>
        /// Checks to see if the IsSchemaInitialized property is set.
        /// </summary>
        internal bool IsSetIsSchemaInitialized() => this.IsSchemaInitialized.HasValue;

        /// <summary>
        /// Gets and sets the property IsSingleton. 
        /// <para>
        /// A Boolean value that specifies whether an entity can have more than one component
        /// of this type.
        /// </para>
        /// </summary>
        public bool? IsSingleton { get; set; }

        /// <summary>
        /// Checks to see if the IsSingleton property is set.
        /// </summary>
        internal bool IsSetIsSingleton() => this.IsSingleton.HasValue;

        /// <summary>
        /// Gets and sets the property PropertyDefinitions. 
        /// <para>
        /// An object that maps strings to the property definitions in the component type. Each
        /// string in the mapping must be unique to this object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PropertyDefinitionResponse> PropertyDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, PropertyDefinitionResponse>() : null;

        /// <summary>
        /// Checks to see if the PropertyDefinitions property is set.
        /// </summary>
        internal bool IsSetPropertyDefinitions() => this.PropertyDefinitions != null && (this.PropertyDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PropertyGroups. 
        /// <para>
        /// The maximum number of results to return at one time. The default is 25.
        /// </para>
        ///  
        /// <para>
        /// Valid Range: Minimum value of 1. Maximum value of 250.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PropertyGroupResponse> PropertyGroups { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, PropertyGroupResponse>() : null;

        /// <summary>
        /// Checks to see if the PropertyGroups property is set.
        /// </summary>
        internal bool IsSetPropertyGroups() => this.PropertyGroups != null && (this.PropertyGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the component type.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SyncSource. 
        /// <para>
        /// The syncSource of the SyncJob, if this entity was created by a SyncJob.
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
        /// The date and time when the component was last updated.
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
        /// The ID of the workspace that contains the component type.
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
