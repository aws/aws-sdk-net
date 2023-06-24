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
    /// Contains the configuration settings for a user interface (UI) element for an Amplify
    /// app. A component is configured as a primary, stand-alone UI element. Use <code>ComponentChild</code>
    /// to configure an instance of a <code>Component</code>. A <code>ComponentChild</code>
    /// instance inherits the configuration of the main <code>Component</code>.
    /// </summary>
    public partial class Component
    {
        private string _appId;
        private Dictionary<string, ComponentBindingPropertiesValue> _bindingProperties = new Dictionary<string, ComponentBindingPropertiesValue>();
        private List<ComponentChild> _children = new List<ComponentChild>();
        private Dictionary<string, ComponentDataConfiguration> _collectionProperties = new Dictionary<string, ComponentDataConfiguration>();
        private string _componentType;
        private DateTime? _createdAt;
        private string _environmentName;
        private Dictionary<string, ComponentEvent> _events = new Dictionary<string, ComponentEvent>();
        private string _id;
        private DateTime? _modifiedAt;
        private string _name;
        private Dictionary<string, Dictionary<string, string>> _overrides = new Dictionary<string, Dictionary<string, string>>();
        private Dictionary<string, ComponentProperty> _properties = new Dictionary<string, ComponentProperty>();
        private string _schemaVersion;
        private string _sourceId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private List<ComponentVariant> _variants = new List<ComponentVariant>();

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique ID of the Amplify app associated with the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property BindingProperties. 
        /// <para>
        /// The information to connect a component's properties to data at runtime. You can't
        /// specify <code>tags</code> as a valid property for <code>bindingProperties</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A list of the component's <code>ComponentChild</code> instances.
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
        /// The data binding configuration for the component's properties. Use this for a collection
        /// component. You can't specify <code>tags</code> as a valid property for <code>collectionProperties</code>.
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
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time that the component was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the backend environment that is a part of the Amplify app.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// Describes the events that can be raised on the component. Use for the workflow feature
        /// in Amplify Studio that allows you to bind events and actions to components.
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
        /// The unique ID of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The time that the component was modified.
        /// </para>
        /// </summary>
        public DateTime ModifiedAt
        {
            get { return this._modifiedAt.GetValueOrDefault(); }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Describes the component's properties that can be overriden in a customized instance
        /// of the component. You can't specify <code>tags</code> as a valid property for <code>overrides</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Describes the component's properties. You can't specify <code>tags</code> as a valid
        /// property for <code>properties</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more key-value pairs to use when tagging the component.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Variants. 
        /// <para>
        /// A list of the component's variants. A variant is a unique style configuration of a
        /// main component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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