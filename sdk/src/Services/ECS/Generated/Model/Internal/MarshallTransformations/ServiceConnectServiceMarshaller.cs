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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetClientAliases())
            {
                context.Writer.WritePropertyName("clientAliases");
                context.Writer.WriteStartArray();
                foreach(var requestObjectClientAliasesListValue in requestObject.ClientAliases)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ServiceConnectClientAliasMarshaller.Instance;
                    marshaller.Marshall(requestObjectClientAliasesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDiscoveryName())
            {
                context.Writer.WritePropertyName("discoveryName");
                context.Writer.WriteStringValue(requestObject.DiscoveryName);
            }

            if(requestObject.IsSetIngressPortOverride())
            {
                context.Writer.WritePropertyName("ingressPortOverride");
                context.Writer.WriteNumberValue(requestObject.IngressPortOverride.Value);
            }

            if(requestObject.IsSetPortName())
            {
                context.Writer.WritePropertyName("portName");
                context.Writer.WriteStringValue(requestObject.PortName);
            }

            if(requestObject.IsSetTimeout())
            {
                context.Writer.WritePropertyName("timeout");
                context.Writer.WriteStartObject();

                var marshaller = TimeoutConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Timeout, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTls())
            {
                context.Writer.WritePropertyName("tls");
                context.Writer.WriteStartObject();

                var marshaller = ServiceConnectTlsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Tls, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ServiceConnectServiceMarshaller Instance = new ServiceConnectServiceMarshaller();

    }
}