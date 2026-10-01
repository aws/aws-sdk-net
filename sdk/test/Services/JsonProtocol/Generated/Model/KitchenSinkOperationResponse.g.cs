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

namespace Amazon.JsonProtocol.Model
{
    /// <summary>
    /// This is the response object from the KitchenSinkOperation operation.
    /// </summary>
    public partial class KitchenSinkOperationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Blob.
        /// </summary>
        public MemoryStream Blob { get; set; }

        /// <summary>
        /// Checks to see if the Blob property is set.
        /// </summary>
        internal bool IsSetBlob() => this.Blob != null;

        /// <summary>
        /// Gets and sets the property Boolean.
        /// </summary>
        public bool? Boolean { get; set; }

        /// <summary>
        /// Checks to see if the Boolean property is set.
        /// </summary>
        internal bool IsSetBoolean() => this.Boolean.HasValue;

        /// <summary>
        /// Gets and sets the property Double.
        /// </summary>
        public double? Double { get; set; }

        /// <summary>
        /// Checks to see if the Double property is set.
        /// </summary>
        internal bool IsSetDouble() => this.Double.HasValue;

        /// <summary>
        /// Gets and sets the property EmptyStruct.
        /// </summary>
        public EmptyStruct EmptyStruct { get; set; }

        /// <summary>
        /// Checks to see if the EmptyStruct property is set.
        /// </summary>
        internal bool IsSetEmptyStruct() => this.EmptyStruct != null;

        /// <summary>
        /// Gets and sets the property Float.
        /// </summary>
        public float? Float { get; set; }

        /// <summary>
        /// Checks to see if the Float property is set.
        /// </summary>
        internal bool IsSetFloat() => this.Float.HasValue;

        /// <summary>
        /// Gets and sets the property HttpdateTimestamp.
        /// </summary>
        public DateTime? HttpdateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the HttpdateTimestamp property is set.
        /// </summary>
        internal bool IsSetHttpdateTimestamp() => this.HttpdateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Integer.
        /// </summary>
        public int? Integer { get; set; }

        /// <summary>
        /// Checks to see if the Integer property is set.
        /// </summary>
        internal bool IsSetInteger() => this.Integer.HasValue;

        /// <summary>
        /// Gets and sets the property Iso8601Timestamp.
        /// </summary>
        public DateTime? Iso8601Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Iso8601Timestamp property is set.
        /// </summary>
        internal bool IsSetIso8601Timestamp() => this.Iso8601Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property JsonValue.
        /// </summary>
        public string JsonValue { get; set; }

        /// <summary>
        /// Checks to see if the JsonValue property is set.
        /// </summary>
        internal bool IsSetJsonValue() => this.JsonValue != null;

        /// <summary>
        /// Gets and sets the property ListOfLists.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<string>> ListOfLists { get; set; } = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;

        /// <summary>
        /// Checks to see if the ListOfLists property is set.
        /// </summary>
        internal bool IsSetListOfLists() => this.ListOfLists != null && (this.ListOfLists.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListOfMapsOfStrings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, string>> ListOfMapsOfStrings { get; set; } = AWSConfigs.InitializeCollections ? new List<Dictionary<string, string>>() : null;

        /// <summary>
        /// Checks to see if the ListOfMapsOfStrings property is set.
        /// </summary>
        internal bool IsSetListOfMapsOfStrings() => this.ListOfMapsOfStrings != null && (this.ListOfMapsOfStrings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListOfStrings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ListOfStrings { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ListOfStrings property is set.
        /// </summary>
        internal bool IsSetListOfStrings() => this.ListOfStrings != null && (this.ListOfStrings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListOfStructs.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SimpleStruct> ListOfStructs { get; set; } = AWSConfigs.InitializeCollections ? new List<SimpleStruct>() : null;

        /// <summary>
        /// Checks to see if the ListOfStructs property is set.
        /// </summary>
        internal bool IsSetListOfStructs() => this.ListOfStructs != null && (this.ListOfStructs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Long.
        /// </summary>
        public long? Long { get; set; }

        /// <summary>
        /// Checks to see if the Long property is set.
        /// </summary>
        internal bool IsSetLong() => this.Long.HasValue;

        /// <summary>
        /// Gets and sets the property MapOfListsOfStrings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> MapOfListsOfStrings { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the MapOfListsOfStrings property is set.
        /// </summary>
        internal bool IsSetMapOfListsOfStrings() => this.MapOfListsOfStrings != null && (this.MapOfListsOfStrings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MapOfMaps.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> MapOfMaps { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;

        /// <summary>
        /// Checks to see if the MapOfMaps property is set.
        /// </summary>
        internal bool IsSetMapOfMaps() => this.MapOfMaps != null && (this.MapOfMaps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MapOfStrings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> MapOfStrings { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the MapOfStrings property is set.
        /// </summary>
        internal bool IsSetMapOfStrings() => this.MapOfStrings != null && (this.MapOfStrings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MapOfStructs.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, SimpleStruct> MapOfStructs { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, SimpleStruct>() : null;

        /// <summary>
        /// Checks to see if the MapOfStructs property is set.
        /// </summary>
        internal bool IsSetMapOfStructs() => this.MapOfStructs != null && (this.MapOfStructs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecursiveList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KitchenSink> RecursiveList { get; set; } = AWSConfigs.InitializeCollections ? new List<KitchenSink>() : null;

        /// <summary>
        /// Checks to see if the RecursiveList property is set.
        /// </summary>
        internal bool IsSetRecursiveList() => this.RecursiveList != null && (this.RecursiveList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecursiveMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, KitchenSink> RecursiveMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, KitchenSink>() : null;

        /// <summary>
        /// Checks to see if the RecursiveMap property is set.
        /// </summary>
        internal bool IsSetRecursiveMap() => this.RecursiveMap != null && (this.RecursiveMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecursiveStruct.
        /// </summary>
        public KitchenSink RecursiveStruct { get; set; }

        /// <summary>
        /// Checks to see if the RecursiveStruct property is set.
        /// </summary>
        internal bool IsSetRecursiveStruct() => this.RecursiveStruct != null;

        /// <summary>
        /// Gets and sets the property SimpleStruct.
        /// </summary>
        public SimpleStruct SimpleStruct { get; set; }

        /// <summary>
        /// Checks to see if the SimpleStruct property is set.
        /// </summary>
        internal bool IsSetSimpleStruct() => this.SimpleStruct != null;

        /// <summary>
        /// Gets and sets the property String.
        /// </summary>
        public string String { get; set; }

        /// <summary>
        /// Checks to see if the String property is set.
        /// </summary>
        internal bool IsSetString() => this.String != null;

        /// <summary>
        /// Gets and sets the property StructWithJsonName.
        /// </summary>
        public StructWithJsonName StructWithJsonName { get; set; }

        /// <summary>
        /// Checks to see if the StructWithJsonName property is set.
        /// </summary>
        internal bool IsSetStructWithJsonName() => this.StructWithJsonName != null;

        /// <summary>
        /// Gets and sets the property Timestamp.
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property UnixTimestamp.
        /// </summary>
        public DateTime? UnixTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UnixTimestamp property is set.
        /// </summary>
        internal bool IsSetUnixTimestamp() => this.UnixTimestamp.HasValue;
    }
}
