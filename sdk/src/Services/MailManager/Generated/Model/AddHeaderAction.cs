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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The action to add a header to a message. When executed, this action will add the given
    /// header to the message.
    /// </summary>
    public partial class AddHeaderAction
    {
        private string _headerName;
        private string _headerValue;

        /// <summary>
        /// Gets and sets the property HeaderName. 
        /// <para>
        /// The name of the header to add to an email. The header must be prefixed with "X-".
        /// Headers are added regardless of whether the header name pre-existed in the email.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// The value of the header to add to the email.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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