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
    /// This is the response object from the JsonIntEnums operation.
    /// </summary>
    public partial class JsonIntEnumsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property IntEnum1.
        /// </summary>
        public int? IntEnum1 { get; set; }

        /// <summary>
        /// Checks to see if the IntEnum1 property is set.
        /// </summary>
        internal bool IsSetIntEnum1() => this.IntEnum1.HasValue;

        /// <summary>
        /// Gets and sets the property IntEnum2.
        /// </summary>
        public int? IntEnum2 { get; set; }

        /// <summary>
        /// Checks to see if the IntEnum2 property is set.
        /// </summary>
        internal bool IsSetIntEnum2() => this.IntEnum2.HasValue;

        /// <summary>
        /// Gets and sets the property IntEnum3.
        /// </summary>
        public int? IntEnum3 { get; set; }

        /// <summary>
        /// Checks to see if the IntEnum3 property is set.
        /// </summary>
        internal bool IsSetIntEnum3() => this.IntEnum3.HasValue;

        /// <summary>
        /// Gets and sets the property IntEnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> IntEnumList { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the IntEnumList property is set.
        /// </summary>
        internal bool IsSetIntEnumList() => this.IntEnumList != null && (this.IntEnumList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntEnumMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> IntEnumMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the IntEnumMap property is set.
        /// </summary>
        internal bool IsSetIntEnumMap() => this.IntEnumMap != null && (this.IntEnumMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntEnumSet.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> IntEnumSet { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the IntEnumSet property is set.
        /// </summary>
        internal bool IsSetIntEnumSet() => this.IntEnumSet != null && (this.IntEnumSet.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
