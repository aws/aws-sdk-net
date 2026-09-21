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
    /// Container for the parameters to the JsonEnums operation. This example serializes enums
    /// as top level properties, in lists, sets, and maps.
    /// </summary>
    public partial class JsonEnumsRequest : AmazonRestJsonProtocolRequest
    {
        /// <summary>
        /// Gets and sets the property FooEnum1.
        /// </summary>
        public FooEnum FooEnum1 { get; set; }

        /// <summary>
        /// Checks to see if the FooEnum1 property is set.
        /// </summary>
        internal bool IsSetFooEnum1() => this.FooEnum1 != null;

        /// <summary>
        /// Gets and sets the property FooEnum2.
        /// </summary>
        public FooEnum FooEnum2 { get; set; }

        /// <summary>
        /// Checks to see if the FooEnum2 property is set.
        /// </summary>
        internal bool IsSetFooEnum2() => this.FooEnum2 != null;

        /// <summary>
        /// Gets and sets the property FooEnum3.
        /// </summary>
        public FooEnum FooEnum3 { get; set; }

        /// <summary>
        /// Checks to see if the FooEnum3 property is set.
        /// </summary>
        internal bool IsSetFooEnum3() => this.FooEnum3 != null;

        /// <summary>
        /// Gets and sets the property FooEnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FooEnumList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FooEnumList property is set.
        /// </summary>
        internal bool IsSetFooEnumList() => this.FooEnumList != null && (this.FooEnumList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FooEnumMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> FooEnumMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the FooEnumMap property is set.
        /// </summary>
        internal bool IsSetFooEnumMap() => this.FooEnumMap != null && (this.FooEnumMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FooEnumSet.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FooEnumSet { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FooEnumSet property is set.
        /// </summary>
        internal bool IsSetFooEnumSet() => this.FooEnumSet != null && (this.FooEnumSet.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
