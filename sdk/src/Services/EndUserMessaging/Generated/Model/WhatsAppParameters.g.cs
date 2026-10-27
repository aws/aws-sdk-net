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

namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// The delivery parameters for the WhatsApp channel.
    /// </summary>
    public partial class WhatsAppParameters
    {
        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The BCP 47 language code used to render the template. This value is required for the
        /// WhatsApp channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 35)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property WhatsAppTemplateName. 
        /// <para>
        /// The name of the Meta-approved WhatsApp authentication template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string WhatsAppTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the WhatsAppTemplateName property is set.
        /// </summary>
        internal bool IsSetWhatsAppTemplateName() => this.WhatsAppTemplateName != null;
    }
}
