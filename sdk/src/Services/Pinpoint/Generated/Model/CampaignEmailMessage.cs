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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the content and "From" address for an email message that's sent to recipients
    /// of a campaign.
    /// </summary>
    public partial class CampaignEmailMessage
    {
        private string _body;
        private string _fromAddress;
        private string _htmlBody;
        private string _title;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the email for recipients whose email clients don't render HTML content.
        /// </para>
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property FromAddress. 
        /// <para>
        /// The verified email address to send the email from. The default address is the FromAddress
        /// specified for the email channel for the application.
        /// </para>
        /// </summary>
        public string FromAddress
        {
            get { return this._fromAddress; }
            set { this._fromAddress = value; }
        }

        // Check to see if FromAddress property is set
        internal bool IsSetFromAddress()
        {
            return this._fromAddress != null;
        }

        /// <summary>
        /// Gets and sets the property HtmlBody. 
        /// <para>
        /// The body of the email, in HTML format, for recipients whose email clients render HTML
        /// content.
        /// </para>
        /// </summary>
        public string HtmlBody
        {
            get { return this._htmlBody; }
            set { this._htmlBody = value; }
        }

        // Check to see if HtmlBody property is set
        internal bool IsSetHtmlBody()
        {
            return this._htmlBody != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The subject line, or title, of the email.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}