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
    /// Container for the parameters to the DeleteWhatsAppMessageTemplate operation.
    /// Deletes a WhatsApp message template.
    /// </summary>
    public partial class DeleteWhatsAppMessageTemplateRequest : AmazonSocialMessagingRequest
    {
        private bool? _deleteAllLanguages;
        private string _id;
        private string _metaTemplateId;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property DeleteAllLanguages. 
        /// <para>
        /// If true, deletes all language versions of the template.
        /// </para>
        /// </summary>
        public bool? DeleteAllLanguages
        {
            get { return this._deleteAllLanguages; }
            set { this._deleteAllLanguages = value; }
        }

        // Check to see if DeleteAllLanguages property is set
        internal bool IsSetDeleteAllLanguages()
        {
            return this._deleteAllLanguages.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the WhatsApp Business Account associated with this template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the template to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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