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

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ClusterInstanceGroupSpecification Marshaller
    /// </summary>
    public class ClusterInstanceGroupSpecificationMarshaller : IRequestMarshaller<ClusterInstanceGroupSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ClusterInstanceGroupSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExecutionRole())
            {
                context.Writer.WritePropertyName("ExecutionRole");
                context.Writer.Write(requestObject.ExecutionRole);
            }

            if(requestObject.IsSetImageId())
            {
                context.Writer.WritePropertyName("ImageId");
                context.Writer.Write(requestObject.ImageId);
            }

            if(requestObject.IsSetInstanceCount())
            {
                context.Writer.WritePropertyName("InstanceCount");
                context.Writer.Write(requestObject.InstanceCount);
            }

            if(requestObject.IsSetInstanceGroupName())
            {
                context.Writer.WritePropertyName("InstanceGroupName");
                context.Writer.Write(requestObject.InstanceGroupName);
            }

            if(requestObject.IsSetInstanceStorageConfigs())
            {
                context.Writer.WritePropertyName("InstanceStorageConfigs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInstanceStorageConfigsListValue in requestObject.InstanceStorageConfigs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ClusterInstanceStorageConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectInstanceStorageConfigsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.Write(requestObject.InstanceType);
            }

            if(requestObject.IsSetLifeCycleConfig())
            {
                context.Writer.WritePropertyName("LifeCycleConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ClusterLifeCycleConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.LifeCycleConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOnStartDeepHealthChecks())
            {
                context.Writer.WritePropertyName("OnStartDeepHealthChecks");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOnStartDeepHealthChecksListValue in requestObject.OnStartDeepHealthChecks)
                {
                        context.Writer.Write(requestObjectOnStartDeepHealthChecksListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOverrideVpcConfig())
            {
                context.Writer.WritePropertyName("OverrideVpcConfig");
                context.Writer.WriteObjectStart();

                var marshaller = VpcConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.OverrideVpcConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetScheduledUpdateConfig())
            {
                context.Writer.WritePropertyName("ScheduledUpdateConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ScheduledUpdateConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ScheduledUpdateConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetThreadsPerCore())
            {
                context.Writer.WritePropertyName("ThreadsPerCore");
                context.Writer.Write(requestObject.ThreadsPerCore);
            }

            if(requestObject.IsSetTrainingPlanArn())
            {
                context.Writer.WritePropertyName("TrainingPlanArn");
                context.Writer.Write(requestObject.TrainingPlanArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ClusterInstanceGroupSpecificationMarshaller Instance = new ClusterInstanceGroupSpecificationMarshaller();

    }
}