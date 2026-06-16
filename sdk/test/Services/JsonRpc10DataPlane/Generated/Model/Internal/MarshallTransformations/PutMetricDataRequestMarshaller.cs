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
 * Do not modify this file. This file is generated from the jsonrpc10dataplane-1999-12-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.JsonRpc10DataPlane.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.JsonRpc10DataPlane.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutMetricData Request Marshaller
    /// </summary>       
    public class PutMetricDataRequestMarshaller : IMarshaller<IRequest, PutMetricDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutMetricDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutMetricDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.JsonRpc10DataPlane");
            string target = "AwsJsonRpc10DataPlane.PutMetricData";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "1999-12-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetEntityMetricData())
            {
                context.Writer.WritePropertyName("EntityMetricData");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEntityMetricDataListValue in publicRequest.EntityMetricData)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EntityMetricDatumMarshaller.Instance;
                    marshaller.Marshall(publicRequestEntityMetricDataListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMetricData())
            {
                context.Writer.WritePropertyName("MetricData");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMetricDataListValue in publicRequest.MetricData)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MetricDatumMarshaller.Instance;
                    marshaller.Marshall(publicRequestMetricDataListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNamespace())
            {
                context.Writer.WritePropertyName("Namespace");
                context.Writer.WriteStringValue(publicRequest.Namespace);
            }

            if(publicRequest.IsSetStrictEntityValidation())
            {
                context.Writer.WritePropertyName("StrictEntityValidation");
                context.Writer.WriteBooleanValue(publicRequest.StrictEntityValidation.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static PutMetricDataRequestMarshaller _instance = new PutMetricDataRequestMarshaller();        

        internal static PutMetricDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutMetricDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}