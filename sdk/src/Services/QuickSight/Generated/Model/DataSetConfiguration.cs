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
    /// Dataset configuration.
    /// </summary>
    public partial class DataSetConfiguration
    {
        private List<ColumnGroupSchema> _columnGroupSchemaList = new List<ColumnGroupSchema>();
        private DataSetSchema _dataSetSchema;
        private string _placeholder;

        /// <summary>
        /// Gets and sets the property ColumnGroupSchemaList. 
        /// <para>
        /// A structure containing the list of column group schemas.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public List<ColumnGroupSchema> ColumnGroupSchemaList
        {
            get { return this._columnGroupSchemaList; }
            set { this._columnGroupSchemaList = value; }
        }

        // Check to see if ColumnGroupSchemaList property is set
        internal bool IsSetColumnGroupSchemaList()
        {
            return this._columnGroupSchemaList != null && this._columnGroupSchemaList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataSetSchema. 
        /// <para>
        /// Dataset schema.
        /// </para>
        /// </summary>
        public DataSetSchema DataSetSchema
        {
            get { return this._dataSetSchema; }
            set { this._dataSetSchema = value; }
        }

        // Check to see if DataSetSchema property is set
        internal bool IsSetDataSetSchema()
        {
            return this._dataSetSchema != null;
        }

        /// <summary>
        /// Gets and sets the property Placeholder. 
        /// <para>
        /// Placeholder.
        /// </para>
        /// </summary>
        public string Placeholder
        {
            get { return this._placeholder; }
            set { this._placeholder = value; }
        }

        // Check to see if Placeholder property is set
        internal bool IsSetPlaceholder()
        {
            return this._placeholder != null;
        }

    }
}