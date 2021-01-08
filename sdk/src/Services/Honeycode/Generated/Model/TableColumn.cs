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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// An object that contains attributes about a single column in a table
    /// </summary>
    public partial class TableColumn
    {
        private Format _format;
        private string _tableColumnId;
        private string _tableColumnName;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        ///  The column level format that is applied in the table. An empty value in this field
        /// means that the column format is the default value 'AUTO'. 
        /// </para>
        /// </summary>
        public Format Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property TableColumnId. 
        /// <para>
        /// The id of the column in the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string TableColumnId
        {
            get { return this._tableColumnId; }
            set { this._tableColumnId = value; }
        }

        // Check to see if TableColumnId property is set
        internal bool IsSetTableColumnId()
        {
            return this._tableColumnId != null;
        }

        /// <summary>
        /// Gets and sets the property TableColumnName. 
        /// <para>
        /// The name of the column in the table.
        /// </para>
        /// </summary>
        public string TableColumnName
        {
            get { return this._tableColumnName; }
            set { this._tableColumnName = value; }
        }

        // Check to see if TableColumnName property is set
        internal bool IsSetTableColumnName()
        {
            return this._tableColumnName != null;
        }

    }
}