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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ObservabilityAdmin.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ObservabilityAdmin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VPCFlowLogParameters Marshaller
    /// </summary>
    public class VPCFlowLogParametersMarshaller : IRequestMarshaller<VPCFlowLogParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VPCFlowLogParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLogFormat())
            {
                context.Writer.WritePropertyName("LogFormat");
                context.Writer.Write(requestObject.LogFormat);
            }

            if(requestObject.IsSetMaxAggregationInterval())
            {
                context.Writer.WritePropertyName("MaxAggregationInterval");
                context.Writer.Write(requestObject.MaxAggregationInterval);
            }

            if(requestObject.IsSetTrafficType())
            {
                context.Writer.WritePropertyName("TrafficType");
                context.Writer.Write(requestObject.TrafficType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VPCFlowLogParametersMarshaller Instance = new VPCFlowLogParametersMarshaller();

    }
}