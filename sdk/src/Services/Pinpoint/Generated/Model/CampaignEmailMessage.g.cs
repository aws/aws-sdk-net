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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the content and "From" address for an email message that's sent to recipients
    /// of a campaign.
    /// </summary>
    public partial class CampaignEmailMessage
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the email for recipients whose email clients don't render HTML content.
        /// </para>
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property FromAddress. 
        /// <para>
        /// The verified email address to send the email from. The default address is the FromAddress
        /// specified for the email channel for the application.
        /// </para>
        /// </summary>
        public string FromAddress { get; set; }

        /// <summary>
        /// Checks to see if the FromAddress property is set.
        /// </summary>
        internal bool IsSetFromAddress() => this.FromAddress != null;

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// The list of <a href="https://docs.aws.amazon.com/pinpoint/latest/apireference/apps-application-id-campaigns-campaign-id.html#apps-application-id-campaigns-campaign-id-model-messageheader">MessageHeaders</a>
        /// for the email. You can have up to 15 MessageHeaders for each email.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MessageHeader> Headers { get; set; } = AWSConfigs.InitializeCollections ? new List<MessageHeader>() : null;

        /// <summary>
        /// Checks to see if the Headers property is set.
        /// </summary>
        internal bool IsSetHeaders() => this.Headers != null && (this.Headers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HtmlBody. 
        /// <para>
        /// The body of the email, in HTML format, for recipients whose email clients render HTML
        /// content.
        /// </para>
        /// </summary>
        public string HtmlBody { get; set; }

        /// <summary>
        /// Checks to see if the HtmlBody property is set.
        /// </summary>
        internal bool IsSetHtmlBody() => this.HtmlBody != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The subject line, or title, of the email.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
