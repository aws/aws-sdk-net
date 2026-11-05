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

namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// Specifies a search result location within the content array, providing positioning
    /// information for cited content using search result index and block positions.
    /// </summary>
    public partial class SearchResultLocation
    {
        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The ending position in the content array where the cited content ends.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? End { get; set; }

        /// <summary>
        /// Checks to see if the End property is set.
        /// </summary>
        internal bool IsSetEnd() => this.End.HasValue;

        /// <summary>
        /// Gets and sets the property SearchResultIndex. 
        /// <para>
        /// The index of the search result content block where the cited content is found.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? SearchResultIndex { get; set; }

        /// <summary>
        /// Checks to see if the SearchResultIndex property is set.
        /// </summary>
        internal bool IsSetSearchResultIndex() => this.SearchResultIndex.HasValue;

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The starting position in the content array where the cited content begins.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Start { get; set; }

        /// <summary>
        /// Checks to see if the Start property is set.
        /// </summary>
        internal bool IsSetStart() => this.Start.HasValue;
    }
}
