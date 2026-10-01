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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// This is the response object from the GetCustomVerificationEmailTemplate operation.
    /// </summary>
    public partial class GetCustomVerificationEmailTemplateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FailureRedirectionURL. 
        /// <para>
        /// The URL that the recipient of the verification email is sent to if his or her address
        /// is not successfully verified.
        /// </para>
        /// </summary>
        public string FailureRedirectionURL { get; set; }

        /// <summary>
        /// Checks to see if the FailureRedirectionURL property is set.
        /// </summary>
        internal bool IsSetFailureRedirectionURL() => this.FailureRedirectionURL != null;

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The email address that the custom verification email is sent from.
        /// </para>
        /// </summary>
        public string FromEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the FromEmailAddress property is set.
        /// </summary>
        internal bool IsSetFromEmailAddress() => this.FromEmailAddress != null;

        /// <summary>
        /// Gets and sets the property SuccessRedirectionURL. 
        /// <para>
        /// The URL that the recipient of the verification email is sent to if his or her address
        /// is successfully verified.
        /// </para>
        /// </summary>
        public string SuccessRedirectionURL { get; set; }

        /// <summary>
        /// Checks to see if the SuccessRedirectionURL property is set.
        /// </summary>
        internal bool IsSetSuccessRedirectionURL() => this.SuccessRedirectionURL != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of objects that define the tags (keys and values) that are associated with
        /// the custom verification email template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateContent. 
        /// <para>
        /// The content of the custom verification email.
        /// </para>
        /// </summary>
        public string TemplateContent { get; set; }

        /// <summary>
        /// Checks to see if the TemplateContent property is set.
        /// </summary>
        internal bool IsSetTemplateContent() => this.TemplateContent != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the custom verification email template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property TemplateSubject. 
        /// <para>
        /// The subject line of the custom verification email.
        /// </para>
        /// </summary>
        public string TemplateSubject { get; set; }

        /// <summary>
        /// Checks to see if the TemplateSubject property is set.
        /// </summary>
        internal bool IsSetTemplateSubject() => this.TemplateSubject != null;
    }
}
