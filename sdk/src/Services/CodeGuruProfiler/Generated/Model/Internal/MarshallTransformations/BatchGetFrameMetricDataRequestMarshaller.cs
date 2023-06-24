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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeGuruProfiler.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeGuruProfiler.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchGetFrameMetricData Request Marshaller
    /// </summary>       
    public class BatchGetFrameMetricDataRequestMarshaller : IMarshaller<IRequest, BatchGetFrameMetricDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchGetFrameMetricDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchGetFrameMetricDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeGuruProfiler");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-18";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetProfilingGroupName())
                throw new AmazonCodeGuruProfilerException("Request object does not have required field ProfilingGroupName set");
            request.AddPathResource("{profilingGroupName}", StringUtils.FromString(publicRequest.ProfilingGroupName));
            
            if (publicRequest.IsSetEndTime())
                request.Parameters.Add("endTime", StringUtils.FromDateTimeToISO8601(publicRequest.EndTime));
            
            if (publicRequest.IsSetPeriod())
                request.Parameters.Add("period", StringUtils.FromString(publicRequest.Period));
            
            if (publicRequest.IsSetStartTime())
                request.Parameters.Add("startTime", StringUtils.FromDateTimeToISO8601(publicRequest.StartTime));
            
            if (publicRequest.IsSetTargetResolution())
                request.Parameters.Add("targetResolution", StringUtils.FromString(publicRequest.TargetResolution));
            request.ResourcePath = "/profilingGroups/{profilingGroupName}/frames/-/metrics";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFrameMetrics())
                {
                    context.Writer.WritePropertyName("frameMetrics");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFrameMetricsListValue in publicRequest.FrameMetrics)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = FrameMetricMarshaller.Instance;
                        marshaller.Marshall(publicRequestFrameMetricsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static BatchGetFrameMetricDataRequestMarshaller _instance = new BatchGetFrameMetricDataRequestMarshaller();        

        internal static BatchGetFrameMetricDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchGetFrameMetricDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}