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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackage.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaPackage.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOriginEndpoint Request Marshaller
    /// </summary>       
    public class CreateOriginEndpointRequestMarshaller : IMarshaller<IRequest, CreateOriginEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOriginEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateOriginEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaPackage");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/origin_endpoints";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetChannelId())
                {
                    context.Writer.WritePropertyName("channelId");
                    context.Writer.Write(publicRequest.ChannelId);
                }

                if(publicRequest.IsSetCmafPackage())
                {
                    context.Writer.WritePropertyName("cmafPackage");
                    context.Writer.WriteObjectStart();

                    var marshaller = CmafPackageCreateOrUpdateParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CmafPackage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDashPackage())
                {
                    context.Writer.WritePropertyName("dashPackage");
                    context.Writer.WriteObjectStart();

                    var marshaller = DashPackageMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DashPackage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetHlsPackage())
                {
                    context.Writer.WritePropertyName("hlsPackage");
                    context.Writer.WriteObjectStart();

                    var marshaller = HlsPackageMarshaller.Instance;
                    marshaller.Marshall(publicRequest.HlsPackage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetId())
                {
                    context.Writer.WritePropertyName("id");
                    context.Writer.Write(publicRequest.Id);
                }

                if(publicRequest.IsSetManifestName())
                {
                    context.Writer.WritePropertyName("manifestName");
                    context.Writer.Write(publicRequest.ManifestName);
                }

                if(publicRequest.IsSetMssPackage())
                {
                    context.Writer.WritePropertyName("mssPackage");
                    context.Writer.WriteObjectStart();

                    var marshaller = MssPackageMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MssPackage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStartoverWindowSeconds())
                {
                    context.Writer.WritePropertyName("startoverWindowSeconds");
                    context.Writer.Write(publicRequest.StartoverWindowSeconds);
                }

                if(publicRequest.IsSetTimeDelaySeconds())
                {
                    context.Writer.WritePropertyName("timeDelaySeconds");
                    context.Writer.Write(publicRequest.TimeDelaySeconds);
                }

                if(publicRequest.IsSetWhitelist())
                {
                    context.Writer.WritePropertyName("whitelist");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWhitelistListValue in publicRequest.Whitelist)
                    {
                            context.Writer.Write(publicRequestWhitelistListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateOriginEndpointRequestMarshaller _instance = new CreateOriginEndpointRequestMarshaller();        

        internal static CreateOriginEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateOriginEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}