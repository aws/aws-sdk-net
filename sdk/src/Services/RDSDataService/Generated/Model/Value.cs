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
    /// Column value
    /// </summary>
    public partial class Value
    {
        private List<Value> _arrayValues = new List<Value>();
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
        /// Gets and sets the property ArrayValues. Arbitrarily nested arrays
        /// </summary>
        public List<Value> ArrayValues
        {
            get { return this._arrayValues; }
            set { this._arrayValues = value; }
        }

        // Check to see if ArrayValues property is set
        internal bool IsSetArrayValues()
        {
            return this._arrayValues != null && this._arrayValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BigIntValue. Long value
        /// </summary>
        public long BigIntValue
        {
            get { return this._bigIntValue.GetValueOrDefault(); }
            set { this._bigIntValue = value; }
        }

        // Check to see if BigIntValue property is set
        internal bool IsSetBigIntValue()
        {
            return this._bigIntValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BitValue. Bit value
        /// </summary>
        public bool BitValue
        {
            get { return this._bitValue.GetValueOrDefault(); }
            set { this._bitValue = value; }
        }

        // Check to see if BitValue property is set
        internal bool IsSetBitValue()
        {
            return this._bitValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BlobValue. Blob value
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
        /// Gets and sets the property DoubleValue. Double value
        /// </summary>
        public double DoubleValue
        {
            get { return this._doubleValue.GetValueOrDefault(); }
            set { this._doubleValue = value; }
        }

        // Check to see if DoubleValue property is set
        internal bool IsSetDoubleValue()
        {
            return this._doubleValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntValue. Integer value
        /// </summary>
        public int IntValue
        {
            get { return this._intValue.GetValueOrDefault(); }
            set { this._intValue = value; }
        }

        // Check to see if IntValue property is set
        internal bool IsSetIntValue()
        {
            return this._intValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsNull. Is column null
        /// </summary>
        public bool IsNull
        {
            get { return this._isNull.GetValueOrDefault(); }
            set { this._isNull = value; }
        }

        // Check to see if IsNull property is set
        internal bool IsSetIsNull()
        {
            return this._isNull.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RealValue. Float value
        /// </summary>
        public float RealValue
        {
            get { return this._realValue.GetValueOrDefault(); }
            set { this._realValue = value; }
        }

        // Check to see if RealValue property is set
        internal bool IsSetRealValue()
        {
            return this._realValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringValue. String value
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
        /// Gets and sets the property StructValue. Struct or UDT
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