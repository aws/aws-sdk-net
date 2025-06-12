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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
        private ComponentPropertyBindingProperties _bindingProperties;
        private Dictionary<string, FormBindingElement> _bindings = AWSConfigs.InitializeCollections ? new Dictionary<string, FormBindingElement>() : null;
        private ComponentPropertyBindingProperties _collectionBindingProperties;
        private string _componentName;
        private List<ComponentProperty> _concat = AWSConfigs.InitializeCollections ? new List<ComponentProperty>() : null;
        private ComponentConditionProperty _condition;
        private bool? _configured;
        private string _defaultValue;
        private string _event;
        private string _importedValue;
        private string _model;
        private string _property;
        private string _type;
        private string _userAttribute;
        private string _value;

        /// <summary>
        /// Gets and sets the property BindingProperties. 
        /// <para>
        /// The information to bind the component property to data at runtime.
        /// </para>
        /// </summary>
        public ComponentPropertyBindingProperties BindingProperties
        {
            get { return this._bindingProperties; }
            set { this._bindingProperties = value; }
        }

        // Check to see if BindingProperties property is set
        internal bool IsSetBindingProperties()
        {
            return this._bindingProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Bindings. 
        /// <para>
        /// The information to bind the component property to form data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, FormBindingElement> Bindings
        {
            get { return this._bindings; }
            set { this._bindings = value; }
        }

        // Check to see if Bindings property is set
        internal bool IsSetBindings()
        {
            return this._bindings != null && (this._bindings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CollectionBindingProperties. 
        /// <para>
        /// The information to bind the component property to data at runtime. Use this for collection
        /// components.
        /// </para>
        /// </summary>
        public ComponentPropertyBindingProperties CollectionBindingProperties
        {
            get { return this._collectionBindingProperties; }
            set { this._collectionBindingProperties = value; }
        }

        // Check to see if CollectionBindingProperties property is set
        internal bool IsSetCollectionBindingProperties()
        {
            return this._collectionBindingProperties != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component that is affected by an event.
        /// </para>
        /// </summary>
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property Concat. 
        /// <para>
        /// A list of component properties to concatenate to create the value to assign to this
        /// component property.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComponentProperty> Concat
        {
            get { return this._concat; }
            set { this._concat = value; }
        }

        // Check to see if Concat property is set
        internal bool IsSetConcat()
        {
            return this._concat != null && (this._concat.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The conditional expression to use to assign a value to the component property.
        /// </para>
        /// </summary>
        public ComponentConditionProperty Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property Configured. 
        /// <para>
        /// Specifies whether the user configured the property in Amplify Studio after importing
        /// it.
        /// </para>
        /// </summary>
        public bool? Configured
        {
            get { return this._configured; }
            set { this._configured = value; }
        }

        // Check to see if Configured property is set
        internal bool IsSetConfigured()
        {
            return this._configured.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value to assign to the component property.
        /// </para>
        /// </summary>
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// An event that occurs in your app. Use this for workflow data binding.
        /// </para>
        /// </summary>
        public string Event
        {
            get { return this._event; }
            set { this._event = value; }
        }

        // Check to see if Event property is set
        internal bool IsSetEvent()
        {
            return this._event != null;
        }

        /// <summary>
        /// Gets and sets the property ImportedValue. 
        /// <para>
        /// The default value assigned to the property when the component is imported into an
        /// app.
        /// </para>
        /// </summary>
        public string ImportedValue
        {
            get { return this._importedValue; }
            set { this._importedValue = value; }
        }

        // Check to see if ImportedValue property is set
        internal bool IsSetImportedValue()
        {
            return this._importedValue != null;
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The data model to use to assign a value to the component property.
        /// </para>
        /// </summary>
        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property Property. 
        /// <para>
        /// The name of the component's property that is affected by an event.
        /// </para>
        /// </summary>
        public string Property
        {
            get { return this._property; }
            set { this._property = value; }
        }

        // Check to see if Property property is set
        internal bool IsSetProperty()
        {
            return this._property != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The component type.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UserAttribute. 
        /// <para>
        /// An authenticated user attribute to use to assign a value to the component property.
        /// </para>
        /// </summary>
        public string UserAttribute
        {
            get { return this._userAttribute; }
            set { this._userAttribute = value; }
        }

        // Check to see if UserAttribute property is set
        internal bool IsSetUserAttribute()
        {
            return this._userAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value to assign to the component property.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}