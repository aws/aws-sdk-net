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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Payload of chat properties to apply when starting a new contact.
    /// </summary>
    public partial class NewSessionDetails
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        ///  A custom key-value pair using an attribute map. The attributes are standard Connect
        /// Customer attributes. They can be accessed in flows just like any other contact attributes.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  There can be up to 32,768 UTF-8 bytes across all key-value pairs per contact. Attribute
        /// keys can include only alphanumeric, dash, and underscore characters. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParticipantDetails.
        /// </summary>
        public ParticipantDetails ParticipantDetails { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantDetails property is set.
        /// </summary>
        internal bool IsSetParticipantDetails() => this.ParticipantDetails != null;

        /// <summary>
        /// Gets and sets the property StreamingConfiguration.
        /// </summary>
        public ChatStreamingConfiguration StreamingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StreamingConfiguration property is set.
        /// </summary>
        internal bool IsSetStreamingConfiguration() => this.StreamingConfiguration != null;

        /// <summary>
        /// Gets and sets the property SupportedMessagingContentTypes. 
        /// <para>
        ///  The supported chat message content types. Supported types are <c>text/plain</c>,
        /// <c>text/markdown</c>, <c>application/json</c>, <c>application/vnd.amazonaws.connect.message.interactive</c>,
        /// and <c>application/vnd.amazonaws.connect.message.interactive.response</c>. 
        /// </para>
        ///  
        /// <para>
        /// Content types must always contain <c> text/plain</c>. You can then put any other supported
        /// type in the list. For example, all the following lists are valid because they contain
        /// <c>text/plain</c>: <c>[text/plain, text/markdown, application/json]</c>, <c> [text/markdown,
        /// text/plain]</c>, <c>[text/plain, application/json, application/vnd.amazonaws.connect.message.interactive.response]</c>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedMessagingContentTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedMessagingContentTypes property is set.
        /// </summary>
        internal bool IsSetSupportedMessagingContentTypes() => this.SupportedMessagingContentTypes != null && (this.SupportedMessagingContentTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
