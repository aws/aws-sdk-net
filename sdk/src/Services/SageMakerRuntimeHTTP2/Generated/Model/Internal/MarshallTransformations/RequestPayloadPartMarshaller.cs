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
 * Do not modify this file. This file is generated from the sagemaker-runtime-http2-2025-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerRuntimeHTTP2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMakerRuntimeHTTP2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RequestPayloadPart Marshaller
    /// </summary>
    public class RequestPayloadPartMarshaller : IRequestMarshaller<RequestPayloadPart, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RequestPayloadPart requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBytes())
            {
                context.Request.Content = requestObject.Bytes.ToArray();
            }
            if(requestObject.IsSetCompletionState())
            {
                var completionStateHeader = new Amazon.Runtime.EventStreams.EventStreamHeader("CompletionState");
                completionStateHeader.SetString(requestObject.CompletionState);
                context.Request.EventHeaders.Add(completionStateHeader);
            }
            if(requestObject.IsSetDataType())
            {
                var dataTypeHeader = new Amazon.Runtime.EventStreams.EventStreamHeader("DataType");
                dataTypeHeader.SetString(requestObject.DataType);
                context.Request.EventHeaders.Add(dataTypeHeader);
            }
            if(requestObject.IsSetP())
            {
                var pHeader = new Amazon.Runtime.EventStreams.EventStreamHeader("P");
                pHeader.SetString(requestObject.P);
                context.Request.EventHeaders.Add(pHeader);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RequestPayloadPartMarshaller Instance = new RequestPayloadPartMarshaller();

    }
}