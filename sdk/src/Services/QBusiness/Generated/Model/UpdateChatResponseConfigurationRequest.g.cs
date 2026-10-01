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
    /// Container for the parameters to the UpdateChatResponseConfiguration operation. Updates
    /// an existing chat response configuration in an Amazon Q Business application. This
    /// operation allows administrators to modify configuration settings, display name, and
    /// response parameters to refine how the system generates responses.
    /// </summary>
    public partial class UpdateChatResponseConfigurationRequest : AmazonQBusinessRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the Amazon Q Business application containing the chat response
        /// configuration to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property ChatResponseConfigurationId. 
        /// <para>
        /// The unique identifier of the chat response configuration to update within the specified
        /// application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ChatResponseConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ChatResponseConfigurationId property is set.
        /// </summary>
        internal bool IsSetChatResponseConfigurationId() => this.ChatResponseConfigurationId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request. This helps
        /// prevent the same update from being processed multiple times if retries occur.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The new human-readable name to assign to the chat response configuration, making it
        /// easier to identify among multiple configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property ResponseConfigurations. 
        /// <para>
        /// The updated collection of response configuration settings that define how Amazon Q
        /// Business generates and formats responses to user queries.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public Dictionary<string, ResponseConfiguration> ResponseConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ResponseConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ResponseConfigurations property is set.
        /// </summary>
        internal bool IsSetResponseConfigurations() => this.ResponseConfigurations != null && (this.ResponseConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
