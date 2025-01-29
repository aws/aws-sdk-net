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
    /// ModelQualityAppSpecification Marshaller
    /// </summary>
    public class ModelQualityAppSpecificationMarshaller : IRequestMarshaller<ModelQualityAppSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ModelQualityAppSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContainerArguments())
            {
                context.Writer.WritePropertyName("ContainerArguments");
                context.Writer.WriteStartArray();
                foreach(var requestObjectContainerArgumentsListValue in requestObject.ContainerArguments)
                {
                        context.Writer.WriteStringValue(requestObjectContainerArgumentsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetContainerEntrypoint())
            {
                context.Writer.WritePropertyName("ContainerEntrypoint");
                context.Writer.WriteStartArray();
                foreach(var requestObjectContainerEntrypointListValue in requestObject.ContainerEntrypoint)
                {
                        context.Writer.WriteStringValue(requestObjectContainerEntrypointListValue);
                }
                context.Writer.WriteEndArray();
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

            if(requestObject.IsSetImageUri())
            {
                context.Writer.WritePropertyName("ImageUri");
                context.Writer.WriteStringValue(requestObject.ImageUri);
            }

            if(requestObject.IsSetPostAnalyticsProcessorSourceUri())
            {
                context.Writer.WritePropertyName("PostAnalyticsProcessorSourceUri");
                context.Writer.WriteStringValue(requestObject.PostAnalyticsProcessorSourceUri);
            }

            if(requestObject.IsSetProblemType())
            {
                context.Writer.WritePropertyName("ProblemType");
                context.Writer.WriteStringValue(requestObject.ProblemType);
            }

            if(requestObject.IsSetRecordPreprocessorSourceUri())
            {
                context.Writer.WritePropertyName("RecordPreprocessorSourceUri");
                context.Writer.WriteStringValue(requestObject.RecordPreprocessorSourceUri);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ModelQualityAppSpecificationMarshaller Instance = new ModelQualityAppSpecificationMarshaller();

    }
}