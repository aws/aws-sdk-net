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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// A message input, or returned from, a call to <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_Converse.html">Converse</a>
    /// or <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_ConverseStream.html">ConverseStream</a>.
    /// </summary>
    public partial class Message
    {
        private List<ContentBlock> _content = AWSConfigs.InitializeCollections ? new List<ContentBlock>() : null;
        private ConversationRole _role;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The message content. Note the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can include up to 20 images. Each image's size, height, and width must be no more
        /// than 3.75 MB, 8000 px, and 8000 px, respectively.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can include up to five documents. Each document's size must be no more than 4.5
        /// MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you include a <c>ContentBlock</c> with a <c>document</c> field in the array, you
        /// must also include a <c>ContentBlock</c> with a <c>text</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only include images and documents if the <c>role</c> is <c>user</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ContentBlock> Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null && (this._content.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The role that the message plays in the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConversationRole Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

    }
}