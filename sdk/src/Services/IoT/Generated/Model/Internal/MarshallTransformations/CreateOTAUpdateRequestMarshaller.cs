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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOTAUpdate Request Marshaller
    /// </summary>       
    public class CreateOTAUpdateRequestMarshaller : IMarshaller<IRequest, CreateOTAUpdateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOTAUpdateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateOTAUpdateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetOtaUpdateId())
                throw new AmazonIoTException("Request object does not have required field OtaUpdateId set");
            request.AddPathResource("{otaUpdateId}", StringUtils.FromString(publicRequest.OtaUpdateId));
            request.ResourcePath = "/otaUpdates/{otaUpdateId}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdditionalParameters())
                {
                    context.Writer.WritePropertyName("additionalParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAdditionalParametersKvp in publicRequest.AdditionalParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestAdditionalParametersKvp.Key);
                        var publicRequestAdditionalParametersValue = publicRequestAdditionalParametersKvp.Value;

                            context.Writer.Write(publicRequestAdditionalParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAwsJobAbortConfig())
                {
                    context.Writer.WritePropertyName("awsJobAbortConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsJobAbortConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AwsJobAbortConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAwsJobExecutionsRolloutConfig())
                {
                    context.Writer.WritePropertyName("awsJobExecutionsRolloutConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsJobExecutionsRolloutConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AwsJobExecutionsRolloutConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAwsJobPresignedUrlConfig())
                {
                    context.Writer.WritePropertyName("awsJobPresignedUrlConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsJobPresignedUrlConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AwsJobPresignedUrlConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAwsJobTimeoutConfig())
                {
                    context.Writer.WritePropertyName("awsJobTimeoutConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsJobTimeoutConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AwsJobTimeoutConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetFiles())
                {
                    context.Writer.WritePropertyName("files");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFilesListValue in publicRequest.Files)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = OTAUpdateFileMarshaller.Instance;
                        marshaller.Marshall(publicRequestFilesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetProtocols())
                {
                    context.Writer.WritePropertyName("protocols");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestProtocolsListValue in publicRequest.Protocols)
                    {
                            context.Writer.Write(publicRequestProtocolsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTargets())
                {
                    context.Writer.WritePropertyName("targets");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTargetsListValue in publicRequest.Targets)
                    {
                            context.Writer.Write(publicRequestTargetsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTargetSelection())
                {
                    context.Writer.WritePropertyName("targetSelection");
                    context.Writer.Write(publicRequest.TargetSelection);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateOTAUpdateRequestMarshaller _instance = new CreateOTAUpdateRequestMarshaller();        

        internal static CreateOTAUpdateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateOTAUpdateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}