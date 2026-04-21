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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AIBenchmarkEndpoint Marshaller
    /// </summary>
    public class AIBenchmarkEndpointMarshaller : IRequestMarshaller<AIBenchmarkEndpoint, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AIBenchmarkEndpoint requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIdentifier())
            {
                context.Writer.WritePropertyName("Identifier");
                context.Writer.WriteStringValue(requestObject.Identifier);
            }

            if(requestObject.IsSetInferenceComponents())
            {
                context.Writer.WritePropertyName("InferenceComponents");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInferenceComponentsListValue in requestObject.InferenceComponents)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AIBenchmarkInferenceComponentMarshaller.Instance;
                    marshaller.Marshall(requestObjectInferenceComponentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetContainerHostname())
            {
                context.Writer.WritePropertyName("TargetContainerHostname");
                context.Writer.WriteStringValue(requestObject.TargetContainerHostname);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AIBenchmarkEndpointMarshaller Instance = new AIBenchmarkEndpointMarshaller();

    }
}