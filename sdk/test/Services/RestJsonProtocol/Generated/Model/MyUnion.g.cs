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

namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// A union with a representative set of types for members.
    /// </summary>
    public partial class MyUnion
    {
        /// <summary>
        /// Gets and sets the property BlobValue.
        /// </summary>
        public MemoryStream BlobValue { get; set; }

        /// <summary>
        /// Checks to see if the BlobValue property is set.
        /// </summary>
        internal bool IsSetBlobValue() => this.BlobValue != null;

        /// <summary>
        /// Gets and sets the property BooleanValue.
        /// </summary>
        public bool? BooleanValue { get; set; }

        /// <summary>
        /// Checks to see if the BooleanValue property is set.
        /// </summary>
        internal bool IsSetBooleanValue() => this.BooleanValue.HasValue;

        /// <summary>
        /// Gets and sets the property EnumValue.
        /// </summary>
        public FooEnum EnumValue { get; set; }

        /// <summary>
        /// Checks to see if the EnumValue property is set.
        /// </summary>
        internal bool IsSetEnumValue() => this.EnumValue != null;

        /// <summary>
        /// Gets and sets the property ListValue.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ListValue { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ListValue property is set.
        /// </summary>
        internal bool IsSetListValue() => this.ListValue != null && (this.ListValue.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MapValue.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> MapValue { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the MapValue property is set.
        /// </summary>
        internal bool IsSetMapValue() => this.MapValue != null && (this.MapValue.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberValue.
        /// </summary>
        public int? NumberValue { get; set; }

        /// <summary>
        /// Checks to see if the NumberValue property is set.
        /// </summary>
        internal bool IsSetNumberValue() => this.NumberValue.HasValue;

        /// <summary>
        /// Gets and sets the property RenamedStructureValue.
        /// </summary>
        public RenamedGreeting RenamedStructureValue { get; set; }

        /// <summary>
        /// Checks to see if the RenamedStructureValue property is set.
        /// </summary>
        internal bool IsSetRenamedStructureValue() => this.RenamedStructureValue != null;

        /// <summary>
        /// Gets and sets the property StringValue.
        /// </summary>
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;

        /// <summary>
        /// Gets and sets the property StructureValue.
        /// </summary>
        public GreetingStruct StructureValue { get; set; }

        /// <summary>
        /// Checks to see if the StructureValue property is set.
        /// </summary>
        internal bool IsSetStructureValue() => this.StructureValue != null;

        /// <summary>
        /// Gets and sets the property TimestampValue.
        /// </summary>
        public DateTime? TimestampValue { get; set; }

        /// <summary>
        /// Checks to see if the TimestampValue property is set.
        /// </summary>
        internal bool IsSetTimestampValue() => this.TimestampValue.HasValue;

        /// <summary>
        /// Gets and sets the property UnionValue.
        /// </summary>
        public NestedUnion UnionValue { get; set; }

        /// <summary>
        /// Checks to see if the UnionValue property is set.
        /// </summary>
        internal bool IsSetUnionValue() => this.UnionValue != null;
    }
}
