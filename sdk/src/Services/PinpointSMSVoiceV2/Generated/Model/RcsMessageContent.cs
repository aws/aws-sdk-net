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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// The content of an RCS message, containing the message body (text, file, rich card,
    /// or carousel) and optional message-level suggested actions.
    /// </summary>
    public partial class RcsMessageContent
    {
        private RcsContent _content;
        private List<RcsSuggestedAction> _suggestions = AWSConfigs.InitializeCollections ? new List<RcsSuggestedAction>() : null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the RCS message. Exactly one content type must be specified: TextMessage,
        /// FileMessage, RichCard, or Carousel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RcsContent Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Suggestions. 
        /// <para>
        /// Message-level suggested actions displayed to the recipient. Maximum 11 suggestions
        /// per message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=11)]
        public List<RcsSuggestedAction> Suggestions
        {
            get { return this._suggestions; }
            set { this._suggestions = value; }
        }

        // Check to see if Suggestions property is set
        internal bool IsSetSuggestions()
        {
            return this._suggestions != null && (this._suggestions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}