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
 * Do not modify this file. This file is generated from the numerictypesrestjson-2026-10-26.normal.json service model.
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
        private Amazon.Extensions.Numerics.BigDecimal? _headerBigDecimal;
        private List<Amazon.Extensions.Numerics.BigDecimal> _headerBigDecimalList = AWSConfigs.InitializeCollections ? new List<Amazon.Extensions.Numerics.BigDecimal>() : null;
        private System.Numerics.BigInteger? _headerBigInteger;
        private List<System.Numerics.BigInteger> _headerBigIntegerList = AWSConfigs.InitializeCollections ? new List<System.Numerics.BigInteger>() : null;
        private sbyte? _headerByte;
        private short? _headerShort;
        private List<short> _headerShortList = AWSConfigs.InitializeCollections ? new List<short>() : null;

        /// <summary>
        /// Gets and sets the property HeaderBigDecimal.
        /// </summary>
        public Amazon.Extensions.Numerics.BigDecimal? HeaderBigDecimal
        {
            get { return this._headerBigDecimal; }
            set { this._headerBigDecimal = value; }
        }

        // Check to see if HeaderBigDecimal property is set
        internal bool IsSetHeaderBigDecimal()
        {
            return this._headerBigDecimal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeaderBigDecimalList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Amazon.Extensions.Numerics.BigDecimal> HeaderBigDecimalList
        {
            get { return this._headerBigDecimalList; }
            set { this._headerBigDecimalList = value; }
        }

        // Check to see if HeaderBigDecimalList property is set
        internal bool IsSetHeaderBigDecimalList()
        {
            return this._headerBigDecimalList != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderBigInteger.
        /// </summary>
        public System.Numerics.BigInteger? HeaderBigInteger
        {
            get { return this._headerBigInteger; }
            set { this._headerBigInteger = value; }
        }

        // Check to see if HeaderBigInteger property is set
        internal bool IsSetHeaderBigInteger()
        {
            return this._headerBigInteger.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeaderBigIntegerList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<System.Numerics.BigInteger> HeaderBigIntegerList
        {
            get { return this._headerBigIntegerList; }
            set { this._headerBigIntegerList = value; }
        }

        // Check to see if HeaderBigIntegerList property is set
        internal bool IsSetHeaderBigIntegerList()
        {
            return this._headerBigIntegerList != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderByte.
        /// </summary>
        public sbyte? HeaderByte
        {
            get { return this._headerByte; }
            set { this._headerByte = value; }
        }

        // Check to see if HeaderByte property is set
        internal bool IsSetHeaderByte()
        {
            return this._headerByte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeaderShort.
        /// </summary>
        public short? HeaderShort
        {
            get { return this._headerShort; }
            set { this._headerShort = value; }
        }

        // Check to see if HeaderShort property is set
        internal bool IsSetHeaderShort()
        {
            return this._headerShort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeaderShortList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<short> HeaderShortList
        {
            get { return this._headerShortList; }
            set { this._headerShortList = value; }
        }

        // Check to see if HeaderShortList property is set
        internal bool IsSetHeaderShortList()
        {
            return this._headerShortList != null;
        }

    }
}