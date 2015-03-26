/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch_2011_02_01.Model
{
    /// <summary>
    /// A named expression that can be evaluated at search time and used for ranking or thresholding
    /// in a search query.
    /// </summary>
    public partial class NamedRankExpression
    {
        private string _rankExpression;
        private string _rankName;

        /// <summary>
        /// Gets and sets the property RankExpression. 
        /// <para>
        /// The expression to evaluate for ranking or thresholding while processing a search request.
        /// The <code>RankExpression</code> syntax is based on JavaScript expressions and supports:
        /// </para>
        ///  <ul> <li>Integer, floating point, hex and octal literals</li> <li>Shortcut evaluation
        /// of logical operators such that an expression <code>a || b</code> evaluates to the
        /// value <code>a</code>, if <code>a</code> is true, without evaluating <code>b</code>
        /// at all</li> <li>JavaScript order of precedence for operators</li> <li>Arithmetic operators:
        /// <code>+ - * / %</code> </li> <li>Boolean operators (including the ternary operator)</li>
        /// <li>Bitwise operators</li> <li>Comparison operators</li> <li>Common mathematic functions:
        /// <code>abs ceil erf exp floor lgamma ln log2 log10 max min sqrt pow</code> </li> <li>Trigonometric
        /// library functions: <code>acosh acos asinh asin atanh atan cosh cos sinh sin tanh tan</code>
        /// </li> <li>Random generation of a number between 0 and 1: <code>rand</code> </li> <li>Current
        /// time in epoch: <code>time</code> </li> <li>The <code>min max</code> functions that
        /// operate on a variable argument list</li> </ul> 
        /// <para>
        /// Intermediate results are calculated as double precision floating point values. The
        /// final return value of a <code>RankExpression</code> is automatically converted from
        /// floating point to a 32-bit unsigned integer by rounding to the nearest integer, with
        /// a natural floor of 0 and a ceiling of max(uint32_t), 4294967295. Mathematical errors
        /// such as dividing by 0 will fail during evaluation and return a value of 0.
        /// </para>
        ///  
        /// <para>
        /// The source data for a <code>RankExpression</code> can be the name of an <code>IndexField</code>
        /// of type uint, another <code>RankExpression</code> or the reserved name <i>text_relevance</i>.
        /// The text_relevance source is defined to return an integer from 0 to 1000 (inclusive)
        /// to indicate how relevant a document is to the search request, taking into account
        /// repetition of search terms in the document and proximity of search terms to each other
        /// in each matching <code>IndexField</code> in the document.
        /// </para>
        ///  
        /// <para>
        /// For more information about using rank expressions to customize ranking, see the Amazon
        /// CloudSearch Developer Guide.
        /// </para>
        /// </summary>
        public string RankExpression
        {
            get { return this._rankExpression; }
            set { this._rankExpression = value; }
        }

        // Check to see if RankExpression property is set
        internal bool IsSetRankExpression()
        {
            return this._rankExpression != null;
        }

        /// <summary>
        /// Gets and sets the property RankName. 
        /// <para>
        /// The name of a rank expression. Rank expression names must begin with a letter and
        /// can contain the following characters: a-z (lowercase), 0-9, and _ (underscore). Uppercase
        /// letters and hyphens are not allowed. The names "body", "docid", and "text_relevance"
        /// are reserved and cannot be specified as field or rank expression names.
        /// </para>
        /// </summary>
        public string RankName
        {
            get { return this._rankName; }
            set { this._rankName = value; }
        }

        // Check to see if RankName property is set
        internal bool IsSetRankName()
        {
            return this._rankName != null;
        }

    }
}