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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
        private bool? _caseSensitive;
        private string _catalogName;
        private string _label;
        private string _name;
        private ColumnNullable _nullable;
        private int? _precision;
        private int? _scale;
        private string _schemaName;
        private string _tableName;
        private string _type;

        /// <summary>
        /// Gets and sets the property CaseSensitive. 
        /// <para>
        /// Indicates whether values in the column are case-sensitive.
        /// </para>
        /// </summary>
        public bool? CaseSensitive
        {
            get { return this._caseSensitive; }
            set { this._caseSensitive = value; }
        }

        // Check to see if CaseSensitive property is set
        internal bool IsSetCaseSensitive()
        {
            return this._caseSensitive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CatalogName. 
        /// <para>
        /// The catalog to which the query results belong.
        /// </para>
        /// </summary>
        public string CatalogName
        {
            get { return this._catalogName; }
            set { this._catalogName = value; }
        }

        // Check to see if CatalogName property is set
        internal bool IsSetCatalogName()
        {
            return this._catalogName != null;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// A column label.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Nullable. 
        /// <para>
        /// Unsupported constraint. This value always shows as <c>UNKNOWN</c>.
        /// </para>
        /// </summary>
        public ColumnNullable Nullable
        {
            get { return this._nullable; }
            set { this._nullable = value; }
        }

        // Check to see if Nullable property is set
        internal bool IsSetNullable()
        {
            return this._nullable != null;
        }

        /// <summary>
        /// Gets and sets the property Precision. 
        /// <para>
        /// For <c>DECIMAL</c> data types, specifies the total number of digits, up to 38. For
        /// performance reasons, we recommend up to 18 digits.
        /// </para>
        /// </summary>
        public int? Precision
        {
            get { return this._precision; }
            set { this._precision = value; }
        }

        // Check to see if Precision property is set
        internal bool IsSetPrecision()
        {
            return this._precision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Scale. 
        /// <para>
        /// For <c>DECIMAL</c> data types, specifies the total number of digits in the fractional
        /// part of the value. Defaults to 0.
        /// </para>
        /// </summary>
        public int? Scale
        {
            get { return this._scale; }
            set { this._scale = value; }
        }

        // Check to see if Scale property is set
        internal bool IsSetScale()
        {
            return this._scale.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The schema name (database name) to which the query results belong.
        /// </para>
        /// </summary>
        public string SchemaName
        {
            get { return this._schemaName; }
            set { this._schemaName = value; }
        }

        // Check to see if SchemaName property is set
        internal bool IsSetSchemaName()
        {
            return this._schemaName != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The table name for the query results.
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}