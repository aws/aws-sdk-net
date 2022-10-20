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

namespace Amazon.CloudWatchRUM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutRumMetricsDestination Request Marshaller
    /// </summary>       
    public class PutRumMetricsDestinationRequestMarshaller : IMarshaller<IRequest, PutRumMetricsDestinationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutRumMetricsDestinationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutRumMetricsDestinationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchRUM");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAppMonitorName())
                throw new AmazonCloudWatchRUMException("Request object does not have required field AppMonitorName set");
            request.AddPathResource("{AppMonitorName}", StringUtils.FromString(publicRequest.AppMonitorName));
            request.ResourcePath = "/rummetrics/{AppMonitorName}/metricsdestination";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
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

                if(publicRequest.IsSetIamRoleArn())
                {
                    context.Writer.WritePropertyName("IamRoleArn");
                    context.Writer.Write(publicRequest.IamRoleArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutRumMetricsDestinationRequestMarshaller _instance = new PutRumMetricsDestinationRequestMarshaller();        

        internal static PutRumMetricsDestinationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutRumMetricsDestinationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}