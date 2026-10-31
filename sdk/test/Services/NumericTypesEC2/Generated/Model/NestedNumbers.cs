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
 * Do not modify this file. This file is generated from the numerictypesec2-2026-10-26.normal.json service model.
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
namespace Amazon.NumericTypesEC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class NestedNumbers
    {
        private Amazon.Extensions.Numerics.BigDecimal? _bigDecimalValue;
        private System.Numerics.BigInteger? _bigIntegerValue;
        private sbyte? _byteValue;
        private short? _shortValue;

        /// <summary>
        /// Gets and sets the property BigDecimalValue.
        /// </summary>
        public Amazon.Extensions.Numerics.BigDecimal? BigDecimalValue
        {
            get { return this._bigDecimalValue; }
            set { this._bigDecimalValue = value; }
        }

        // Check to see if BigDecimalValue property is set
        internal bool IsSetBigDecimalValue()
        {
            return this._bigDecimalValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BigIntegerValue.
        /// </summary>
        public System.Numerics.BigInteger? BigIntegerValue
        {
            get { return this._bigIntegerValue; }
            set { this._bigIntegerValue = value; }
        }

        // Check to see if BigIntegerValue property is set
        internal bool IsSetBigIntegerValue()
        {
            return this._bigIntegerValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ByteValue.
        /// </summary>
        public sbyte? ByteValue
        {
            get { return this._byteValue; }
            set { this._byteValue = value; }
        }

        // Check to see if ByteValue property is set
        internal bool IsSetByteValue()
        {
            return this._byteValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShortValue.
        /// </summary>
        public short? ShortValue
        {
            get { return this._shortValue; }
            set { this._shortValue = value; }
        }

        // Check to see if ShortValue property is set
        internal bool IsSetShortValue()
        {
            return this._shortValue.HasValue; 
        }

    }
}