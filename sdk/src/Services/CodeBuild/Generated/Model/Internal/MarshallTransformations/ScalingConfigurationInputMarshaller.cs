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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ScalingConfigurationInput Marshaller
    /// </summary>
    public class ScalingConfigurationInputMarshaller : IRequestMarshaller<ScalingConfigurationInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScalingConfigurationInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMaxCapacity())
            {
                context.Writer.WritePropertyName("maxCapacity");
                context.Writer.Write(requestObject.MaxCapacity);
            }

            if(requestObject.IsSetScalingType())
            {
                context.Writer.WritePropertyName("scalingType");
                context.Writer.Write(requestObject.ScalingType);
            }

            if(requestObject.IsSetTargetTrackingScalingConfigs())
            {
                context.Writer.WritePropertyName("targetTrackingScalingConfigs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetTrackingScalingConfigsListValue in requestObject.TargetTrackingScalingConfigs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TargetTrackingScalingConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetTrackingScalingConfigsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScalingConfigurationInputMarshaller Instance = new ScalingConfigurationInputMarshaller();

    }
}
#pragma warning restore CS0612,CS0618