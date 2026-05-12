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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
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
using Amazon.Polly.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Polly.Model
{
    /// <summary>
    /// Contains text content to be synthesized into speech.
    /// </summary>
    public partial class TextEvent
        : IEventStreamEvent
    {
        private FlushStreamConfiguration _flushStreamConfiguration;
        private string _text;
        private TextType _textType;

        /// <summary>
        /// Gets and sets the property FlushStreamConfiguration. 
        /// <para>
        /// Configuration for controlling when synthesized audio flushes to the output stream.
        /// </para>
        /// </summary>
        public FlushStreamConfiguration FlushStreamConfiguration
        {
            get { return this._flushStreamConfiguration; }
            set { this._flushStreamConfiguration = value; }
        }

        // Check to see if FlushStreamConfiguration property is set
        internal bool IsSetFlushStreamConfiguration()
        {
            return this._flushStreamConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text content to synthesize. If you specify <c>ssml</c> as the <c>TextType</c>,
        /// follow the SSML format for the input text.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property TextType. 
        /// <para>
        /// Specifies whether the input text is plain text or SSML. Default: plain text.
        /// </para>
        /// </summary>
        public TextType TextType
        {
            get { return this._textType; }
            set { this._textType = value; }
        }

        // Check to see if TextType property is set
        internal bool IsSetTextType()
        {
            return this._textType != null;
        }

    }
}