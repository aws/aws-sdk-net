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

namespace Amazon.NumericTypesRestJson.Model
{
    /// <summary>
    /// This is the response object from the HttpNumbers operation.
    /// </summary>
    public partial class HttpNumbersResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property HeaderBigDecimal.
        /// </summary>
        public Amazon.Extensions.Numerics.BigDecimal? HeaderBigDecimal { get; set; }

        /// <summary>
        /// Checks to see if the HeaderBigDecimal property is set.
        /// </summary>
        internal bool IsSetHeaderBigDecimal() => this.HeaderBigDecimal.HasValue;

        /// <summary>
        /// Gets and sets the property HeaderBigDecimalList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Amazon.Extensions.Numerics.BigDecimal> HeaderBigDecimalList { get; set; } = AWSConfigs.InitializeCollections ? new List<Amazon.Extensions.Numerics.BigDecimal>() : null;

        /// <summary>
        /// Checks to see if the HeaderBigDecimalList property is set.
        /// </summary>
        internal bool IsSetHeaderBigDecimalList() => this.HeaderBigDecimalList != null && (this.HeaderBigDecimalList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HeaderBigInteger.
        /// </summary>
        public System.Numerics.BigInteger? HeaderBigInteger { get; set; }

        /// <summary>
        /// Checks to see if the HeaderBigInteger property is set.
        /// </summary>
        internal bool IsSetHeaderBigInteger() => this.HeaderBigInteger.HasValue;

        /// <summary>
        /// Gets and sets the property HeaderBigIntegerList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<System.Numerics.BigInteger> HeaderBigIntegerList { get; set; } = AWSConfigs.InitializeCollections ? new List<System.Numerics.BigInteger>() : null;

        /// <summary>
        /// Checks to see if the HeaderBigIntegerList property is set.
        /// </summary>
        internal bool IsSetHeaderBigIntegerList() => this.HeaderBigIntegerList != null && (this.HeaderBigIntegerList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HeaderByte.
        /// </summary>
        public sbyte? HeaderByte { get; set; }

        /// <summary>
        /// Checks to see if the HeaderByte property is set.
        /// </summary>
        internal bool IsSetHeaderByte() => this.HeaderByte.HasValue;

        /// <summary>
        /// Gets and sets the property HeaderShort.
        /// </summary>
        public short? HeaderShort { get; set; }

        /// <summary>
        /// Checks to see if the HeaderShort property is set.
        /// </summary>
        internal bool IsSetHeaderShort() => this.HeaderShort.HasValue;

        /// <summary>
        /// Gets and sets the property HeaderShortList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<short> HeaderShortList { get; set; } = AWSConfigs.InitializeCollections ? new List<short>() : null;

        /// <summary>
        /// Checks to see if the HeaderShortList property is set.
        /// </summary>
        internal bool IsSetHeaderShortList() => this.HeaderShortList != null && (this.HeaderShortList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
