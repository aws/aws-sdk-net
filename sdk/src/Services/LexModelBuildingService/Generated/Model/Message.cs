/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// The message object that provides the message text and its type.
    /// </summary>
    public partial class Message
    {
        private string _content;
        private ContentType _contentType;
        private int? _groupNumber;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The text of the message.
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
        /// The content type of the message string.
        /// </para>
        /// </summary>
        public ContentType ContentType
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
        /// Gets and sets the property GroupNumber. 
        /// <para>
        /// Identifies the message group that the message belongs to. When a group is assigned
        /// to a message, Amazon Lex returns one message from each group in the response.
        /// </para>
        /// </summary>
        public int GroupNumber
        {
            get { return this._groupNumber.GetValueOrDefault(); }
            set { this._groupNumber = value; }
        }

        // Check to see if GroupNumber property is set
        internal bool IsSetGroupNumber()
        {
            return this._groupNumber.HasValue; 
        }

    }
}