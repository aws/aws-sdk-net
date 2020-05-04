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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// The response elements represent the output of a request to run a SQL statement against
    /// a database.
    /// </summary>
    public partial class ExecuteStatementResponse : AmazonWebServiceResponse
    {
        private List<ColumnMetadata> _columnMetadata = new List<ColumnMetadata>();
        private List<Field> _generatedFields = new List<Field>();
        private long? _numberOfRecordsUpdated;
        private List<List<Field>> _records = new List<List<Field>>();

        /// <summary>
        /// Gets and sets the property ColumnMetadata. 
        /// <para>
        /// Metadata for the columns included in the results.
        /// </para>
        /// </summary>
        public List<ColumnMetadata> ColumnMetadata
        {
            get { return this._columnMetadata; }
            set { this._columnMetadata = value; }
        }

        // Check to see if ColumnMetadata property is set
        internal bool IsSetColumnMetadata()
        {
            return this._columnMetadata != null && this._columnMetadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GeneratedFields. 
        /// <para>
        /// Values for fields generated during the request.
        /// </para>
        ///  <pre><code> &lt;note&gt; &lt;p&gt;The &lt;code&gt;generatedFields&lt;/code&gt; data
        /// isn't supported by Aurora PostgreSQL. To get the values of generated fields, use the
        /// &lt;code&gt;RETURNING&lt;/code&gt; clause. For more information, see &lt;a href=&quot;https://www.postgresql.org/docs/10/dml-returning.html&quot;&gt;Returning
        /// Data From Modified Rows&lt;/a&gt; in the PostgreSQL documentation.&lt;/p&gt; &lt;/note&gt;
        /// </code></pre>
        /// </summary>
        public List<Field> GeneratedFields
        {
            get { return this._generatedFields; }
            set { this._generatedFields = value; }
        }

        // Check to see if GeneratedFields property is set
        internal bool IsSetGeneratedFields()
        {
            return this._generatedFields != null && this._generatedFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfRecordsUpdated. 
        /// <para>
        /// The number of records updated by the request.
        /// </para>
        /// </summary>
        public long NumberOfRecordsUpdated
        {
            get { return this._numberOfRecordsUpdated.GetValueOrDefault(); }
            set { this._numberOfRecordsUpdated = value; }
        }

        // Check to see if NumberOfRecordsUpdated property is set
        internal bool IsSetNumberOfRecordsUpdated()
        {
            return this._numberOfRecordsUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// The records returned by the SQL statement.
        /// </para>
        /// </summary>
        public List<List<Field>> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && this._records.Count > 0; 
        }

    }
}