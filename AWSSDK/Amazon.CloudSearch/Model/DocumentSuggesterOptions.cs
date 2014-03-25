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
        private string fuzzyMatching;
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

        /// <summary>
        /// Sets the SourceField property
        /// </summary>
        /// <param name="sourceField">The value to set for the SourceField property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DocumentSuggesterOptions WithSourceField(string sourceField)
        {
            this.sourceField = sourceField;
            return this;
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
        public string FuzzyMatching
        {
            get { return this.fuzzyMatching; }
            set { this.fuzzyMatching = value; }
        }

        /// <summary>
        /// Sets the FuzzyMatching property
        /// </summary>
        /// <param name="fuzzyMatching">The value to set for the FuzzyMatching property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DocumentSuggesterOptions WithFuzzyMatching(string fuzzyMatching)
        {
            this.fuzzyMatching = fuzzyMatching;
            return this;
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

        /// <summary>
        /// Sets the SortExpression property
        /// </summary>
        /// <param name="sortExpression">The value to set for the SortExpression property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DocumentSuggesterOptions WithSortExpression(string sortExpression)
        {
            this.sortExpression = sortExpression;
            return this;
        }
            

        // Check to see if SortExpression property is set
        internal bool IsSetSortExpression()
        {
            return this.sortExpression != null;
        }
    }
}
