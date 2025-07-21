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
    /// LoadBalancer Marshaller
    /// </summary>
    public class LoadBalancerMarshaller : IRequestMarshaller<LoadBalancer, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LoadBalancer requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdvancedConfiguration())
            {
                context.Writer.WritePropertyName("advancedConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AdvancedConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AdvancedConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContainerName())
            {
                context.Writer.WritePropertyName("containerName");
                context.Writer.WriteStringValue(requestObject.ContainerName);
            }

            if(requestObject.IsSetContainerPort())
            {
                context.Writer.WritePropertyName("containerPort");
                context.Writer.WriteNumberValue(requestObject.ContainerPort.Value);
            }

            if(requestObject.IsSetLoadBalancerName())
            {
                context.Writer.WritePropertyName("loadBalancerName");
                context.Writer.WriteStringValue(requestObject.LoadBalancerName);
            }

            if(requestObject.IsSetTargetGroupArn())
            {
                context.Writer.WritePropertyName("targetGroupArn");
                context.Writer.WriteStringValue(requestObject.TargetGroupArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LoadBalancerMarshaller Instance = new LoadBalancerMarshaller();

    }
}