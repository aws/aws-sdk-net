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
    /// Provides information about how Amazon Kendra should use the columns of a database
    /// in an index.
    /// </summary>
    public partial class ColumnConfiguration
    {
        private List<string> _changeDetectingColumns = new List<string>();
        private string _documentDataColumnName;
        private string _documentIdColumnName;
        private string _documentTitleColumnName;
        private List<DataSourceToIndexFieldMapping> _fieldMappings = new List<DataSourceToIndexFieldMapping>();

        /// <summary>
        /// Gets and sets the property ChangeDetectingColumns. 
        /// <para>
        /// One to five columns that indicate when a document in the database has changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> ChangeDetectingColumns
        {
            get { return this._changeDetectingColumns; }
            set { this._changeDetectingColumns = value; }
        }

        // Check to see if ChangeDetectingColumns property is set
        internal bool IsSetChangeDetectingColumns()
        {
            return this._changeDetectingColumns != null && this._changeDetectingColumns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DocumentDataColumnName. 
        /// <para>
        /// The column that contains the contents of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DocumentDataColumnName
        {
            get { return this._documentDataColumnName; }
            set { this._documentDataColumnName = value; }
        }

        // Check to see if DocumentDataColumnName property is set
        internal bool IsSetDocumentDataColumnName()
        {
            return this._documentDataColumnName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentIdColumnName. 
        /// <para>
        /// The column that provides the document's identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DocumentIdColumnName
        {
            get { return this._documentIdColumnName; }
            set { this._documentIdColumnName = value; }
        }

        // Check to see if DocumentIdColumnName property is set
        internal bool IsSetDocumentIdColumnName()
        {
            return this._documentIdColumnName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentTitleColumnName. 
        /// <para>
        /// The column that contains the title of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DocumentTitleColumnName
        {
            get { return this._documentTitleColumnName; }
            set { this._documentTitleColumnName = value; }
        }

        // Check to see if DocumentTitleColumnName property is set
        internal bool IsSetDocumentTitleColumnName()
        {
            return this._documentTitleColumnName != null;
        }

        /// <summary>
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// An array of objects that map database column names to the corresponding fields in
        /// an index. You must first create the fields in the index using the <code>UpdateIndex</code>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> FieldMappings
        {
            get { return this._fieldMappings; }
            set { this._fieldMappings = value; }
        }

        // Check to see if FieldMappings property is set
        internal bool IsSetFieldMappings()
        {
            return this._fieldMappings != null && this._fieldMappings.Count > 0; 
        }

    }
}