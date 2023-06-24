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
    /// Provides additional detail about why the request failed:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Document size is too large - Check the size of your file and resubmit the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Document type is not supported - Check the file type and resubmit the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Too many pages in the document - Check the number of pages in your file and resubmit
    /// the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Access denied to Amazon Textract - Verify that your account has permission to use
    /// Amazon Textract API operations and resubmit the request.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class InvalidRequestDetail
    {
        private InvalidRequestDetailReason _reason;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// Reason code is <code>INVALID_DOCUMENT</code>.
        /// </para>
        /// </summary>
        public InvalidRequestDetailReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}