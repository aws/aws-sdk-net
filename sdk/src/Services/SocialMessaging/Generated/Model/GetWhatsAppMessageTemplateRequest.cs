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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the GetWhatsAppMessageTemplate operation.
    /// Retrieves a specific WhatsApp message template.
    /// </summary>
    public partial class GetWhatsAppMessageTemplateRequest : AmazonSocialMessagingRequest
    {
        private string _id;
        private string _metaTemplateId;
        private string _templateLanguageCode;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the WhatsApp Business Account associated with this template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=115)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MetaTemplateId. 
        /// <para>
        /// The numeric ID of the template assigned by Meta.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string MetaTemplateId
        {
            get { return this._metaTemplateId; }
            set { this._metaTemplateId = value; }
        }

        // Check to see if MetaTemplateId property is set
        internal bool IsSetMetaTemplateId()
        {
            return this._metaTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateLanguageCode. 
        /// <para>
        /// The language code of the message template (for example, <c>en</c> or <c>en_US</c>).
        /// Use together with <c>templateName</c> as an alternative to <c>metaTemplateId</c> to
        /// identify a template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public string TemplateLanguageCode
        {
            get { return this._templateLanguageCode; }
            set { this._templateLanguageCode = value; }
        }

        // Check to see if TemplateLanguageCode property is set
        internal bool IsSetTemplateLanguageCode()
        {
            return this._templateLanguageCode != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the message template. Use together with <c>templateLanguageCode</c> as
        /// an alternative to <c>metaTemplateId</c> to identify a template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}