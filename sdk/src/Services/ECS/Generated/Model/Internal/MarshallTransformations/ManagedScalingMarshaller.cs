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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ManagedScaling Marshaller
    /// </summary>
    public class ManagedScalingMarshaller : IRequestMarshaller<ManagedScaling, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ManagedScaling requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInstanceWarmupPeriod())
            {
                context.Writer.WritePropertyName("instanceWarmupPeriod");
                context.Writer.WriteNumberValue(requestObject.InstanceWarmupPeriod.Value);
            }

            if(requestObject.IsSetMaximumScalingStepSize())
            {
                context.Writer.WritePropertyName("maximumScalingStepSize");
                context.Writer.WriteNumberValue(requestObject.MaximumScalingStepSize.Value);
            }

            if(requestObject.IsSetMinimumScalingStepSize())
            {
                context.Writer.WritePropertyName("minimumScalingStepSize");
                context.Writer.WriteNumberValue(requestObject.MinimumScalingStepSize.Value);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if(requestObject.IsSetTargetCapacity())
            {
                context.Writer.WritePropertyName("targetCapacity");
                context.Writer.WriteNumberValue(requestObject.TargetCapacity.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ManagedScalingMarshaller Instance = new ManagedScalingMarshaller();

    }
}