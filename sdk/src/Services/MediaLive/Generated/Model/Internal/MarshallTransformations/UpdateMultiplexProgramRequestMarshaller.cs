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

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMultiplexProgram Request Marshaller
    /// </summary>       
    public class UpdateMultiplexProgramRequestMarshaller : IMarshaller<IRequest, UpdateMultiplexProgramRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMultiplexProgramRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMultiplexProgramRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaLive");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-14";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetMultiplexId())
                throw new AmazonMediaLiveException("Request object does not have required field MultiplexId set");
            request.AddPathResource("{multiplexId}", StringUtils.FromString(publicRequest.MultiplexId));
            if (!publicRequest.IsSetProgramName())
                throw new AmazonMediaLiveException("Request object does not have required field ProgramName set");
            request.AddPathResource("{programName}", StringUtils.FromString(publicRequest.ProgramName));
            request.ResourcePath = "/prod/multiplexes/{multiplexId}/programs/{programName}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetMultiplexProgramSettings())
                {
                    context.Writer.WritePropertyName("multiplexProgramSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = MultiplexProgramSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MultiplexProgramSettings, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateMultiplexProgramRequestMarshaller _instance = new UpdateMultiplexProgramRequestMarshaller();        

        internal static UpdateMultiplexProgramRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMultiplexProgramRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}