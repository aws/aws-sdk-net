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
    /// RecommendationJobInputConfig Marshaller
    /// </summary>
    public class RecommendationJobInputConfigMarshaller : IRequestMarshaller<RecommendationJobInputConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RecommendationJobInputConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContainerConfig())
            {
                context.Writer.WritePropertyName("ContainerConfig");
                context.Writer.WriteStartObject();

                var marshaller = RecommendationJobContainerConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainerConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEndpointConfigurations())
            {
                context.Writer.WritePropertyName("EndpointConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEndpointConfigurationsListValue in requestObject.EndpointConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EndpointInputConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectEndpointConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEndpoints())
            {
                context.Writer.WritePropertyName("Endpoints");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEndpointsListValue in requestObject.Endpoints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EndpointInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectEndpointsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetJobDurationInSeconds())
            {
                context.Writer.WritePropertyName("JobDurationInSeconds");
                context.Writer.WriteNumberValue(requestObject.JobDurationInSeconds.Value);
            }

            if(requestObject.IsSetModelName())
            {
                context.Writer.WritePropertyName("ModelName");
                context.Writer.WriteStringValue(requestObject.ModelName);
            }

            if(requestObject.IsSetModelPackageVersionArn())
            {
                context.Writer.WritePropertyName("ModelPackageVersionArn");
                context.Writer.WriteStringValue(requestObject.ModelPackageVersionArn);
            }

            if(requestObject.IsSetResourceLimit())
            {
                context.Writer.WritePropertyName("ResourceLimit");
                context.Writer.WriteStartObject();

                var marshaller = RecommendationJobResourceLimitMarshaller.Instance;
                marshaller.Marshall(requestObject.ResourceLimit, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTrafficPattern())
            {
                context.Writer.WritePropertyName("TrafficPattern");
                context.Writer.WriteStartObject();

                var marshaller = TrafficPatternMarshaller.Instance;
                marshaller.Marshall(requestObject.TrafficPattern, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVolumeKmsKeyId())
            {
                context.Writer.WritePropertyName("VolumeKmsKeyId");
                context.Writer.WriteStringValue(requestObject.VolumeKmsKeyId);
            }

            if(requestObject.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("VpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = RecommendationJobVpcConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RecommendationJobInputConfigMarshaller Instance = new RecommendationJobInputConfigMarshaller();

    }
}