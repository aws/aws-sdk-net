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
using ThirdParty.Json.LitJson;

namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ServiceConnectService Marshaller
    /// </summary>
    public class ServiceConnectServiceMarshaller : IRequestMarshaller<ServiceConnectService, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServiceConnectService requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetClientAliases())
            {
                context.Writer.WritePropertyName("clientAliases");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectClientAliasesListValue in requestObject.ClientAliases)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ServiceConnectClientAliasMarshaller.Instance;
                    marshaller.Marshall(requestObjectClientAliasesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDiscoveryName())
            {
                context.Writer.WritePropertyName("discoveryName");
                context.Writer.Write(requestObject.DiscoveryName);
            }

            if(requestObject.IsSetIngressPortOverride())
            {
                context.Writer.WritePropertyName("ingressPortOverride");
                context.Writer.Write(requestObject.IngressPortOverride);
            }

            if(requestObject.IsSetPortName())
            {
                context.Writer.WritePropertyName("portName");
                context.Writer.Write(requestObject.PortName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ServiceConnectServiceMarshaller Instance = new ServiceConnectServiceMarshaller();

    }
}