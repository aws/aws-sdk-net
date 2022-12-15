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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetContainerConfig())
            {
                context.Writer.WritePropertyName("ContainerConfig");
                context.Writer.WriteObjectStart();

                var marshaller = RecommendationJobContainerConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainerConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEndpointConfigurations())
            {
                context.Writer.WritePropertyName("EndpointConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEndpointConfigurationsListValue in requestObject.EndpointConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EndpointInputConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectEndpointConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEndpoints())
            {
                context.Writer.WritePropertyName("Endpoints");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEndpointsListValue in requestObject.Endpoints)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EndpointInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectEndpointsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetJobDurationInSeconds())
            {
                context.Writer.WritePropertyName("JobDurationInSeconds");
                context.Writer.Write(requestObject.JobDurationInSeconds);
            }

            if(requestObject.IsSetModelPackageVersionArn())
            {
                context.Writer.WritePropertyName("ModelPackageVersionArn");
                context.Writer.Write(requestObject.ModelPackageVersionArn);
            }

            if(requestObject.IsSetResourceLimit())
            {
                context.Writer.WritePropertyName("ResourceLimit");
                context.Writer.WriteObjectStart();

                var marshaller = RecommendationJobResourceLimitMarshaller.Instance;
                marshaller.Marshall(requestObject.ResourceLimit, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTrafficPattern())
            {
                context.Writer.WritePropertyName("TrafficPattern");
                context.Writer.WriteObjectStart();

                var marshaller = TrafficPatternMarshaller.Instance;
                marshaller.Marshall(requestObject.TrafficPattern, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVolumeKmsKeyId())
            {
                context.Writer.WritePropertyName("VolumeKmsKeyId");
                context.Writer.Write(requestObject.VolumeKmsKeyId);
            }

            if(requestObject.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("VpcConfig");
                context.Writer.WriteObjectStart();

                var marshaller = RecommendationJobVpcConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfig, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RecommendationJobInputConfigMarshaller Instance = new RecommendationJobInputConfigMarshaller();

    }
}