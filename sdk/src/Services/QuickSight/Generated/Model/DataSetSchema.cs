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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Dataset schema.
    /// </summary>
    public partial class DataSetSchema
    {
        private List<ColumnSchema> _columnSchemaList = new List<ColumnSchema>();

        /// <summary>
        /// Gets and sets the property ColumnSchemaList. 
        /// <para>
        /// A structure containing the list of column schemas.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public List<ColumnSchema> ColumnSchemaList
        {
            get { return this._columnSchemaList; }
            set { this._columnSchemaList = value; }
        }

        // Check to see if ColumnSchemaList property is set
        internal bool IsSetColumnSchemaList()
        {
            return this._columnSchemaList != null && this._columnSchemaList.Count > 0; 
        }

    }
}