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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.QBusiness.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// An output event that Amazon Q Business returns to an user who wants to perform a plugin
    /// action during a streaming chat conversation. It contains information about the selected
    /// action with a list of possible user input fields, some pre-populated by Amazon Q Business.
    /// </summary>
    public partial class ActionReviewEvent
        : IEventStreamEvent
    {
        private string _conversationId;
        private Dictionary<string, ActionReviewPayloadField> _payload = AWSConfigs.InitializeCollections ? new Dictionary<string, ActionReviewPayloadField>() : null;
        private string _payloadFieldNameSeparator;
        private string _pluginId;
        private PluginType _pluginType;
        private string _systemMessageId;
        private string _userMessageId;

        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The identifier of the conversation with which the action review event is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ConversationId
        {
            get { return this._conversationId; }
            set { this._conversationId = value; }
        }

        // Check to see if ConversationId property is set
        internal bool IsSetConversationId()
        {
            return this._conversationId != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// Field values that an end user needs to provide to Amazon Q Business for Amazon Q Business
        /// to perform the requested plugin action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ActionReviewPayloadField> Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null && (this._payload.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PayloadFieldNameSeparator. 
        /// <para>
        /// A string used to retain information about the hierarchical contexts within an action
        /// review event payload.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string PayloadFieldNameSeparator
        {
            get { return this._payloadFieldNameSeparator; }
            set { this._payloadFieldNameSeparator = value; }
        }

        // Check to see if PayloadFieldNameSeparator property is set
        internal bool IsSetPayloadFieldNameSeparator()
        {
            return this._payloadFieldNameSeparator != null;
        }

        /// <summary>
        /// Gets and sets the property PluginId. 
        /// <para>
        /// The identifier of the plugin associated with the action review event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string PluginId
        {
            get { return this._pluginId; }
            set { this._pluginId = value; }
        }

        // Check to see if PluginId property is set
        internal bool IsSetPluginId()
        {
            return this._pluginId != null;
        }

        /// <summary>
        /// Gets and sets the property PluginType. 
        /// <para>
        /// The type of plugin.
        /// </para>
        /// </summary>
        public PluginType PluginType
        {
            get { return this._pluginType; }
            set { this._pluginType = value; }
        }

        // Check to see if PluginType property is set
        internal bool IsSetPluginType()
        {
            return this._pluginType != null;
        }

        /// <summary>
        /// Gets and sets the property SystemMessageId. 
        /// <para>
        /// The identifier of an Amazon Q Business AI generated associated with the action review
        /// event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SystemMessageId
        {
            get { return this._systemMessageId; }
            set { this._systemMessageId = value; }
        }

        // Check to see if SystemMessageId property is set
        internal bool IsSetSystemMessageId()
        {
            return this._systemMessageId != null;
        }

        /// <summary>
        /// Gets and sets the property UserMessageId. 
        /// <para>
        /// The identifier of the conversation with which the plugin action is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string UserMessageId
        {
            get { return this._userMessageId; }
            set { this._userMessageId = value; }
        }

        // Check to see if UserMessageId property is set
        internal bool IsSetUserMessageId()
        {
            return this._userMessageId != null;
        }

    }
}