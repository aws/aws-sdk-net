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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains the individual types of column statistics data. Only one data object should
    /// be set and indicated by the <c>Type</c> attribute.
    /// </summary>
    public partial class ColumnStatisticsData
    {
        /// <summary>
        /// Gets and sets the property BinaryColumnStatisticsData. 
        /// <para>
        /// Binary column statistics data.
        /// </para>
        /// </summary>
        public BinaryColumnStatisticsData BinaryColumnStatisticsData { get; set; }

        /// <summary>
        /// Checks to see if the BinaryColumnStatisticsData property is set.
        /// </summary>
        internal bool IsSetBinaryColumnStatisticsData() => this.BinaryColumnStatisticsData != null;

        /// <summary>
        /// Gets and sets the property BooleanColumnStatisticsData. 
        /// <para>
        /// Boolean column statistics data.
        /// </para>
        /// </summary>
        public BooleanColumnStatisticsData BooleanColumnStatisticsData { get; set; }

        /// <summary>
        /// Checks to see if the BooleanColumnStatisticsData property is set.
        /// </summary>
        internal bool IsSetBooleanColumnStatisticsData() => this.BooleanColumnStatisticsData != null;

        /// <summary>
        /// Gets and sets the property DateColumnStatisticsData. 
        /// <para>
        /// Date column statistics data.
        /// </para>
        /// </summary>
        public DateColumnStatisticsData DateColumnStatisticsData { get; set; }

        /// <summary>
        /// Checks to see if the DateColumnStatisticsData property is set.
        /// </summary>
        internal bool IsSetDateColumnStatisticsData() => this.DateColumnStatisticsData != null;

        /// <summary>
        /// Gets and sets the property DecimalColumnStatisticsData. 
        /// <para>
        ///  Decimal column statistics data. UnscaledValues within are Base64-encoded binary objects
        /// storing big-endian, two's complement representations of the decimal's unscaled value.
        /// 
        /// </para>
        /// </summary>
        public DecimalColumnStatisticsData DecimalColumnStatisticsData { get; set; }

        /// <summary>
        /// Checks to see if the DecimalColumnStatisticsData property is set.
        /// </summary>
        internal bool IsSetDecimalColumnStatisticsData() => this.DecimalColumnStatisticsData != null;

        /// <summary>
        /// Gets and sets the property DoubleColumnStatisticsData. 
        /// <para>
        /// Double column statistics data.
        /// </para>
        /// </summary>
        public DoubleColumnStatisticsData DoubleColumnStatisticsData { get; set; }

        /// <summary>
        /// Checks to see if the DoubleColumnStatisticsData property is set.
        /// </summary>
        internal bool IsSetDoubleColumnStatisticsData() => this.DoubleColumnStatisticsData != null;

        /// <summary>
        /// Gets and sets the property LongColumnStatisticsData. 
        /// <para>
        /// Long column statistics data.
        /// </para>
        /// </summary>
        public LongColumnStatisticsData LongColumnStatisticsData { get; set; }

        /// <summary>
        /// Checks to see if the LongColumnStatisticsData property is set.
        /// </summary>
        internal bool IsSetLongColumnStatisticsData() => this.LongColumnStatisticsData != null;

        /// <summary>
        /// Gets and sets the property StringColumnStatisticsData. 
        /// <para>
        /// String column statistics data.
        /// </para>
        /// </summary>
        public StringColumnStatisticsData StringColumnStatisticsData { get; set; }

        /// <summary>
        /// Checks to see if the StringColumnStatisticsData property is set.
        /// </summary>
        internal bool IsSetStringColumnStatisticsData() => this.StringColumnStatisticsData != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of column statistics data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ColumnStatisticsType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
