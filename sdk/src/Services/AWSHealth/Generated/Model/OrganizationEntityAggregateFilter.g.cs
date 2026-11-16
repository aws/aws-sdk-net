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

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// A filter for narrowing down the entity aggregates returned by DescribeEntityAggregatesForOrganization.
    /// </summary>
    public partial class OrganizationEntityAggregateFilter
    {
        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tag keys to lists of tag values. A tag matches when its key is in the map
        /// and its value is one of the values listed for that key. Matching is case sensitive,
        /// and the filter matches when at least one key in the map matches.
        /// </para>
        ///  
        /// <para>
        /// Only entities whose tags match are included in the aggregates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public Dictionary<string, List<string>> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
