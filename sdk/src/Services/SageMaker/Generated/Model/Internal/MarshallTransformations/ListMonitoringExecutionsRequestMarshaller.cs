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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
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
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListMonitoringExecutions Request Marshaller
    /// </summary>       
    public class ListMonitoringExecutionsRequestMarshaller : IMarshaller<IRequest, ListMonitoringExecutionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListMonitoringExecutionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListMonitoringExecutionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.ListMonitoringExecutions";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCreationTimeAfter())
            {
                context.Writer.WritePropertyName("CreationTimeAfter");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.CreationTimeAfter.Value)));
            }

            if(publicRequest.IsSetCreationTimeBefore())
            {
                context.Writer.WritePropertyName("CreationTimeBefore");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.CreationTimeBefore.Value)));
            }

            if(publicRequest.IsSetEndpointName())
            {
                context.Writer.WritePropertyName("EndpointName");
                context.Writer.WriteStringValue(publicRequest.EndpointName);
            }

            if(publicRequest.IsSetLastModifiedTimeAfter())
            {
                context.Writer.WritePropertyName("LastModifiedTimeAfter");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.LastModifiedTimeAfter.Value)));
            }

            if(publicRequest.IsSetLastModifiedTimeBefore())
            {
                context.Writer.WritePropertyName("LastModifiedTimeBefore");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.LastModifiedTimeBefore.Value)));
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetMonitoringJobDefinitionName())
            {
                context.Writer.WritePropertyName("MonitoringJobDefinitionName");
                context.Writer.WriteStringValue(publicRequest.MonitoringJobDefinitionName);
            }

            if(publicRequest.IsSetMonitoringScheduleName())
            {
                context.Writer.WritePropertyName("MonitoringScheduleName");
                context.Writer.WriteStringValue(publicRequest.MonitoringScheduleName);
            }

            if(publicRequest.IsSetMonitoringTypeEquals())
            {
                context.Writer.WritePropertyName("MonitoringTypeEquals");
                context.Writer.WriteStringValue(publicRequest.MonitoringTypeEquals);
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetScheduledTimeAfter())
            {
                context.Writer.WritePropertyName("ScheduledTimeAfter");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ScheduledTimeAfter.Value)));
            }

            if(publicRequest.IsSetScheduledTimeBefore())
            {
                context.Writer.WritePropertyName("ScheduledTimeBefore");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ScheduledTimeBefore.Value)));
            }

            if(publicRequest.IsSetSortBy())
            {
                context.Writer.WritePropertyName("SortBy");
                context.Writer.WriteStringValue(publicRequest.SortBy);
            }

            if(publicRequest.IsSetSortOrder())
            {
                context.Writer.WritePropertyName("SortOrder");
                context.Writer.WriteStringValue(publicRequest.SortOrder);
            }

            if(publicRequest.IsSetStatusEquals())
            {
                context.Writer.WritePropertyName("StatusEquals");
                context.Writer.WriteStringValue(publicRequest.StatusEquals);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static ListMonitoringExecutionsRequestMarshaller _instance = new ListMonitoringExecutionsRequestMarshaller();        

        internal static ListMonitoringExecutionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListMonitoringExecutionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}