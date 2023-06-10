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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateComponentType operation.
    /// Updates information in a component type.
    /// </summary>
    public partial class UpdateComponentTypeRequest : AmazonIoTTwinMakerRequest
    {
        private string _componentTypeId;
        private string _componentTypeName;
        private string _description;
        private List<string> _extendsFrom = new List<string>();
        private Dictionary<string, FunctionRequest> _functions = new Dictionary<string, FunctionRequest>();
        private bool? _isSingleton;
        private Dictionary<string, PropertyDefinitionRequest> _propertyDefinitions = new Dictionary<string, PropertyDefinitionRequest>();
        private Dictionary<string, PropertyGroupRequest> _propertyGroups = new Dictionary<string, PropertyGroupRequest>();
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property ComponentTypeId. 
        /// <para>
        /// The ID of the component type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ComponentTypeId
        {
            get { return this._componentTypeId; }
            set { this._componentTypeId = value; }
        }

        // Check to see if ComponentTypeId property is set
        internal bool IsSetComponentTypeId()
        {
            return this._componentTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentTypeName. 
        /// <para>
        /// The component type name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ComponentTypeName
        {
            get { return this._componentTypeName; }
            set { this._componentTypeName = value; }
        }

        // Check to see if ComponentTypeName property is set
        internal bool IsSetComponentTypeName()
        {
            return this._componentTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the component type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExtendsFrom. 
        /// <para>
        /// Specifies the component type that this component type extends.
        /// </para>
        /// </summary>
        public List<string> ExtendsFrom
        {
            get { return this._extendsFrom; }
            set { this._extendsFrom = value; }
        }

        // Check to see if ExtendsFrom property is set
        internal bool IsSetExtendsFrom()
        {
            return this._extendsFrom != null && this._extendsFrom.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Functions. 
        /// <para>
        /// An object that maps strings to the functions in the component type. Each string in
        /// the mapping must be unique to this object.
        /// </para>
        /// </summary>
        public Dictionary<string, FunctionRequest> Functions
        {
            get { return this._functions; }
            set { this._functions = value; }
        }

        // Check to see if Functions property is set
        internal bool IsSetFunctions()
        {
            return this._functions != null && this._functions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IsSingleton. 
        /// <para>
        /// A Boolean value that specifies whether an entity can have more than one component
        /// of this type.
        /// </para>
        /// </summary>
        public bool IsSingleton
        {
            get { return this._isSingleton.GetValueOrDefault(); }
            set { this._isSingleton = value; }
        }

        // Check to see if IsSingleton property is set
        internal bool IsSetIsSingleton()
        {
            return this._isSingleton.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PropertyDefinitions. 
        /// <para>
        /// An object that maps strings to the property definitions in the component type. Each
        /// string in the mapping must be unique to this object.
        /// </para>
        /// </summary>
        public Dictionary<string, PropertyDefinitionRequest> PropertyDefinitions
        {
            get { return this._propertyDefinitions; }
            set { this._propertyDefinitions = value; }
        }

        // Check to see if PropertyDefinitions property is set
        internal bool IsSetPropertyDefinitions()
        {
            return this._propertyDefinitions != null && this._propertyDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PropertyGroups. 
        /// <para>
        /// The property groups.
        /// </para>
        /// </summary>
        public Dictionary<string, PropertyGroupRequest> PropertyGroups
        {
            get { return this._propertyGroups; }
            set { this._propertyGroups = value; }
        }

        // Check to see if PropertyGroups property is set
        internal bool IsSetPropertyGroups()
        {
            return this._propertyGroups != null && this._propertyGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}