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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// A Gremlin or openCypher change record.
    /// </summary>
    public partial class PropertygraphData
    {
        private string _from;
        private string _id;
        private string _key;
        private string _to;
        private string _type;
        private Amazon.Runtime.Documents.Document _value;

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// If this is an edge (type = <c>e</c>), the ID of the corresponding <c>from</c> vertex
        /// or source node.
        /// </para>
        /// </summary>
        public string From
        {
            get { return this._from; }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the Gremlin or openCypher element.
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
        /// Gets and sets the property Key. 
        /// <para>
        /// The property name. For element labels, this is <c>label</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// If this is an edge (type = <c>e</c>), the ID of the corresponding <c>to</c> vertex
        /// or target node.
        /// </para>
        /// </summary>
        public string To
        {
            get { return this._to; }
            set { this._to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this._to != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of this Gremlin or openCypher element. Must be one of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>v1</c> </b>   -   Vertex label for Gremlin, or node label for openCypher.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>vp</c> </b>   -   Vertex properties for Gremlin, or node properties for openCypher.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>e</c> </b>   -   Edge and edge label for Gremlin, or relationship and relationship
        /// type for openCypher.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>ep</c> </b>   -   Edge properties for Gremlin, or relationship properties
        /// for openCypher.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Type
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
        /// Gets and sets the property Value. 
        /// <para>
        /// This is a JSON object that contains a value field for the value itself, and a datatype
        /// field for the JSON data type of that value:
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return !this._value.IsNull();
        }

    }
}