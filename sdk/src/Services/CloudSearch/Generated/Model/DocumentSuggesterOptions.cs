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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Options for a search suggester.
    /// </summary>
    public partial class DocumentSuggesterOptions
    {
        private SuggesterFuzzyMatching _fuzzyMatching;
        private string _sortExpression;
        private string _sourceField;

        /// <summary>
        /// Gets and sets the property FuzzyMatching. 
        /// <para>
        /// The level of fuzziness allowed when suggesting matches for a string: <c>none</c>,
        /// <c>low</c>, or <c>high</c>. With none, the specified string is treated as an exact
        /// prefix. With low, suggestions must differ from the specified string by no more than
        /// one character. With high, suggestions can differ by up to two characters. The default
        /// is none. 
        /// </para>
        /// </summary>
        public SuggesterFuzzyMatching FuzzyMatching
        {
            get { return this._fuzzyMatching; }
            set { this._fuzzyMatching = value; }
        }

        // Check to see if FuzzyMatching property is set
        internal bool IsSetFuzzyMatching()
        {
            return this._fuzzyMatching != null;
        }

        /// <summary>
        /// Gets and sets the property SortExpression. 
        /// <para>
        /// An expression that computes a score for each suggestion to control how they are sorted.
        /// The scores are rounded to the nearest integer, with a floor of 0 and a ceiling of
        /// 2^31-1. A document's relevance score is not computed for suggestions, so sort expressions
        /// cannot reference the <c>_score</c> value. To sort suggestions using a numeric field
        /// or existing expression, simply specify the name of the field or expression. If no
        /// expression is configured for the suggester, the suggestions are sorted with the closest
        /// matches listed first.
        /// </para>
        /// </summary>
        public string SortExpression
        {
            get { return this._sortExpression; }
            set { this._sortExpression = value; }
        }

        // Check to see if SortExpression property is set
        internal bool IsSetSortExpression()
        {
            return this._sortExpression != null;
        }

        /// <summary>
        /// Gets and sets the property SourceField. 
        /// <para>
        /// The name of the index field you want to use for suggestions. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string SourceField
        {
            get { return this._sourceField; }
            set { this._sourceField = value; }
        }

        // Check to see if SourceField property is set
        internal bool IsSetSourceField()
        {
            return this._sourceField != null;
        }

    }
}