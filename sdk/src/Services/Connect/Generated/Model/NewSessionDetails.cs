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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ParticipantDetails _participantDetails;
        private ChatStreamingConfiguration _streamingConfiguration;
        private List<string> _supportedMessagingContentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        ///  A custom key-value pair using an attribute map. The attributes are standard Amazon
        /// Connect attributes. They can be accessed in flows just like any other contact attributes.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  There can be up to 32,768 UTF-8 bytes across all key-value pairs per contact. Attribute
        /// keys can include only alphanumeric, dash, and underscore characters. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParticipantDetails.
        /// </summary>
        public ParticipantDetails ParticipantDetails
        {
            get { return this._participantDetails; }
            set { this._participantDetails = value; }
        }

        // Check to see if ParticipantDetails property is set
        internal bool IsSetParticipantDetails()
        {
            return this._participantDetails != null;
        }

        /// <summary>
        /// Gets and sets the property StreamingConfiguration.
        /// </summary>
        public ChatStreamingConfiguration StreamingConfiguration
        {
            get { return this._streamingConfiguration; }
            set { this._streamingConfiguration = value; }
        }

        // Check to see if StreamingConfiguration property is set
        internal bool IsSetStreamingConfiguration()
        {
            return this._streamingConfiguration != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedMessagingContentTypes
        {
            get { return this._supportedMessagingContentTypes; }
            set { this._supportedMessagingContentTypes = value; }
        }

        // Check to see if SupportedMessagingContentTypes property is set
        internal bool IsSetSupportedMessagingContentTypes()
        {
            return this._supportedMessagingContentTypes != null && (this._supportedMessagingContentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}