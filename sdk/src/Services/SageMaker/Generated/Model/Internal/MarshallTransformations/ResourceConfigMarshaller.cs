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
    /// ResourceConfig Marshaller
    /// </summary>
    public class ResourceConfigMarshaller : IRequestMarshaller<ResourceConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInstanceCount())
            {
                context.Writer.WritePropertyName("InstanceCount");
                context.Writer.WriteNumberValue(requestObject.InstanceCount.Value);
            }

            if(requestObject.IsSetInstanceGroups())
            {
                context.Writer.WritePropertyName("InstanceGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInstanceGroupsListValue in requestObject.InstanceGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InstanceGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectInstanceGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInstancePlacementConfig())
            {
                context.Writer.WritePropertyName("InstancePlacementConfig");
                context.Writer.WriteStartObject();

                var marshaller = InstancePlacementConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.InstancePlacementConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.WriteStringValue(requestObject.InstanceType);
            }

            if(requestObject.IsSetKeepAlivePeriodInSeconds())
            {
                context.Writer.WritePropertyName("KeepAlivePeriodInSeconds");
                context.Writer.WriteNumberValue(requestObject.KeepAlivePeriodInSeconds.Value);
            }

            if(requestObject.IsSetTrainingPlanArn())
            {
                context.Writer.WritePropertyName("TrainingPlanArn");
                context.Writer.WriteStringValue(requestObject.TrainingPlanArn);
            }

            if(requestObject.IsSetVolumeKmsKeyId())
            {
                context.Writer.WritePropertyName("VolumeKmsKeyId");
                context.Writer.WriteStringValue(requestObject.VolumeKmsKeyId);
            }

            if(requestObject.IsSetVolumeSizeInGB())
            {
                context.Writer.WritePropertyName("VolumeSizeInGB");
                context.Writer.WriteNumberValue(requestObject.VolumeSizeInGB.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceConfigMarshaller Instance = new ResourceConfigMarshaller();

    }
}