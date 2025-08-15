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

using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.Internal;

namespace Amazon.Extensions.CborProtocol.Internal.EventStreams
{
    /// <summary>
    /// Base class for cbor event stream publishers.
    /// </summary>
    public abstract class CborEventStreamPublisher : EventStreamPublisher
    {
        /// <summary>
        /// Construct a CborMarshallerContext that subclasses can use to run the marshaller for the event type
        /// that should be sent.
        /// </summary>
        /// <param name="writer">The writer that the marshaller will use to write as it is marshalling the user's object into it's CBOR representation.</param>
        /// <returns></returns>
        protected static CborMarshallerContext CreateCborMarshallerContext(CborWriter writer)
        {
            // The original request and service are not needed for event serialization so placeholder values are used.
            IRequest request = new DefaultRequest(new EventStreamRequest(), "eventstream");
            return new CborMarshallerContext(request, writer);
        }
    }
}
