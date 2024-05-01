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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// The object that provides message text and its type.
    /// </summary>
    public partial class Message
    {
        private CustomPayload _customPayload;
        private ImageResponseCard _imageResponseCard;
        private PlainTextMessage _plainTextMessage;
        private SSMLMessage _ssmlMessage;

        /// <summary>
        /// Gets and sets the property CustomPayload. 
        /// <para>
        /// A message in a custom format defined by the client application.
        /// </para>
        /// </summary>
        public CustomPayload CustomPayload
        {
            get { return this._customPayload; }
            set { this._customPayload = value; }
        }

        // Check to see if CustomPayload property is set
        internal bool IsSetCustomPayload()
        {
            return this._customPayload != null;
        }

        /// <summary>
        /// Gets and sets the property ImageResponseCard. 
        /// <para>
        /// A message that defines a response card that the client application can show to the
        /// user.
        /// </para>
        /// </summary>
        public ImageResponseCard ImageResponseCard
        {
            get { return this._imageResponseCard; }
            set { this._imageResponseCard = value; }
        }

        // Check to see if ImageResponseCard property is set
        internal bool IsSetImageResponseCard()
        {
            return this._imageResponseCard != null;
        }

        /// <summary>
        /// Gets and sets the property PlainTextMessage. 
        /// <para>
        /// A message in plain text format.
        /// </para>
        /// </summary>
        public PlainTextMessage PlainTextMessage
        {
            get { return this._plainTextMessage; }
            set { this._plainTextMessage = value; }
        }

        // Check to see if PlainTextMessage property is set
        internal bool IsSetPlainTextMessage()
        {
            return this._plainTextMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SsmlMessage. 
        /// <para>
        /// A message in Speech Synthesis Markup Language (SSML).
        /// </para>
        /// </summary>
        public SSMLMessage SsmlMessage
        {
            get { return this._ssmlMessage; }
            set { this._ssmlMessage = value; }
        }

        // Check to see if SsmlMessage property is set
        internal bool IsSetSsmlMessage()
        {
            return this._ssmlMessage != null;
        }

    }
}