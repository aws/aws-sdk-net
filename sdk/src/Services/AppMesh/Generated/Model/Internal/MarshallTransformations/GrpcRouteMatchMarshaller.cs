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
    /// GrpcRouteMatch Marshaller
    /// </summary>
    public class GrpcRouteMatchMarshaller : IRequestMarshaller<GrpcRouteMatch, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GrpcRouteMatch requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMetadata())
            {
                context.Writer.WritePropertyName("metadata");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMetadataListValue in requestObject.Metadata)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GrpcRouteMetadataMarshaller.Instance;
                    marshaller.Marshall(requestObjectMetadataListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMethodName())
            {
                context.Writer.WritePropertyName("methodName");
                context.Writer.WriteStringValue(requestObject.MethodName);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
            }

            if(requestObject.IsSetServiceName())
            {
                context.Writer.WritePropertyName("serviceName");
                context.Writer.WriteStringValue(requestObject.ServiceName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GrpcRouteMatchMarshaller Instance = new GrpcRouteMatchMarshaller();

    }
}