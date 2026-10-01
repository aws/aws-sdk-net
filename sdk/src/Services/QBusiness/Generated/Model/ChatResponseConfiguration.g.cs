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
    /// Configuration details that define how Amazon Q Business generates and formats responses
    /// to user queries in chat interactions. This configuration allows administrators to
    /// customize response characteristics to meet specific organizational needs and communication
    /// standards.
    /// </summary>
    public partial class ChatResponseConfiguration
    {
        /// <summary>
        /// Gets and sets the property ChatResponseConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the chat response configuration, which uniquely
        /// identifies the resource across all Amazon Web Services services and accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1284)]
        public string ChatResponseConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ChatResponseConfigurationArn property is set.
        /// </summary>
        internal bool IsSetChatResponseConfigurationArn() => this.ChatResponseConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ChatResponseConfigurationId. 
        /// <para>
        /// A unique identifier for your chat response configuration settings, used to reference
        /// and manage the configuration within the Amazon Q Business service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ChatResponseConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ChatResponseConfigurationId property is set.
        /// </summary>
        internal bool IsSetChatResponseConfigurationId() => this.ChatResponseConfigurationId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp indicating when the chat response configuration was initially created,
        /// useful for tracking the lifecycle of configuration resources.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A human-readable name for the chat response configuration, making it easier to identify
        /// and manage multiple configurations within an organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property ResponseConfigurationSummary. 
        /// <para>
        /// A summary of the response configuration settings, providing a concise overview of
        /// the key parameters that define how responses are generated and formatted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string ResponseConfigurationSummary { get; set; }

        /// <summary>
        /// Checks to see if the ResponseConfigurationSummary property is set.
        /// </summary>
        internal bool IsSetResponseConfigurationSummary() => this.ResponseConfigurationSummary != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the chat response configuration, indicating whether it is active,
        /// pending, or in another state that affects its availability for use in chat interactions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChatResponseConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp indicating when the chat response configuration was last modified, helping
        /// administrators track changes and maintain version awareness.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
