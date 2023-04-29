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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains the individual types of column statistics data. Only one data object should
    /// be set and indicated by the <code>Type</code> attribute.
    /// </summary>
    public partial class ColumnStatisticsData
    {
        private BinaryColumnStatisticsData _binaryColumnStatisticsData;
        private BooleanColumnStatisticsData _booleanColumnStatisticsData;
        private DateColumnStatisticsData _dateColumnStatisticsData;
        private DecimalColumnStatisticsData _decimalColumnStatisticsData;
        private DoubleColumnStatisticsData _doubleColumnStatisticsData;
        private LongColumnStatisticsData _longColumnStatisticsData;
        private StringColumnStatisticsData _stringColumnStatisticsData;
        private ColumnStatisticsType _type;

        /// <summary>
        /// Gets and sets the property BinaryColumnStatisticsData. 
        /// <para>
        /// Binary column statistics data.
        /// </para>
        /// </summary>
        public BinaryColumnStatisticsData BinaryColumnStatisticsData
        {
            get { return this._binaryColumnStatisticsData; }
            set { this._binaryColumnStatisticsData = value; }
        }

        // Check to see if BinaryColumnStatisticsData property is set
        internal bool IsSetBinaryColumnStatisticsData()
        {
            return this._binaryColumnStatisticsData != null;
        }

        /// <summary>
        /// Gets and sets the property BooleanColumnStatisticsData. 
        /// <para>
        /// Boolean column statistics data.
        /// </para>
        /// </summary>
        public BooleanColumnStatisticsData BooleanColumnStatisticsData
        {
            get { return this._booleanColumnStatisticsData; }
            set { this._booleanColumnStatisticsData = value; }
        }

        // Check to see if BooleanColumnStatisticsData property is set
        internal bool IsSetBooleanColumnStatisticsData()
        {
            return this._booleanColumnStatisticsData != null;
        }

        /// <summary>
        /// Gets and sets the property DateColumnStatisticsData. 
        /// <para>
        /// Date column statistics data.
        /// </para>
        /// </summary>
        public DateColumnStatisticsData DateColumnStatisticsData
        {
            get { return this._dateColumnStatisticsData; }
            set { this._dateColumnStatisticsData = value; }
        }

        // Check to see if DateColumnStatisticsData property is set
        internal bool IsSetDateColumnStatisticsData()
        {
            return this._dateColumnStatisticsData != null;
        }

        /// <summary>
        /// Gets and sets the property DecimalColumnStatisticsData. 
        /// <para>
        ///  Decimal column statistics data. UnscaledValues within are Base64-encoded binary objects
        /// storing big-endian, two's complement representations of the decimal's unscaled value.
        /// 
        /// </para>
        /// </summary>
        public DecimalColumnStatisticsData DecimalColumnStatisticsData
        {
            get { return this._decimalColumnStatisticsData; }
            set { this._decimalColumnStatisticsData = value; }
        }

        // Check to see if DecimalColumnStatisticsData property is set
        internal bool IsSetDecimalColumnStatisticsData()
        {
            return this._decimalColumnStatisticsData != null;
        }

        /// <summary>
        /// Gets and sets the property DoubleColumnStatisticsData. 
        /// <para>
        /// Double column statistics data.
        /// </para>
        /// </summary>
        public DoubleColumnStatisticsData DoubleColumnStatisticsData
        {
            get { return this._doubleColumnStatisticsData; }
            set { this._doubleColumnStatisticsData = value; }
        }

        // Check to see if DoubleColumnStatisticsData property is set
        internal bool IsSetDoubleColumnStatisticsData()
        {
            return this._doubleColumnStatisticsData != null;
        }

        /// <summary>
        /// Gets and sets the property LongColumnStatisticsData. 
        /// <para>
        /// Long column statistics data.
        /// </para>
        /// </summary>
        public LongColumnStatisticsData LongColumnStatisticsData
        {
            get { return this._longColumnStatisticsData; }
            set { this._longColumnStatisticsData = value; }
        }

        // Check to see if LongColumnStatisticsData property is set
        internal bool IsSetLongColumnStatisticsData()
        {
            return this._longColumnStatisticsData != null;
        }

        /// <summary>
        /// Gets and sets the property StringColumnStatisticsData. 
        /// <para>
        /// String column statistics data.
        /// </para>
        /// </summary>
        public StringColumnStatisticsData StringColumnStatisticsData
        {
            get { return this._stringColumnStatisticsData; }
            set { this._stringColumnStatisticsData = value; }
        }

        // Check to see if StringColumnStatisticsData property is set
        internal bool IsSetStringColumnStatisticsData()
        {
            return this._stringColumnStatisticsData != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of column statistics data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnStatisticsType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}