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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ComponentStatusData Marshaller
    /// </summary>
    public class ComponentStatusDataMarshaller : IRequestMarshaller<ComponentStatusData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ComponentStatusData requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBytesReceived())
            {
                context.Writer.WritePropertyName("bytesReceived");
                context.Writer.Write(requestObject.BytesReceived);
            }

            if(requestObject.IsSetBytesSent())
            {
                context.Writer.WritePropertyName("bytesSent");
                context.Writer.Write(requestObject.BytesSent);
            }

            if(requestObject.IsSetCapabilityArn())
            {
                context.Writer.WritePropertyName("capabilityArn");
                context.Writer.Write(requestObject.CapabilityArn);
            }

            if(requestObject.IsSetComponentType())
            {
                context.Writer.WritePropertyName("componentType");
                context.Writer.Write(requestObject.ComponentType);
            }

            if(requestObject.IsSetDataflowId())
            {
                context.Writer.WritePropertyName("dataflowId");
                context.Writer.Write(requestObject.DataflowId);
            }

            if(requestObject.IsSetPacketsDropped())
            {
                context.Writer.WritePropertyName("packetsDropped");
                context.Writer.Write(requestObject.PacketsDropped);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("status");
                context.Writer.Write(requestObject.Status);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComponentStatusDataMarshaller Instance = new ComponentStatusDataMarshaller();

    }
}