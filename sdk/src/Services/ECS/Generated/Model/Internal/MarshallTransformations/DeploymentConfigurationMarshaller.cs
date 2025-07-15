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
    /// DeploymentConfiguration Marshaller
    /// </summary>
    public class DeploymentConfigurationMarshaller : IRequestMarshaller<DeploymentConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DeploymentConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlarms())
            {
                context.Writer.WritePropertyName("alarms");
                context.Writer.WriteStartObject();

                var marshaller = DeploymentAlarmsMarshaller.Instance;
                marshaller.Marshall(requestObject.Alarms, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBakeTimeInMinutes())
            {
                context.Writer.WritePropertyName("bakeTimeInMinutes");
                context.Writer.WriteNumberValue(requestObject.BakeTimeInMinutes.Value);
            }

            if(requestObject.IsSetDeploymentCircuitBreaker())
            {
                context.Writer.WritePropertyName("deploymentCircuitBreaker");
                context.Writer.WriteStartObject();

                var marshaller = DeploymentCircuitBreakerMarshaller.Instance;
                marshaller.Marshall(requestObject.DeploymentCircuitBreaker, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLifecycleHooks())
            {
                context.Writer.WritePropertyName("lifecycleHooks");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLifecycleHooksListValue in requestObject.LifecycleHooks)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DeploymentLifecycleHookMarshaller.Instance;
                    marshaller.Marshall(requestObjectLifecycleHooksListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMaximumPercent())
            {
                context.Writer.WritePropertyName("maximumPercent");
                context.Writer.WriteNumberValue(requestObject.MaximumPercent.Value);
            }

            if(requestObject.IsSetMinimumHealthyPercent())
            {
                context.Writer.WritePropertyName("minimumHealthyPercent");
                context.Writer.WriteNumberValue(requestObject.MinimumHealthyPercent.Value);
            }

            if(requestObject.IsSetStrategy())
            {
                context.Writer.WritePropertyName("strategy");
                context.Writer.WriteStringValue(requestObject.Strategy);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DeploymentConfigurationMarshaller Instance = new DeploymentConfigurationMarshaller();

    }
}