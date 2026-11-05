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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// The content of the email, composed of a subject line and either an HTML part or a
    /// text-only part.
    /// </summary>
    public partial class Template
    {
        /// <summary>
        /// Gets and sets the property HtmlPart. 
        /// <para>
        /// The HTML body of the email.
        /// </para>
        /// </summary>
        public string HtmlPart { get; set; }

        /// <summary>
        /// Checks to see if the HtmlPart property is set.
        /// </summary>
        internal bool IsSetHtmlPart() => this.HtmlPart != null;

        /// <summary>
        /// Gets and sets the property SubjectPart. 
        /// <para>
        /// The subject line of the email.
        /// </para>
        /// </summary>
        public string SubjectPart { get; set; }

        /// <summary>
        /// Checks to see if the SubjectPart property is set.
        /// </summary>
        internal bool IsSetSubjectPart() => this.SubjectPart != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the template. You use this name when you send email using the <c>SendTemplatedEmail</c>
        /// or <c>SendBulkTemplatedEmail</c> operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property TextPart. 
        /// <para>
        /// The email body that is visible to recipients whose email clients do not display HTML
        /// content.
        /// </para>
        /// </summary>
        public string TextPart { get; set; }

        /// <summary>
        /// Checks to see if the TextPart property is set.
        /// </summary>
        internal bool IsSetTextPart() => this.TextPart != null;
    }
}
