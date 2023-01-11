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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Maps attributes or field names of Confluence pages to Amazon Kendra index field names.
    /// To create custom fields, use the <code>UpdateIndex</code> API before you map to Confluence
    /// fields. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
    /// data source fields</a>. The Confluence data source field names must exist in your
    /// Confluence custom metadata.
    /// </summary>
    public partial class ConfluencePageToIndexFieldMapping
    {
        private ConfluencePageFieldName _dataSourceFieldName;
        private string _dateFieldFormat;
        private string _indexFieldName;

        /// <summary>
        /// Gets and sets the property DataSourceFieldName. 
        /// <para>
        /// The name of the field in the data source.
        /// </para>
        /// </summary>
        public ConfluencePageFieldName DataSourceFieldName
        {
            get { return this._dataSourceFieldName; }
            set { this._dataSourceFieldName = value; }
        }

        // Check to see if DataSourceFieldName property is set
        internal bool IsSetDataSourceFieldName()
        {
            return this._dataSourceFieldName != null;
        }

        /// <summary>
        /// Gets and sets the property DateFieldFormat. 
        /// <para>
        /// The format for date fields in the data source. If the field specified in <code>DataSourceFieldName</code>
        /// is a date field you must specify the date format. If the field is not a date field,
        /// an exception is thrown.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=40)]
        public string DateFieldFormat
        {
            get { return this._dateFieldFormat; }
            set { this._dateFieldFormat = value; }
        }

        // Check to see if DateFieldFormat property is set
        internal bool IsSetDateFieldFormat()
        {
            return this._dateFieldFormat != null;
        }

        /// <summary>
        /// Gets and sets the property IndexFieldName. 
        /// <para>
        /// The name of the index field to map to the Confluence data source field. The index
        /// field type must match the Confluence field type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public string IndexFieldName
        {
            get { return this._indexFieldName; }
            set { this._indexFieldName = value; }
        }

        // Check to see if IndexFieldName property is set
        internal bool IsSetIndexFieldName()
        {
            return this._indexFieldName != null;
        }

    }
}