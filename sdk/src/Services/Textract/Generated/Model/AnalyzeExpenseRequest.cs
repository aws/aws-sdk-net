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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the AnalyzeExpense operation.
    /// <c>AnalyzeExpense</c> synchronously analyzes an input document for financially related
    /// relationships between text.
    /// 
    ///  
    /// <para>
    /// Information is returned as <c>ExpenseDocuments</c> and seperated as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>LineItemGroups</c>- A data set containing <c>LineItems</c> which store information
    /// about the lines of text, such as an item purchased and its price on a receipt.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SummaryFields</c>- Contains all other information a receipt, such as header information
    /// or the vendors name.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AnalyzeExpenseRequest : AmazonTextractRequest
    {
        private Document _document;

        /// <summary>
        /// Gets and sets the property Document.
        /// </summary>
        [AWSProperty(Required=true)]
        public Document Document
        {
            get { return this._document; }
            set { this._document = value; }
        }

        // Check to see if Document property is set
        internal bool IsSetDocument()
        {
            return this._document != null;
        }

    }
}