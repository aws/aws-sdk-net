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
    /// Specifies the content and settings for a message template that can be used in text
    /// messages that are sent through the SMS channel.
    /// </summary>
    public partial class SMSTemplateRequest
    {
        private string _body;
        private string _defaultSubstitutions;
        private string _recommenderId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _templateDescription;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The message body to use in text messages that are based on the message template.
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

    }
}