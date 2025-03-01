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
    /// NodeRangeProperty Marshaller
    /// </summary>
    public class NodeRangePropertyMarshaller : IRequestMarshaller<NodeRangeProperty, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NodeRangeProperty requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConsumableResourceProperties())
            {
                context.Writer.WritePropertyName("consumableResourceProperties");
                context.Writer.WriteStartObject();

                var marshaller = ConsumableResourcePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.ConsumableResourceProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContainer())
            {
                context.Writer.WritePropertyName("container");
                context.Writer.WriteStartObject();

                var marshaller = ContainerPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.Container, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEcsProperties())
            {
                context.Writer.WritePropertyName("ecsProperties");
                context.Writer.WriteStartObject();

                var marshaller = EcsPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.EcsProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEksProperties())
            {
                context.Writer.WritePropertyName("eksProperties");
                context.Writer.WriteStartObject();

                var marshaller = EksPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.EksProperties, context);

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
        public readonly static NodeRangePropertyMarshaller Instance = new NodeRangePropertyMarshaller();

    }
}