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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure describing a table resource with tags.
    /// </summary>
    public partial class TaggedTable
    {
        private List<LFTagPair> _lfTagOnDatabase = new List<LFTagPair>();
        private List<ColumnLFTag> _lfTagsOnColumns = new List<ColumnLFTag>();
        private List<LFTagPair> _lfTagsOnTable = new List<LFTagPair>();
        private TableResource _table;

        /// <summary>
        /// Gets and sets the property LFTagOnDatabase. 
        /// <para>
        /// A list of tags attached to the database where the table resides.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<LFTagPair> LFTagOnDatabase
        {
            get { return this._lfTagOnDatabase; }
            set { this._lfTagOnDatabase = value; }
        }

        // Check to see if LFTagOnDatabase property is set
        internal bool IsSetLFTagOnDatabase()
        {
            return this._lfTagOnDatabase != null && this._lfTagOnDatabase.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LFTagsOnColumns. 
        /// <para>
        /// A list of tags attached to columns in the table.
        /// </para>
        /// </summary>
        public List<ColumnLFTag> LFTagsOnColumns
        {
            get { return this._lfTagsOnColumns; }
            set { this._lfTagsOnColumns = value; }
        }

        // Check to see if LFTagsOnColumns property is set
        internal bool IsSetLFTagsOnColumns()
        {
            return this._lfTagsOnColumns != null && this._lfTagsOnColumns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LFTagsOnTable. 
        /// <para>
        /// A list of tags attached to the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<LFTagPair> LFTagsOnTable
        {
            get { return this._lfTagsOnTable; }
            set { this._lfTagsOnTable = value; }
        }

        // Check to see if LFTagsOnTable property is set
        internal bool IsSetLFTagsOnTable()
        {
            return this._lfTagsOnTable != null && this._lfTagsOnTable.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// A table that has tags attached to it.
        /// </para>
        /// </summary>
        public TableResource Table
        {
            get { return this._table; }
            set { this._table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this._table != null;
        }

    }
}