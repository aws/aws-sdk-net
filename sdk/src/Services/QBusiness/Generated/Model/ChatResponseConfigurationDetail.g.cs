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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Detailed information about a chat response configuration, including comprehensive
    /// settings and parameters that define how Amazon Q Business generates and formats responses.
    /// </summary>
    public partial class ChatResponseConfigurationDetail
    {
        /// <summary>
        /// Gets and sets the property Error.
        /// </summary>
        public ErrorDetail Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property ResponseConfigurationSummary. 
        /// <para>
        /// A summary of the response configuration details, providing a concise overview of the
        /// key parameters and settings that define the response generation behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ResponseConfigurationSummary { get; set; }

        /// <summary>
        /// Checks to see if the ResponseConfigurationSummary property is set.
        /// </summary>
        internal bool IsSetResponseConfigurationSummary() => this.ResponseConfigurationSummary != null;

        /// <summary>
        /// Gets and sets the property ResponseConfigurations. 
        /// <para>
        /// A collection of specific response configuration settings that collectively define
        /// how responses are generated, formatted, and presented to users in chat interactions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public Dictionary<string, ResponseConfiguration> ResponseConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ResponseConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ResponseConfigurations property is set.
        /// </summary>
        internal bool IsSetResponseConfigurations() => this.ResponseConfigurations != null && (this.ResponseConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the chat response configuration, indicating whether it is active,
        /// pending, or in another state that affects its availability for use.
        /// </para>
        /// </summary>
        public ChatResponseConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp indicating when the detailed chat response configuration was last modified,
        /// helping administrators track changes and maintain version awareness.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
