/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PI.Model
{
    /// <summary>
    /// A logical grouping of Performance Insights metrics for a related subject area. For
    /// example, the <code>db.sql</code> dimension group consists of the following dimensions:
    /// <code>db.sql.id</code>, <code>db.sql.db_id</code>, <code>db.sql.statement</code>,
    /// and <code>db.sql.tokenized_id</code>.
    /// </summary>
    public partial class DimensionGroup
    {
        private List<string> _dimensions = new List<string>();
        private string _group;
        private int? _limit;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// A list of specific dimensions from a dimension group. If this parameter is not present,
        /// then it signifies that all of the dimensions in the group were requested, or are present
        /// in the response.
        /// </para>
        ///  
        /// <para>
        /// Valid values for elements in the <code>Dimensions</code> array are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// db.user.id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// db.user.name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// db.host.id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// db.host.name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// db.sql.id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// db.sql.db_id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// db.sql.statement
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// db.sql.tokenized_id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// db.sql_tokenized.id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// db.sql_tokenized.db_id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// db.sql_tokenized.statement
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// db.wait_event.name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// db.wait_event.type
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// db.wait_event_type.name
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && this._dimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name of the dimension group. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>db.user</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.host</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sql</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sql_tokenized</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.wait_event</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.wait_event_type</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items to fetch for this dimension group.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

    }
}