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
    /// An object that returns information about a component type create or update request.
    /// </summary>
    public partial class ComponentResponse
    {
        private string _componentName;
        private string _componentTypeId;
        private string _definedIn;
        private string _description;
        private Dictionary<string, PropertyResponse> _properties = new Dictionary<string, PropertyResponse>();
        private Dictionary<string, ComponentPropertyGroupResponse> _propertyGroups = new Dictionary<string, ComponentPropertyGroupResponse>();
        private Status _status;
        private string _syncSource;

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property ComponentTypeId. 
        /// <para>
        /// The ID of the component type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property DefinedIn. 
        /// <para>
        /// The name of the property definition set in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DefinedIn
        {
            get { return this._definedIn; }
            set { this._definedIn = value; }
        }

        // Check to see if DefinedIn property is set
        internal bool IsSetDefinedIn()
        {
            return this._definedIn != null;
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
        /// Gets and sets the property Properties. 
        /// <para>
        /// An object that maps strings to the properties to set in the component type. Each string
        /// in the mapping must be unique to this object.
        /// </para>
        /// </summary>
        public Dictionary<string, PropertyResponse> Properties
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
        /// Gets and sets the property PropertyGroups. 
        /// <para>
        /// The property groups.
        /// </para>
        /// </summary>
        public Dictionary<string, ComponentPropertyGroupResponse> PropertyGroups
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the component type.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SyncSource. 
        /// <para>
        /// The syncSource of the sync job, if this entity was created by a sync job.
        /// </para>
        /// </summary>
        public string SyncSource
        {
            get { return this._syncSource; }
            set { this._syncSource = value; }
        }

        // Check to see if SyncSource property is set
        internal bool IsSetSyncSource()
        {
            return this._syncSource != null;
        }

    }
}