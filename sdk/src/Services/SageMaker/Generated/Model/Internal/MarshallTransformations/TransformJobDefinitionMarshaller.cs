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
    /// TransformJobDefinition Marshaller
    /// </summary>
    public class TransformJobDefinitionMarshaller : IRequestMarshaller<TransformJobDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TransformJobDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBatchStrategy())
            {
                context.Writer.WritePropertyName("BatchStrategy");
                context.Writer.WriteStringValue(requestObject.BatchStrategy);
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEnvironmentKvp in requestObject.Environment)
                {
                    context.Writer.WritePropertyName(requestObjectEnvironmentKvp.Key);
                    var requestObjectEnvironmentValue = requestObjectEnvironmentKvp.Value;

                        context.Writer.WriteStringValue(requestObjectEnvironmentValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaxConcurrentTransforms())
            {
                context.Writer.WritePropertyName("MaxConcurrentTransforms");
                context.Writer.WriteNumberValue(requestObject.MaxConcurrentTransforms.Value);
            }

            if(requestObject.IsSetMaxPayloadInMB())
            {
                context.Writer.WritePropertyName("MaxPayloadInMB");
                context.Writer.WriteNumberValue(requestObject.MaxPayloadInMB.Value);
            }

            if(requestObject.IsSetTransformInput())
            {
                context.Writer.WritePropertyName("TransformInput");
                context.Writer.WriteStartObject();

                var marshaller = TransformInputMarshaller.Instance;
                marshaller.Marshall(requestObject.TransformInput, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTransformOutput())
            {
                context.Writer.WritePropertyName("TransformOutput");
                context.Writer.WriteStartObject();

                var marshaller = TransformOutputMarshaller.Instance;
                marshaller.Marshall(requestObject.TransformOutput, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTransformResources())
            {
                context.Writer.WritePropertyName("TransformResources");
                context.Writer.WriteStartObject();

                var marshaller = TransformResourcesMarshaller.Instance;
                marshaller.Marshall(requestObject.TransformResources, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TransformJobDefinitionMarshaller Instance = new TransformJobDefinitionMarshaller();

    }
}