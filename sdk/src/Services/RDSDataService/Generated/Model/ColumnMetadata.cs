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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// Column Metadata
    /// </summary>
    public partial class ColumnMetadata
    {
        private int? _arrayBaseColumnType;
        private bool? _isAutoIncrement;
        private bool? _isCaseSensitive;
        private bool? _isCurrency;
        private bool? _isSigned;
        private string _label;
        private string _name;
        private int? _nullable;
        private int? _precision;
        private int? _scale;
        private string _schemaName;
        private string _tableName;
        private int? _type;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property ArrayBaseColumnType. Homogenous array base SQL type from
        /// java.sql.Types.
        /// </summary>
        public int ArrayBaseColumnType
        {
            get { return this._arrayBaseColumnType.GetValueOrDefault(); }
            set { this._arrayBaseColumnType = value; }
        }

        // Check to see if ArrayBaseColumnType property is set
        internal bool IsSetArrayBaseColumnType()
        {
            return this._arrayBaseColumnType.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsAutoIncrement. Whether the designated column is automatically
        /// numbered
        /// </summary>
        public bool IsAutoIncrement
        {
            get { return this._isAutoIncrement.GetValueOrDefault(); }
            set { this._isAutoIncrement = value; }
        }

        // Check to see if IsAutoIncrement property is set
        internal bool IsSetIsAutoIncrement()
        {
            return this._isAutoIncrement.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsCaseSensitive. Whether values in the designated column's
        /// case matters
        /// </summary>
        public bool IsCaseSensitive
        {
            get { return this._isCaseSensitive.GetValueOrDefault(); }
            set { this._isCaseSensitive = value; }
        }

        // Check to see if IsCaseSensitive property is set
        internal bool IsSetIsCaseSensitive()
        {
            return this._isCaseSensitive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsCurrency. Whether values in the designated column is
        /// a cash value
        /// </summary>
        public bool IsCurrency
        {
            get { return this._isCurrency.GetValueOrDefault(); }
            set { this._isCurrency = value; }
        }

        // Check to see if IsCurrency property is set
        internal bool IsSetIsCurrency()
        {
            return this._isCurrency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsSigned. Whether values in the designated column are signed
        /// numbers
        /// </summary>
        public bool IsSigned
        {
            get { return this._isSigned.GetValueOrDefault(); }
            set { this._isSigned = value; }
        }

        // Check to see if IsSigned property is set
        internal bool IsSetIsSigned()
        {
            return this._isSigned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Label. Usually specified by the SQL AS. If not specified,
        /// return column name.
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
        /// Gets and sets the property Name. Name of the column.
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
        /// Gets and sets the property Nullable. Indicates the nullability of values in the designated
        /// column. One of columnNoNulls (0), columnNullable (1), columnNullableUnknown (2)
        /// </summary>
        public int Nullable
        {
            get { return this._nullable.GetValueOrDefault(); }
            set { this._nullable = value; }
        }

        // Check to see if Nullable property is set
        internal bool IsSetNullable()
        {
            return this._nullable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Precision. Get the designated column's specified column
        /// size.For numeric data, this is the maximum precision.  For character data, this is
        /// the length in characters. For datetime datatypes, this is the length in characters
        /// of the String representation (assuming the maximum allowed precision of the fractional
        /// seconds component). For binary data, this is the length in bytes.  For the ROWID datatype,
        /// this is the length in bytes. 0 is returned for data types where the column size is
        /// not applicable.
        /// </summary>
        public int Precision
        {
            get { return this._precision.GetValueOrDefault(); }
            set { this._precision = value; }
        }

        // Check to see if Precision property is set
        internal bool IsSetPrecision()
        {
            return this._precision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Scale. Designated column's number of digits to right of
        /// the decimal point. 0 is returned for data types where the scale is not applicable.
        /// </summary>
        public int Scale
        {
            get { return this._scale.GetValueOrDefault(); }
            set { this._scale = value; }
        }

        // Check to see if Scale property is set
        internal bool IsSetScale()
        {
            return this._scale.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SchemaName. Designated column's table's schema
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
        /// Gets and sets the property TableName. Designated column's table name
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
        /// Gets and sets the property Type. SQL type from java.sql.Types.
        /// </summary>
        public int Type
        {
            get { return this._type.GetValueOrDefault(); }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TypeName. Database-specific type name.
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