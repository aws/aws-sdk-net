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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppMesh.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HttpGatewayRouteMatch Marshaller
    /// </summary>
    public class HttpGatewayRouteMatchMarshaller : IRequestMarshaller<HttpGatewayRouteMatch, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HttpGatewayRouteMatch requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHeaders())
            {
                context.Writer.WritePropertyName("headers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHeadersListValue in requestObject.Headers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HttpGatewayRouteHeaderMarshaller.Instance;
                    marshaller.Marshall(requestObjectHeadersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetHostname())
            {
                context.Writer.WritePropertyName("hostname");
                context.Writer.WriteStartObject();

                var marshaller = GatewayRouteHostnameMatchMarshaller.Instance;
                marshaller.Marshall(requestObject.Hostname, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMethod())
            {
                context.Writer.WritePropertyName("method");
                context.Writer.WriteStringValue(requestObject.Method);
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("path");
                context.Writer.WriteStartObject();

                var marshaller = HttpPathMatchMarshaller.Instance;
                marshaller.Marshall(requestObject.Path, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
            }

            if(requestObject.IsSetPrefix())
            {
                context.Writer.WritePropertyName("prefix");
                context.Writer.WriteStringValue(requestObject.Prefix);
            }

            if(requestObject.IsSetQueryParameters())
            {
                context.Writer.WritePropertyName("queryParameters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectQueryParametersListValue in requestObject.QueryParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HttpQueryParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectQueryParametersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HttpGatewayRouteMatchMarshaller Instance = new HttpGatewayRouteMatchMarshaller();

    }
}