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
    /// <para>A named expression that can be evaluated at search time. Can be used for sorting and filtering search results and constructing other
    /// expressions. </para>
    /// </summary>
    public partial class Expression
    {
        
        private string expressionName;
        private string expressionValue;


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
        public string ExpressionName
        {
            get { return this.expressionName; }
            set { this.expressionName = value; }
        }

        // Check to see if ExpressionName property is set
        internal bool IsSetExpressionName()
        {
            return this.expressionName != null;
        }

        /// <summary>
        /// The expression to evaluate for sorting while processing a search request. The <c>Expression</c> syntax is based on JavaScript expressions.
        /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html"
        /// target="_blank">Configuring Expressions</a> in the <i>Amazon CloudSearch Developer Guide</i>.
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
        public string ExpressionValue
        {
            get { return this.expressionValue; }
            set { this.expressionValue = value; }
        }

        // Check to see if ExpressionValue property is set
        internal bool IsSetExpressionValue()
        {
            return this.expressionValue != null;
        }
    }
}
