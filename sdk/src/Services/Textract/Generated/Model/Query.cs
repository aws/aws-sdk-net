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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Each query contains the question you want to ask in the Text and the alias you want
    /// to associate.
    /// </summary>
    public partial class Query
    {
        private string _alias;
        private List<string> _pages = new List<string>();
        private string _text;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Alias attached to the query, for ease of location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property Pages. 
        /// <para>
        /// Pages is a parameter that the user inputs to specify which pages to apply a query
        /// to. The following is a list of rules for using this parameter.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If a page is not specified, it is set to <code>["1"]</code> by default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The following characters are allowed in the parameter's string: <code>0 1 2 3 4 5
        /// 6 7 8 9 - *</code>. No whitespace is allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When using * to indicate all pages, it must be the only element in the list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can use page intervals, such as <code>[“1-3”, “1-1”, “4-*”]</code>. Where <code>*</code>
        /// indicates last page of document.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified pages must be greater than 0 and less than or equal to the number of pages
        /// in the document.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Pages
        {
            get { return this._pages; }
            set { this._pages = value; }
        }

        // Check to see if Pages property is set
        internal bool IsSetPages()
        {
            return this._pages != null && this._pages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// Question that Amazon Textract will apply to the document. An example would be "What
        /// is the customer's SSN?"
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}