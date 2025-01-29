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
    /// InferenceComponentSpecification Marshaller
    /// </summary>
    public class InferenceComponentSpecificationMarshaller : IRequestMarshaller<InferenceComponentSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InferenceComponentSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBaseInferenceComponentName())
            {
                context.Writer.WritePropertyName("BaseInferenceComponentName");
                context.Writer.WriteStringValue(requestObject.BaseInferenceComponentName);
            }

            if(requestObject.IsSetComputeResourceRequirements())
            {
                context.Writer.WritePropertyName("ComputeResourceRequirements");
                context.Writer.WriteStartObject();

                var marshaller = InferenceComponentComputeResourceRequirementsMarshaller.Instance;
                marshaller.Marshall(requestObject.ComputeResourceRequirements, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContainer())
            {
                context.Writer.WritePropertyName("Container");
                context.Writer.WriteStartObject();

                var marshaller = InferenceComponentContainerSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.Container, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetModelName())
            {
                context.Writer.WritePropertyName("ModelName");
                context.Writer.WriteStringValue(requestObject.ModelName);
            }

            if(requestObject.IsSetStartupParameters())
            {
                context.Writer.WritePropertyName("StartupParameters");
                context.Writer.WriteStartObject();

                var marshaller = InferenceComponentStartupParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.StartupParameters, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InferenceComponentSpecificationMarshaller Instance = new InferenceComponentSpecificationMarshaller();

    }
}