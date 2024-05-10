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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchRUM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchRUM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchCreateRumMetricDefinitions Request Marshaller
    /// </summary>       
    public class BatchCreateRumMetricDefinitionsRequestMarshaller : IMarshaller<IRequest, BatchCreateRumMetricDefinitionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchCreateRumMetricDefinitionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchCreateRumMetricDefinitionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchRUM");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAppMonitorName())
                throw new AmazonCloudWatchRUMException("Request object does not have required field AppMonitorName set");
            request.AddPathResource("{AppMonitorName}", StringUtils.FromString(publicRequest.AppMonitorName));
            request.ResourcePath = "/rummetrics/{AppMonitorName}/metrics";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDestination())
                {
                    context.Writer.WritePropertyName("Destination");
                    context.Writer.Write(publicRequest.Destination);
                }

                if(publicRequest.IsSetDestinationArn())
                {
                    context.Writer.WritePropertyName("DestinationArn");
                    context.Writer.Write(publicRequest.DestinationArn);
                }

                if(publicRequest.IsSetMetricDefinitions())
                {
                    context.Writer.WritePropertyName("MetricDefinitions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMetricDefinitionsListValue in publicRequest.MetricDefinitions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MetricDefinitionRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestMetricDefinitionsListValue, context);

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
        private static BatchCreateRumMetricDefinitionsRequestMarshaller _instance = new BatchCreateRumMetricDefinitionsRequestMarshaller();        

        internal static BatchCreateRumMetricDefinitionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchCreateRumMetricDefinitionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}