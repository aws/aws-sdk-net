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
    /// Specifies the settings for an email activity in a journey. This type of activity sends
    /// an email message to participants.
    /// </summary>
    public partial class EmailMessageActivity
    {
        /// <summary>
        /// Gets and sets the property MessageConfig. 
        /// <para>
        /// Specifies the sender address for an email message that's sent to participants in the
        /// journey.
        /// </para>
        /// </summary>
        public JourneyEmailMessage MessageConfig { get; set; }

        /// <summary>
        /// Checks to see if the MessageConfig property is set.
        /// </summary>
        internal bool IsSetMessageConfig() => this.MessageConfig != null;

        /// <summary>
        /// Gets and sets the property NextActivity. 
        /// <para>
        /// The unique identifier for the next activity to perform, after the message is sent.
        /// </para>
        /// </summary>
        public string NextActivity { get; set; }

        /// <summary>
        /// Checks to see if the NextActivity property is set.
        /// </summary>
        internal bool IsSetNextActivity() => this.NextActivity != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the email message template to use for the message. If specified, this
        /// value must match the name of an existing message template.
        /// </para>
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property TemplateVersion. 
        /// <para>
        /// The unique identifier for the version of the email template to use for the message.
        /// If specified, this value must match the identifier for an existing template version.
        /// To retrieve a list of versions and version identifiers for a template, use the <link
        /// linkend="templates-template-name-template-type-versions">Template Versions</link>
        /// resource.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for this property, Amazon Pinpoint uses the <i>active
        /// version</i> of the template. The <i>active version</i> is typically the version of
        /// a template that's been most recently reviewed and approved for use, depending on your
        /// workflow. It isn't necessarily the latest version of a template.
        /// </para>
        /// </summary>
        public string TemplateVersion { get; set; }

        /// <summary>
        /// Checks to see if the TemplateVersion property is set.
        /// </summary>
        internal bool IsSetTemplateVersion() => this.TemplateVersion != null;
    }
}
