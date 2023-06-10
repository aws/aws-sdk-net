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
    /// The component property group request.
    /// </summary>
    public partial class ComponentPropertyGroupRequest
    {
        private GroupType _groupType;
        private List<string> _propertyNames = new List<string>();
        private PropertyGroupUpdateType _updateType;

        /// <summary>
        /// Gets and sets the property GroupType. 
        /// <para>
        /// The group type.
        /// </para>
        /// </summary>
        public GroupType GroupType
        {
            get { return this._groupType; }
            set { this._groupType = value; }
        }

        // Check to see if GroupType property is set
        internal bool IsSetGroupType()
        {
            return this._groupType != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyNames. 
        /// <para>
        /// The property names.
        /// </para>
        /// </summary>
        public List<string> PropertyNames
        {
            get { return this._propertyNames; }
            set { this._propertyNames = value; }
        }

        // Check to see if PropertyNames property is set
        internal bool IsSetPropertyNames()
        {
            return this._propertyNames != null && this._propertyNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdateType. 
        /// <para>
        /// The update type.
        /// </para>
        /// </summary>
        public PropertyGroupUpdateType UpdateType
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