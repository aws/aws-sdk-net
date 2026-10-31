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
    /// Container for the parameters to the HttpNumbers operation.
    /// Sends every numeric type in headers, the query string and the URI, and receives them
    /// in headers.
    /// </summary>
    public partial class HttpNumbersRequest : AmazonNumericTypesRestXmlRequest
    {
        private Amazon.Extensions.Numerics.BigDecimal? _headerBigDecimal;
        private List<Amazon.Extensions.Numerics.BigDecimal> _headerBigDecimalList = AWSConfigs.InitializeCollections ? new List<Amazon.Extensions.Numerics.BigDecimal>() : null;
        private System.Numerics.BigInteger? _headerBigInteger;
        private List<System.Numerics.BigInteger> _headerBigIntegerList = AWSConfigs.InitializeCollections ? new List<System.Numerics.BigInteger>() : null;
        private sbyte? _headerByte;
        private short? _headerShort;
        private List<short> _headerShortList = AWSConfigs.InitializeCollections ? new List<short>() : null;
        private Amazon.Extensions.Numerics.BigDecimal? _labelBigDecimal;
        private System.Numerics.BigInteger? _labelBigInteger;
        private sbyte? _labelByte;
        private short? _labelShort;
        private Amazon.Extensions.Numerics.BigDecimal? _queryBigDecimal;
        private List<Amazon.Extensions.Numerics.BigDecimal> _queryBigDecimalList = AWSConfigs.InitializeCollections ? new List<Amazon.Extensions.Numerics.BigDecimal>() : null;
        private System.Numerics.BigInteger? _queryBigInteger;
        private List<System.Numerics.BigInteger> _queryBigIntegerList = AWSConfigs.InitializeCollections ? new List<System.Numerics.BigInteger>() : null;
        private sbyte? _queryByte;
        private List<sbyte> _queryByteList = AWSConfigs.InitializeCollections ? new List<sbyte>() : null;
        private short? _queryShort;
        private List<short> _queryShortList = AWSConfigs.InitializeCollections ? new List<short>() : null;

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

        /// <summary>
        /// Gets and sets the property LabelBigDecimal.
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Extensions.Numerics.BigDecimal? LabelBigDecimal
        {
            get { return this._labelBigDecimal; }
            set { this._labelBigDecimal = value; }
        }

        // Check to see if LabelBigDecimal property is set
        internal bool IsSetLabelBigDecimal()
        {
            return this._labelBigDecimal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LabelBigInteger.
        /// </summary>
        [AWSProperty(Required=true)]
        public System.Numerics.BigInteger? LabelBigInteger
        {
            get { return this._labelBigInteger; }
            set { this._labelBigInteger = value; }
        }

        // Check to see if LabelBigInteger property is set
        internal bool IsSetLabelBigInteger()
        {
            return this._labelBigInteger.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LabelByte.
        /// </summary>
        [AWSProperty(Required=true)]
        public sbyte? LabelByte
        {
            get { return this._labelByte; }
            set { this._labelByte = value; }
        }

        // Check to see if LabelByte property is set
        internal bool IsSetLabelByte()
        {
            return this._labelByte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LabelShort.
        /// </summary>
        [AWSProperty(Required=true)]
        public short? LabelShort
        {
            get { return this._labelShort; }
            set { this._labelShort = value; }
        }

        // Check to see if LabelShort property is set
        internal bool IsSetLabelShort()
        {
            return this._labelShort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryBigDecimal.
        /// </summary>
        public Amazon.Extensions.Numerics.BigDecimal? QueryBigDecimal
        {
            get { return this._queryBigDecimal; }
            set { this._queryBigDecimal = value; }
        }

        // Check to see if QueryBigDecimal property is set
        internal bool IsSetQueryBigDecimal()
        {
            return this._queryBigDecimal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryBigDecimalList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Amazon.Extensions.Numerics.BigDecimal> QueryBigDecimalList
        {
            get { return this._queryBigDecimalList; }
            set { this._queryBigDecimalList = value; }
        }

        // Check to see if QueryBigDecimalList property is set
        internal bool IsSetQueryBigDecimalList()
        {
            return this._queryBigDecimalList != null && (this._queryBigDecimalList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryBigInteger.
        /// </summary>
        public System.Numerics.BigInteger? QueryBigInteger
        {
            get { return this._queryBigInteger; }
            set { this._queryBigInteger = value; }
        }

        // Check to see if QueryBigInteger property is set
        internal bool IsSetQueryBigInteger()
        {
            return this._queryBigInteger.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryBigIntegerList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<System.Numerics.BigInteger> QueryBigIntegerList
        {
            get { return this._queryBigIntegerList; }
            set { this._queryBigIntegerList = value; }
        }

        // Check to see if QueryBigIntegerList property is set
        internal bool IsSetQueryBigIntegerList()
        {
            return this._queryBigIntegerList != null && (this._queryBigIntegerList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryByte.
        /// </summary>
        public sbyte? QueryByte
        {
            get { return this._queryByte; }
            set { this._queryByte = value; }
        }

        // Check to see if QueryByte property is set
        internal bool IsSetQueryByte()
        {
            return this._queryByte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryByteList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<sbyte> QueryByteList
        {
            get { return this._queryByteList; }
            set { this._queryByteList = value; }
        }

        // Check to see if QueryByteList property is set
        internal bool IsSetQueryByteList()
        {
            return this._queryByteList != null && (this._queryByteList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryShort.
        /// </summary>
        public short? QueryShort
        {
            get { return this._queryShort; }
            set { this._queryShort = value; }
        }

        // Check to see if QueryShort property is set
        internal bool IsSetQueryShort()
        {
            return this._queryShort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryShortList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<short> QueryShortList
        {
            get { return this._queryShortList; }
            set { this._queryShortList = value; }
        }

        // Check to see if QueryShortList property is set
        internal bool IsSetQueryShortList()
        {
            return this._queryShortList != null && (this._queryShortList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}