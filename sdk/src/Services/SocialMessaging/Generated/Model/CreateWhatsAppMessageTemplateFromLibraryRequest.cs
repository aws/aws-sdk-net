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
    /// Container for the parameters to the CreateWhatsAppMessageTemplateFromLibrary operation.
    /// Creates a new WhatsApp message template using a template from Meta's template library.
    /// </summary>
    public partial class CreateWhatsAppMessageTemplateFromLibraryRequest : AmazonSocialMessagingRequest
    {
        private string _id;
        private MetaLibraryTemplate _metaLibraryTemplate;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the WhatsApp Business Account to associate with this template.
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
        /// Gets and sets the property MetaLibraryTemplate. 
        /// <para>
        /// The template configuration from Meta's library, including customizations for buttons
        /// and body text.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetaLibraryTemplate MetaLibraryTemplate
        {
            get { return this._metaLibraryTemplate; }
            set { this._metaLibraryTemplate = value; }
        }

        // Check to see if MetaLibraryTemplate property is set
        internal bool IsSetMetaLibraryTemplate()
        {
            return this._metaLibraryTemplate != null;
        }

    }
}