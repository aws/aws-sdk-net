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
    /// The message body of an RCS message. Exactly one content type must be specified.
    /// </summary>
    public partial class RcsContent
    {
        private RcsCarousel _carousel;
        private RcsFileMessage _fileMessage;
        private RcsStandaloneCard _richCard;
        private RcsTextMessage _textMessage;

        /// <summary>
        /// Gets and sets the property Carousel. 
        /// <para>
        /// A carousel of 2 to 10 scrollable cards, each with media, title, description, and suggested
        /// actions.
        /// </para>
        /// </summary>
        public RcsCarousel Carousel
        {
            get { return this._carousel; }
            set { this._carousel = value; }
        }

        // Check to see if Carousel property is set
        internal bool IsSetCarousel()
        {
            return this._carousel != null;
        }

        /// <summary>
        /// Gets and sets the property FileMessage. 
        /// <para>
        /// A file message containing a media file (image, video, audio, or PDF) with an optional
        /// thumbnail.
        /// </para>
        /// </summary>
        public RcsFileMessage FileMessage
        {
            get { return this._fileMessage; }
            set { this._fileMessage = value; }
        }

        // Check to see if FileMessage property is set
        internal bool IsSetFileMessage()
        {
            return this._fileMessage != null;
        }

        /// <summary>
        /// Gets and sets the property RichCard. 
        /// <para>
        /// A standalone rich card with media, title, description, and suggested actions.
        /// </para>
        /// </summary>
        public RcsStandaloneCard RichCard
        {
            get { return this._richCard; }
            set { this._richCard = value; }
        }

        // Check to see if RichCard property is set
        internal bool IsSetRichCard()
        {
            return this._richCard != null;
        }

        /// <summary>
        /// Gets and sets the property TextMessage. 
        /// <para>
        /// A plain text RCS message.
        /// </para>
        /// </summary>
        public RcsTextMessage TextMessage
        {
            get { return this._textMessage; }
            set { this._textMessage = value; }
        }

        // Check to see if TextMessage property is set
        internal bool IsSetTextMessage()
        {
            return this._textMessage != null;
        }

    }
}