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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HttpRequestConfiguration Marshaller
    /// </summary>
    public class HttpRequestConfigurationMarshaller : IRequestMarshaller<HttpRequestConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HttpRequestConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBody())
            {
                context.Writer.WritePropertyName("Body");
                context.Writer.WriteStringValue(requestObject.Body);
            }

            if(requestObject.IsSetHeaders())
            {
                context.Writer.WritePropertyName("Headers");
                context.Writer.WriteStartObject();
                foreach (var requestObjectHeadersKvp in requestObject.Headers)
                {
                    context.Writer.WritePropertyName(requestObjectHeadersKvp.Key);
                    var requestObjectHeadersValue = requestObjectHeadersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectHeadersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMethodType())
            {
                context.Writer.WritePropertyName("MethodType");
                context.Writer.WriteStringValue(requestObject.MethodType);
            }

            if(requestObject.IsSetOutput())
            {
                context.Writer.WritePropertyName("Output");
                context.Writer.WriteStartObject();
                foreach (var requestObjectOutputKvp in requestObject.Output)
                {
                    context.Writer.WritePropertyName(requestObjectOutputKvp.Key);
                    var requestObjectOutputValue = requestObjectOutputKvp.Value;

                        context.Writer.WriteStringValue(requestObjectOutputValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRequestTimeoutMilliseconds())
            {
                context.Writer.WritePropertyName("RequestTimeoutMilliseconds");
                context.Writer.WriteNumberValue(requestObject.RequestTimeoutMilliseconds.Value);
            }

            if(requestObject.IsSetRuntime())
            {
                context.Writer.WritePropertyName("Runtime");
                context.Writer.WriteStringValue(requestObject.Runtime);
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("Url");
                context.Writer.WriteStringValue(requestObject.Url);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HttpRequestConfigurationMarshaller Instance = new HttpRequestConfigurationMarshaller();

    }
}