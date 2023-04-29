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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// An object that includes a chunk of the response payload. When the stream has ended,
    /// Lambda includes a <code>InvokeComplete</code> object.
    /// </summary>
    public partial class InvokeWithResponseStreamResponseEvent
    {
        private InvokeWithResponseStreamCompleteEvent _invokeComplete;
        private InvokeResponseStreamUpdate _payloadChunk;

        /// <summary>
        /// Gets and sets the property InvokeComplete. 
        /// <para>
        /// An object that's returned when the stream has ended and all the payload chunks have
        /// been returned.
        /// </para>
        /// </summary>
        public InvokeWithResponseStreamCompleteEvent InvokeComplete
        {
            get { return this._invokeComplete; }
            set { this._invokeComplete = value; }
        }

        // Check to see if InvokeComplete property is set
        internal bool IsSetInvokeComplete()
        {
            return this._invokeComplete != null;
        }

        /// <summary>
        /// Gets and sets the property PayloadChunk. 
        /// <para>
        /// A chunk of the streamed response payload.
        /// </para>
        /// </summary>
        public InvokeResponseStreamUpdate PayloadChunk
        {
            get { return this._payloadChunk; }
            set { this._payloadChunk = value; }
        }

        // Check to see if PayloadChunk property is set
        internal bool IsSetPayloadChunk()
        {
            return this._payloadChunk != null;
        }

    }
}