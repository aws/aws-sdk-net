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
 * Do not modify this file. This file is generated from the keyspacesstreams-2024-09-09.normal.json service model.
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
        private string _asciit;
        private string _bigintt;
        private MemoryStream _blobt;
        private bool? _boolt;
        private string _countert;
        private string _datet;
        private string _decimalt;
        private string _doublet;
        private string _floatt;
        private string _inett;
        private string _intt;
        private List<KeyspacesCell> _listt = AWSConfigs.InitializeCollections ? new List<KeyspacesCell>() : null;
        private List<KeyspacesCellMapDefinition> _mapt = AWSConfigs.InitializeCollections ? new List<KeyspacesCellMapDefinition>() : null;
        private List<KeyspacesCell> _sett = AWSConfigs.InitializeCollections ? new List<KeyspacesCell>() : null;
        private string _smallintt;
        private string _textt;
        private string _timestampt;
        private string _timet;
        private string _timeuuidt;
        private string _tinyintt;
        private List<KeyspacesCell> _tuplet = AWSConfigs.InitializeCollections ? new List<KeyspacesCell>() : null;
        private Dictionary<string, KeyspacesCell> _udtt = AWSConfigs.InitializeCollections ? new Dictionary<string, KeyspacesCell>() : null;
        private string _uuidt;
        private string _varchart;
        private string _varintt;

        /// <summary>
        /// Gets and sets the property AsciiT. 
        /// <para>
        /// A value of ASCII text type, containing US-ASCII characters. 
        /// </para>
        /// </summary>
        public string AsciiT
        {
            get { return this._asciit; }
            set { this._asciit = value; }
        }

        // Check to see if AsciiT property is set
        internal bool IsSetAsciiT()
        {
            return this._asciit != null;
        }

        /// <summary>
        /// Gets and sets the property BigintT. 
        /// <para>
        /// A 64-bit signed integer value. 
        /// </para>
        /// </summary>
        public string BigintT
        {
            get { return this._bigintt; }
            set { this._bigintt = value; }
        }

        // Check to see if BigintT property is set
        internal bool IsSetBigintT()
        {
            return this._bigintt != null;
        }

        /// <summary>
        /// Gets and sets the property BlobT. 
        /// <para>
        /// A binary large object (BLOB) value stored as a Base64-encoded string. 
        /// </para>
        /// </summary>
        public MemoryStream BlobT
        {
            get { return this._blobt; }
            set { this._blobt = value; }
        }

        // Check to see if BlobT property is set
        internal bool IsSetBlobT()
        {
            return this._blobt != null;
        }

        /// <summary>
        /// Gets and sets the property BoolT. 
        /// <para>
        /// A Boolean value, either <c>true</c> or <c>false</c>. 
        /// </para>
        /// </summary>
        public bool? BoolT
        {
            get { return this._boolt; }
            set { this._boolt = value; }
        }

        // Check to see if BoolT property is set
        internal bool IsSetBoolT()
        {
            return this._boolt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CounterT. 
        /// <para>
        /// A distributed counter value that can be incremented and decremented. 
        /// </para>
        /// </summary>
        public string CounterT
        {
            get { return this._countert; }
            set { this._countert = value; }
        }

        // Check to see if CounterT property is set
        internal bool IsSetCounterT()
        {
            return this._countert != null;
        }

        /// <summary>
        /// Gets and sets the property DateT. 
        /// <para>
        /// A date value without a time component, represented as days since epoch (January 1,
        /// 1970). 
        /// </para>
        /// </summary>
        public string DateT
        {
            get { return this._datet; }
            set { this._datet = value; }
        }

        // Check to see if DateT property is set
        internal bool IsSetDateT()
        {
            return this._datet != null;
        }

        /// <summary>
        /// Gets and sets the property DecimalT. 
        /// <para>
        /// A variable-precision decimal number value. 
        /// </para>
        /// </summary>
        public string DecimalT
        {
            get { return this._decimalt; }
            set { this._decimalt = value; }
        }

        // Check to see if DecimalT property is set
        internal bool IsSetDecimalT()
        {
            return this._decimalt != null;
        }

        /// <summary>
        /// Gets and sets the property DoubleT. 
        /// <para>
        /// A 64-bit double-precision floating point value. 
        /// </para>
        /// </summary>
        public string DoubleT
        {
            get { return this._doublet; }
            set { this._doublet = value; }
        }

        // Check to see if DoubleT property is set
        internal bool IsSetDoubleT()
        {
            return this._doublet != null;
        }

        /// <summary>
        /// Gets and sets the property FloatT. 
        /// <para>
        /// A 32-bit single-precision floating point value. 
        /// </para>
        /// </summary>
        public string FloatT
        {
            get { return this._floatt; }
            set { this._floatt = value; }
        }

        // Check to see if FloatT property is set
        internal bool IsSetFloatT()
        {
            return this._floatt != null;
        }

        /// <summary>
        /// Gets and sets the property InetT. 
        /// <para>
        /// An IP address value, either IPv4 or IPv6 format. 
        /// </para>
        /// </summary>
        public string InetT
        {
            get { return this._inett; }
            set { this._inett = value; }
        }

        // Check to see if InetT property is set
        internal bool IsSetInetT()
        {
            return this._inett != null;
        }

        /// <summary>
        /// Gets and sets the property IntT. 
        /// <para>
        /// A 32-bit signed integer value. 
        /// </para>
        /// </summary>
        public string IntT
        {
            get { return this._intt; }
            set { this._intt = value; }
        }

        // Check to see if IntT property is set
        internal bool IsSetIntT()
        {
            return this._intt != null;
        }

        /// <summary>
        /// Gets and sets the property ListT. 
        /// <para>
        /// An ordered collection of elements that can contain duplicate values. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyspacesCell> ListT
        {
            get { return this._listt; }
            set { this._listt = value; }
        }

        // Check to see if ListT property is set
        internal bool IsSetListT()
        {
            return this._listt != null && (this._listt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MapT. 
        /// <para>
        /// A collection of key-value pairs where each key is unique. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyspacesCellMapDefinition> MapT
        {
            get { return this._mapt; }
            set { this._mapt = value; }
        }

        // Check to see if MapT property is set
        internal bool IsSetMapT()
        {
            return this._mapt != null && (this._mapt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SetT. 
        /// <para>
        /// An unordered collection of unique elements. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyspacesCell> SetT
        {
            get { return this._sett; }
            set { this._sett = value; }
        }

        // Check to see if SetT property is set
        internal bool IsSetSetT()
        {
            return this._sett != null && (this._sett.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SmallintT. 
        /// <para>
        /// A 16-bit signed integer value. 
        /// </para>
        /// </summary>
        public string SmallintT
        {
            get { return this._smallintt; }
            set { this._smallintt = value; }
        }

        // Check to see if SmallintT property is set
        internal bool IsSetSmallintT()
        {
            return this._smallintt != null;
        }

        /// <summary>
        /// Gets and sets the property TextT. 
        /// <para>
        /// A UTF-8 encoded string value. 
        /// </para>
        /// </summary>
        public string TextT
        {
            get { return this._textt; }
            set { this._textt = value; }
        }

        // Check to see if TextT property is set
        internal bool IsSetTextT()
        {
            return this._textt != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampT. 
        /// <para>
        /// A timestamp value representing date and time with millisecond precision. 
        /// </para>
        /// </summary>
        public string TimestampT
        {
            get { return this._timestampt; }
            set { this._timestampt = value; }
        }

        // Check to see if TimestampT property is set
        internal bool IsSetTimestampT()
        {
            return this._timestampt != null;
        }

        /// <summary>
        /// Gets and sets the property TimeT. 
        /// <para>
        /// A time value without a date component, with nanosecond precision. 
        /// </para>
        /// </summary>
        public string TimeT
        {
            get { return this._timet; }
            set { this._timet = value; }
        }

        // Check to see if TimeT property is set
        internal bool IsSetTimeT()
        {
            return this._timet != null;
        }

        /// <summary>
        /// Gets and sets the property TimeuuidT. 
        /// <para>
        /// A universally unique identifier (UUID) that includes a timestamp component, ensuring
        /// both uniqueness and time ordering. 
        /// </para>
        /// </summary>
        public string TimeuuidT
        {
            get { return this._timeuuidt; }
            set { this._timeuuidt = value; }
        }

        // Check to see if TimeuuidT property is set
        internal bool IsSetTimeuuidT()
        {
            return this._timeuuidt != null;
        }

        /// <summary>
        /// Gets and sets the property TinyintT. 
        /// <para>
        /// An 8-bit signed integer value. 
        /// </para>
        /// </summary>
        public string TinyintT
        {
            get { return this._tinyintt; }
            set { this._tinyintt = value; }
        }

        // Check to see if TinyintT property is set
        internal bool IsSetTinyintT()
        {
            return this._tinyintt != null;
        }

        /// <summary>
        /// Gets and sets the property TupleT. 
        /// <para>
        /// A fixed-length ordered list of elements, where each element can be of a different
        /// data type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyspacesCell> TupleT
        {
            get { return this._tuplet; }
            set { this._tuplet = value; }
        }

        // Check to see if TupleT property is set
        internal bool IsSetTupleT()
        {
            return this._tuplet != null && (this._tuplet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UdtT. 
        /// <para>
        /// A user-defined type (UDT) value consisting of named fields, each with its own data
        /// type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, KeyspacesCell> UdtT
        {
            get { return this._udtt; }
            set { this._udtt = value; }
        }

        // Check to see if UdtT property is set
        internal bool IsSetUdtT()
        {
            return this._udtt != null && (this._udtt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UuidT. 
        /// <para>
        /// A universally unique identifier (UUID) value. 
        /// </para>
        /// </summary>
        public string UuidT
        {
            get { return this._uuidt; }
            set { this._uuidt = value; }
        }

        // Check to see if UuidT property is set
        internal bool IsSetUuidT()
        {
            return this._uuidt != null;
        }

        /// <summary>
        /// Gets and sets the property VarcharT. 
        /// <para>
        /// A UTF-8 encoded string value, functionally equivalent to text type. 
        /// </para>
        /// </summary>
        public string VarcharT
        {
            get { return this._varchart; }
            set { this._varchart = value; }
        }

        // Check to see if VarcharT property is set
        internal bool IsSetVarcharT()
        {
            return this._varchart != null;
        }

        /// <summary>
        /// Gets and sets the property VarintT. 
        /// <para>
        /// A variable precision integer value with arbitrary length. 
        /// </para>
        /// </summary>
        public string VarintT
        {
            get { return this._varintt; }
            set { this._varintt = value; }
        }

        // Check to see if VarintT property is set
        internal bool IsSetVarintT()
        {
            return this._varintt != null;
        }

    }
}