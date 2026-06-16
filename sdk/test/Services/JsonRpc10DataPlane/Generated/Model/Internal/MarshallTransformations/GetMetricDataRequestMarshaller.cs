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
    /// GetMetricData Request Marshaller
    /// </summary>       
    public class GetMetricDataRequestMarshaller : IMarshaller<IRequest, GetMetricDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetMetricDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetMetricDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.JsonRpc10DataPlane");
            string target = "AwsJsonRpc10DataPlane.GetMetricData";
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
            if(publicRequest.IsSetEndTime())
            {
                context.Writer.WritePropertyName("EndTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.EndTime.Value)));
            }

            if(publicRequest.IsSetLabelOptions())
            {
                context.Writer.WritePropertyName("LabelOptions");
                context.Writer.WriteStartObject();

                var marshaller = LabelOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.LabelOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaxDatapoints())
            {
                context.Writer.WritePropertyName("MaxDatapoints");
                context.Writer.WriteNumberValue(publicRequest.MaxDatapoints.Value);
            }

            if(publicRequest.IsSetMetricDataQueries())
            {
                context.Writer.WritePropertyName("MetricDataQueries");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMetricDataQueriesListValue in publicRequest.MetricDataQueries)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MetricDataQueryMarshaller.Instance;
                    marshaller.Marshall(publicRequestMetricDataQueriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetScanBy())
            {
                context.Writer.WritePropertyName("ScanBy");
                context.Writer.WriteStringValue(publicRequest.ScanBy);
            }

            if(publicRequest.IsSetStartTime())
            {
                context.Writer.WritePropertyName("StartTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.StartTime.Value)));
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static GetMetricDataRequestMarshaller _instance = new GetMetricDataRequestMarshaller();        

        internal static GetMetricDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMetricDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}