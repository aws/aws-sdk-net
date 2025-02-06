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
    /// InferenceSpecification Marshaller
    /// </summary>
    public class InferenceSpecificationMarshaller : IRequestMarshaller<InferenceSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InferenceSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContainers())
            {
                context.Writer.WritePropertyName("Containers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectContainersListValue in requestObject.Containers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ModelPackageContainerDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectContainersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSupportedContentTypes())
            {
                context.Writer.WritePropertyName("SupportedContentTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSupportedContentTypesListValue in requestObject.SupportedContentTypes)
                {
                        context.Writer.WriteStringValue(requestObjectSupportedContentTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSupportedRealtimeInferenceInstanceTypes())
            {
                context.Writer.WritePropertyName("SupportedRealtimeInferenceInstanceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSupportedRealtimeInferenceInstanceTypesListValue in requestObject.SupportedRealtimeInferenceInstanceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectSupportedRealtimeInferenceInstanceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSupportedResponseMIMETypes())
            {
                context.Writer.WritePropertyName("SupportedResponseMIMETypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSupportedResponseMIMETypesListValue in requestObject.SupportedResponseMIMETypes)
                {
                        context.Writer.WriteStringValue(requestObjectSupportedResponseMIMETypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSupportedTransformInstanceTypes())
            {
                context.Writer.WritePropertyName("SupportedTransformInstanceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSupportedTransformInstanceTypesListValue in requestObject.SupportedTransformInstanceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectSupportedTransformInstanceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InferenceSpecificationMarshaller Instance = new InferenceSpecificationMarshaller();

    }
}