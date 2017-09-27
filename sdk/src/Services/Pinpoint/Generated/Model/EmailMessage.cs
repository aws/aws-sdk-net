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
    /// Email Message.
    /// </summary>
    public partial class EmailMessage
    {
        private string _body;
        private string _fromAddress;
        private string _htmlBody;
        private Dictionary<string, List<string>> _substitutions = new Dictionary<string, List<string>>();
        private string _templateArn;
        private string _title;

        /// <summary>
        /// Gets and sets the property Body. The message body of the notification, the email body
        /// or the text message.
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
        /// Gets and sets the property FromAddress. The email address used to send the email from.
        /// Defaults to use FromAddress specified in the Email Channel.
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
        /// Gets and sets the property HtmlBody. The HTML part of the email.
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
        /// Gets and sets the property Substitutions. Default message substitutions. Can be overridden
        /// by individual address substitutions.
        /// </summary>
        public Dictionary<string, List<string>> Substitutions
        {
            get { return this._substitutions; }
            set { this._substitutions = value; }
        }

        // Check to see if Substitutions property is set
        internal bool IsSetSubstitutions()
        {
            return this._substitutions != null && this._substitutions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateArn. The ARN of the template to use for the email.
        /// </summary>
        public string TemplateArn
        {
            get { return this._templateArn; }
            set { this._templateArn = value; }
        }

        // Check to see if TemplateArn property is set
        internal bool IsSetTemplateArn()
        {
            return this._templateArn != null;
        }

        /// <summary>
        /// Gets and sets the property Title. The subject of the email.
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