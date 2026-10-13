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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Maps attributes or field names of the documents synced from the data source to Amazon
    /// Kendra index field names. You can set up field mappings for each data source when
    /// calling <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_CreateDataSource.html">CreateDataSource</a>
    /// or <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_UpdateDataSource.html">UpdateDataSource</a>
    /// API. To create custom fields, use the <c>UpdateIndex</c> API to first create an index
    /// field and then map to the data source field. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
    /// data source fields</a>.
    /// </summary>
    public partial class DataSourceToIndexFieldMapping
    {
        /// <summary>
        /// Gets and sets the property DataSourceFieldName. 
        /// <para>
        /// The name of the field in the data source. You must first create the index field using
        /// the <c>UpdateIndex</c> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DataSourceFieldName { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceFieldName property is set.
        /// </summary>
        internal bool IsSetDataSourceFieldName() => this.DataSourceFieldName != null;

        /// <summary>
        /// Gets and sets the property DateFieldFormat. 
        /// <para>
        /// The format for date fields in the data source. If the field specified in <c>DataSourceFieldName</c>
        /// is a date field, you must specify the date format. If the field is not a date field,
        /// an exception is thrown.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 40)]
        public string DateFieldFormat { get; set; }

        /// <summary>
        /// Checks to see if the DateFieldFormat property is set.
        /// </summary>
        internal bool IsSetDateFieldFormat() => this.DateFieldFormat != null;

        /// <summary>
        /// Gets and sets the property IndexFieldName. 
        /// <para>
        /// The name of the index field to map to the data source field. The index field type
        /// must match the data source field type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public string IndexFieldName { get; set; }

        /// <summary>
        /// Checks to see if the IndexFieldName property is set.
        /// </summary>
        internal bool IsSetIndexFieldName() => this.IndexFieldName != null;
    }
}
