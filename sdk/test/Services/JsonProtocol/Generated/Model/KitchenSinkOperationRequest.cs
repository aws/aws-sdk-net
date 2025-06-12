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
 * Do not modify this file. This file is generated from the json-protocol-2018-01-01.normal.json service model.
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
namespace Amazon.JsonProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the KitchenSinkOperation operation.
    /// 
    /// </summary>
    public partial class KitchenSinkOperationRequest : AmazonJsonProtocolRequest
    {
        private MemoryStream _blob;
        private bool? _boolean;
        private double? _double;
        private EmptyStruct _emptyStruct;
        private float? _float;
        private DateTime? _httpdateTimestamp;
        private int? _integer;
        private DateTime? _iso8601Timestamp;
        private string _jsonValue;
        private List<List<string>> _listOfLists = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;
        private List<Dictionary<string, string>> _listOfMapsOfStrings = AWSConfigs.InitializeCollections ? new List<Dictionary<string, string>>() : null;
        private List<string> _listOfStrings = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<SimpleStruct> _listOfStructs = AWSConfigs.InitializeCollections ? new List<SimpleStruct>() : null;
        private long? _long;
        private Dictionary<string, List<string>> _mapOfListsOfStrings = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private Dictionary<string, Dictionary<string, string>> _mapOfMaps = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;
        private Dictionary<string, string> _mapOfStrings = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, SimpleStruct> _mapOfStructs = AWSConfigs.InitializeCollections ? new Dictionary<string, SimpleStruct>() : null;
        private List<KitchenSink> _recursiveList = AWSConfigs.InitializeCollections ? new List<KitchenSink>() : null;
        private Dictionary<string, KitchenSink> _recursiveMap = AWSConfigs.InitializeCollections ? new Dictionary<string, KitchenSink>() : null;
        private KitchenSink _recursiveStruct;
        private SimpleStruct _simpleStruct;
        private string _string;
        private StructWithJsonName _structWithJsonName;
        private DateTime? _timestamp;
        private DateTime? _unixTimestamp;

        /// <summary>
        /// Gets and sets the property Blob.
        /// </summary>
        public MemoryStream Blob
        {
            get { return this._blob; }
            set { this._blob = value; }
        }

        // Check to see if Blob property is set
        internal bool IsSetBlob()
        {
            return this._blob != null;
        }

        /// <summary>
        /// Gets and sets the property Boolean.
        /// </summary>
        public bool? Boolean
        {
            get { return this._boolean; }
            set { this._boolean = value; }
        }

        // Check to see if Boolean property is set
        internal bool IsSetBoolean()
        {
            return this._boolean.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Double.
        /// </summary>
        public double? Double
        {
            get { return this._double; }
            set { this._double = value; }
        }

        // Check to see if Double property is set
        internal bool IsSetDouble()
        {
            return this._double.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EmptyStruct.
        /// </summary>
        public EmptyStruct EmptyStruct
        {
            get { return this._emptyStruct; }
            set { this._emptyStruct = value; }
        }

        // Check to see if EmptyStruct property is set
        internal bool IsSetEmptyStruct()
        {
            return this._emptyStruct != null;
        }

        /// <summary>
        /// Gets and sets the property Float.
        /// </summary>
        public float? Float
        {
            get { return this._float; }
            set { this._float = value; }
        }

        // Check to see if Float property is set
        internal bool IsSetFloat()
        {
            return this._float.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HttpdateTimestamp.
        /// </summary>
        public DateTime? HttpdateTimestamp
        {
            get { return this._httpdateTimestamp; }
            set { this._httpdateTimestamp = value; }
        }

        // Check to see if HttpdateTimestamp property is set
        internal bool IsSetHttpdateTimestamp()
        {
            return this._httpdateTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Integer.
        /// </summary>
        public int? Integer
        {
            get { return this._integer; }
            set { this._integer = value; }
        }

        // Check to see if Integer property is set
        internal bool IsSetInteger()
        {
            return this._integer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iso8601Timestamp.
        /// </summary>
        public DateTime? Iso8601Timestamp
        {
            get { return this._iso8601Timestamp; }
            set { this._iso8601Timestamp = value; }
        }

        // Check to see if Iso8601Timestamp property is set
        internal bool IsSetIso8601Timestamp()
        {
            return this._iso8601Timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JsonValue.
        /// </summary>
        public string JsonValue
        {
            get { return this._jsonValue; }
            set { this._jsonValue = value; }
        }

        // Check to see if JsonValue property is set
        internal bool IsSetJsonValue()
        {
            return this._jsonValue != null;
        }

        /// <summary>
        /// Gets and sets the property ListOfLists.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<string>> ListOfLists
        {
            get { return this._listOfLists; }
            set { this._listOfLists = value; }
        }

        // Check to see if ListOfLists property is set
        internal bool IsSetListOfLists()
        {
            return this._listOfLists != null && (this._listOfLists.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListOfMapsOfStrings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, string>> ListOfMapsOfStrings
        {
            get { return this._listOfMapsOfStrings; }
            set { this._listOfMapsOfStrings = value; }
        }

        // Check to see if ListOfMapsOfStrings property is set
        internal bool IsSetListOfMapsOfStrings()
        {
            return this._listOfMapsOfStrings != null && (this._listOfMapsOfStrings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListOfStrings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ListOfStrings
        {
            get { return this._listOfStrings; }
            set { this._listOfStrings = value; }
        }

        // Check to see if ListOfStrings property is set
        internal bool IsSetListOfStrings()
        {
            return this._listOfStrings != null && (this._listOfStrings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListOfStructs.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SimpleStruct> ListOfStructs
        {
            get { return this._listOfStructs; }
            set { this._listOfStructs = value; }
        }

        // Check to see if ListOfStructs property is set
        internal bool IsSetListOfStructs()
        {
            return this._listOfStructs != null && (this._listOfStructs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Long.
        /// </summary>
        public long? Long
        {
            get { return this._long; }
            set { this._long = value; }
        }

        // Check to see if Long property is set
        internal bool IsSetLong()
        {
            return this._long.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MapOfListsOfStrings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> MapOfListsOfStrings
        {
            get { return this._mapOfListsOfStrings; }
            set { this._mapOfListsOfStrings = value; }
        }

        // Check to see if MapOfListsOfStrings property is set
        internal bool IsSetMapOfListsOfStrings()
        {
            return this._mapOfListsOfStrings != null && (this._mapOfListsOfStrings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MapOfMaps.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> MapOfMaps
        {
            get { return this._mapOfMaps; }
            set { this._mapOfMaps = value; }
        }

        // Check to see if MapOfMaps property is set
        internal bool IsSetMapOfMaps()
        {
            return this._mapOfMaps != null && (this._mapOfMaps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MapOfStrings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> MapOfStrings
        {
            get { return this._mapOfStrings; }
            set { this._mapOfStrings = value; }
        }

        // Check to see if MapOfStrings property is set
        internal bool IsSetMapOfStrings()
        {
            return this._mapOfStrings != null && (this._mapOfStrings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MapOfStructs.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, SimpleStruct> MapOfStructs
        {
            get { return this._mapOfStructs; }
            set { this._mapOfStructs = value; }
        }

        // Check to see if MapOfStructs property is set
        internal bool IsSetMapOfStructs()
        {
            return this._mapOfStructs != null && (this._mapOfStructs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecursiveList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KitchenSink> RecursiveList
        {
            get { return this._recursiveList; }
            set { this._recursiveList = value; }
        }

        // Check to see if RecursiveList property is set
        internal bool IsSetRecursiveList()
        {
            return this._recursiveList != null && (this._recursiveList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecursiveMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, KitchenSink> RecursiveMap
        {
            get { return this._recursiveMap; }
            set { this._recursiveMap = value; }
        }

        // Check to see if RecursiveMap property is set
        internal bool IsSetRecursiveMap()
        {
            return this._recursiveMap != null && (this._recursiveMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecursiveStruct.
        /// </summary>
        public KitchenSink RecursiveStruct
        {
            get { return this._recursiveStruct; }
            set { this._recursiveStruct = value; }
        }

        // Check to see if RecursiveStruct property is set
        internal bool IsSetRecursiveStruct()
        {
            return this._recursiveStruct != null;
        }

        /// <summary>
        /// Gets and sets the property SimpleStruct.
        /// </summary>
        public SimpleStruct SimpleStruct
        {
            get { return this._simpleStruct; }
            set { this._simpleStruct = value; }
        }

        // Check to see if SimpleStruct property is set
        internal bool IsSetSimpleStruct()
        {
            return this._simpleStruct != null;
        }

        /// <summary>
        /// Gets and sets the property String.
        /// </summary>
        public string String
        {
            get { return this._string; }
            set { this._string = value; }
        }

        // Check to see if String property is set
        internal bool IsSetString()
        {
            return this._string != null;
        }

        /// <summary>
        /// Gets and sets the property StructWithJsonName.
        /// </summary>
        public StructWithJsonName StructWithJsonName
        {
            get { return this._structWithJsonName; }
            set { this._structWithJsonName = value; }
        }

        // Check to see if StructWithJsonName property is set
        internal bool IsSetStructWithJsonName()
        {
            return this._structWithJsonName != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp.
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnixTimestamp.
        /// </summary>
        public DateTime? UnixTimestamp
        {
            get { return this._unixTimestamp; }
            set { this._unixTimestamp = value; }
        }

        // Check to see if UnixTimestamp property is set
        internal bool IsSetUnixTimestamp()
        {
            return this._unixTimestamp.HasValue; 
        }

    }
}