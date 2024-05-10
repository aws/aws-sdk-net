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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// When included in a receipt rule, this action adds a header to the received email.
    /// 
    ///  
    /// <para>
    /// For information about adding a header using a receipt rule, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-action-add-header.html">Amazon
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
        /// The name of the header to add to the incoming message. The name must contain at least
        /// one character, and can contain up to 50 characters. It consists of alphanumeric (a–z,
        /// A–Z, 0–9) characters and dashes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The content to include in the header. This value can contain up to 2048 characters.
        /// It can't contain newline (<c>\n</c>) or carriage return (<c>\r</c>) characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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