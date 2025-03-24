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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NdiConfig Marshaller
    /// </summary>
    public class NdiConfigMarshaller : IRequestMarshaller<NdiConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NdiConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMachineName())
            {
                context.Writer.WritePropertyName("machineName");
                context.Writer.WriteStringValue(requestObject.MachineName);
            }

            if(requestObject.IsSetNdiDiscoveryServers())
            {
                context.Writer.WritePropertyName("ndiDiscoveryServers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNdiDiscoveryServersListValue in requestObject.NdiDiscoveryServers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NdiDiscoveryServerConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectNdiDiscoveryServersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNdiState())
            {
                context.Writer.WritePropertyName("ndiState");
                context.Writer.WriteStringValue(requestObject.NdiState);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NdiConfigMarshaller Instance = new NdiConfigMarshaller();

    }
}