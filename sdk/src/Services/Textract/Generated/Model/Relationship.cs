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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Information about how blocks are related to each other. A <code>Block</code> object
    /// contains 0 or more <code>Relation</code> objects in a list, <code>Relationships</code>.
    /// For more information, see <a>Block</a>.
    /// 
    ///  
    /// <para>
    /// The <code>Type</code> element provides the type of the relationship for all blocks
    /// in the <code>IDs</code> array. 
    /// </para>
    /// </summary>
    public partial class Relationship
    {
        private List<string> _ids = new List<string>();
        private RelationshipType _type;

        /// <summary>
        /// Gets and sets the property Ids. 
        /// <para>
        /// An array of IDs for related blocks. You can get the type of the relationship from
        /// the <code>Type</code> element.
        /// </para>
        /// </summary>
        public List<string> Ids
        {
            get { return this._ids; }
            set { this._ids = value; }
        }

        // Check to see if Ids property is set
        internal bool IsSetIds()
        {
            return this._ids != null && this._ids.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of relationship between the blocks in the IDs array and the current block.
        /// The following list describes the relationship types that can be returned. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>VALUE</i> - A list that contains the ID of the VALUE block that's associated with
        /// the KEY of a key-value pair.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>CHILD</i> - A list of IDs that identify blocks found within the current block
        /// object. For example, WORD blocks have a CHILD relationship to the LINE block type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>MERGED_CELL</i> - A list of IDs that identify each of the MERGED_CELL block types
        /// in a table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>ANSWER</i> - A list that contains the ID of the QUERY_RESULT block that’s associated
        /// with the corresponding QUERY block. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>TABLE</i> - A list of IDs that identify associated TABLE block types. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>TABLE_TITLE</i> - A list that contains the ID for the TABLE_TITLE block type in
        /// a table. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>TABLE_FOOTER</i> - A list of IDs that identify the TABLE_FOOTER block types in
        /// a table. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RelationshipType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}