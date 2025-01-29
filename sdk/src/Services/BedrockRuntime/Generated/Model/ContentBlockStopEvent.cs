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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.BedrockRuntime.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// A content block stop event.
    /// </summary>
    public partial class ContentBlockStopEvent
        : IEventStreamEvent
    {
        private int? _contentBlockIndex;

        /// <summary>
        /// Gets and sets the property ContentBlockIndex. 
        /// <para>
        /// The index for a content block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? ContentBlockIndex
        {
            get { return this._contentBlockIndex; }
            set { this._contentBlockIndex = value; }
        }

        // Check to see if ContentBlockIndex property is set
        internal bool IsSetContentBlockIndex()
        {
            return this._contentBlockIndex.HasValue; 
        }

    }
}