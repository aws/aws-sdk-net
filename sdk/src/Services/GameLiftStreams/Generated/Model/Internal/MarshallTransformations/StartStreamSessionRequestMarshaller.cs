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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLiftStreams.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GameLiftStreams.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartStreamSession Request Marshaller
    /// </summary>       
    public class StartStreamSessionRequestMarshaller : IMarshaller<IRequest, StartStreamSessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartStreamSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartStreamSessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLiftStreams");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetIdentifier())
                throw new AmazonGameLiftStreamsException("Request object does not have required field Identifier set");
            request.AddPathResource("{Identifier}", StringUtils.FromString(publicRequest.Identifier));
            request.ResourcePath = "/streamgroups/{Identifier}/streamsessions";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdditionalEnvironmentVariables())
                {
                    context.Writer.WritePropertyName("AdditionalEnvironmentVariables");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAdditionalEnvironmentVariablesKvp in publicRequest.AdditionalEnvironmentVariables)
                    {
                        context.Writer.WritePropertyName(publicRequestAdditionalEnvironmentVariablesKvp.Key);
                        var publicRequestAdditionalEnvironmentVariablesValue = publicRequestAdditionalEnvironmentVariablesKvp.Value;

                            context.Writer.Write(publicRequestAdditionalEnvironmentVariablesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAdditionalLaunchArgs())
                {
                    context.Writer.WritePropertyName("AdditionalLaunchArgs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAdditionalLaunchArgsListValue in publicRequest.AdditionalLaunchArgs)
                    {
                            context.Writer.Write(publicRequestAdditionalLaunchArgsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetApplicationIdentifier())
                {
                    context.Writer.WritePropertyName("ApplicationIdentifier");
                    context.Writer.Write(publicRequest.ApplicationIdentifier);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetConnectionTimeoutSeconds())
                {
                    context.Writer.WritePropertyName("ConnectionTimeoutSeconds");
                    context.Writer.Write(publicRequest.ConnectionTimeoutSeconds);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetLocations())
                {
                    context.Writer.WritePropertyName("Locations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLocationsListValue in publicRequest.Locations)
                    {
                            context.Writer.Write(publicRequestLocationsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetProtocol())
                {
                    context.Writer.WritePropertyName("Protocol");
                    context.Writer.Write(publicRequest.Protocol);
                }

                if(publicRequest.IsSetSessionLengthSeconds())
                {
                    context.Writer.WritePropertyName("SessionLengthSeconds");
                    context.Writer.Write(publicRequest.SessionLengthSeconds);
                }

                if(publicRequest.IsSetSignalRequest())
                {
                    context.Writer.WritePropertyName("SignalRequest");
                    context.Writer.Write(publicRequest.SignalRequest);
                }

                if(publicRequest.IsSetUserId())
                {
                    context.Writer.WritePropertyName("UserId");
                    context.Writer.Write(publicRequest.UserId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartStreamSessionRequestMarshaller _instance = new StartStreamSessionRequestMarshaller();        

        internal static StartStreamSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartStreamSessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}