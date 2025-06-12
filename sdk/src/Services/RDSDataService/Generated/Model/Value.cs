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
    /// Contains the value of a column.
    /// 
    ///  <note> 
    /// <para>
    /// This data structure is only used with the deprecated <c>ExecuteSql</c> operation.
    /// Use the <c>BatchExecuteStatement</c> or <c>ExecuteStatement</c> operation instead.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Value
    {
        private List<Value> _arrayValues = AWSConfigs.InitializeCollections ? new List<Value>() : null;
        private long? _bigIntValue;
        private bool? _bitValue;
        private MemoryStream _blobValue;
        private double? _doubleValue;
        private int? _intValue;
        private bool? _isNull;
        private float? _realValue;
        private string _stringValue;
        private StructValue _structValue;

        /// <summary>
        /// Gets and sets the property ArrayValues. 
        /// <para>
        /// An array of column values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Value> ArrayValues
        {
            get { return this._arrayValues; }
            set { this._arrayValues = value; }
        }

        // Check to see if ArrayValues property is set
        internal bool IsSetArrayValues()
        {
            return this._arrayValues != null && (this._arrayValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BigIntValue. 
        /// <para>
        /// A value for a column of big integer data type.
        /// </para>
        /// </summary>
        public long? BigIntValue
        {
            get { return this._bigIntValue; }
            set { this._bigIntValue = value; }
        }

        // Check to see if BigIntValue property is set
        internal bool IsSetBigIntValue()
        {
            return this._bigIntValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BitValue. 
        /// <para>
        /// A value for a column of BIT data type.
        /// </para>
        /// </summary>
        public bool? BitValue
        {
            get { return this._bitValue; }
            set { this._bitValue = value; }
        }

        // Check to see if BitValue property is set
        internal bool IsSetBitValue()
        {
            return this._bitValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BlobValue. 
        /// <para>
        /// A value for a column of BLOB data type.
        /// </para>
        /// </summary>
        public MemoryStream BlobValue
        {
            get { return this._blobValue; }
            set { this._blobValue = value; }
        }

        // Check to see if BlobValue property is set
        internal bool IsSetBlobValue()
        {
            return this._blobValue != null;
        }

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// A value for a column of double data type.
        /// </para>
        /// </summary>
        public double? DoubleValue
        {
            get { return this._doubleValue; }
            set { this._doubleValue = value; }
        }

        // Check to see if DoubleValue property is set
        internal bool IsSetDoubleValue()
        {
            return this._doubleValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntValue. 
        /// <para>
        /// A value for a column of integer data type.
        /// </para>
        /// </summary>
        public int? IntValue
        {
            get { return this._intValue; }
            set { this._intValue = value; }
        }

        // Check to see if IntValue property is set
        internal bool IsSetIntValue()
        {
            return this._intValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsNull. 
        /// <para>
        /// A NULL value.
        /// </para>
        /// </summary>
        public bool? IsNull
        {
            get { return this._isNull; }
            set { this._isNull = value; }
        }

        // Check to see if IsNull property is set
        internal bool IsSetIsNull()
        {
            return this._isNull.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RealValue. 
        /// <para>
        /// A value for a column of real data type.
        /// </para>
        /// </summary>
        public float? RealValue
        {
            get { return this._realValue; }
            set { this._realValue = value; }
        }

        // Check to see if RealValue property is set
        internal bool IsSetRealValue()
        {
            return this._realValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A value for a column of string data type.
        /// </para>
        /// </summary>
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

        /// <summary>
        /// Gets and sets the property StructValue. 
        /// <para>
        /// A value for a column of STRUCT data type.
        /// </para>
        /// </summary>
        public StructValue StructValue
        {
            get { return this._structValue; }
            set { this._structValue = value; }
        }

        // Check to see if StructValue property is set
        internal bool IsSetStructValue()
        {
            return this._structValue != null;
        }

    }
}