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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains information about an entity that can be referenced in a Cedar policy.
    /// 
    ///  
    /// <para>
    /// This data type is used as one of the fields in the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_EntitiesDefinition.html">EntitiesDefinition</a>
    /// structure.
    /// </para>
    ///  
    /// <para>
    ///  <code>{ "id": { "entityType": "Photo", "entityId": "VacationPhoto94.jpg" }, "Attributes":
    /// {}, "Parents": [ { "entityType": "Album", "entityId": "alice_folder" } ] }</code>
    /// 
    /// </para>
    /// </summary>
    public partial class EntityItem
    {
        private Dictionary<string, AttributeValue> _attributes = new Dictionary<string, AttributeValue>();
        private EntityIdentifier _identifier;
        private List<EntityIdentifier> _parents = new List<EntityIdentifier>();

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A list of attributes for the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public Dictionary<string, AttributeValue> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EntityIdentifier Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Parents. 
        /// <para>
        /// The parents in the hierarchy that contains the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<EntityIdentifier> Parents
        {
            get { return this._parents; }
            set { this._parents = value; }
        }

        // Check to see if Parents property is set
        internal bool IsSetParents()
        {
            return this._parents != null && this._parents.Count > 0; 
        }

    }
}