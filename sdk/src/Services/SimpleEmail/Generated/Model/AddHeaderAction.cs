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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// When included in a receipt rule, this action adds a header to the received email.
    /// 
    ///  
    /// <para>
    /// For information about adding a header using a receipt rule, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-action-add-header.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AddHeaderAction
    {
        private string _headerName;
        private string _headerValue;

        /// <summary>
        /// Gets and sets the property HeaderName. 
        /// <para>
        /// The name of the header to add. Must be between 1 and 50 characters, inclusive, and
        /// consist of alphanumeric (a-z, A-Z, 0-9) characters and dashes only.
        /// </para>
        /// </summary>
        public string HeaderName
        {
            get { return this._headerName; }
            set { this._headerName = value; }
        }

        // Check to see if HeaderName property is set
        internal bool IsSetHeaderName()
        {
            return this._headerName != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderValue. 
        /// <para>
        /// Must be less than 2048 characters, and must not contain newline characters ("\r" or
        /// "\n").
        /// </para>
        /// </summary>
        public string HeaderValue
        {
            get { return this._headerValue; }
            set { this._headerValue = value; }
        }

        // Check to see if HeaderValue property is set
        internal bool IsSetHeaderValue()
        {
            return this._headerValue != null;
        }

    }
}