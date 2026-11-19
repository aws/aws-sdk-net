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

namespace Amazon.NumericTypesCbor.Model
{
    /// <summary>
    /// </summary>
    public partial class NestedNumbers
    {
        /// <summary>
        /// Gets and sets the property BigDecimalValue.
        /// </summary>
        public Amazon.Extensions.Numerics.BigDecimal? BigDecimalValue { get; set; }

        /// <summary>
        /// Checks to see if the BigDecimalValue property is set.
        /// </summary>
        internal bool IsSetBigDecimalValue() => this.BigDecimalValue.HasValue;

        /// <summary>
        /// Gets and sets the property BigIntegerValue.
        /// </summary>
        public System.Numerics.BigInteger? BigIntegerValue { get; set; }

        /// <summary>
        /// Checks to see if the BigIntegerValue property is set.
        /// </summary>
        internal bool IsSetBigIntegerValue() => this.BigIntegerValue.HasValue;

        /// <summary>
        /// Gets and sets the property ByteValue.
        /// </summary>
        public sbyte? ByteValue { get; set; }

        /// <summary>
        /// Checks to see if the ByteValue property is set.
        /// </summary>
        internal bool IsSetByteValue() => this.ByteValue.HasValue;

        /// <summary>
        /// Gets and sets the property ShortValue.
        /// </summary>
        public short? ShortValue { get; set; }

        /// <summary>
        /// Checks to see if the ShortValue property is set.
        /// </summary>
        internal bool IsSetShortValue() => this.ShortValue.HasValue;
    }
}
