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
    /// An object that contains a response to the utterance from the bot.
    /// </summary>
    public partial class UtteranceBotResponse
    {
        private string _content;
        private UtteranceContentType _contentType;
        private ImageResponseCard _imageResponseCard;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The text of the response to the utterance from the bot.
        /// </para>
        /// </summary>
        public string Content
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
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The type of the response. The following values are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PlainText</c> – A plain text string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CustomPayload</c> – A response string that you can customize to include data or
        /// metadata for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SSML</c> – A string that includes Speech Synthesis Markup Language to customize
        /// the audio response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ImageResponseCard</c> – An image with buttons that the customer can select. See
        /// <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_runtime_ImageResponseCard.html">ImageResponseCard</a>
        /// for more information.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UtteranceContentType ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property ImageResponseCard.
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

    }
}