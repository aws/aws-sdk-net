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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Updates and saves all of the information about a component, based on component ID.
    /// </summary>
    public partial class UpdateComponentData
    {
        private Dictionary<string, ComponentBindingPropertiesValue> _bindingProperties = new Dictionary<string, ComponentBindingPropertiesValue>();
        private List<ComponentChild> _children = new List<ComponentChild>();
        private Dictionary<string, ComponentDataConfiguration> _collectionProperties = new Dictionary<string, ComponentDataConfiguration>();
        private string _componentType;
        private Dictionary<string, ComponentEvent> _events = new Dictionary<string, ComponentEvent>();
        private string _id;
        private string _name;
        private Dictionary<string, Dictionary<string, string>> _overrides = new Dictionary<string, Dictionary<string, string>>();
        private Dictionary<string, ComponentProperty> _properties = new Dictionary<string, ComponentProperty>();
        private string _schemaVersion;
        private string _sourceId;
        private List<ComponentVariant> _variants = new List<ComponentVariant>();

        /// <summary>
        /// Gets and sets the property BindingProperties. 
        /// <para>
        /// The data binding information for the component's properties.
        /// </para>
        /// </summary>
        public Dictionary<string, ComponentBindingPropertiesValue> BindingProperties
        {
            get { return this._bindingProperties; }
            set { this._bindingProperties = value; }
        }

        // Check to see if BindingProperties property is set
        internal bool IsSetBindingProperties()
        {
            return this._bindingProperties != null && this._bindingProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Children. 
        /// <para>
        /// The components that are instances of the main component.
        /// </para>
        /// </summary>
        public List<ComponentChild> Children
        {
            get { return this._children; }
            set { this._children = value; }
        }

        // Check to see if Children property is set
        internal bool IsSetChildren()
        {
            return this._children != null && this._children.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CollectionProperties. 
        /// <para>
        /// The configuration for binding a component's properties to a data model. Use this for
        /// a collection component.
        /// </para>
        /// </summary>
        public Dictionary<string, ComponentDataConfiguration> CollectionProperties
        {
            get { return this._collectionProperties; }
            set { this._collectionProperties = value; }
        }

        // Check to see if CollectionProperties property is set
        internal bool IsSetCollectionProperties()
        {
            return this._collectionProperties != null && this._collectionProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ComponentType. 
        /// <para>
        /// The type of the component. This can be an Amplify custom UI component or another custom
        /// component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ComponentType
        {
            get { return this._componentType; }
            set { this._componentType = value; }
        }

        // Check to see if ComponentType property is set
        internal bool IsSetComponentType()
        {
            return this._componentType != null;
        }

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The event configuration for the component. Use for the workflow feature in Amplify
        /// Studio that allows you to bind events and actions to components.
        /// </para>
        /// </summary>
        public Dictionary<string, ComponentEvent> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && this._events.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the component to update.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the component to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Overrides. 
        /// <para>
        /// Describes the properties that can be overriden to customize the component.
        /// </para>
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null && this._overrides.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// Describes the component's properties.
        /// </para>
        /// </summary>
        public Dictionary<string, ComponentProperty> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && this._properties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version of the component when it was imported.
        /// </para>
        /// </summary>
        public string SchemaVersion
        {
            get { return this._schemaVersion; }
            set { this._schemaVersion = value; }
        }

        // Check to see if SchemaVersion property is set
        internal bool IsSetSchemaVersion()
        {
            return this._schemaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The unique ID of the component in its original source system, such as Figma.
        /// </para>
        /// </summary>
        public string SourceId
        {
            get { return this._sourceId; }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Variants. 
        /// <para>
        /// A list of the unique variants of the main component being updated.
        /// </para>
        /// </summary>
        public List<ComponentVariant> Variants
        {
            get { return this._variants; }
            set { this._variants = value; }
        }

        // Check to see if Variants property is set
        internal bool IsSetVariants()
        {
            return this._variants != null && this._variants.Count > 0; 
        }

    }
}