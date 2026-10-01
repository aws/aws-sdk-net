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

namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Suggestions for refining individual query terms. Suggestions are returned as objects
    /// which note the term, suggested replacement, and its index in the query.
    /// </summary>
    public partial class QueryRefinement
    {
        /// <summary>
        /// Gets and sets the property EndIndex. 
        /// <para>
        /// End index of the parsed query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Checks to see if the EndIndex property is set.
        /// </summary>
        internal bool IsSetEndIndex() => this.EndIndex.HasValue;

        /// <summary>
        /// Gets and sets the property OriginalTerm. 
        /// <para>
        /// The sub-string of the original query that is replaced by this query term.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 200)]
        public string OriginalTerm { get; set; }

        /// <summary>
        /// Checks to see if the OriginalTerm property is set.
        /// </summary>
        internal bool IsSetOriginalTerm() => this.OriginalTerm != null;

        /// <summary>
        /// Gets and sets the property RefinedTerm. 
        /// <para>
        /// The term that will be suggested to the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 200)]
        public string RefinedTerm { get; set; }

        /// <summary>
        /// Checks to see if the RefinedTerm property is set.
        /// </summary>
        internal bool IsSetRefinedTerm() => this.RefinedTerm != null;

        /// <summary>
        /// Gets and sets the property StartIndex. 
        /// <para>
        /// Start index of the parsed component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? StartIndex { get; set; }

        /// <summary>
        /// Checks to see if the StartIndex property is set.
        /// </summary>
        internal bool IsSetStartIndex() => this.StartIndex.HasValue;
    }
}
