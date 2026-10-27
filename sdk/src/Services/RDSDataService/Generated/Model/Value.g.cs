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

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// Contains the value of a column.
    /// 
    ///  <note> 
    /// <para>
    /// This data structure is only used with the deprecated <c>ExecuteSql</c> operation.
    /// Use the <c>BatchExecuteStatement</c> or <c>ExecuteStatement</c> operation instead.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Value
    {
        /// <summary>
        /// Gets and sets the property ArrayValues. 
        /// <para>
        /// An array of column values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Value> ArrayValues { get; set; } = AWSConfigs.InitializeCollections ? new List<Value>() : null;

        /// <summary>
        /// Checks to see if the ArrayValues property is set.
        /// </summary>
        internal bool IsSetArrayValues() => this.ArrayValues != null && (this.ArrayValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BigIntValue. 
        /// <para>
        /// A value for a column of big integer data type.
        /// </para>
        /// </summary>
        public long? BigIntValue { get; set; }

        /// <summary>
        /// Checks to see if the BigIntValue property is set.
        /// </summary>
        internal bool IsSetBigIntValue() => this.BigIntValue.HasValue;

        /// <summary>
        /// Gets and sets the property BitValue. 
        /// <para>
        /// A value for a column of BIT data type.
        /// </para>
        /// </summary>
        public bool? BitValue { get; set; }

        /// <summary>
        /// Checks to see if the BitValue property is set.
        /// </summary>
        internal bool IsSetBitValue() => this.BitValue.HasValue;

        /// <summary>
        /// Gets and sets the property BlobValue. 
        /// <para>
        /// A value for a column of BLOB data type.
        /// </para>
        /// </summary>
        public MemoryStream BlobValue { get; set; }

        /// <summary>
        /// Checks to see if the BlobValue property is set.
        /// </summary>
        internal bool IsSetBlobValue() => this.BlobValue != null;

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// A value for a column of double data type.
        /// </para>
        /// </summary>
        public double? DoubleValue { get; set; }

        /// <summary>
        /// Checks to see if the DoubleValue property is set.
        /// </summary>
        internal bool IsSetDoubleValue() => this.DoubleValue.HasValue;

        /// <summary>
        /// Gets and sets the property IntValue. 
        /// <para>
        /// A value for a column of integer data type.
        /// </para>
        /// </summary>
        public int? IntValue { get; set; }

        /// <summary>
        /// Checks to see if the IntValue property is set.
        /// </summary>
        internal bool IsSetIntValue() => this.IntValue.HasValue;

        /// <summary>
        /// Gets and sets the property IsNull. 
        /// <para>
        /// A NULL value.
        /// </para>
        /// </summary>
        public bool? IsNull { get; set; }

        /// <summary>
        /// Checks to see if the IsNull property is set.
        /// </summary>
        internal bool IsSetIsNull() => this.IsNull.HasValue;

        /// <summary>
        /// Gets and sets the property RealValue. 
        /// <para>
        /// A value for a column of real data type.
        /// </para>
        /// </summary>
        public float? RealValue { get; set; }

        /// <summary>
        /// Checks to see if the RealValue property is set.
        /// </summary>
        internal bool IsSetRealValue() => this.RealValue.HasValue;

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A value for a column of string data type.
        /// </para>
        /// </summary>
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;

        /// <summary>
        /// Gets and sets the property StructValue. 
        /// <para>
        /// A value for a column of STRUCT data type.
        /// </para>
        /// </summary>
        public StructValue StructValue { get; set; }

        /// <summary>
        /// Checks to see if the StructValue property is set.
        /// </summary>
        internal bool IsSetStructValue() => this.StructValue != null;
    }
}
