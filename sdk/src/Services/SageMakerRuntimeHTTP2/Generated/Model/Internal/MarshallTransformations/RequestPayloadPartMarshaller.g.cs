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

using Amazon.SageMakerRuntimeHTTP2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.SageMakerRuntimeHTTP2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RequestPayloadPart Marshaller
    /// </summary>
    public partial class RequestPayloadPartMarshaller : IRequestMarshaller<RequestPayloadPart, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(RequestPayloadPart requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBytes())
            {
                context.Request.Content = requestObject.Bytes.ToArray();
            }

            if (requestObject.IsSetCompletionState())
            {
                var header = new Amazon.Runtime.EventStreams.EventStreamHeader("CompletionState");
                header.SetString(requestObject.CompletionState);
                context.Request.EventHeaders.Add(header);
            }

            if (requestObject.IsSetDataType())
            {
                var header = new Amazon.Runtime.EventStreams.EventStreamHeader("DataType");
                header.SetString(requestObject.DataType);
                context.Request.EventHeaders.Add(header);
            }

            if (requestObject.IsSetP())
            {
                var header = new Amazon.Runtime.EventStreams.EventStreamHeader("P");
                header.SetString(requestObject.P);
                context.Request.EventHeaders.Add(header);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static RequestPayloadPartMarshaller Instance = new RequestPayloadPartMarshaller();
    }
}
