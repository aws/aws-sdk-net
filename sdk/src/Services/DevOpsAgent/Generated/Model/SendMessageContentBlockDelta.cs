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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Union of possible delta payloads within a content block delta event
    /// </summary>
    public partial class SendMessageContentBlockDelta
    {
        private SendMessageJsonDelta _jsonDelta;
        private SendMessageTextDelta _textDelta;

        /// <summary>
        /// Gets and sets the property JsonDelta. 
        /// <para>
        /// JSON delta for structured content blocks
        /// </para>
        /// </summary>
        public SendMessageJsonDelta JsonDelta
        {
            get { return this._jsonDelta; }
            set { this._jsonDelta = value; }
        }

        // Check to see if JsonDelta property is set
        internal bool IsSetJsonDelta()
        {
            return this._jsonDelta != null;
        }

        /// <summary>
        /// Gets and sets the property TextDelta. 
        /// <para>
        /// Text delta for text-based content blocks
        /// </para>
        /// </summary>
        public SendMessageTextDelta TextDelta
        {
            get { return this._textDelta; }
            set { this._textDelta = value; }
        }

        // Check to see if TextDelta property is set
        internal bool IsSetTextDelta()
        {
            return this._textDelta != null;
        }

    }
}