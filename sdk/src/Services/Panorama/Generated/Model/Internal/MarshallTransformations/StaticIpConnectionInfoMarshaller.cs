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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Panorama.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Panorama.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StaticIpConnectionInfo Marshaller
    /// </summary>
    public class StaticIpConnectionInfoMarshaller : IRequestMarshaller<StaticIpConnectionInfo, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StaticIpConnectionInfo requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDefaultGateway())
            {
                context.Writer.WritePropertyName("DefaultGateway");
                context.Writer.WriteStringValue(requestObject.DefaultGateway);
            }

            if(requestObject.IsSetDns())
            {
                context.Writer.WritePropertyName("Dns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDnsListValue in requestObject.Dns)
                {
                        context.Writer.WriteStringValue(requestObjectDnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIpAddress())
            {
                context.Writer.WritePropertyName("IpAddress");
                context.Writer.WriteStringValue(requestObject.IpAddress);
            }

            if(requestObject.IsSetMask())
            {
                context.Writer.WritePropertyName("Mask");
                context.Writer.WriteStringValue(requestObject.Mask);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StaticIpConnectionInfoMarshaller Instance = new StaticIpConnectionInfoMarshaller();

    }
}