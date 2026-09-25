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
    /// Container for the parameters to the UpdateComponentType operation. Updates information
    /// in a component type.
    /// </summary>
    public partial class UpdateComponentTypeRequest : AmazonIoTTwinMakerRequest
    {
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
        public Dictionary<string, CompositeComponentTypeRequest> CompositeComponentTypes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CompositeComponentTypeRequest>() : null;

        /// <summary>
        /// Checks to see if the CompositeComponentTypes property is set.
        /// </summary>
        internal bool IsSetCompositeComponentTypes() => this.CompositeComponentTypes != null && (this.CompositeComponentTypes.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Specifies the component type that this component type extends.
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
        public Dictionary<string, FunctionRequest> Functions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, FunctionRequest>() : null;

        /// <summary>
        /// Checks to see if the Functions property is set.
        /// </summary>
        internal bool IsSetFunctions() => this.Functions != null && (this.Functions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public Dictionary<string, PropertyDefinitionRequest> PropertyDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, PropertyDefinitionRequest>() : null;

        /// <summary>
        /// Checks to see if the PropertyDefinitions property is set.
        /// </summary>
        internal bool IsSetPropertyDefinitions() => this.PropertyDefinitions != null && (this.PropertyDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PropertyGroups. 
        /// <para>
        /// The property groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PropertyGroupRequest> PropertyGroups { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, PropertyGroupRequest>() : null;

        /// <summary>
        /// Checks to see if the PropertyGroups property is set.
        /// </summary>
        internal bool IsSetPropertyGroups() => this.PropertyGroups != null && (this.PropertyGroups.Count > 0 || !AWSConfigs.InitializeCollections);

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
