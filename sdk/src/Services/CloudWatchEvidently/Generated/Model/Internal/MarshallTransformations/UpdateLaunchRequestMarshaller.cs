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
    /// UpdateLaunch Request Marshaller
    /// </summary>       
    public class UpdateLaunchRequestMarshaller : IMarshaller<IRequest, UpdateLaunchRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLaunchRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLaunchRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchEvidently");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-02-01";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetLaunch())
                throw new AmazonCloudWatchEvidentlyException("Request object does not have required field Launch set");
            request.AddPathResource("{launch}", StringUtils.FromString(publicRequest.Launch));
            if (!publicRequest.IsSetProject())
                throw new AmazonCloudWatchEvidentlyException("Request object does not have required field Project set");
            request.AddPathResource("{project}", StringUtils.FromString(publicRequest.Project));
            request.ResourcePath = "/projects/{project}/launches/{launch}";
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

                if(publicRequest.IsSetGroups())
                {
                    context.Writer.WritePropertyName("groups");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGroupsListValue in publicRequest.Groups)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = LaunchGroupConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestGroupsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMetricMonitors())
                {
                    context.Writer.WritePropertyName("metricMonitors");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMetricMonitorsListValue in publicRequest.MetricMonitors)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MetricMonitorConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestMetricMonitorsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRandomizationSalt())
                {
                    context.Writer.WritePropertyName("randomizationSalt");
                    context.Writer.Write(publicRequest.RandomizationSalt);
                }

                if(publicRequest.IsSetScheduledSplitsConfig())
                {
                    context.Writer.WritePropertyName("scheduledSplitsConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ScheduledSplitsLaunchConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ScheduledSplitsConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateLaunchRequestMarshaller _instance = new UpdateLaunchRequestMarshaller();        

        internal static UpdateLaunchRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLaunchRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}