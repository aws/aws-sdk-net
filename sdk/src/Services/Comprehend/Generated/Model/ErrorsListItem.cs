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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Text extraction encountered one or more page-level errors in the input document.
    /// 
    ///  
    /// <para>
    /// The <code>ErrorCode</code> contains one of the following values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// TEXTRACT_BAD_PAGE - Amazon Textract cannot read the page. For more information about
    /// page limits in Amazon Textract, see <a href="https://docs.aws.amazon.com/textract/latest/dg/limits-document.html">
    /// Page Quotas in Amazon Textract</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// TEXTRACT_PROVISIONED_THROUGHPUT_EXCEEDED - The number of requests exceeded your throughput
    /// limit. For more information about throughput quotas in Amazon Textract, see <a href="https://docs.aws.amazon.com/textract/latest/dg/limits-quotas-explained.html">
    /// Default quotas in Amazon Textract</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// PAGE_CHARACTERS_EXCEEDED - Too many text characters on the page (10,000 characters
    /// maximum).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// PAGE_SIZE_EXCEEDED - The maximum page size is 10 MB.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INTERNAL_SERVER_ERROR - The request encountered a service issue. Try the API request
    /// again.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ErrorsListItem
    {
        private PageBasedErrorCode _errorCode;
        private string _errorMessage;
        private int? _page;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Error code for the cause of the error.
        /// </para>
        /// </summary>
        public PageBasedErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Text message explaining the reason for the error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Page. 
        /// <para>
        /// Page number where the error occurred.
        /// </para>
        /// </summary>
        public int Page
        {
            get { return this._page.GetValueOrDefault(); }
            set { this._page = value; }
        }

        // Check to see if Page property is set
        internal bool IsSetPage()
        {
            return this._page.HasValue; 
        }

    }
}