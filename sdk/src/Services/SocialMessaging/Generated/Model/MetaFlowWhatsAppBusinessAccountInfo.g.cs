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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Contains WhatsApp Business Account metadata associated with a Flow, as returned by
    /// Meta.
    /// </summary>
    public partial class MetaFlowWhatsAppBusinessAccountInfo
    {
        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency code for the WhatsApp Business Account (for example, USD).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The WhatsApp Business Account ID from Meta.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MessageTemplateNamespace. 
        /// <para>
        /// The message template namespace for the WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string MessageTemplateNamespace { get; set; }

        /// <summary>
        /// Checks to see if the MessageTemplateNamespace property is set.
        /// </summary>
        internal bool IsSetMessageTemplateNamespace() => this.MessageTemplateNamespace != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 200)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TimezoneId. 
        /// <para>
        /// The timezone ID for the WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string TimezoneId { get; set; }

        /// <summary>
        /// Checks to see if the TimezoneId property is set.
        /// </summary>
        internal bool IsSetTimezoneId() => this.TimezoneId != null;
    }
}
