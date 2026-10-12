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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// The message body of an RCS message. Exactly one content type must be specified.
    /// </summary>
    public partial class RcsContent
    {
        /// <summary>
        /// Gets and sets the property Carousel. 
        /// <para>
        /// A carousel of 2 to 10 scrollable cards, each with media, title, description, and suggested
        /// actions.
        /// </para>
        /// </summary>
        public RcsCarousel Carousel { get; set; }

        /// <summary>
        /// Checks to see if the Carousel property is set.
        /// </summary>
        internal bool IsSetCarousel() => this.Carousel != null;

        /// <summary>
        /// Gets and sets the property FileMessage. 
        /// <para>
        /// A file message containing a media file (image, video, audio, or PDF) with an optional
        /// thumbnail.
        /// </para>
        /// </summary>
        public RcsFileMessage FileMessage { get; set; }

        /// <summary>
        /// Checks to see if the FileMessage property is set.
        /// </summary>
        internal bool IsSetFileMessage() => this.FileMessage != null;

        /// <summary>
        /// Gets and sets the property RichCard. 
        /// <para>
        /// A standalone rich card with media, title, description, and suggested actions.
        /// </para>
        /// </summary>
        public RcsStandaloneCard RichCard { get; set; }

        /// <summary>
        /// Checks to see if the RichCard property is set.
        /// </summary>
        internal bool IsSetRichCard() => this.RichCard != null;

        /// <summary>
        /// Gets and sets the property TextMessage. 
        /// <para>
        /// A plain text RCS message.
        /// </para>
        /// </summary>
        public RcsTextMessage TextMessage { get; set; }

        /// <summary>
        /// Checks to see if the TextMessage property is set.
        /// </summary>
        internal bool IsSetTextMessage() => this.TextMessage != null;
    }
}
