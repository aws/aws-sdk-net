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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// The specific filters applied to your data source content. You can filter out or include
    /// certain content.
    /// </summary>
    public partial class PatternObjectFilter
    {
        /// <summary>
        /// Gets and sets the property ExclusionFilters. 
        /// <para>
        /// A list of one or more exclusion regular expression patterns to exclude certain object
        /// types that adhere to the pattern. If you specify an inclusion and exclusion filter/pattern
        /// and both match a document, the exclusion filter takes precedence and the document
        /// isn’t crawled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 25)]
        public List<string> ExclusionFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExclusionFilters property is set.
        /// </summary>
        internal bool IsSetExclusionFilters() => this.ExclusionFilters != null && (this.ExclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InclusionFilters. 
        /// <para>
        /// A list of one or more inclusion regular expression patterns to include certain object
        /// types that adhere to the pattern. If you specify an inclusion and exclusion filter/pattern
        /// and both match a document, the exclusion filter takes precedence and the document
        /// isn’t crawled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 25)]
        public List<string> InclusionFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InclusionFilters property is set.
        /// </summary>
        internal bool IsSetInclusionFilters() => this.InclusionFilters != null && (this.InclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ObjectType. 
        /// <para>
        /// The supported object type or content type of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 50)]
        public string ObjectType { get; set; }

        /// <summary>
        /// Checks to see if the ObjectType property is set.
        /// </summary>
        internal bool IsSetObjectType() => this.ObjectType != null;
    }
}
