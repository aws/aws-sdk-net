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
    /// The updated delivery parameters for the WhatsApp channel. Absent members preserve
    /// the current value, and the empty sentinel on a member clears it.
    /// </summary>
    public partial class UpdateWhatsAppParameters
    {
        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The updated BCP 47 language code. An empty string clears the previously stored value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 35)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property WhatsAppTemplateName. 
        /// <para>
        /// The updated name of the Meta-approved WhatsApp authentication template. An empty string
        /// clears the previously stored value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string WhatsAppTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the WhatsAppTemplateName property is set.
        /// </summary>
        internal bool IsSetWhatsAppTemplateName() => this.WhatsAppTemplateName != null;
    }
}
