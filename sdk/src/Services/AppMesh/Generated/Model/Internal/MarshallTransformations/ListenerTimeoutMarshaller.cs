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
using ThirdParty.Json.LitJson;

namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListenerTimeout Marshaller
    /// </summary>       
    public class ListenerTimeoutMarshaller : IRequestMarshaller<ListenerTimeout, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ListenerTimeout requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetGrpc())
            {
                context.Writer.WritePropertyName("grpc");
                context.Writer.WriteObjectStart();

                var marshaller = GrpcTimeoutMarshaller.Instance;
                marshaller.Marshall(requestObject.Grpc, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHttp())
            {
                context.Writer.WritePropertyName("http");
                context.Writer.WriteObjectStart();

                var marshaller = HttpTimeoutMarshaller.Instance;
                marshaller.Marshall(requestObject.Http, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHttp2())
            {
                context.Writer.WritePropertyName("http2");
                context.Writer.WriteObjectStart();

                var marshaller = HttpTimeoutMarshaller.Instance;
                marshaller.Marshall(requestObject.Http2, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTcp())
            {
                context.Writer.WritePropertyName("tcp");
                context.Writer.WriteObjectStart();

                var marshaller = TcpTimeoutMarshaller.Instance;
                marshaller.Marshall(requestObject.Tcp, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ListenerTimeoutMarshaller Instance = new ListenerTimeoutMarshaller();

    }
}