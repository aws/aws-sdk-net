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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the content and settings for a message template that can be used in messages
    /// that are sent through the email channel.
    /// </summary>
    public partial class EmailTemplateRequest
    {
        private string _defaultSubstitutions;
        private string _htmlPart;
        private string _recommenderId;
        private string _subject;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _templateDescription;
        private string _textPart;

        /// <summary>
        /// Gets and sets the property DefaultSubstitutions. 
        /// <para>
        /// A JSON object that specifies the default values to use for message variables in the
        /// message template. This object is a set of key-value pairs. Each key defines a message
        /// variable in the template. The corresponding value defines the default value for that
        /// variable. When you create a message that's based on the template, you can override
        /// these defaults with message-specific and address-specific variables and values.
        /// </para>
        /// </summary>
        public string DefaultSubstitutions
        {
            get { return this._defaultSubstitutions; }
            set { this._defaultSubstitutions = value; }
        }

        // Check to see if DefaultSubstitutions property is set
        internal bool IsSetDefaultSubstitutions()
        {
            return this._defaultSubstitutions != null;
        }

        /// <summary>
        /// Gets and sets the property HtmlPart. 
        /// <para>
        /// The message body, in HTML format, to use in email messages that are based on the message
        /// template. We recommend using HTML format for email clients that render HTML content.
        /// You can include links, formatted text, and more in an HTML message.
        /// </para>
        /// </summary>
        public string HtmlPart
        {
            get { return this._htmlPart; }
            set { this._htmlPart = value; }
        }

        // Check to see if HtmlPart property is set
        internal bool IsSetHtmlPart()
        {
            return this._htmlPart != null;
        }

        /// <summary>
        /// Gets and sets the property RecommenderId. 
        /// <para>
        /// The unique identifier for the recommender model to use for the message template. Amazon
        /// Pinpoint uses this value to determine how to retrieve and process data from a recommender
        /// model when it sends messages that use the template, if the template contains message
        /// variables for recommendation data.
        /// </para>
        /// </summary>
        public string RecommenderId
        {
            get { return this._recommenderId; }
            set { this._recommenderId = value; }
        }

        // Check to see if RecommenderId property is set
        internal bool IsSetRecommenderId()
        {
            return this._recommenderId != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line, or title, to use in email messages that are based on the message
        /// template.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A string-to-string map of key-value pairs that defines the tags to associate with
        /// the message template. Each tag consists of a required tag key and an associated tag
        /// value.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateDescription. 
        /// <para>
        /// A custom description of the message template.
        /// </para>
        /// </summary>
        public string TemplateDescription
        {
            get { return this._templateDescription; }
            set { this._templateDescription = value; }
        }

        // Check to see if TemplateDescription property is set
        internal bool IsSetTemplateDescription()
        {
            return this._templateDescription != null;
        }

        /// <summary>
        /// Gets and sets the property TextPart. 
        /// <para>
        /// The message body, in plain text format, to use in email messages that are based on
        /// the message template. We recommend using plain text format for email clients that
        /// don't render HTML content and clients that are connected to high-latency networks,
        /// such as mobile devices.
        /// </para>
        /// </summary>
        public string TextPart
        {
            get { return this._textPart; }
            set { this._textPart = value; }
        }

        // Check to see if TextPart property is set
        internal bool IsSetTextPart()
        {
            return this._textPart != null;
        }

    }
}