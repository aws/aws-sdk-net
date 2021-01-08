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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kafka.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMonitoring Request Marshaller
    /// </summary>       
    public class UpdateMonitoringRequestMarshaller : IMarshaller<IRequest, UpdateMonitoringRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMonitoringRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMonitoringRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Kafka");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetClusterArn())
                throw new AmazonKafkaException("Request object does not have required field ClusterArn set");
            request.AddPathResource("{clusterArn}", StringUtils.FromString(publicRequest.ClusterArn));
            request.ResourcePath = "/v1/clusters/{clusterArn}/monitoring";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCurrentVersion())
                {
                    context.Writer.WritePropertyName("currentVersion");
                    context.Writer.Write(publicRequest.CurrentVersion);
                }

                if(publicRequest.IsSetEnhancedMonitoring())
                {
                    context.Writer.WritePropertyName("enhancedMonitoring");
                    context.Writer.Write(publicRequest.EnhancedMonitoring);
                }

                if(publicRequest.IsSetLoggingInfo())
                {
                    context.Writer.WritePropertyName("loggingInfo");
                    context.Writer.WriteObjectStart();

                    var marshaller = LoggingInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LoggingInfo, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOpenMonitoring())
                {
                    context.Writer.WritePropertyName("openMonitoring");
                    context.Writer.WriteObjectStart();

                    var marshaller = OpenMonitoringInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OpenMonitoring, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateMonitoringRequestMarshaller _instance = new UpdateMonitoringRequestMarshaller();        

        internal static UpdateMonitoringRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMonitoringRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}