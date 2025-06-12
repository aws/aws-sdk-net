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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// The response elements represent the output of a request to run a SQL statement against
    /// a database.
    /// </summary>
    public partial class ExecuteStatementResponse : AmazonWebServiceResponse
    {
        private List<ColumnMetadata> _columnMetadata = AWSConfigs.InitializeCollections ? new List<ColumnMetadata>() : null;
        private string _formattedRecords;
        private List<Field> _generatedFields = AWSConfigs.InitializeCollections ? new List<Field>() : null;
        private long? _numberOfRecordsUpdated;
        private List<List<Field>> _records = AWSConfigs.InitializeCollections ? new List<List<Field>>() : null;

        /// <summary>
        /// Gets and sets the property ColumnMetadata. 
        /// <para>
        /// Metadata for the columns included in the results. This field is blank if the <c>formatRecordsAs</c>
        /// parameter is set to <c>JSON</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ColumnMetadata> ColumnMetadata
        {
            get { return this._columnMetadata; }
            set { this._columnMetadata = value; }
        }

        // Check to see if ColumnMetadata property is set
        internal bool IsSetColumnMetadata()
        {
            return this._columnMetadata != null && (this._columnMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FormattedRecords. 
        /// <para>
        /// A string value that represents the result set of a <c>SELECT</c> statement in JSON
        /// format. This value is only present when the <c>formatRecordsAs</c> parameter is set
        /// to <c>JSON</c>.
        /// </para>
        ///  
        /// <para>
        /// The size limit for this field is currently 10 MB. If the JSON-formatted string representing
        /// the result set requires more than 10 MB, the call returns an error.
        /// </para>
        /// </summary>
        public string FormattedRecords
        {
            get { return this._formattedRecords; }
            set { this._formattedRecords = value; }
        }

        // Check to see if FormattedRecords property is set
        internal bool IsSetFormattedRecords()
        {
            return this._formattedRecords != null;
        }

        /// <summary>
        /// Gets and sets the property GeneratedFields. 
        /// <para>
        /// Values for fields generated during a DML request.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>generatedFields</c> data isn't supported by Aurora PostgreSQL. To get the values
        /// of generated fields, use the <c>RETURNING</c> clause. For more information, see <a
        /// href="https://www.postgresql.org/docs/10/dml-returning.html">Returning Data From Modified
        /// Rows</a> in the PostgreSQL documentation.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Field> GeneratedFields
        {
            get { return this._generatedFields; }
            set { this._generatedFields = value; }
        }

        // Check to see if GeneratedFields property is set
        internal bool IsSetGeneratedFields()
        {
            return this._generatedFields != null && (this._generatedFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumberOfRecordsUpdated. 
        /// <para>
        /// The number of records updated by the request.
        /// </para>
        /// </summary>
        public long? NumberOfRecordsUpdated
        {
            get { return this._numberOfRecordsUpdated; }
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
        /// The records returned by the SQL statement. This field is blank if the <c>formatRecordsAs</c>
        /// parameter is set to <c>JSON</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<Field>> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && (this._records.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}