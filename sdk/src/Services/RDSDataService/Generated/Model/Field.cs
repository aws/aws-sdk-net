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

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// Contains a value.
    /// </summary>
    public partial class Field
    {
        private ArrayValue _arrayValue;
        private MemoryStream _blobValue;
        private bool? _booleanValue;
        private double? _doubleValue;
        private bool? _isNull;
        private long? _longValue;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property ArrayValue. 
        /// <para>
        /// An array of values.
        /// </para>
        /// </summary>
        public ArrayValue ArrayValue
        {
            get { return this._arrayValue; }
            set { this._arrayValue = value; }
        }

        // Check to see if ArrayValue property is set
        internal bool IsSetArrayValue()
        {
            return this._arrayValue != null;
        }

        /// <summary>
        /// Gets and sets the property BlobValue. 
        /// <para>
        /// A value of BLOB data type.
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
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// A value of Boolean data type.
        /// </para>
        /// </summary>
        public bool BooleanValue
        {
            get { return this._booleanValue.GetValueOrDefault(); }
            set { this._booleanValue = value; }
        }

        // Check to see if BooleanValue property is set
        internal bool IsSetBooleanValue()
        {
            return this._booleanValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// A value of double data type.
        /// </para>
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
        /// Gets and sets the property IsNull. 
        /// <para>
        /// A NULL value.
        /// </para>
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
        /// Gets and sets the property LongValue. 
        /// <para>
        /// A value of long data type.
        /// </para>
        /// </summary>
        public long LongValue
        {
            get { return this._longValue.GetValueOrDefault(); }
            set { this._longValue = value; }
        }

        // Check to see if LongValue property is set
        internal bool IsSetLongValue()
        {
            return this._longValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A value of string data type.
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

    }
}