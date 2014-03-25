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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>Options for a search suggester.</para>
    /// </summary>
    public partial class DocumentSuggesterOptions
    {
        
        private string sourceField;
        private SuggesterFuzzyMatching fuzzyMatching;
        private string sortExpression;


        /// <summary>
        /// The name of the index field you want to use for suggestions.
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
        public string SourceField
        {
            get { return this.sourceField; }
            set { this.sourceField = value; }
        }

        // Check to see if SourceField property is set
        internal bool IsSetSourceField()
        {
            return this.sourceField != null;
        }

        /// <summary>
        /// The level of fuzziness allowed when suggesting matches for a string: <c>none</c>, <c>low</c>, or <c>high</c>. With none, the specified
        /// string is treated as an exact prefix. With low, suggestions must differ from the specified string by no more than one character. With high,
        /// suggestions can differ by up to two characters. The default is none.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>none, low, high</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public SuggesterFuzzyMatching FuzzyMatching
        {
            get { return this.fuzzyMatching; }
            set { this.fuzzyMatching = value; }
        }

        // Check to see if FuzzyMatching property is set
        internal bool IsSetFuzzyMatching()
        {
            return this.fuzzyMatching != null;
        }

        /// <summary>
        /// An expression that computes a score for each suggestion to control how they are sorted.
        ///  
        /// </summary>
        public string SortExpression
        {
            get { return this.sortExpression; }
            set { this.sortExpression = value; }
        }

        // Check to see if SortExpression property is set
        internal bool IsSetSortExpression()
        {
            return this.sortExpression != null;
        }
    }
}
