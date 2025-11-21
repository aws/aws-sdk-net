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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Configuration information about the external data source.
    /// </summary>
    public partial class WhatsAppMessageTemplateSourceConfigurationSummary
    {
        private string _businessAccountId;
        private List<string> _components = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _language;
        private string _name;
        private WhatsAppSourceConfigurationStatus _status;
        private string _statusReason;
        private string _templateId;

        /// <summary>
        /// Gets and sets the property BusinessAccountId. 
        /// <para>
        /// The ID of the End User Messaging WhatsApp Business Account to associate with this
        /// template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string BusinessAccountId
        {
            get { return this._businessAccountId; }
            set { this._businessAccountId = value; }
        }

        // Check to see if BusinessAccountId property is set
        internal bool IsSetBusinessAccountId()
        {
            return this._businessAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Components. 
        /// <para>
        /// The list of component mapping from WhatsApp template parameters to Message Template
        /// attributes.
        /// </para>
        /// </summary>
        public List<string> Components
        {
            get { return this._components; }
            set { this._components = value; }
        }

        // Check to see if Components property is set
        internal bool IsSetComponents()
        {
            return this._components != null && (this._components.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language of the WhatsApp template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the WhatsApp template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the message template.
        /// </para>
        /// </summary>
        public WhatsAppSourceConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The status reason of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The ID of WhatsApp template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

    }
}