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
    /// A nested UI configuration within a parent <code>Component</code>.
    /// </summary>
    public partial class ComponentChild
    {
        private List<ComponentChild> _children = new List<ComponentChild>();
        private string _componentType;
        private Dictionary<string, ComponentEvent> _events = new Dictionary<string, ComponentEvent>();
        private string _name;
        private Dictionary<string, ComponentProperty> _properties = new Dictionary<string, ComponentProperty>();
        private string _sourceId;

        /// <summary>
        /// Gets and sets the property Children. 
        /// <para>
        /// The list of <code>ComponentChild</code> instances for this component.
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
        /// Gets and sets the property ComponentType. 
        /// <para>
        /// The type of the child component. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Describes the events that can be raised on the child component. Use for the workflow
        /// feature in Amplify Studio that allows you to bind events and actions to components.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the child component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Properties. 
        /// <para>
        /// Describes the properties of the child component. You can't specify <code>tags</code>
        /// as a valid property for <code>properties</code>.
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
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The unique ID of the child component in its original source system, such as Figma.
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

    }
}