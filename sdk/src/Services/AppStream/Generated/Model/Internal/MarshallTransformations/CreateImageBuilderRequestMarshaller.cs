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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateImageBuilder Request Marshaller
    /// </summary>       
    public class CreateImageBuilderRequestMarshaller : IMarshaller<IRequest, CreateImageBuilderRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateImageBuilderRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateImageBuilderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            string target = "PhotonAdminProxyService.CreateImageBuilder";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessEndpoints())
                {
                    context.Writer.WritePropertyName("AccessEndpoints");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAccessEndpointsListValue in publicRequest.AccessEndpoints)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AccessEndpointMarshaller.Instance;
                        marshaller.Marshall(publicRequestAccessEndpointsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAppstreamAgentVersion())
                {
                    context.Writer.WritePropertyName("AppstreamAgentVersion");
                    context.Writer.Write(publicRequest.AppstreamAgentVersion);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("DisplayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetDomainJoinInfo())
                {
                    context.Writer.WritePropertyName("DomainJoinInfo");
                    context.Writer.WriteObjectStart();

                    var marshaller = DomainJoinInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DomainJoinInfo, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEnableDefaultInternetAccess())
                {
                    context.Writer.WritePropertyName("EnableDefaultInternetAccess");
                    context.Writer.Write(publicRequest.EnableDefaultInternetAccess);
                }

                if(publicRequest.IsSetIamRoleArn())
                {
                    context.Writer.WritePropertyName("IamRoleArn");
                    context.Writer.Write(publicRequest.IamRoleArn);
                }

                if(publicRequest.IsSetImageArn())
                {
                    context.Writer.WritePropertyName("ImageArn");
                    context.Writer.Write(publicRequest.ImageArn);
                }

                if(publicRequest.IsSetImageName())
                {
                    context.Writer.WritePropertyName("ImageName");
                    context.Writer.Write(publicRequest.ImageName);
                }

                if(publicRequest.IsSetInstanceType())
                {
                    context.Writer.WritePropertyName("InstanceType");
                    context.Writer.Write(publicRequest.InstanceType);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetSoftwaresToInstall())
                {
                    context.Writer.WritePropertyName("SoftwaresToInstall");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSoftwaresToInstallListValue in publicRequest.SoftwaresToInstall)
                    {
                            context.Writer.Write(publicRequestSoftwaresToInstallListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSoftwaresToUninstall())
                {
                    context.Writer.WritePropertyName("SoftwaresToUninstall");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSoftwaresToUninstallListValue in publicRequest.SoftwaresToUninstall)
                    {
                            context.Writer.Write(publicRequestSoftwaresToUninstallListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WritePropertyName("VpcConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = VpcConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateImageBuilderRequestMarshaller _instance = new CreateImageBuilderRequestMarshaller();        

        internal static CreateImageBuilderRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateImageBuilderRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}