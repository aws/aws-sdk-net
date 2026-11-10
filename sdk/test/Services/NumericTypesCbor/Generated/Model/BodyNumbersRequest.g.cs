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
    /// Container for the parameters to the BodyNumbers operation. Sends and receives every
    /// numeric type in the request and response bodies.
    /// </summary>
    public partial class BodyNumbersRequest : AmazonNumericTypesCborRequest
    {
        /// <summary>
        /// Gets and sets the property BigDecimalList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Amazon.Extensions.Numerics.BigDecimal> BigDecimalList { get; set; } = AWSConfigs.InitializeCollections ? new List<Amazon.Extensions.Numerics.BigDecimal>() : null;

        /// <summary>
        /// Checks to see if the BigDecimalList property is set.
        /// </summary>
        internal bool IsSetBigDecimalList() => this.BigDecimalList != null && (this.BigDecimalList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BigDecimalMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Amazon.Extensions.Numerics.BigDecimal> BigDecimalMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Extensions.Numerics.BigDecimal>() : null;

        /// <summary>
        /// Checks to see if the BigDecimalMap property is set.
        /// </summary>
        internal bool IsSetBigDecimalMap() => this.BigDecimalMap != null && (this.BigDecimalMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BigDecimalValue.
        /// </summary>
        public Amazon.Extensions.Numerics.BigDecimal? BigDecimalValue { get; set; }

        /// <summary>
        /// Checks to see if the BigDecimalValue property is set.
        /// </summary>
        internal bool IsSetBigDecimalValue() => this.BigDecimalValue.HasValue;

        /// <summary>
        /// Gets and sets the property BigIntegerList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<System.Numerics.BigInteger> BigIntegerList { get; set; } = AWSConfigs.InitializeCollections ? new List<System.Numerics.BigInteger>() : null;

        /// <summary>
        /// Checks to see if the BigIntegerList property is set.
        /// </summary>
        internal bool IsSetBigIntegerList() => this.BigIntegerList != null && (this.BigIntegerList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BigIntegerMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, System.Numerics.BigInteger> BigIntegerMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, System.Numerics.BigInteger>() : null;

        /// <summary>
        /// Checks to see if the BigIntegerMap property is set.
        /// </summary>
        internal bool IsSetBigIntegerMap() => this.BigIntegerMap != null && (this.BigIntegerMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BigIntegerValue.
        /// </summary>
        public System.Numerics.BigInteger? BigIntegerValue { get; set; }

        /// <summary>
        /// Checks to see if the BigIntegerValue property is set.
        /// </summary>
        internal bool IsSetBigIntegerValue() => this.BigIntegerValue.HasValue;

        /// <summary>
        /// Gets and sets the property ByteList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<sbyte> ByteList { get; set; } = AWSConfigs.InitializeCollections ? new List<sbyte>() : null;

        /// <summary>
        /// Checks to see if the ByteList property is set.
        /// </summary>
        internal bool IsSetByteList() => this.ByteList != null && (this.ByteList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ByteMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, sbyte> ByteMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, sbyte>() : null;

        /// <summary>
        /// Checks to see if the ByteMap property is set.
        /// </summary>
        internal bool IsSetByteMap() => this.ByteMap != null && (this.ByteMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ByteValue.
        /// </summary>
        public sbyte? ByteValue { get; set; }

        /// <summary>
        /// Checks to see if the ByteValue property is set.
        /// </summary>
        internal bool IsSetByteValue() => this.ByteValue.HasValue;

        /// <summary>
        /// Gets and sets the property Nested.
        /// </summary>
        public NestedNumbers Nested { get; set; }

        /// <summary>
        /// Checks to see if the Nested property is set.
        /// </summary>
        internal bool IsSetNested() => this.Nested != null;

        /// <summary>
        /// Gets and sets the property NestedList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NestedNumbers> NestedList { get; set; } = AWSConfigs.InitializeCollections ? new List<NestedNumbers>() : null;

        /// <summary>
        /// Checks to see if the NestedList property is set.
        /// </summary>
        internal bool IsSetNestedList() => this.NestedList != null && (this.NestedList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ShortList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<short> ShortList { get; set; } = AWSConfigs.InitializeCollections ? new List<short>() : null;

        /// <summary>
        /// Checks to see if the ShortList property is set.
        /// </summary>
        internal bool IsSetShortList() => this.ShortList != null && (this.ShortList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ShortMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, short> ShortMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, short>() : null;

        /// <summary>
        /// Checks to see if the ShortMap property is set.
        /// </summary>
        internal bool IsSetShortMap() => this.ShortMap != null && (this.ShortMap.Count > 0 || !AWSConfigs.InitializeCollections);

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
