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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// An object that filters an entity search. Multiple filters function as OR criteria
    /// in the search. For example a search that includes a <code>NAMESPACE</code> and a <code>REFERENCED_ENTITY_ID</code>
    /// filter searches for entities in the specified namespace that use the entity specified
    /// by the value of <code>REFERENCED_ENTITY_ID</code>.
    /// </summary>
    public partial class EntityFilter
    {
        private EntityFilterName _name;
        private List<string> _value = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the entity search filter field. <code>REFERENCED_ENTITY_ID</code> filters
        /// on entities that are used by the entity in the result set. For example, you can filter
        /// on the ID of a property that is used in a state.
        /// </para>
        /// </summary>
        public EntityFilterName Name
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
        /// Gets and sets the property Value. 
        /// <para>
        /// An array of string values for the search filter field. Multiple values function as
        /// AND criteria in the search.
        /// </para>
        /// </summary>
        public List<string> Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null && this._value.Count > 0; 
        }

    }
}