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
    /// ContainerDefinition Marshaller
    /// </summary>
    public class ContainerDefinitionMarshaller : IRequestMarshaller<ContainerDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContainerDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalModelDataSources())
            {
                context.Writer.WritePropertyName("AdditionalModelDataSources");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalModelDataSourcesListValue in requestObject.AdditionalModelDataSources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AdditionalModelDataSourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdditionalModelDataSourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetContainerHostname())
            {
                context.Writer.WritePropertyName("ContainerHostname");
                context.Writer.WriteStringValue(requestObject.ContainerHostname);
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

            if(requestObject.IsSetImage())
            {
                context.Writer.WritePropertyName("Image");
                context.Writer.WriteStringValue(requestObject.Image);
            }

            if(requestObject.IsSetImageConfig())
            {
                context.Writer.WritePropertyName("ImageConfig");
                context.Writer.WriteStartObject();

                var marshaller = ImageConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ImageConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInferenceSpecificationName())
            {
                context.Writer.WritePropertyName("InferenceSpecificationName");
                context.Writer.WriteStringValue(requestObject.InferenceSpecificationName);
            }

            if(requestObject.IsSetMode())
            {
                context.Writer.WritePropertyName("Mode");
                context.Writer.WriteStringValue(requestObject.Mode);
            }

            if(requestObject.IsSetModelDataSource())
            {
                context.Writer.WritePropertyName("ModelDataSource");
                context.Writer.WriteStartObject();

                var marshaller = ModelDataSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.ModelDataSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetModelDataUrl())
            {
                context.Writer.WritePropertyName("ModelDataUrl");
                context.Writer.WriteStringValue(requestObject.ModelDataUrl);
            }

            if(requestObject.IsSetModelPackageName())
            {
                context.Writer.WritePropertyName("ModelPackageName");
                context.Writer.WriteStringValue(requestObject.ModelPackageName);
            }

            if(requestObject.IsSetMultiModelConfig())
            {
                context.Writer.WritePropertyName("MultiModelConfig");
                context.Writer.WriteStartObject();

                var marshaller = MultiModelConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.MultiModelConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContainerDefinitionMarshaller Instance = new ContainerDefinitionMarshaller();

    }
}