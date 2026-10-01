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
    /// This is the response object from the SparseJsonMaps operation.
    /// </summary>
    public partial class SparseJsonMapsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property SparseBooleanMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, bool?> SparseBooleanMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, bool?>() : null;

        /// <summary>
        /// Checks to see if the SparseBooleanMap property is set.
        /// </summary>
        internal bool IsSetSparseBooleanMap() => this.SparseBooleanMap != null && (this.SparseBooleanMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SparseNumberMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int?> SparseNumberMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int?>() : null;

        /// <summary>
        /// Checks to see if the SparseNumberMap property is set.
        /// </summary>
        internal bool IsSetSparseNumberMap() => this.SparseNumberMap != null && (this.SparseNumberMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SparseSetMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> SparseSetMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the SparseSetMap property is set.
        /// </summary>
        internal bool IsSetSparseSetMap() => this.SparseSetMap != null && (this.SparseSetMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SparseStringMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SparseStringMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SparseStringMap property is set.
        /// </summary>
        internal bool IsSetSparseStringMap() => this.SparseStringMap != null && (this.SparseStringMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SparseStructMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, GreetingStruct> SparseStructMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, GreetingStruct>() : null;

        /// <summary>
        /// Checks to see if the SparseStructMap property is set.
        /// </summary>
        internal bool IsSetSparseStructMap() => this.SparseStructMap != null && (this.SparseStructMap.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
