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
    /// A configuration event activated by an end user request to select a specific chat mode.
    /// </summary>
    public partial class ConfigurationEvent
        : IEventStreamEvent
    {
        private AttributeFilter _attributeFilter;
        private ChatMode _chatMode;
        private ChatModeConfiguration _chatModeConfiguration;

        /// <summary>
        /// Gets and sets the property AttributeFilter.
        /// </summary>
        public AttributeFilter AttributeFilter
        {
            get { return this._attributeFilter; }
            set { this._attributeFilter = value; }
        }

        // Check to see if AttributeFilter property is set
        internal bool IsSetAttributeFilter()
        {
            return this._attributeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ChatMode. 
        /// <para>
        /// The chat modes available to an Amazon Q Business end user.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RETRIEVAL_MODE</c> - The default chat mode for an Amazon Q Business application.
        /// When this mode is enabled, Amazon Q Business generates responses only from data sources
        /// connected to an Amazon Q Business application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATOR_MODE</c> - By selecting this mode, users can choose to generate responses
        /// only from the LLM knowledge, without consulting connected data sources, for a chat
        /// request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PLUGIN_MODE</c> - By selecting this mode, users can choose to use plugins in chat.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/guardrails.html">Admin
        /// controls and guardrails</a>, <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/plugins.html">Plugins</a>,
        /// and <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/using-web-experience.html#chat-source-scope">Conversation
        /// settings</a>.
        /// </para>
        /// </summary>
        public ChatMode ChatMode
        {
            get { return this._chatMode; }
            set { this._chatMode = value; }
        }

        // Check to see if ChatMode property is set
        internal bool IsSetChatMode()
        {
            return this._chatMode != null;
        }

        /// <summary>
        /// Gets and sets the property ChatModeConfiguration.
        /// </summary>
        public ChatModeConfiguration ChatModeConfiguration
        {
            get { return this._chatModeConfiguration; }
            set { this._chatModeConfiguration = value; }
        }

        // Check to see if ChatModeConfiguration property is set
        internal bool IsSetChatModeConfiguration()
        {
            return this._chatModeConfiguration != null;
        }

    }
}