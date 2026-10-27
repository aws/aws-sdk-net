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

namespace Amazon.KeyspacesStreams.Model
{
    /// <summary>
    /// Represents the value of a cell in an Amazon Keyspaces table, supporting various data
    /// types with type-specific fields.
    /// </summary>
    public partial class KeyspacesCellValue
    {
        /// <summary>
        /// Gets and sets the property AsciiT. 
        /// <para>
        /// A value of ASCII text type, containing US-ASCII characters. 
        /// </para>
        /// </summary>
        public string AsciiT { get; set; }

        /// <summary>
        /// Checks to see if the AsciiT property is set.
        /// </summary>
        internal bool IsSetAsciiT() => this.AsciiT != null;

        /// <summary>
        /// Gets and sets the property BigintT. 
        /// <para>
        /// A 64-bit signed integer value. 
        /// </para>
        /// </summary>
        public string BigintT { get; set; }

        /// <summary>
        /// Checks to see if the BigintT property is set.
        /// </summary>
        internal bool IsSetBigintT() => this.BigintT != null;

        /// <summary>
        /// Gets and sets the property BlobT. 
        /// <para>
        /// A binary large object (BLOB) value stored as a Base64-encoded string. 
        /// </para>
        /// </summary>
        public MemoryStream BlobT { get; set; }

        /// <summary>
        /// Checks to see if the BlobT property is set.
        /// </summary>
        internal bool IsSetBlobT() => this.BlobT != null;

        /// <summary>
        /// Gets and sets the property BoolT. 
        /// <para>
        /// A Boolean value, either <c>true</c> or <c>false</c>. 
        /// </para>
        /// </summary>
        public bool? BoolT { get; set; }

        /// <summary>
        /// Checks to see if the BoolT property is set.
        /// </summary>
        internal bool IsSetBoolT() => this.BoolT.HasValue;

        /// <summary>
        /// Gets and sets the property CounterT. 
        /// <para>
        /// A distributed counter value that can be incremented and decremented. 
        /// </para>
        /// </summary>
        public string CounterT { get; set; }

        /// <summary>
        /// Checks to see if the CounterT property is set.
        /// </summary>
        internal bool IsSetCounterT() => this.CounterT != null;

        /// <summary>
        /// Gets and sets the property DateT. 
        /// <para>
        /// A date value without a time component, represented as days since epoch (January 1,
        /// 1970). 
        /// </para>
        /// </summary>
        public string DateT { get; set; }

        /// <summary>
        /// Checks to see if the DateT property is set.
        /// </summary>
        internal bool IsSetDateT() => this.DateT != null;

        /// <summary>
        /// Gets and sets the property DecimalT. 
        /// <para>
        /// A variable-precision decimal number value. 
        /// </para>
        /// </summary>
        public string DecimalT { get; set; }

        /// <summary>
        /// Checks to see if the DecimalT property is set.
        /// </summary>
        internal bool IsSetDecimalT() => this.DecimalT != null;

        /// <summary>
        /// Gets and sets the property DoubleT. 
        /// <para>
        /// A 64-bit double-precision floating point value. 
        /// </para>
        /// </summary>
        public string DoubleT { get; set; }

        /// <summary>
        /// Checks to see if the DoubleT property is set.
        /// </summary>
        internal bool IsSetDoubleT() => this.DoubleT != null;

        /// <summary>
        /// Gets and sets the property DurationT. 
        /// <para>
        /// A duration value with nanosecond precision, representing a period of time encoded
        /// as 32-bit months, 32-bit days, and 64-bit nanoseconds. 
        /// </para>
        /// </summary>
        public string DurationT { get; set; }

        /// <summary>
        /// Checks to see if the DurationT property is set.
        /// </summary>
        internal bool IsSetDurationT() => this.DurationT != null;

        /// <summary>
        /// Gets and sets the property FloatT. 
        /// <para>
        /// A 32-bit single-precision floating point value. 
        /// </para>
        /// </summary>
        public string FloatT { get; set; }

        /// <summary>
        /// Checks to see if the FloatT property is set.
        /// </summary>
        internal bool IsSetFloatT() => this.FloatT != null;

        /// <summary>
        /// Gets and sets the property InetT. 
        /// <para>
        /// An IP address value, either IPv4 or IPv6 format. 
        /// </para>
        /// </summary>
        public string InetT { get; set; }

        /// <summary>
        /// Checks to see if the InetT property is set.
        /// </summary>
        internal bool IsSetInetT() => this.InetT != null;

        /// <summary>
        /// Gets and sets the property IntT. 
        /// <para>
        /// A 32-bit signed integer value. 
        /// </para>
        /// </summary>
        public string IntT { get; set; }

        /// <summary>
        /// Checks to see if the IntT property is set.
        /// </summary>
        internal bool IsSetIntT() => this.IntT != null;

        /// <summary>
        /// Gets and sets the property ListT. 
        /// <para>
        /// An ordered collection of elements that can contain duplicate values. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyspacesCell> ListT { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyspacesCell>() : null;

