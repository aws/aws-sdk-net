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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The template for email messages that threat protection sends to a user when your threat
    /// protection automated response has a <i>Notify</i> action.
    /// </summary>
    public partial class NotifyEmailType
    {
        private string _htmlBody;
        private string _subject;
        private string _textBody;

        /// <summary>
        /// Gets and sets the property HtmlBody. 
        /// <para>
        /// The body of an email notification formatted in HTML. Choose an <c>HtmlBody</c> or
        /// a <c>TextBody</c> to send an HTML-formatted or plaintext message, respectively.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=20000)]
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
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject of the threat protection email notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

        /// <summary>
        /// Gets and sets the property TextBody. 
        /// <para>
        /// The body of an email notification formatted in plaintext. Choose an <c>HtmlBody</c>
        /// or a <c>TextBody</c> to send an HTML-formatted or plaintext message, respectively.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=20000)]
        public string TextBody
        {
            get { return this._textBody; }
            set { this._textBody = value; }
        }

        // Check to see if TextBody property is set
        internal bool IsSetTextBody()
        {
            return this._textBody != null;
        }

    }
}