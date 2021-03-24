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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageVod.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaPackageVod.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePackagingConfiguration Request Marshaller
    /// </summary>       
    public class CreatePackagingConfigurationRequestMarshaller : IMarshaller<IRequest, CreatePackagingConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePackagingConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePackagingConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaPackageVod");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-07";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/packaging_configurations";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCmafPackage())
                {
                    context.Writer.WritePropertyName("cmafPackage");
                    context.Writer.WriteObjectStart();

                    var marshaller = CmafPackageMarshaller.Instance;
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

                if(publicRequest.IsSetMssPackage())
                {
                    context.Writer.WritePropertyName("mssPackage");
                    context.Writer.WriteObjectStart();

                    var marshaller = MssPackageMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MssPackage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPackagingGroupId())
                {
                    context.Writer.WritePropertyName("packagingGroupId");
                    context.Writer.Write(publicRequest.PackagingGroupId);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreatePackagingConfigurationRequestMarshaller _instance = new CreatePackagingConfigurationRequestMarshaller();        

        internal static CreatePackagingConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePackagingConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}