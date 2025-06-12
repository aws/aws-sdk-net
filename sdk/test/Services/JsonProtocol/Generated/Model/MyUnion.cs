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
    /// A union with a representative set of types for members.
    /// </summary>
    public partial class MyUnion
    {
        private MemoryStream _blobValue;
        private bool? _booleanValue;
        private FooEnum _enumValue;
        private List<string> _listValue = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _mapValue = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _numberValue;
        private string _stringValue;
        private GreetingStruct _structureValue;
        private DateTime? _timestampValue;

        /// <summary>
        /// Gets and sets the property BlobValue.
        /// </summary>
        public MemoryStream BlobValue
        {
            get { return this._blobValue; }
            set { this._blobValue = value; }
        }

        // Check to see if BlobValue property is set
        internal bool IsSetBlobValue()
        {
            return this._blobValue != null;
        }

        /// <summary>
        /// Gets and sets the property BooleanValue.
        /// </summary>
        public bool? BooleanValue
        {
            get { return this._booleanValue; }
            set { this._booleanValue = value; }
        }

        // Check to see if BooleanValue property is set
        internal bool IsSetBooleanValue()
        {
            return this._booleanValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnumValue.
        /// </summary>
        public FooEnum EnumValue
        {
            get { return this._enumValue; }
            set { this._enumValue = value; }
        }

        // Check to see if EnumValue property is set
        internal bool IsSetEnumValue()
        {
            return this._enumValue != null;
        }

        /// <summary>
        /// Gets and sets the property ListValue.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ListValue
        {
            get { return this._listValue; }
            set { this._listValue = value; }
        }

        // Check to see if ListValue property is set
        internal bool IsSetListValue()
        {
            return this._listValue != null && (this._listValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MapValue.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> MapValue
        {
            get { return this._mapValue; }
            set { this._mapValue = value; }
        }

        // Check to see if MapValue property is set
        internal bool IsSetMapValue()
        {
            return this._mapValue != null && (this._mapValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumberValue.
        /// </summary>
        public int? NumberValue
        {
            get { return this._numberValue; }
            set { this._numberValue = value; }
        }

        // Check to see if NumberValue property is set
        internal bool IsSetNumberValue()
        {
            return this._numberValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringValue.
        /// </summary>
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

        /// <summary>
        /// Gets and sets the property StructureValue.
        /// </summary>
        public GreetingStruct StructureValue
        {
            get { return this._structureValue; }
            set { this._structureValue = value; }
        }

        // Check to see if StructureValue property is set
        internal bool IsSetStructureValue()
        {
            return this._structureValue != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampValue.
        /// </summary>
        public DateTime? TimestampValue
        {
            get { return this._timestampValue; }
            set { this._timestampValue = value; }
        }

        // Check to see if TimestampValue property is set
        internal bool IsSetTimestampValue()
        {
            return this._timestampValue.HasValue; 
        }

    }
}