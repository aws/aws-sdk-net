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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
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
namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// The delivery parameters for the WhatsApp channel.
    /// </summary>
    public partial class WhatsAppParameters
    {
        private string _languageCode;
        private string _whatsAppTemplateName;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The BCP 47 language code used to render the template. This value is required for the
        /// WhatsApp channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=35)]
        public string LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property WhatsAppTemplateName. 
        /// <para>
        /// The name of the Meta-approved WhatsApp authentication template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string WhatsAppTemplateName
        {
            get { return this._whatsAppTemplateName; }
            set { this._whatsAppTemplateName = value; }
        }

        // Check to see if WhatsAppTemplateName property is set
        internal bool IsSetWhatsAppTemplateName()
        {
            return this._whatsAppTemplateName != null;
        }

    }
}