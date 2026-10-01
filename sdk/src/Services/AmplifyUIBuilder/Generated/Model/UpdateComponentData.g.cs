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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Updates and saves all of the information about a component, based on component ID.
    /// </summary>
    public partial class UpdateComponentData
    {
        /// <summary>
        /// Gets and sets the property BindingProperties. 
        /// <para>
        /// The data binding information for the component's properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentBindingPropertiesValue> BindingProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentBindingPropertiesValue>() : null;

        /// <summary>
        /// Checks to see if the BindingProperties property is set.
        /// </summary>
        internal bool IsSetBindingProperties() => this.BindingProperties != null && (this.BindingProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Children. 
        /// <para>
        /// The components that are instances of the main component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComponentChild> Children { get; set; } = AWSConfigs.InitializeCollections ? new List<ComponentChild>() : null;

        /// <summary>
        /// Checks to see if the Children property is set.
        /// </summary>
        internal bool IsSetChildren() => this.Children != null && (this.Children.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CollectionProperties. 
        /// <para>
        /// The configuration for binding a component's properties to a data model. Use this for
        /// a collection component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentDataConfiguration> CollectionProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentDataConfiguration>() : null;

        /// <summary>
        /// Checks to see if the CollectionProperties property is set.
        /// </summary>
        internal bool IsSetCollectionProperties() => this.CollectionProperties != null && (this.CollectionProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComponentType. 
        /// <para>
        /// The type of the component. This can be an Amplify custom UI component or another custom
        /// component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ComponentType { get; set; }

        /// <summary>
        /// Checks to see if the ComponentType property is set.
        /// </summary>
        internal bool IsSetComponentType() => this.ComponentType != null;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The event configuration for the component. Use for the workflow feature in Amplify
        /// Studio that allows you to bind events and actions to components.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentEvent> Events { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentEvent>() : null;

        /// <summary>
        /// Checks to see if the Events property is set.
        /// </summary>
        internal bool IsSetEvents() => this.Events != null && (this.Events.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the component to update.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the component to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// Describes the properties that can be overriden to customize the component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> Overrides { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;

        /// <summary>
        /// Checks to see if the Overrides property is set.
        /// </summary>
        internal bool IsSetOverrides() => this.Overrides != null && (this.Overrides.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// Describes the component's properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentProperty> Properties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentProperty>() : null;

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null && (this.Properties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version of the component when it was imported.
        /// </para>
        /// </summary>
        public string SchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersion property is set.
        /// </summary>
        internal bool IsSetSchemaVersion() => this.SchemaVersion != null;

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The unique ID of the component in its original source system, such as Figma.
        /// </para>
        /// </summary>
        public string SourceId { get; set; }

        /// <summary>
        /// Checks to see if the SourceId property is set.
        /// </summary>
        internal bool IsSetSourceId() => this.SourceId != null;

        /// <summary>
        /// Gets and sets the property Variants. 
        /// <para>
        /// A list of the unique variants of the main component being updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComponentVariant> Variants { get; set; } = AWSConfigs.InitializeCollections ? new List<ComponentVariant>() : null;

        /// <summary>
        /// Checks to see if the Variants property is set.
        /// </summary>
        internal bool IsSetVariants() => this.Variants != null && (this.Variants.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
