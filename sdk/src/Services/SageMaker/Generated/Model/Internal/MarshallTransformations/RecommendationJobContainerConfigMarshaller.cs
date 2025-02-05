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
    /// RecommendationJobContainerConfig Marshaller
    /// </summary>
    public class RecommendationJobContainerConfigMarshaller : IRequestMarshaller<RecommendationJobContainerConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RecommendationJobContainerConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataInputConfig())
            {
                context.Writer.WritePropertyName("DataInputConfig");
                context.Writer.WriteStringValue(requestObject.DataInputConfig);
            }

            if(requestObject.IsSetDomain())
            {
                context.Writer.WritePropertyName("Domain");
                context.Writer.WriteStringValue(requestObject.Domain);
            }

            if(requestObject.IsSetFramework())
            {
                context.Writer.WritePropertyName("Framework");
                context.Writer.WriteStringValue(requestObject.Framework);
            }

            if(requestObject.IsSetFrameworkVersion())
            {
                context.Writer.WritePropertyName("FrameworkVersion");
                context.Writer.WriteStringValue(requestObject.FrameworkVersion);
            }

            if(requestObject.IsSetNearestModelName())
            {
                context.Writer.WritePropertyName("NearestModelName");
                context.Writer.WriteStringValue(requestObject.NearestModelName);
            }

            if(requestObject.IsSetPayloadConfig())
            {
                context.Writer.WritePropertyName("PayloadConfig");
                context.Writer.WriteStartObject();

                var marshaller = RecommendationJobPayloadConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.PayloadConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSupportedEndpointType())
            {
                context.Writer.WritePropertyName("SupportedEndpointType");
                context.Writer.WriteStringValue(requestObject.SupportedEndpointType);
            }

            if(requestObject.IsSetSupportedInstanceTypes())
            {
                context.Writer.WritePropertyName("SupportedInstanceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSupportedInstanceTypesListValue in requestObject.SupportedInstanceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectSupportedInstanceTypesListValue);
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

            if(requestObject.IsSetTask())
            {
                context.Writer.WritePropertyName("Task");
                context.Writer.WriteStringValue(requestObject.Task);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RecommendationJobContainerConfigMarshaller Instance = new RecommendationJobContainerConfigMarshaller();

    }
}