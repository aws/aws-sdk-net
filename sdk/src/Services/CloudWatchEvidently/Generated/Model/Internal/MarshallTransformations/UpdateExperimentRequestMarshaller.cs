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
    /// UpdateExperiment Request Marshaller
    /// </summary>       
    public class UpdateExperimentRequestMarshaller : IMarshaller<IRequest, UpdateExperimentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateExperimentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateExperimentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchEvidently");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-02-01";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetExperiment())
                throw new AmazonCloudWatchEvidentlyException("Request object does not have required field Experiment set");
            request.AddPathResource("{experiment}", StringUtils.FromString(publicRequest.Experiment));
            if (!publicRequest.IsSetProject())
                throw new AmazonCloudWatchEvidentlyException("Request object does not have required field Project set");
            request.AddPathResource("{project}", StringUtils.FromString(publicRequest.Project));
            request.ResourcePath = "/projects/{project}/experiments/{experiment}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetMetricGoals())
                {
                    context.Writer.WritePropertyName("metricGoals");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMetricGoalsListValue in publicRequest.MetricGoals)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MetricGoalConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestMetricGoalsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOnlineAbConfig())
                {
                    context.Writer.WritePropertyName("onlineAbConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OnlineAbConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OnlineAbConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRandomizationSalt())
                {
                    context.Writer.WritePropertyName("randomizationSalt");
                    context.Writer.Write(publicRequest.RandomizationSalt);
                }

                if(publicRequest.IsSetSamplingRate())
                {
                    context.Writer.WritePropertyName("samplingRate");
                    context.Writer.Write(publicRequest.SamplingRate);
                }

                if(publicRequest.IsSetTreatments())
                {
                    context.Writer.WritePropertyName("treatments");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTreatmentsListValue in publicRequest.Treatments)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TreatmentConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestTreatmentsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateExperimentRequestMarshaller _instance = new UpdateExperimentRequestMarshaller();        

        internal static UpdateExperimentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateExperimentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}