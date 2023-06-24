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
    /// ConfigureAgent Request Marshaller
    /// </summary>       
    public class ConfigureAgentRequestMarshaller : IMarshaller<IRequest, ConfigureAgentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ConfigureAgentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ConfigureAgentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeGuruProfiler");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-18";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetProfilingGroupName())
                throw new AmazonCodeGuruProfilerException("Request object does not have required field ProfilingGroupName set");
            request.AddPathResource("{profilingGroupName}", StringUtils.FromString(publicRequest.ProfilingGroupName));
            request.ResourcePath = "/profilingGroups/{profilingGroupName}/configureAgent";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFleetInstanceId())
                {
                    context.Writer.WritePropertyName("fleetInstanceId");
                    context.Writer.Write(publicRequest.FleetInstanceId);
                }

                if(publicRequest.IsSetMetadata())
                {
                    context.Writer.WritePropertyName("metadata");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestMetadataKvp in publicRequest.Metadata)
                    {
                        context.Writer.WritePropertyName(publicRequestMetadataKvp.Key);
                        var publicRequestMetadataValue = publicRequestMetadataKvp.Value;

                            context.Writer.Write(publicRequestMetadataValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ConfigureAgentRequestMarshaller _instance = new ConfigureAgentRequestMarshaller();        

        internal static ConfigureAgentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfigureAgentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}