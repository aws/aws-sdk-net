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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the BatchGetResourceConfig operation.
    /// </summary>
    public partial class BatchGetResourceConfigResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BaseConfigurationItems. 
        /// <para>
        /// A list that contains the current configuration of one or more resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BaseConfigurationItem> BaseConfigurationItems { get; set; } = AWSConfigs.InitializeCollections ? new List<BaseConfigurationItem>() : null;

        /// <summary>
        /// Checks to see if the BaseConfigurationItems property is set.
        /// </summary>
        internal bool IsSetBaseConfigurationItems() => this.BaseConfigurationItems != null && (this.BaseConfigurationItems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UnprocessedResourceKeys. 
        /// <para>
        /// A list of resource keys that were not processed with the current response. The unprocessesResourceKeys
        /// value is in the same form as ResourceKeys, so the value can be directly provided to
        /// a subsequent BatchGetResourceConfig operation. If there are no unprocessed resource
        /// keys, the response contains an empty unprocessedResourceKeys list. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<ResourceKey> UnprocessedResourceKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceKey>() : null;

        /// <summary>
        /// Checks to see if the UnprocessedResourceKeys property is set.
        /// </summary>
        internal bool IsSetUnprocessedResourceKeys() => this.UnprocessedResourceKeys != null && (this.UnprocessedResourceKeys.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
