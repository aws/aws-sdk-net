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
 * Do not modify this file. This file is generated from the redshift-data-2019-12-20.normal.json service model.
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
        private string _columnDefault;
        private bool? _isCaseSensitive;
        private bool? _isCurrency;
        private bool? _isSigned;
        private string _label;
        private int? _length;
        private string _name;
        private int? _nullable;
        private int? _precision;
        private int? _scale;
        private string _schemaName;
        private string _tableName;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property ColumnDefault. 
        /// <para>
        /// The default value of the column. 
        /// </para>
        /// </summary>
        public string ColumnDefault
        {
            get { return this._columnDefault; }
            set { this._columnDefault = value; }
        }

        // Check to see if ColumnDefault property is set
        internal bool IsSetColumnDefault()
        {
            return this._columnDefault != null;
        }

        /// <summary>
        /// Gets and sets the property IsCaseSensitive. 
        /// <para>
        /// A value that indicates whether the column is case-sensitive. 
        /// </para>
        /// </summary>
        public bool? IsCaseSensitive
        {
            get { return this._isCaseSensitive; }
            set { this._isCaseSensitive = value; }
        }

        // Check to see if IsCaseSensitive property is set
        internal bool IsSetIsCaseSensitive()
        {
            return this._isCaseSensitive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsCurrency. 
        /// <para>
        /// A value that indicates whether the column contains currency values.
        /// </para>
        /// </summary>
        public bool? IsCurrency
        {
            get { return this._isCurrency; }
            set { this._isCurrency = value; }
        }

        // Check to see if IsCurrency property is set
        internal bool IsSetIsCurrency()
        {
            return this._isCurrency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsSigned. 
        /// <para>
        /// A value that indicates whether an integer column is signed.
        /// </para>
        /// </summary>
        public bool? IsSigned
        {
            get { return this._isSigned; }
            set { this._isSigned = value; }
        }

        // Check to see if IsSigned property is set
        internal bool IsSetIsSigned()
        {
            return this._isSigned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The label for the column. 
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
        /// Gets and sets the property Length. 
        /// <para>
        /// The length of the column.
        /// </para>
        /// </summary>
        public int? Length
        {
            get { return this._length; }
            set { this._length = value; }
        }

        // Check to see if Length property is set
        internal bool IsSetLength()
        {
            return this._length.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the column. 
        /// </para>
        /// </summary>
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
        /// A value that indicates whether the column is nullable. 
        /// </para>
        /// </summary>
        public int? Nullable
        {
            get { return this._nullable; }
            set { this._nullable = value; }
        }

        // Check to see if Nullable property is set
        internal bool IsSetNullable()
        {
            return this._nullable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Precision. 
        /// <para>
        /// The precision value of a decimal number column. 
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
        /// The scale value of a decimal number column. 
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
        /// The name of the schema that contains the table that includes the column.
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
        /// The name of the table that includes the column. 
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
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The database-specific data type of the column. 
        /// </para>
        /// </summary>
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

    }
}