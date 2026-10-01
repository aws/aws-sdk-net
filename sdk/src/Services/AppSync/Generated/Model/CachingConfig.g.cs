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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// The caching configuration for a resolver that has caching activated.
    /// </summary>
    public partial class CachingConfig
    {
        /// <summary>
        /// Gets and sets the property CachingKeys. 
        /// <para>
        /// The caching keys for a resolver that has caching activated.
        /// </para>
        ///  
        /// <para>
        /// Valid values are entries from the <c>$context.arguments</c>, <c>$context.source</c>,
        /// and <c>$context.identity</c> maps.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CachingKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CachingKeys property is set.
        /// </summary>
        internal bool IsSetCachingKeys() => this.CachingKeys != null && (this.CachingKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ttl. 
        /// <para>
        /// The TTL in seconds for a resolver that has caching activated.
        /// </para>
        ///  
        /// <para>
        /// Valid values are 1–3,600 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? Ttl { get; set; }

        /// <summary>
        /// Checks to see if the Ttl property is set.
        /// </summary>
        internal bool IsSetTtl() => this.Ttl.HasValue;
    }
}
