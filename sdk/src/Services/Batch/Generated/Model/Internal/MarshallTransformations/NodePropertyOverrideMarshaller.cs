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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NodePropertyOverride Marshaller
    /// </summary>
    public class NodePropertyOverrideMarshaller : IRequestMarshaller<NodePropertyOverride, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NodePropertyOverride requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConsumableResourcePropertiesOverride())
            {
                context.Writer.WritePropertyName("consumableResourcePropertiesOverride");
                context.Writer.WriteStartObject();

                var marshaller = ConsumableResourcePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.ConsumableResourcePropertiesOverride, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContainerOverrides())
            {
                context.Writer.WritePropertyName("containerOverrides");
                context.Writer.WriteStartObject();

                var marshaller = ContainerOverridesMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainerOverrides, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEcsPropertiesOverride())
            {
                context.Writer.WritePropertyName("ecsPropertiesOverride");
                context.Writer.WriteStartObject();

                var marshaller = EcsPropertiesOverrideMarshaller.Instance;
                marshaller.Marshall(requestObject.EcsPropertiesOverride, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEksPropertiesOverride())
            {
                context.Writer.WritePropertyName("eksPropertiesOverride");
                context.Writer.WriteStartObject();

                var marshaller = EksPropertiesOverrideMarshaller.Instance;
                marshaller.Marshall(requestObject.EksPropertiesOverride, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInstanceTypes())
            {
                context.Writer.WritePropertyName("instanceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInstanceTypesListValue in requestObject.InstanceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectInstanceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetNodes())
            {
                context.Writer.WritePropertyName("targetNodes");
                context.Writer.WriteStringValue(requestObject.TargetNodes);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NodePropertyOverrideMarshaller Instance = new NodePropertyOverrideMarshaller();

    }
}