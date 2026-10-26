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
 * Do not modify this file. This file is generated from the numerictypesrestxml-2026-10-26.normal.json service model.
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
namespace Amazon.NumericTypesRestXml.Model
{
    /// <summary>
    /// Container for the parameters to the BodyNumbers operation.
    /// Sends and receives every numeric type in the request and response bodies.
    /// </summary>
    public partial class BodyNumbersRequest : AmazonNumericTypesRestXmlRequest
    {
        private List<Amazon.Extensions.Numerics.BigDecimal> _bigDecimalList = AWSConfigs.InitializeCollections ? new List<Amazon.Extensions.Numerics.BigDecimal>() : null;
        private Dictionary<string, Amazon.Extensions.Numerics.BigDecimal> _bigDecimalMap = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Extensions.Numerics.BigDecimal>() : null;
        private Amazon.Extensions.Numerics.BigDecimal? _bigDecimalValue;
        private List<System.Numerics.BigInteger> _bigIntegerList = AWSConfigs.InitializeCollections ? new List<System.Numerics.BigInteger>() : null;
        private Dictionary<string, System.Numerics.BigInteger> _bigIntegerMap = AWSConfigs.InitializeCollections ? new Dictionary<string, System.Numerics.BigInteger>() : null;
        private System.Numerics.BigInteger? _bigIntegerValue;
        private List<sbyte> _byteList = AWSConfigs.InitializeCollections ? new List<sbyte>() : null;
        private Dictionary<string, sbyte> _byteMap = AWSConfigs.InitializeCollections ? new Dictionary<string, sbyte>() : null;
        private sbyte? _byteValue;
        private NestedNumbers _nested;
        private List<NestedNumbers> _nestedList = AWSConfigs.InitializeCollections ? new List<NestedNumbers>() : null;
        private List<short> _shortList = AWSConfigs.InitializeCollections ? new List<short>() : null;
        private Dictionary<string, short> _shortMap = AWSConfigs.InitializeCollections ? new Dictionary<string, short>() : null;
        private short? _shortValue;

        /// <summary>
        /// Gets and sets the property BigDecimalList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Amazon.Extensions.Numerics.BigDecimal> BigDecimalList
        {
            get { return this._bigDecimalList; }
            set { this._bigDecimalList = value; }
        }

        // Check to see if BigDecimalList property is set
        internal bool IsSetBigDecimalList()
        {
            return this._bigDecimalList != null && (this._bigDecimalList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BigDecimalMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Amazon.Extensions.Numerics.BigDecimal> BigDecimalMap
        {
            get { return this._bigDecimalMap; }
            set { this._bigDecimalMap = value; }
        }

        // Check to see if BigDecimalMap property is set
        internal bool IsSetBigDecimalMap()
        {
            return this._bigDecimalMap != null && (this._bigDecimalMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Gets and sets the property BigIntegerList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<System.Numerics.BigInteger> BigIntegerList
        {
            get { return this._bigIntegerList; }
            set { this._bigIntegerList = value; }
        }

        // Check to see if BigIntegerList property is set
        internal bool IsSetBigIntegerList()
        {
            return this._bigIntegerList != null && (this._bigIntegerList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BigIntegerMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, System.Numerics.BigInteger> BigIntegerMap
        {
            get { return this._bigIntegerMap; }
            set { this._bigIntegerMap = value; }
        }

        // Check to see if BigIntegerMap property is set
        internal bool IsSetBigIntegerMap()
        {
            return this._bigIntegerMap != null && (this._bigIntegerMap.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property ByteList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<sbyte> ByteList
        {
            get { return this._byteList; }
            set { this._byteList = value; }
        }

        // Check to see if ByteList property is set
        internal bool IsSetByteList()
        {
            return this._byteList != null && (this._byteList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ByteMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, sbyte> ByteMap
        {
            get { return this._byteMap; }
            set { this._byteMap = value; }
        }

        // Check to see if ByteMap property is set
        internal bool IsSetByteMap()
        {
            return this._byteMap != null && (this._byteMap.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property Nested.
        /// </summary>
        public NestedNumbers Nested
        {
            get { return this._nested; }
            set { this._nested = value; }
        }

        // Check to see if Nested property is set
        internal bool IsSetNested()
        {
            return this._nested != null;
        }

        /// <summary>
        /// Gets and sets the property NestedList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NestedNumbers> NestedList
        {
            get { return this._nestedList; }
            set { this._nestedList = value; }
        }

        // Check to see if NestedList property is set
        internal bool IsSetNestedList()
        {
            return this._nestedList != null && (this._nestedList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ShortList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<short> ShortList
        {
            get { return this._shortList; }
            set { this._shortList = value; }
        }

        // Check to see if ShortList property is set
        internal bool IsSetShortList()
        {
            return this._shortList != null && (this._shortList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ShortMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, short> ShortMap
        {
            get { return this._shortMap; }
            set { this._shortMap = value; }
        }

        // Check to see if ShortMap property is set
        internal bool IsSetShortMap()
        {
            return this._shortMap != null && (this._shortMap.Count > 0 || !AWSConfigs.InitializeCollections); 
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