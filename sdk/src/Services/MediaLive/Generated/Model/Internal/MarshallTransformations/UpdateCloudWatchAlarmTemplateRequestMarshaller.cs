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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCloudWatchAlarmTemplate Request Marshaller
    /// </summary>       
    public class UpdateCloudWatchAlarmTemplateRequestMarshaller : IMarshaller<IRequest, UpdateCloudWatchAlarmTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCloudWatchAlarmTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateCloudWatchAlarmTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaLive");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-14";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetIdentifier())
                throw new AmazonMediaLiveException("Request object does not have required field Identifier set");
            request.AddPathResource("{identifier}", StringUtils.FromString(publicRequest.Identifier));
            request.ResourcePath = "/prod/cloudwatch-alarm-templates/{identifier}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComparisonOperator())
                {
                    context.Writer.WritePropertyName("comparisonOperator");
                    context.Writer.Write(publicRequest.ComparisonOperator);
                }

                if(publicRequest.IsSetDatapointsToAlarm())
                {
                    context.Writer.WritePropertyName("datapointsToAlarm");
                    context.Writer.Write(publicRequest.DatapointsToAlarm);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEvaluationPeriods())
                {
                    context.Writer.WritePropertyName("evaluationPeriods");
                    context.Writer.Write(publicRequest.EvaluationPeriods);
                }

                if(publicRequest.IsSetGroupIdentifier())
                {
                    context.Writer.WritePropertyName("groupIdentifier");
                    context.Writer.Write(publicRequest.GroupIdentifier);
                }

                if(publicRequest.IsSetMetricName())
                {
                    context.Writer.WritePropertyName("metricName");
                    context.Writer.Write(publicRequest.MetricName);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPeriod())
                {
                    context.Writer.WritePropertyName("period");
                    context.Writer.Write(publicRequest.Period);
                }

                if(publicRequest.IsSetStatistic())
                {
                    context.Writer.WritePropertyName("statistic");
                    context.Writer.Write(publicRequest.Statistic);
                }

                if(publicRequest.IsSetTargetResourceType())
                {
                    context.Writer.WritePropertyName("targetResourceType");
                    context.Writer.Write(publicRequest.TargetResourceType);
                }

                if(publicRequest.IsSetThreshold())
                {
                    context.Writer.WritePropertyName("threshold");
                    if(StringUtils.IsSpecialDoubleValue(publicRequest.Threshold))
                    {
                        context.Writer.Write(StringUtils.FromSpecialDoubleValue(publicRequest.Threshold));
                    }
                    else
                    {
                        context.Writer.Write(publicRequest.Threshold);
                    }
                }

                if(publicRequest.IsSetTreatMissingData())
                {
                    context.Writer.WritePropertyName("treatMissingData");
                    context.Writer.Write(publicRequest.TreatMissingData);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateCloudWatchAlarmTemplateRequestMarshaller _instance = new UpdateCloudWatchAlarmTemplateRequestMarshaller();        

        internal static UpdateCloudWatchAlarmTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateCloudWatchAlarmTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}