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
    /// A chat message.
    /// </summary>
    public partial class ChatMessage
    {
        private string _content;
        private string _contentType;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the chat message. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>text/plain</c> and <c>text/markdown</c>, the Length Constraints are Minimum
        /// of 1, Maximum of 1024. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>application/json</c>, the Length Constraints are Minimum of 1, Maximum of 12000.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>application/vnd.amazonaws.connect.message.interactive.response</c>, the Length
        /// Constraints are Minimum of 1, Maximum of 12288.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16384)]
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
        /// The type of the content. Supported types are <c>text/plain</c>, <c>text/markdown</c>,
        /// <c>application/json</c>, and <c>application/vnd.amazonaws.connect.message.interactive.response</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

    }
}