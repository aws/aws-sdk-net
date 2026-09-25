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
    /// Describes the configuration for all of a component's properties. Use <c>ComponentProperty</c>
    /// to specify the values to render or bind by default.
    /// </summary>
    public partial class ComponentProperty
    {
        /// <summary>
        /// Gets and sets the property BindingProperties. 
        /// <para>
        /// The information to bind the component property to data at runtime.
        /// </para>
        /// </summary>
        public ComponentPropertyBindingProperties BindingProperties { get; set; }

        /// <summary>
        /// Checks to see if the BindingProperties property is set.
        /// </summary>
        internal bool IsSetBindingProperties() => this.BindingProperties != null;

        /// <summary>
        /// Gets and sets the property Bindings. 
        /// <para>
        /// The information to bind the component property to form data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, FormBindingElement> Bindings { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, FormBindingElement>() : null;

        /// <summary>
        /// Checks to see if the Bindings property is set.
        /// </summary>
        internal bool IsSetBindings() => this.Bindings != null && (this.Bindings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CollectionBindingProperties. 
        /// <para>
        /// The information to bind the component property to data at runtime. Use this for collection
        /// components.
        /// </para>
        /// </summary>
        public ComponentPropertyBindingProperties CollectionBindingProperties { get; set; }

        /// <summary>
        /// Checks to see if the CollectionBindingProperties property is set.
        /// </summary>
        internal bool IsSetCollectionBindingProperties() => this.CollectionBindingProperties != null;

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component that is affected by an event.
        /// </para>
        /// </summary>
        public string ComponentName { get; set; }

        /// <summary>
        /// Checks to see if the ComponentName property is set.
        /// </summary>
        internal bool IsSetComponentName() => this.ComponentName != null;

        /// <summary>
        /// Gets and sets the property Concat. 
        /// <para>
        /// A list of component properties to concatenate to create the value to assign to this
        /// component property.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComponentProperty> Concat { get; set; } = AWSConfigs.InitializeCollections ? new List<ComponentProperty>() : null;

        /// <summary>
        /// Checks to see if the Concat property is set.
        /// </summary>
        internal bool IsSetConcat() => this.Concat != null && (this.Concat.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The conditional expression to use to assign a value to the component property.
        /// </para>
        /// </summary>
        public ComponentConditionProperty Condition { get; set; }

        /// <summary>
        /// Checks to see if the Condition property is set.
        /// </summary>
        internal bool IsSetCondition() => this.Condition != null;

        /// <summary>
        /// Gets and sets the property Configured. 
        /// <para>
        /// Specifies whether the user configured the property in Amplify Studio after importing
        /// it.
        /// </para>
        /// </summary>
        public bool? Configured { get; set; }

        /// <summary>
        /// Checks to see if the Configured property is set.
        /// </summary>
        internal bool IsSetConfigured() => this.Configured.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value to assign to the component property.
        /// </para>
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// An event that occurs in your app. Use this for workflow data binding.
        /// </para>
        /// </summary>
        public string Event { get; set; }

        /// <summary>
        /// Checks to see if the Event property is set.
        /// </summary>
        internal bool IsSetEvent() => this.Event != null;

        /// <summary>
        /// Gets and sets the property ImportedValue. 
        /// <para>
        /// The default value assigned to the property when the component is imported into an
        /// app.
        /// </para>
        /// </summary>
        public string ImportedValue { get; set; }

        /// <summary>
        /// Checks to see if the ImportedValue property is set.
        /// </summary>
        internal bool IsSetImportedValue() => this.ImportedValue != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The data model to use to assign a value to the component property.
        /// </para>
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property Property. 
        /// <para>
        /// The name of the component's property that is affected by an event.
        /// </para>
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Checks to see if the Property property is set.
        /// </summary>
        internal bool IsSetProperty() => this.Property != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The component type.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UserAttribute. 
        /// <para>
        /// An authenticated user attribute to use to assign a value to the component property.
        /// </para>
        /// </summary>
        public string UserAttribute { get; set; }

        /// <summary>
        /// Checks to see if the UserAttribute property is set.
        /// </summary>
        internal bool IsSetUserAttribute() => this.UserAttribute != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value to assign to the component property.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
