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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchEvidently.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudWatchEvidently.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetExperimentResults Request Marshaller
    /// </summary>       
    public class GetExperimentResultsRequestMarshaller : IMarshaller<IRequest, GetExperimentResultsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetExperimentResultsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetExperimentResultsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchEvidently");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-02-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetExperiment())
                throw new AmazonCloudWatchEvidentlyException("Request object does not have required field Experiment set");
            request.AddPathResource("{experiment}", StringUtils.FromString(publicRequest.Experiment));
            if (!publicRequest.IsSetProject())
                throw new AmazonCloudWatchEvidentlyException("Request object does not have required field Project set");
            request.AddPathResource("{project}", StringUtils.FromString(publicRequest.Project));
            request.ResourcePath = "/projects/{project}/experiments/{experiment}/results";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBaseStat())
                {
                    context.Writer.WritePropertyName("baseStat");
                    context.Writer.Write(publicRequest.BaseStat);
                }

                if(publicRequest.IsSetEndTime())
                {
                    context.Writer.WritePropertyName("endTime");
                    context.Writer.Write(publicRequest.EndTime);
                }

                if(publicRequest.IsSetMetricNames())
                {
                    context.Writer.WritePropertyName("metricNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMetricNamesListValue in publicRequest.MetricNames)
                    {
                            context.Writer.Write(publicRequestMetricNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPeriod())
                {
                    context.Writer.WritePropertyName("period");
                    context.Writer.Write(publicRequest.Period);
                }

                if(publicRequest.IsSetReportNames())
                {
                    context.Writer.WritePropertyName("reportNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestReportNamesListValue in publicRequest.ReportNames)
                    {
                            context.Writer.Write(publicRequestReportNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetResultStats())
                {
                    context.Writer.WritePropertyName("resultStats");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResultStatsListValue in publicRequest.ResultStats)
                    {
                            context.Writer.Write(publicRequestResultStatsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStartTime())
                {
                    context.Writer.WritePropertyName("startTime");
                    context.Writer.Write(publicRequest.StartTime);
                }

                if(publicRequest.IsSetTreatmentNames())
                {
                    context.Writer.WritePropertyName("treatmentNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTreatmentNamesListValue in publicRequest.TreatmentNames)
                    {
                            context.Writer.Write(publicRequestTreatmentNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetExperimentResultsRequestMarshaller _instance = new GetExperimentResultsRequestMarshaller();        

        internal static GetExperimentResultsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetExperimentResultsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}