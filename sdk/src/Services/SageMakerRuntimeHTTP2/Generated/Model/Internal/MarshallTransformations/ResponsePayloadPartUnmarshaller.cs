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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerRuntimeHTTP2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMakerRuntimeHTTP2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResponsePayloadPart Object
    /// </summary>  
    public class ResponsePayloadPartUnmarshaller : IJsonUnmarshaller<ResponsePayloadPart, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ResponsePayloadPart Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ResponsePayloadPart unmarshalledObject = new ResponsePayloadPart();
            if (context.IsEmptyResponse)
                return null;
            unmarshalledObject.Bytes = context.Stream as MemoryStream;
            if (context.ResponseData.IsEventHeaderPresent("CompletionState"))
            {
                unmarshalledObject.CompletionState = context.ResponseData.GetEventStreamHeader("CompletionState").AsString();
            }
            if (context.ResponseData.IsEventHeaderPresent("DataType"))
            {
                unmarshalledObject.DataType = context.ResponseData.GetEventStreamHeader("DataType").AsString();
            }
            if (context.ResponseData.IsEventHeaderPresent("P"))
            {
                unmarshalledObject.P = context.ResponseData.GetEventStreamHeader("P").AsString();
            }
            return unmarshalledObject;
        }


        private static ResponsePayloadPartUnmarshaller _instance = new ResponsePayloadPartUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResponsePayloadPartUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}