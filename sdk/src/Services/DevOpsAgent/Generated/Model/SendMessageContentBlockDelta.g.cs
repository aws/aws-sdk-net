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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Union of possible delta payloads within a content block delta event
    /// </summary>
    public partial class SendMessageContentBlockDelta
    {
        /// <summary>
        /// Gets and sets the property JsonDelta. 
        /// <para>
        /// JSON delta for structured content blocks
        /// </para>
        /// </summary>
        public SendMessageJsonDelta JsonDelta { get; set; }

        /// <summary>
        /// Checks to see if the JsonDelta property is set.
        /// </summary>
        internal bool IsSetJsonDelta() => this.JsonDelta != null;

        /// <summary>
        /// Gets and sets the property TextDelta. 
        /// <para>
        /// Text delta for text-based content blocks
        /// </para>
        /// </summary>
        public SendMessageTextDelta TextDelta { get; set; }

        /// <summary>
        /// Checks to see if the TextDelta property is set.
        /// </summary>
        internal bool IsSetTextDelta() => this.TextDelta != null;
    }
}
