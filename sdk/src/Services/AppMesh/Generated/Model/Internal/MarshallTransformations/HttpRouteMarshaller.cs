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
    /// HttpRoute Marshaller
    /// </summary>
    public class HttpRouteMarshaller : IRequestMarshaller<HttpRoute, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HttpRoute requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("action");
                context.Writer.WriteStartObject();

                var marshaller = HttpRouteActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Action, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMatch())
            {
                context.Writer.WritePropertyName("match");
                context.Writer.WriteStartObject();

                var marshaller = HttpRouteMatchMarshaller.Instance;
                marshaller.Marshall(requestObject.Match, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRetryPolicy())
            {
                context.Writer.WritePropertyName("retryPolicy");
                context.Writer.WriteStartObject();

                var marshaller = HttpRetryPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.RetryPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimeout())
            {
                context.Writer.WritePropertyName("timeout");
                context.Writer.WriteStartObject();

                var marshaller = HttpTimeoutMarshaller.Instance;
                marshaller.Marshall(requestObject.Timeout, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HttpRouteMarshaller Instance = new HttpRouteMarshaller();

    }
}