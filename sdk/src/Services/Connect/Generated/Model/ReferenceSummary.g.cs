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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains summary information about a reference. <c>ReferenceSummary</c> contains only
    /// one non null field between the URL and attachment based on the reference type.
    /// </summary>
    public partial class ReferenceSummary
    {
        /// <summary>
        /// Gets and sets the property Attachment. 
        /// <para>
        /// Information about the reference when the <c>referenceType</c> is <c>ATTACHMENT</c>.
        /// Otherwise, null.
        /// </para>
        /// </summary>
        public AttachmentReference Attachment { get; set; }

        /// <summary>
        /// Checks to see if the Attachment property is set.
        /// </summary>
        internal bool IsSetAttachment() => this.Attachment != null;

        /// <summary>
        /// Gets and sets the property ContactAnalysis.
        /// </summary>
        public ContactAnalysisReference ContactAnalysis { get; set; }

        /// <summary>
        /// Checks to see if the ContactAnalysis property is set.
        /// </summary>
        internal bool IsSetContactAnalysis() => this.ContactAnalysis != null;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// Information about a reference when the <c>referenceType</c> is <c>DATE</c>. Otherwise,
        /// null.
        /// </para>
        /// </summary>
        public DateReference Date { get; set; }

        /// <summary>
        /// Checks to see if the Date property is set.
        /// </summary>
        internal bool IsSetDate() => this.Date != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// Information about a reference when the <c>referenceType</c> is <c>EMAIL</c>. Otherwise,
        /// null.
        /// </para>
        /// </summary>
        public EmailReference Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property EmailMessage. 
        /// <para>
        /// Information about the reference when the referenceType is <c>EMAIL_MESSAGE</c>. Otherwise,
        /// null.
        /// </para>
        /// </summary>
        public EmailMessageReference EmailMessage { get; set; }

        /// <summary>
        /// Checks to see if the EmailMessage property is set.
        /// </summary>
        internal bool IsSetEmailMessage() => this.EmailMessage != null;

        /// <summary>
        /// Gets and sets the property EmailMessagePlainText.
        /// </summary>
        public EmailMessageReference EmailMessagePlainText { get; set; }

        /// <summary>
        /// Checks to see if the EmailMessagePlainText property is set.
        /// </summary>
        internal bool IsSetEmailMessagePlainText() => this.EmailMessagePlainText != null;

        /// <summary>
        /// Gets and sets the property EmailMessagePlainTextRedacted.
        /// </summary>
        public EmailMessageReference EmailMessagePlainTextRedacted { get; set; }

        /// <summary>
        /// Checks to see if the EmailMessagePlainTextRedacted property is set.
        /// </summary>
        internal bool IsSetEmailMessagePlainTextRedacted() => this.EmailMessagePlainTextRedacted != null;

        /// <summary>
        /// Gets and sets the property EmailMessageRedacted.
        /// </summary>
        public EmailMessageReference EmailMessageRedacted { get; set; }

        /// <summary>
        /// Checks to see if the EmailMessageRedacted property is set.
        /// </summary>
        internal bool IsSetEmailMessageRedacted() => this.EmailMessageRedacted != null;

        /// <summary>
        /// Gets and sets the property Number. 
        /// <para>
        /// Information about a reference when the <c>referenceType</c> is <c>NUMBER</c>. Otherwise,
        /// null.
        /// </para>
        /// </summary>
        public NumberReference Number { get; set; }

        /// <summary>
        /// Checks to see if the Number property is set.
        /// </summary>
        internal bool IsSetNumber() => this.Number != null;

        /// <summary>
        /// Gets and sets the property String. 
        /// <para>
        /// Information about a reference when the <c>referenceType</c> is <c>STRING</c>. Otherwise,
        /// null.
        /// </para>
        /// </summary>
        public StringReference String { get; set; }

        /// <summary>
        /// Checks to see if the String property is set.
        /// </summary>
        internal bool IsSetString() => this.String != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// Information about the reference when the <c>referenceType</c> is <c>URL</c>. Otherwise,
        /// null.
        /// </para>
        /// </summary>
        public UrlReference Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
