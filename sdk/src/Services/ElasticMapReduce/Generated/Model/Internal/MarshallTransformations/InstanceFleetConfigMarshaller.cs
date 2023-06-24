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
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstanceFleetConfig Marshaller
    /// </summary>
    public class InstanceFleetConfigMarshaller : IRequestMarshaller<InstanceFleetConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceFleetConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetInstanceFleetType())
            {
                context.Writer.WritePropertyName("InstanceFleetType");
                context.Writer.Write(requestObject.InstanceFleetType);
            }

            if(requestObject.IsSetInstanceTypeConfigs())
            {
                context.Writer.WritePropertyName("InstanceTypeConfigs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInstanceTypeConfigsListValue in requestObject.InstanceTypeConfigs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = InstanceTypeConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectInstanceTypeConfigsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLaunchSpecifications())
            {
                context.Writer.WritePropertyName("LaunchSpecifications");
                context.Writer.WriteObjectStart();

                var marshaller = InstanceFleetProvisioningSpecificationsMarshaller.Instance;
                marshaller.Marshall(requestObject.LaunchSpecifications, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetResizeSpecifications())
            {
                context.Writer.WritePropertyName("ResizeSpecifications");
                context.Writer.WriteObjectStart();

                var marshaller = InstanceFleetResizingSpecificationsMarshaller.Instance;
                marshaller.Marshall(requestObject.ResizeSpecifications, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTargetOnDemandCapacity())
            {
                context.Writer.WritePropertyName("TargetOnDemandCapacity");
                context.Writer.Write(requestObject.TargetOnDemandCapacity);
            }

            if(requestObject.IsSetTargetSpotCapacity())
            {
                context.Writer.WritePropertyName("TargetSpotCapacity");
                context.Writer.Write(requestObject.TargetSpotCapacity);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstanceFleetConfigMarshaller Instance = new InstanceFleetConfigMarshaller();

    }
}