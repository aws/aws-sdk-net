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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TargetNetworkUpdate Marshaller
    /// </summary>
    public class TargetNetworkUpdateMarshaller : IRequestMarshaller<TargetNetworkUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TargetNetworkUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInboundCidr())
            {
                context.Writer.WritePropertyName("inboundCidr");
                context.Writer.Write(requestObject.InboundCidr);
            }

            if(requestObject.IsSetInspectionCidr())
            {
                context.Writer.WritePropertyName("inspectionCidr");
                context.Writer.Write(requestObject.InspectionCidr);
            }

            if(requestObject.IsSetOutboundCidr())
            {
                context.Writer.WritePropertyName("outboundCidr");
                context.Writer.Write(requestObject.OutboundCidr);
            }

            if(requestObject.IsSetTopology())
            {
                context.Writer.WritePropertyName("topology");
                context.Writer.Write(requestObject.Topology);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TargetNetworkUpdateMarshaller Instance = new TargetNetworkUpdateMarshaller();

    }
}