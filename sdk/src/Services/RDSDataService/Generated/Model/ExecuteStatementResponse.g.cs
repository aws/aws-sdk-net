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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the ExecuteStatement operation.
    /// </summary>
    public partial class ExecuteStatementResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ColumnMetadata. 
        /// <para>
        /// Metadata for the columns included in the results. This field is blank if the <c>formatRecordsAs</c>
        /// parameter is set to <c>JSON</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ColumnMetadata> ColumnMetadata { get; set; } = AWSConfigs.InitializeCollections ? new List<ColumnMetadata>() : null;

        /// <summary>
        /// Checks to see if the ColumnMetadata property is set.
        /// </summary>
        internal bool IsSetColumnMetadata() => this.ColumnMetadata != null && (this.ColumnMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public string FormattedRecords { get; set; }

        /// <summary>
        /// Checks to see if the FormattedRecords property is set.
        /// </summary>
        internal bool IsSetFormattedRecords() => this.FormattedRecords != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Field> GeneratedFields { get; set; } = AWSConfigs.InitializeCollections ? new List<Field>() : null;

        /// <summary>
        /// Checks to see if the GeneratedFields property is set.
        /// </summary>
        internal bool IsSetGeneratedFields() => this.GeneratedFields != null && (this.GeneratedFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberOfRecordsUpdated. 
        /// <para>
        /// The number of records updated by the request.
        /// </para>
        /// </summary>
        public long? NumberOfRecordsUpdated { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfRecordsUpdated property is set.
        /// </summary>
        internal bool IsSetNumberOfRecordsUpdated() => this.NumberOfRecordsUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// The records returned by the SQL statement. This field is blank if the <c>formatRecordsAs</c>
        /// parameter is set to <c>JSON</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<Field>> Records { get; set; } = AWSConfigs.InitializeCollections ? new List<List<Field>>() : null;

        /// <summary>
        /// Checks to see if the Records property is set.
        /// </summary>
        internal bool IsSetRecords() => this.Records != null && (this.Records.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
