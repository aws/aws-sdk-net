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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains the content for the message you pass to, or receive from a model. For more
    /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-create.html">Create
    /// a prompt using Prompt management</a>.
    /// </summary>
    public partial class ContentBlock
    {
        private CachePointBlock _cachePoint;
        private string _text;

        /// <summary>
        /// Gets and sets the property CachePoint. 
        /// <para>
        /// Creates a cache checkpoint within a message.
        /// </para>
        /// </summary>
        public CachePointBlock CachePoint
        {
            get { return this._cachePoint; }
            set { this._cachePoint = value; }
        }

        // Check to see if CachePoint property is set
        internal bool IsSetCachePoint()
        {
            return this._cachePoint != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text in the message.
        /// </para>
        /// </summary>
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

    }
}