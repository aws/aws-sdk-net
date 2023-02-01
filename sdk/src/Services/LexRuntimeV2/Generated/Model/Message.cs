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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// Container for text that is returned to the customer..
    /// </summary>
    public partial class Message
    {
        private string _content;
        private MessageContentType _contentType;
        private ImageResponseCard _imageResponseCard;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The text of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
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
        /// Indicates the type of response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MessageContentType ContentType
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