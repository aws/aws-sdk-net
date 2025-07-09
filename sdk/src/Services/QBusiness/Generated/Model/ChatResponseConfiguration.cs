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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
        private string _chatResponseConfigurationArn;
        private string _chatResponseConfigurationId;
        private DateTime? _createdAt;
        private string _displayName;
        private string _responseConfigurationSummary;
        private ChatResponseConfigurationStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ChatResponseConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the chat response configuration, which uniquely
        /// identifies the resource across all Amazon Web Services services and accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1284)]
        public string ChatResponseConfigurationArn
        {
            get { return this._chatResponseConfigurationArn; }
            set { this._chatResponseConfigurationArn = value; }
        }

        // Check to see if ChatResponseConfigurationArn property is set
        internal bool IsSetChatResponseConfigurationArn()
        {
            return this._chatResponseConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ChatResponseConfigurationId. 
        /// <para>
        /// A unique identifier for your chat response configuration settings, used to reference
        /// and manage the configuration within the Amazon Q Business service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ChatResponseConfigurationId
        {
            get { return this._chatResponseConfigurationId; }
            set { this._chatResponseConfigurationId = value; }
        }

        // Check to see if ChatResponseConfigurationId property is set
        internal bool IsSetChatResponseConfigurationId()
        {
            return this._chatResponseConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp indicating when the chat response configuration was initially created,
        /// useful for tracking the lifecycle of configuration resources.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A human-readable name for the chat response configuration, making it easier to identify
        /// and manage multiple configurations within an organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseConfigurationSummary. 
        /// <para>
        /// A summary of the response configuration settings, providing a concise overview of
        /// the key parameters that define how responses are generated and formatted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string ResponseConfigurationSummary
        {
            get { return this._responseConfigurationSummary; }
            set { this._responseConfigurationSummary = value; }
        }

        // Check to see if ResponseConfigurationSummary property is set
        internal bool IsSetResponseConfigurationSummary()
        {
            return this._responseConfigurationSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the chat response configuration, indicating whether it is active,
        /// pending, or in another state that affects its availability for use in chat interactions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChatResponseConfigurationStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp indicating when the chat response configuration was last modified, helping
        /// administrators track changes and maintain version awareness.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}