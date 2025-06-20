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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Suggestions for refining individual query terms. Suggestions are returned as objects
    /// which note the term, suggested replacement, and its index in the query.
    /// </summary>
    public partial class QueryRefinement
    {
        private int? _endIndex;
        private string _originalTerm;
        private string _refinedTerm;
        private int? _startIndex;

        /// <summary>
        /// Gets and sets the property EndIndex. 
        /// <para>
        /// End index of the parsed query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? EndIndex
        {
            get { return this._endIndex; }
            set { this._endIndex = value; }
        }

        // Check to see if EndIndex property is set
        internal bool IsSetEndIndex()
        {
            return this._endIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginalTerm. 
        /// <para>
        /// The sub-string of the original query that is replaced by this query term.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=200)]
        public string OriginalTerm
        {
            get { return this._originalTerm; }
            set { this._originalTerm = value; }
        }

        // Check to see if OriginalTerm property is set
        internal bool IsSetOriginalTerm()
        {
            return this._originalTerm != null;
        }

        /// <summary>
        /// Gets and sets the property RefinedTerm. 
        /// <para>
        /// The term that will be suggested to the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=200)]
        public string RefinedTerm
        {
            get { return this._refinedTerm; }
            set { this._refinedTerm = value; }
        }

        // Check to see if RefinedTerm property is set
        internal bool IsSetRefinedTerm()
        {
            return this._refinedTerm != null;
        }

        /// <summary>
        /// Gets and sets the property StartIndex. 
        /// <para>
        /// Start index of the parsed component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? StartIndex
        {
            get { return this._startIndex; }
            set { this._startIndex = value; }
        }

        // Check to see if StartIndex property is set
        internal bool IsSetStartIndex()
        {
            return this._startIndex.HasValue; 
        }

    }
}