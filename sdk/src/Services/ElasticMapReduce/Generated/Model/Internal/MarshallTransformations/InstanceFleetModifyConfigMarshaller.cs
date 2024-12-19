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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstanceFleetModifyConfig Marshaller
    /// </summary>
    public class InstanceFleetModifyConfigMarshaller : IRequestMarshaller<InstanceFleetModifyConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceFleetModifyConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInstanceFleetId())
            {
                context.Writer.WritePropertyName("InstanceFleetId");
                context.Writer.WriteStringValue(requestObject.InstanceFleetId);
            }

            if(requestObject.IsSetInstanceTypeConfigs())
            {
                context.Writer.WritePropertyName("InstanceTypeConfigs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInstanceTypeConfigsListValue in requestObject.InstanceTypeConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InstanceTypeConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectInstanceTypeConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResizeSpecifications())
            {
                context.Writer.WritePropertyName("ResizeSpecifications");
                context.Writer.WriteStartObject();

                var marshaller = InstanceFleetResizingSpecificationsMarshaller.Instance;
                marshaller.Marshall(requestObject.ResizeSpecifications, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTargetOnDemandCapacity())
            {
                context.Writer.WritePropertyName("TargetOnDemandCapacity");
                context.Writer.WriteNumberValue(requestObject.TargetOnDemandCapacity.Value);
            }

            if(requestObject.IsSetTargetSpotCapacity())
            {
                context.Writer.WritePropertyName("TargetSpotCapacity");
                context.Writer.WriteNumberValue(requestObject.TargetSpotCapacity.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstanceFleetModifyConfigMarshaller Instance = new InstanceFleetModifyConfigMarshaller();

    }
}