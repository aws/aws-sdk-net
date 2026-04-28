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
    /// Indicates that the synthesis stream is closed and provides summary information.
    /// </summary>
    public partial class StreamClosedEvent
        : IEventStreamEvent
    {
        private int? _requestCharacters;

        /// <summary>
        /// Gets and sets the property RequestCharacters. 
        /// <para>
        /// The total number of characters synthesized during the streaming session.
        /// </para>
        /// </summary>
        public int? RequestCharacters
        {
            get { return this._requestCharacters; }
            set { this._requestCharacters = value; }
        }

        // Check to see if RequestCharacters property is set
        internal bool IsSetRequestCharacters()
        {
            return this._requestCharacters.HasValue; 
        }

    }
}