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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Information about the columns in a query execution result.
    /// </summary>
    public partial class ColumnInfo
    {
        /// <summary>
        /// Gets and sets the property CaseSensitive. 
        /// <para>
        /// Indicates whether values in the column are case-sensitive.
        /// </para>
        /// </summary>
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// Checks to see if the CaseSensitive property is set.
        /// </summary>
        internal bool IsSetCaseSensitive() => this.CaseSensitive.HasValue;

        /// <summary>
        /// Gets and sets the property CatalogName. 
        /// <para>
        /// The catalog to which the query results belong.
        /// </para>
        /// </summary>
        public string CatalogName { get; set; }

        /// <summary>
        /// Checks to see if the CatalogName property is set.
        /// </summary>
        internal bool IsSetCatalogName() => this.CatalogName != null;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// A column label.
        /// </para>
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Nullable. 
        /// <para>
        /// Unsupported constraint. This value always shows as <c>UNKNOWN</c>.
        /// </para>
        /// </summary>
        public ColumnNullable Nullable { get; set; }

        /// <summary>
        /// Checks to see if the Nullable property is set.
        /// </summary>
        internal bool IsSetNullable() => this.Nullable != null;

        /// <summary>
        /// Gets and sets the property Precision. 
        /// <para>
        /// For <c>DECIMAL</c> data types, specifies the total number of digits, up to 38. For
        /// performance reasons, we recommend up to 18 digits.
        /// </para>
        /// </summary>
        public int? Precision { get; set; }

        /// <summary>
        /// Checks to see if the Precision property is set.
        /// </summary>
        internal bool IsSetPrecision() => this.Precision.HasValue;

        /// <summary>
        /// Gets and sets the property Scale. 
        /// <para>
        /// For <c>DECIMAL</c> data types, specifies the total number of digits in the fractional
        /// part of the value. Defaults to 0.
        /// </para>
        /// </summary>
        public int? Scale { get; set; }

        /// <summary>
        /// Checks to see if the Scale property is set.
        /// </summary>
        internal bool IsSetScale() => this.Scale.HasValue;

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The schema name (database name) to which the query results belong.
        /// </para>
        /// </summary>
        public string SchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SchemaName property is set.
        /// </summary>
        internal bool IsSetSchemaName() => this.SchemaName != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The table name for the query results.
        /// </para>
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
