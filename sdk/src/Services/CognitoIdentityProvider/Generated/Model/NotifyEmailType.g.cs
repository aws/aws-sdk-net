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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property HtmlBody. 
        /// <para>
        /// The body of an email notification formatted in HTML. Choose an <c>HtmlBody</c> or
        /// a <c>TextBody</c> to send an HTML-formatted or plaintext message, respectively.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 20000)]
        public string HtmlBody { get; set; }

        /// <summary>
        /// Checks to see if the HtmlBody property is set.
        /// </summary>
        internal bool IsSetHtmlBody() => this.HtmlBody != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject of the threat protection email notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;

        /// <summary>
        /// Gets and sets the property TextBody. 
        /// <para>
        /// The body of an email notification formatted in plaintext. Choose an <c>HtmlBody</c>
        /// or a <c>TextBody</c> to send an HTML-formatted or plaintext message, respectively.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 20000)]
        public string TextBody { get; set; }

        /// <summary>
        /// Checks to see if the TextBody property is set.
        /// </summary>
        internal bool IsSetTextBody() => this.TextBody != null;
    }
}
