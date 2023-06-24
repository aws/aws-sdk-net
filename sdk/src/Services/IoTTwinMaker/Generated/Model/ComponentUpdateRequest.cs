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
    /// The component update request.
    /// </summary>
    public partial class ComponentUpdateRequest
    {
        private string _componentTypeId;
        private string _description;
        private Dictionary<string, ComponentPropertyGroupRequest> _propertyGroupUpdates = new Dictionary<string, ComponentPropertyGroupRequest>();
        private Dictionary<string, PropertyRequest> _propertyUpdates = new Dictionary<string, PropertyRequest>();
        private ComponentUpdateType _updateType;

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
        /// Gets and sets the property PropertyGroupUpdates. 
        /// <para>
        /// The property group updates.
        /// </para>
        /// </summary>
        public Dictionary<string, ComponentPropertyGroupRequest> PropertyGroupUpdates
        {
            get { return this._propertyGroupUpdates; }
            set { this._propertyGroupUpdates = value; }
        }

        // Check to see if PropertyGroupUpdates property is set
        internal bool IsSetPropertyGroupUpdates()
        {
            return this._propertyGroupUpdates != null && this._propertyGroupUpdates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PropertyUpdates. 
        /// <para>
        /// An object that maps strings to the properties to set in the component type update.
        /// Each string in the mapping must be unique to this object.
        /// </para>
        /// </summary>
        public Dictionary<string, PropertyRequest> PropertyUpdates
        {
            get { return this._propertyUpdates; }
            set { this._propertyUpdates = value; }
        }

        // Check to see if PropertyUpdates property is set
        internal bool IsSetPropertyUpdates()
        {
            return this._propertyUpdates != null && this._propertyUpdates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdateType. 
        /// <para>
        /// The update type of the component update request.
        /// </para>
        /// </summary>
        public ComponentUpdateType UpdateType
        {
            get { return this._updateType; }
            set { this._updateType = value; }
        }

        // Check to see if UpdateType property is set
        internal bool IsSetUpdateType()
        {
            return this._updateType != null;
        }

    }
}