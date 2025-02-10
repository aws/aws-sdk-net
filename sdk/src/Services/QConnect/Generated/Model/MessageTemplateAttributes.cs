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
    /// The attributes that are used with the message template.
    /// </summary>
    public partial class MessageTemplateAttributes
    {
        private AgentAttributes _agentAttributes;
        private Dictionary<string, string> _customAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private CustomerProfileAttributes _customerProfileAttributes;
        private SystemAttributes _systemAttributes;

        /// <summary>
        /// Gets and sets the property AgentAttributes. 
        /// <para>
        /// The agent attributes that are used with the message template.
        /// </para>
        /// </summary>
        public AgentAttributes AgentAttributes
        {
            get { return this._agentAttributes; }
            set { this._agentAttributes = value; }
        }

        // Check to see if AgentAttributes property is set
        internal bool IsSetAgentAttributes()
        {
            return this._agentAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property CustomAttributes. 
        /// <para>
        /// The custom attributes that are used with the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> CustomAttributes
        {
            get { return this._customAttributes; }
            set { this._customAttributes = value; }
        }

        // Check to see if CustomAttributes property is set
        internal bool IsSetCustomAttributes()
        {
            return this._customAttributes != null && (this._customAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomerProfileAttributes. 
        /// <para>
        /// The customer profile attributes that are used with the message template.
        /// </para>
        /// </summary>
        public CustomerProfileAttributes CustomerProfileAttributes
        {
            get { return this._customerProfileAttributes; }
            set { this._customerProfileAttributes = value; }
        }

        // Check to see if CustomerProfileAttributes property is set
        internal bool IsSetCustomerProfileAttributes()
        {
            return this._customerProfileAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property SystemAttributes. 
        /// <para>
        /// The system attributes that are used with the message template.
        /// </para>
        /// </summary>
        public SystemAttributes SystemAttributes
        {
            get { return this._systemAttributes; }
            set { this._systemAttributes = value; }
        }

        // Check to see if SystemAttributes property is set
        internal bool IsSetSystemAttributes()
        {
            return this._systemAttributes != null;
        }

    }
}