        /// <summary>
        /// Checks to see if the ListT property is set.
        /// </summary>
        internal bool IsSetListT() => this.ListT != null && (this.ListT.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MapT. 
        /// <para>
        /// A collection of key-value pairs where each key is unique. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyspacesCellMapDefinition> MapT { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyspacesCellMapDefinition>() : null;

        /// <summary>
        /// Checks to see if the MapT property is set.
        /// </summary>
        internal bool IsSetMapT() => this.MapT != null && (this.MapT.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SetT. 
        /// <para>
        /// An unordered collection of unique elements. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyspacesCell> SetT { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyspacesCell>() : null;

        /// <summary>
        /// Checks to see if the SetT property is set.
        /// </summary>
        internal bool IsSetSetT() => this.SetT != null && (this.SetT.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SmallintT. 
        /// <para>
        /// A 16-bit signed integer value. 
        /// </para>
        /// </summary>
        public string SmallintT { get; set; }

        /// <summary>
        /// Checks to see if the SmallintT property is set.
        /// </summary>
        internal bool IsSetSmallintT() => this.SmallintT != null;

        /// <summary>
        /// Gets and sets the property TextT. 
        /// <para>
        /// A UTF-8 encoded string value. 
        /// </para>
        /// </summary>
        public string TextT { get; set; }

        /// <summary>
        /// Checks to see if the TextT property is set.
        /// </summary>
        internal bool IsSetTextT() => this.TextT != null;

        /// <summary>
        /// Gets and sets the property TimeT. 
        /// <para>
        /// A time value without a date component, with nanosecond precision. 
        /// </para>
        /// </summary>
        public string TimeT { get; set; }

        /// <summary>
        /// Checks to see if the TimeT property is set.
        /// </summary>
        internal bool IsSetTimeT() => this.TimeT != null;

        /// <summary>
        /// Gets and sets the property TimestampT. 
        /// <para>
        /// A timestamp value representing date and time with millisecond precision. 
        /// </para>
        /// </summary>
        public string TimestampT { get; set; }

        /// <summary>
        /// Checks to see if the TimestampT property is set.
        /// </summary>
        internal bool IsSetTimestampT() => this.TimestampT != null;

        /// <summary>
        /// Gets and sets the property TimeuuidT. 
        /// <para>
        /// A universally unique identifier (UUID) that includes a timestamp component, ensuring
        /// both uniqueness and time ordering. 
        /// </para>
        /// </summary>
        public string TimeuuidT { get; set; }

        /// <summary>
        /// Checks to see if the TimeuuidT property is set.
        /// </summary>
        internal bool IsSetTimeuuidT() => this.TimeuuidT != null;

        /// <summary>
        /// Gets and sets the property TinyintT. 
        /// <para>
        /// An 8-bit signed integer value. 
        /// </para>
        /// </summary>
        public string TinyintT { get; set; }

        /// <summary>
        /// Checks to see if the TinyintT property is set.
        /// </summary>
        internal bool IsSetTinyintT() => this.TinyintT != null;

        /// <summary>
        /// Gets and sets the property TupleT. 
        /// <para>
        /// A fixed-length ordered list of elements, where each element can be of a different
        /// data type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyspacesCell> TupleT { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyspacesCell>() : null;

        /// <summary>
        /// Checks to see if the TupleT property is set.
        /// </summary>
        internal bool IsSetTupleT() => this.TupleT != null && (this.TupleT.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UdtT. 
        /// <para>
        /// A user-defined type (UDT) value consisting of named fields, each with its own data
        /// type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, KeyspacesCell> UdtT { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, KeyspacesCell>() : null;

        /// <summary>
        /// Checks to see if the UdtT property is set.
        /// </summary>
        internal bool IsSetUdtT() => this.UdtT != null && (this.UdtT.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UuidT. 
        /// <para>
        /// A universally unique identifier (UUID) value. 
        /// </para>
        /// </summary>
        public string UuidT { get; set; }

        /// <summary>
        /// Checks to see if the UuidT property is set.
        /// </summary>
        internal bool IsSetUuidT() => this.UuidT != null;

        /// <summary>
        /// Gets and sets the property VarcharT. 
        /// <para>
        /// A UTF-8 encoded string value, functionally equivalent to text type. 
        /// </para>
        /// </summary>
        public string VarcharT { get; set; }

        /// <summary>
        /// Checks to see if the VarcharT property is set.
        /// </summary>
        internal bool IsSetVarcharT() => this.VarcharT != null;

        /// <summary>
        /// Gets and sets the property VarintT. 
        /// <para>
        /// An integer value within the +/-10^38 range. 
        /// </para>
        /// </summary>
        public string VarintT { get; set; }

        /// <summary>
        /// Checks to see if the VarintT property is set.
        /// </summary>
        internal bool IsSetVarintT() => this.VarintT != null;
    }
}
