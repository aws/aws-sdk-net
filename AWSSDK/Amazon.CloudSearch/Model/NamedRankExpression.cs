/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>A named expression that can be evaluated at search time and used for ranking or thresholding in a search query. </para>
    /// </summary>
    public class NamedRankExpression  
    {
        
        private string rankName;
        private string rankExpression;

        /// <summary>
        /// The name of a rank expression. Rank expression names must begin with a letter and can contain the following characters: a-z (lowercase),
        /// 0-9, and _ (underscore). Uppercase letters and hyphens are not allowed. The names "body", "docid", and "text_relevance" are reserved and
        /// cannot be specified as field or rank expression names.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-z][a-z0-9_]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string RankName
        {
            get { return this.rankName; }
            set { this.rankName = value; }
        }

        /// <summary>
        /// Sets the RankName property
        /// </summary>
        /// <param name="rankName">The value to set for the RankName property </param>
        /// <returns>this instance</returns>
        public NamedRankExpression WithRankName(string rankName)
        {
            this.rankName = rankName;
            return this;
        }
            

        // Check to see if RankName property is set
        internal bool IsSetRankName()
        {
            return this.rankName != null;       
        }

        /// <summary>
        /// The expression to evaluate for ranking or thresholding while processing a search request. The <c>RankExpression</c> syntax is based on
        /// JavaScript expressions and supports:<ul> <li>Integer, floating point, hex and octal literals</li> <li>Shortcut evaluation of logical
        /// operators such that an expression <c>a || b</c> evaluates to the value <c>a</c> if <c>a</c> is <c>true</c> without evaluting <c>b</c> at
        /// all</li> <li>JavaScript order of precendence for operators</li> <li>Arithmetic operators: <c>+ - * / %</c></li> <li>Boolean operators
        /// (including the ternary operator)</li> <li>Bitwise operators</li> <li>Comparison operators</li> <li>Common mathematic functions: <c>abs ceil
        /// erf exp floor lgamma ln log2 log10 max min sqrt pow</c></li> <li>Trigonometric library functions: <c>acosh acos asinh asin atanh atan cosh
        /// cos sinh sin tanh tan</c></li> <li>Random generation of a number between 0 and 1: <c>rand</c></li> <li>Current time in epoch:
        /// <c>time</c></li> <li>The <c>min max</c> functions that operate on a variable argument list</li> </ul> Intermediate results are calculated as
        /// double precision floating point values. The final return value of a <c>RankExpression</c> is automatically converted from floating point to
        /// a 32-bit unsigned integer by rounding to the nearest integer, with a natural floor of 0 and a ceiling of max(uint32_t), 4294967295.
        /// Mathematical errors such as dividing by 0 will fail during evaluation and return a value of 0. The source data for a <c>RankExpression</c>
        /// can be the name of an <c>IndexField</c> of type uint, another <c>RankExpression</c> or the reserved name <i>text_relevance</i>. The
        /// text_relevance source is defined to return an integer from 0 to 1000 (inclusive) to indicate how relevant a document is to the search
        /// request, taking into account repetition of search terms in the document and proximity of search terms to each other in each matching
        /// <c>IndexField</c> in the document. For more information about using rank expressions to customize ranking, see the Amazon CloudSearch
        /// Developer Guide.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 10240</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string RankExpression
        {
            get { return this.rankExpression; }
            set { this.rankExpression = value; }
        }

        /// <summary>
        /// Sets the RankExpression property
        /// </summary>
        /// <param name="rankExpression">The value to set for the RankExpression property </param>
        /// <returns>this instance</returns>
        public NamedRankExpression WithRankExpression(string rankExpression)
        {
            this.rankExpression = rankExpression;
            return this;
        }
            

        // Check to see if RankExpression property is set
        internal bool IsSetRankExpression()
        {
            return this.rankExpression != null;       
        }
    }
}
