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
    /// Represents the event action configuration for an element of a <c>Component</c> or
    /// <c>ComponentChild</c>. Use for the workflow feature in Amplify Studio that allows
    /// you to bind events and actions to components. <c>ActionParameters</c> defines the
    /// action that is performed when an event occurs on the component.
    /// </summary>
    public partial class ActionParameters
    {
        private ComponentProperty _anchor;
        private Dictionary<string, ComponentProperty> _fields = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentProperty>() : null;
        private ComponentProperty _global;
        private ComponentProperty _id;
        private string _model;
        private MutationActionSetStateParameter _state;
        private ComponentProperty _target;
        private ComponentProperty _type;
        private ComponentProperty _url;

        /// <summary>
        /// Gets and sets the property Anchor. 
        /// <para>
        /// The HTML anchor link to the location to open. Specify this value for a navigation
        /// action.
        /// </para>
        /// </summary>
        public ComponentProperty Anchor
        {
            get { return this._anchor; }
            set { this._anchor = value; }
        }

        // Check to see if Anchor property is set
        internal bool IsSetAnchor()
        {
            return this._anchor != null;
        }

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// A dictionary of key-value pairs mapping Amplify Studio properties to fields in a data
        /// model. Use when the action performs an operation on an Amplify DataStore model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentProperty> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && (this._fields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Global. 
        /// <para>
        /// Specifies whether the user should be signed out globally. Specify this value for an
        /// auth sign out action.
        /// </para>
        /// </summary>
        public ComponentProperty Global
        {
            get { return this._global; }
            set { this._global = value; }
        }

        // Check to see if Global property is set
        internal bool IsSetGlobal()
        {
            return this._global != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the component that the <c>ActionParameters</c> apply to.
        /// </para>
        /// </summary>
        public ComponentProperty Id
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
        /// Gets and sets the property Model. 
        /// <para>
        /// The name of the data model. Use when the action performs an operation on an Amplify
        /// DataStore model.
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
        /// Gets and sets the property State. 
        /// <para>
        /// A key-value pair that specifies the state property name and its initial value.
        /// </para>
        /// </summary>
        public MutationActionSetStateParameter State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The element within the same component to modify when the action occurs.
        /// </para>
        /// </summary>
        public ComponentProperty Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of navigation action. Valid values are <c>url</c> and <c>anchor</c>. This
        /// value is required for a navigation action.
        /// </para>
        /// </summary>
        public ComponentProperty Type
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
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL to the location to open. Specify this value for a navigation action.
        /// </para>
        /// </summary>
        public ComponentProperty Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}