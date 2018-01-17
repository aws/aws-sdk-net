/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScalingPlans.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AutoScalingPlans.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ScalingInstruction Marshaller
    /// </summary>       
    public class ScalingInstructionMarshaller : IRequestMarshaller<ScalingInstruction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScalingInstruction requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetMaxCapacity())
            {
                context.Writer.WritePropertyName("MaxCapacity");
                context.Writer.Write(requestObject.MaxCapacity);
            }

            if(requestObject.IsSetMinCapacity())
            {
                context.Writer.WritePropertyName("MinCapacity");
                context.Writer.Write(requestObject.MinCapacity);
            }

            if(requestObject.IsSetResourceId())
            {
                context.Writer.WritePropertyName("ResourceId");
                context.Writer.Write(requestObject.ResourceId);
            }

            if(requestObject.IsSetScalableDimension())
            {
                context.Writer.WritePropertyName("ScalableDimension");
                context.Writer.Write(requestObject.ScalableDimension);
            }

            if(requestObject.IsSetServiceNamespace())
            {
                context.Writer.WritePropertyName("ServiceNamespace");
                context.Writer.Write(requestObject.ServiceNamespace);
            }

            if(requestObject.IsSetTargetTrackingConfigurations())
            {
                context.Writer.WritePropertyName("TargetTrackingConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetTrackingConfigurationsListValue in requestObject.TargetTrackingConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TargetTrackingConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetTrackingConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ScalingInstructionMarshaller Instance = new ScalingInstructionMarshaller();

    }
}