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
    /// <para>Configuration information for a search suggester. Each suggester has a unique name and specifies the text field you want to use for
    /// suggestions. The following options can be configured for a suggester: <c>FuzzyMatching</c> ,
    /// <c>SortExpression</c> . </para>
    /// </summary>
    public partial class Suggester
    {
        
        private string suggesterName;
        private DocumentSuggesterOptions documentSuggesterOptions;


        /// <summary>
        /// A string that represents the name of an index field. Field names begin with a letter and can contain the following characters: a-z
        /// (lowercase), 0-9, and _ (underscore). The name "score" is reserved and cannot be used as a field name. To reference a document's ID, you can
        /// use the name <c>_id</c>.
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
        public string SuggesterName
        {
            get { return this.suggesterName; }
            set { this.suggesterName = value; }
        }

        // Check to see if SuggesterName property is set
        internal bool IsSetSuggesterName()
        {
            return this.suggesterName != null;
        }

        /// <summary>
        /// Options for a search suggester.
        ///  
        /// </summary>
        public DocumentSuggesterOptions DocumentSuggesterOptions
        {
            get { return this.documentSuggesterOptions; }
            set { this.documentSuggesterOptions = value; }
        }

        // Check to see if DocumentSuggesterOptions property is set
        internal bool IsSetDocumentSuggesterOptions()
        {
            return this.documentSuggesterOptions != null;
        }
    }
}
