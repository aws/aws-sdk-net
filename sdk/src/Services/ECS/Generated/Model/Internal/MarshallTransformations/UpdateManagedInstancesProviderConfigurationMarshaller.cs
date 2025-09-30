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
    /// UpdateManagedInstancesProviderConfiguration Marshaller
    /// </summary>
    public class UpdateManagedInstancesProviderConfigurationMarshaller : IRequestMarshaller<UpdateManagedInstancesProviderConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateManagedInstancesProviderConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInfrastructureRoleArn())
            {
                context.Writer.WritePropertyName("infrastructureRoleArn");
                context.Writer.WriteStringValue(requestObject.InfrastructureRoleArn);
            }

            if(requestObject.IsSetInstanceLaunchTemplate())
            {
                context.Writer.WritePropertyName("instanceLaunchTemplate");
                context.Writer.WriteStartObject();

                var marshaller = InstanceLaunchTemplateUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.InstanceLaunchTemplate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPropagateTags())
            {
                context.Writer.WritePropertyName("propagateTags");
                context.Writer.WriteStringValue(requestObject.PropagateTags);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateManagedInstancesProviderConfigurationMarshaller Instance = new UpdateManagedInstancesProviderConfigurationMarshaller();

    }
}