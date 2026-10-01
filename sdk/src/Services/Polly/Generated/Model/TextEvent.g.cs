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

namespace Amazon.Polly.Model
{
    /// <summary>
    /// Contains text content to be synthesized into speech.
    /// </summary>
    public partial class TextEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property FlushStreamConfiguration. 
        /// <para>
        /// Configuration for controlling when synthesized audio flushes to the output stream.
        /// </para>
        /// </summary>
        public FlushStreamConfiguration FlushStreamConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FlushStreamConfiguration property is set.
        /// </summary>
        internal bool IsSetFlushStreamConfiguration() => this.FlushStreamConfiguration != null;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text content to synthesize. If you specify <c>ssml</c> as the <c>TextType</c>,
        /// follow the SSML format for the input text.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

        /// <summary>
        /// Gets and sets the property TextType. 
        /// <para>
        /// Specifies whether the input text is plain text or SSML. Default: plain text.
        /// </para>
        /// </summary>
        public TextType TextType { get; set; }

        /// <summary>
        /// Checks to see if the TextType property is set.
        /// </summary>
        internal bool IsSetTextType() => this.TextType != null;
    }
}
