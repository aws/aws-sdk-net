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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMediaInsightsPipelineConfiguration Request Marshaller
    /// </summary>       
    public class UpdateMediaInsightsPipelineConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateMediaInsightsPipelineConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMediaInsightsPipelineConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMediaInsightsPipelineConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMediaPipelines");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-15";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetIdentifier())
                throw new AmazonChimeSDKMediaPipelinesException("Request object does not have required field Identifier set");
            request.AddPathResource("{identifier}", StringUtils.FromString(publicRequest.Identifier));
            request.ResourcePath = "/media-insights-pipeline-configurations/{identifier}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetElements())
                {
                    context.Writer.WritePropertyName("Elements");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestElementsListValue in publicRequest.Elements)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MediaInsightsPipelineConfigurationElementMarshaller.Instance;
                        marshaller.Marshall(publicRequestElementsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRealTimeAlertConfiguration())
                {
                    context.Writer.WritePropertyName("RealTimeAlertConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = RealTimeAlertConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RealTimeAlertConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResourceAccessRoleArn())
                {
                    context.Writer.WritePropertyName("ResourceAccessRoleArn");
                    context.Writer.Write(publicRequest.ResourceAccessRoleArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateMediaInsightsPipelineConfigurationRequestMarshaller _instance = new UpdateMediaInsightsPipelineConfigurationRequestMarshaller();        

        internal static UpdateMediaInsightsPipelineConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMediaInsightsPipelineConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}