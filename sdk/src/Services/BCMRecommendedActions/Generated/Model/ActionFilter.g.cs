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

namespace Amazon.BCMRecommendedActions.Model
{
    /// <summary>
    /// Describes a filter that returns a more specific list of recommended actions.
    /// </summary>
    public partial class ActionFilter
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The category to filter on. Valid values are <c>FEATURE</c> for feature type, <c>SEVERITY</c>
        /// for severity level, and <c>TYPE</c> for recommendation type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FilterName Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property MatchOption. 
        /// <para>
        /// Specifies how to apply the filter. Use <c>EQUALS</c> to include matching results or
        /// <c>NOT_EQUALS</c> to exclude matching results.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MatchOption MatchOption { get; set; }

        /// <summary>
        /// Checks to see if the MatchOption property is set.
        /// </summary>
        internal bool IsSetMatchOption() => this.MatchOption != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// One or more values to match against the specified key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> Values { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
