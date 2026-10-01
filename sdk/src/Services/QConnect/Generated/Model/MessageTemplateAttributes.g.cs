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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The attributes that are used with the message template.
    /// </summary>
    public partial class MessageTemplateAttributes
    {
        /// <summary>
        /// Gets and sets the property AgentAttributes. 
        /// <para>
        /// The agent attributes that are used with the message template.
        /// </para>
        /// </summary>
        public AgentAttributes AgentAttributes { get; set; }

        /// <summary>
        /// Checks to see if the AgentAttributes property is set.
        /// </summary>
        internal bool IsSetAgentAttributes() => this.AgentAttributes != null;

        /// <summary>
        /// Gets and sets the property CustomAttributes. 
        /// <para>
        /// The custom attributes that are used with the message template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> CustomAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the CustomAttributes property is set.
        /// </summary>
        internal bool IsSetCustomAttributes() => this.CustomAttributes != null && (this.CustomAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomerProfileAttributes. 
        /// <para>
        /// The customer profile attributes that are used with the message template.
        /// </para>
        /// </summary>
        public CustomerProfileAttributes CustomerProfileAttributes { get; set; }

        /// <summary>
        /// Checks to see if the CustomerProfileAttributes property is set.
        /// </summary>
        internal bool IsSetCustomerProfileAttributes() => this.CustomerProfileAttributes != null;

        /// <summary>
        /// Gets and sets the property SystemAttributes. 
        /// <para>
        /// The system attributes that are used with the message template.
        /// </para>
        /// </summary>
        public SystemAttributes SystemAttributes { get; set; }

        /// <summary>
        /// Checks to see if the SystemAttributes property is set.
        /// </summary>
        internal bool IsSetSystemAttributes() => this.SystemAttributes != null;
    }
}
