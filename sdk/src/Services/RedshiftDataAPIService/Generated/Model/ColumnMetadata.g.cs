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

namespace Amazon.RedshiftDataAPIService.Model
{
    /// <summary>
    /// The properties (metadata) of a column.
    /// </summary>
    public partial class ColumnMetadata
    {
        /// <summary>
        /// Gets and sets the property ColumnDefault. 
        /// <para>
        /// The default value of the column. 
        /// </para>
        /// </summary>
        public string ColumnDefault { get; set; }

        /// <summary>
        /// Checks to see if the ColumnDefault property is set.
        /// </summary>
        internal bool IsSetColumnDefault() => this.ColumnDefault != null;

        /// <summary>
        /// Gets and sets the property IsCaseSensitive. 
        /// <para>
        /// A value that indicates whether the column is case-sensitive. 
        /// </para>
        /// </summary>
        public bool? IsCaseSensitive { get; set; }

        /// <summary>
        /// Checks to see if the IsCaseSensitive property is set.
        /// </summary>
        internal bool IsSetIsCaseSensitive() => this.IsCaseSensitive.HasValue;

        /// <summary>
        /// Gets and sets the property IsCurrency. 
        /// <para>
        /// A value that indicates whether the column contains currency values.
        /// </para>
        /// </summary>
        public bool? IsCurrency { get; set; }

        /// <summary>
        /// Checks to see if the IsCurrency property is set.
        /// </summary>
        internal bool IsSetIsCurrency() => this.IsCurrency.HasValue;

        /// <summary>
        /// Gets and sets the property IsSigned. 
        /// <para>
        /// A value that indicates whether an integer column is signed.
        /// </para>
        /// </summary>
        public bool? IsSigned { get; set; }

        /// <summary>
        /// Checks to see if the IsSigned property is set.
        /// </summary>
        internal bool IsSetIsSigned() => this.IsSigned.HasValue;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The label for the column. 
        /// </para>
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property Length. 
        /// <para>
        /// The length of the column.
        /// </para>
        /// </summary>
        public int? Length { get; set; }

        /// <summary>
        /// Checks to see if the Length property is set.
        /// </summary>
        internal bool IsSetLength() => this.Length.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the column. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Nullable. 
        /// <para>
        /// A value that indicates whether the column is nullable. 
        /// </para>
        /// </summary>
        public int? Nullable { get; set; }

        /// <summary>
        /// Checks to see if the Nullable property is set.
        /// </summary>
        internal bool IsSetNullable() => this.Nullable.HasValue;

        /// <summary>
        /// Gets and sets the property Precision. 
        /// <para>
        /// The precision value of a decimal number column, or the column length for a non-numeric
        /// column. 
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
        /// The scale value of a decimal number column. 
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
        /// The name of the schema that contains the table that includes the column.
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
        /// The name of the table that includes the column. 
        /// </para>
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The database-specific data type of the column. 
        /// </para>
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;
    }
}
