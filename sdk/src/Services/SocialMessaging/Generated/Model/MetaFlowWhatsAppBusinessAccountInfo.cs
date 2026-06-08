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
    /// Contains WhatsApp Business Account metadata associated with a Flow, as returned by
    /// Meta.
    /// </summary>
    public partial class MetaFlowWhatsAppBusinessAccountInfo
    {
        private string _currency;
        private string _id;
        private string _messageTemplateNamespace;
        private string _name;
        private string _timezoneId;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency code for the WhatsApp Business Account (for example, USD).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string Currency
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

        // Check to see if Currency property is set
        internal bool IsSetCurrency()
        {
            return this._currency != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The WhatsApp Business Account ID from Meta.
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
        /// Gets and sets the property MessageTemplateNamespace. 
        /// <para>
        /// The message template namespace for the WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string MessageTemplateNamespace
        {
            get { return this._messageTemplateNamespace; }
            set { this._messageTemplateNamespace = value; }
        }

        // Check to see if MessageTemplateNamespace property is set
        internal bool IsSetMessageTemplateNamespace()
        {
            return this._messageTemplateNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property TimezoneId. 
        /// <para>
        /// The timezone ID for the WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string TimezoneId
        {
            get { return this._timezoneId; }
            set { this._timezoneId = value; }
        }

        // Check to see if TimezoneId property is set
        internal bool IsSetTimezoneId()
        {
            return this._timezoneId != null;
        }

    }
}