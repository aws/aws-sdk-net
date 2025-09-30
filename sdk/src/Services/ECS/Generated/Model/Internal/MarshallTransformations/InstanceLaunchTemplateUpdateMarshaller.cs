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
    /// InstanceLaunchTemplateUpdate Marshaller
    /// </summary>
    public class InstanceLaunchTemplateUpdateMarshaller : IRequestMarshaller<InstanceLaunchTemplateUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceLaunchTemplateUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEc2InstanceProfileArn())
            {
                context.Writer.WritePropertyName("ec2InstanceProfileArn");
                context.Writer.WriteStringValue(requestObject.Ec2InstanceProfileArn);
            }

            if(requestObject.IsSetInstanceRequirements())
            {
                context.Writer.WritePropertyName("instanceRequirements");
                context.Writer.WriteStartObject();

                var marshaller = InstanceRequirementsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.InstanceRequirements, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMonitoring())
            {
                context.Writer.WritePropertyName("monitoring");
                context.Writer.WriteStringValue(requestObject.Monitoring);
            }

            if(requestObject.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("networkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ManagedInstancesNetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStorageConfiguration())
            {
                context.Writer.WritePropertyName("storageConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ManagedInstancesStorageConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.StorageConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstanceLaunchTemplateUpdateMarshaller Instance = new InstanceLaunchTemplateUpdateMarshaller();

    }
}