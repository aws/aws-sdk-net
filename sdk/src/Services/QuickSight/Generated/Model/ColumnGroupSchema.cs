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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The column group schema.
    /// </summary>
    public partial class ColumnGroupSchema
    {
        private List<ColumnGroupColumnSchema> _columnGroupColumnSchemaList = new List<ColumnGroupColumnSchema>();
        private string _name;

        /// <summary>
        /// Gets and sets the property ColumnGroupColumnSchemaList. 
        /// <para>
        /// A structure containing the list of schemas for column group columns.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public List<ColumnGroupColumnSchema> ColumnGroupColumnSchemaList
        {
            get { return this._columnGroupColumnSchemaList; }
            set { this._columnGroupColumnSchemaList = value; }
        }

        // Check to see if ColumnGroupColumnSchemaList property is set
        internal bool IsSetColumnGroupColumnSchemaList()
        {
            return this._columnGroupColumnSchemaList != null && this._columnGroupColumnSchemaList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the column group schema.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}