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
    /// An object that uniquely identifies an entity property.
    /// </summary>
    public partial class EntityPropertyReference
    {
        private string _componentName;
        private string _entityId;
        private Dictionary<string, string> _externalIdProperty = new Dictionary<string, string>();
        private string _propertyName;

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
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The ID of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalIdProperty. 
        /// <para>
        /// A mapping of external IDs to property names. External IDs uniquely identify properties
        /// from external data stores.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ExternalIdProperty
        {
            get { return this._externalIdProperty; }
            set { this._externalIdProperty = value; }
        }

        // Check to see if ExternalIdProperty property is set
        internal bool IsSetExternalIdProperty()
        {
            return this._externalIdProperty != null && this._externalIdProperty.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PropertyName. 
        /// <para>
        /// The name of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PropertyName
        {
            get { return this._propertyName; }
            set { this._propertyName = value; }
        }

        // Check to see if PropertyName property is set
        internal bool IsSetPropertyName()
        {
            return this._propertyName != null;
        }

    }
}