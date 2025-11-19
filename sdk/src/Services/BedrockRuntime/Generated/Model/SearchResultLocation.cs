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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
        private int? _end;
        private int? _searchResultIndex;
        private int? _start;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The ending position in the content array where the cited content ends.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int End
        {
            get { return this._end.GetValueOrDefault(); }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SearchResultIndex. 
        /// <para>
        /// The index of the search result content block where the cited content is found.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int SearchResultIndex
        {
            get { return this._searchResultIndex.GetValueOrDefault(); }
            set { this._searchResultIndex = value; }
        }

        // Check to see if SearchResultIndex property is set
        internal bool IsSetSearchResultIndex()
        {
            return this._searchResultIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The starting position in the content array where the cited content begins.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int Start
        {
            get { return this._start.GetValueOrDefault(); }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

    }
}