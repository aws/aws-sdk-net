/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutPlaybackConfiguration Request Marshaller
    /// </summary>       
    public class PutPlaybackConfigurationRequestMarshaller : IMarshaller<IRequest, PutPlaybackConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutPlaybackConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutPlaybackConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaTailor");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/prod/playbackConfiguration";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdDecisionServerUrl())
                {
                    context.Writer.WritePropertyName("AdDecisionServerUrl");
                    context.Writer.Write(publicRequest.AdDecisionServerUrl);
                }

                if(publicRequest.IsSetCdnConfiguration())
                {
                    context.Writer.WritePropertyName("CdnConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CdnConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CdnConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetSlateAdUrl())
                {
                    context.Writer.WritePropertyName("SlateAdUrl");
                    context.Writer.Write(publicRequest.SlateAdUrl);
                }

                if(publicRequest.IsSetVideoContentSourceUrl())
                {
                    context.Writer.WritePropertyName("VideoContentSourceUrl");
                    context.Writer.Write(publicRequest.VideoContentSourceUrl);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutPlaybackConfigurationRequestMarshaller _instance = new PutPlaybackConfigurationRequestMarshaller();        

        internal static PutPlaybackConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutPlaybackConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}