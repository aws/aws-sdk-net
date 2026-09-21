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
    /// This is the response object from the JsonIntEnums operation.
    /// </summary>
    public partial class JsonIntEnumsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property IntegerEnum1.
        /// </summary>
        public int? IntegerEnum1 { get; set; }

        /// <summary>
        /// Checks to see if the IntegerEnum1 property is set.
        /// </summary>
        internal bool IsSetIntegerEnum1() => this.IntegerEnum1.HasValue;

        /// <summary>
        /// Gets and sets the property IntegerEnum2.
        /// </summary>
        public int? IntegerEnum2 { get; set; }

        /// <summary>
        /// Checks to see if the IntegerEnum2 property is set.
        /// </summary>
        internal bool IsSetIntegerEnum2() => this.IntegerEnum2.HasValue;

        /// <summary>
        /// Gets and sets the property IntegerEnum3.
        /// </summary>
        public int? IntegerEnum3 { get; set; }

        /// <summary>
        /// Checks to see if the IntegerEnum3 property is set.
        /// </summary>
        internal bool IsSetIntegerEnum3() => this.IntegerEnum3.HasValue;

        /// <summary>
        /// Gets and sets the property IntegerEnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> IntegerEnumList { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the IntegerEnumList property is set.
        /// </summary>
        internal bool IsSetIntegerEnumList() => this.IntegerEnumList != null && (this.IntegerEnumList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntegerEnumMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> IntegerEnumMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the IntegerEnumMap property is set.
        /// </summary>
        internal bool IsSetIntegerEnumMap() => this.IntegerEnumMap != null && (this.IntegerEnumMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntegerEnumSet.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> IntegerEnumSet { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the IntegerEnumSet property is set.
        /// </summary>
        internal bool IsSetIntegerEnumSet() => this.IntegerEnumSet != null && (this.IntegerEnumSet.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
