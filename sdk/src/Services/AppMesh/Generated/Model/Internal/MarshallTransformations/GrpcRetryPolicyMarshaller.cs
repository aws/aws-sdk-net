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
    /// GrpcRetryPolicy Marshaller
    /// </summary>
    public class GrpcRetryPolicyMarshaller : IRequestMarshaller<GrpcRetryPolicy, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GrpcRetryPolicy requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGrpcRetryEvents())
            {
                context.Writer.WritePropertyName("grpcRetryEvents");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGrpcRetryEventsListValue in requestObject.GrpcRetryEvents)
                {
                        context.Writer.WriteStringValue(requestObjectGrpcRetryEventsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetHttpRetryEvents())
            {
                context.Writer.WritePropertyName("httpRetryEvents");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHttpRetryEventsListValue in requestObject.HttpRetryEvents)
                {
                        context.Writer.WriteStringValue(requestObjectHttpRetryEventsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMaxRetries())
            {
                context.Writer.WritePropertyName("maxRetries");
                context.Writer.WriteNumberValue(requestObject.MaxRetries.Value);
            }

            if(requestObject.IsSetPerRetryTimeout())
            {
                context.Writer.WritePropertyName("perRetryTimeout");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PerRetryTimeout, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTcpRetryEvents())
            {
                context.Writer.WritePropertyName("tcpRetryEvents");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTcpRetryEventsListValue in requestObject.TcpRetryEvents)
                {
                        context.Writer.WriteStringValue(requestObjectTcpRetryEventsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GrpcRetryPolicyMarshaller Instance = new GrpcRetryPolicyMarshaller();

    }
}