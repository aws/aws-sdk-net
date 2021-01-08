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

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFleet Request Marshaller
    /// </summary>       
    public class CreateFleetRequestMarshaller : IMarshaller<IRequest, CreateFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFleetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            string target = "PhotonAdminProxyService.CreateFleet";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComputeCapacity())
                {
                    context.Writer.WritePropertyName("ComputeCapacity");
                    context.Writer.WriteObjectStart();

                    var marshaller = ComputeCapacityMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ComputeCapacity, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDisconnectTimeoutInSeconds())
                {
                    context.Writer.WritePropertyName("DisconnectTimeoutInSeconds");
                    context.Writer.Write(publicRequest.DisconnectTimeoutInSeconds);
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

                if(publicRequest.IsSetFleetType())
                {
                    context.Writer.WritePropertyName("FleetType");
                    context.Writer.Write(publicRequest.FleetType);
                }

                if(publicRequest.IsSetIamRoleArn())
                {
                    context.Writer.WritePropertyName("IamRoleArn");
                    context.Writer.Write(publicRequest.IamRoleArn);
                }

                if(publicRequest.IsSetIdleDisconnectTimeoutInSeconds())
                {
                    context.Writer.WritePropertyName("IdleDisconnectTimeoutInSeconds");
                    context.Writer.Write(publicRequest.IdleDisconnectTimeoutInSeconds);
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

                if(publicRequest.IsSetMaxUserDurationInSeconds())
                {
                    context.Writer.WritePropertyName("MaxUserDurationInSeconds");
                    context.Writer.Write(publicRequest.MaxUserDurationInSeconds);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetStreamView())
                {
                    context.Writer.WritePropertyName("StreamView");
                    context.Writer.Write(publicRequest.StreamView);
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
        private static CreateFleetRequestMarshaller _instance = new CreateFleetRequestMarshaller();        

        internal static CreateFleetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFleetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}