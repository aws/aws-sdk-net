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
 * Do not modify this file. This file is generated from the workspaces-thin-client-2023-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesThinClient.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpacesThinClient.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEnvironment Request Marshaller
    /// </summary>       
    public class UpdateEnvironmentRequestMarshaller : IMarshaller<IRequest, UpdateEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpacesThinClient");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-08-22";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetId())
                throw new AmazonWorkSpacesThinClientException("Request object does not have required field Id set");
            request.AddPathResource("{id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/environments/{id}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDesiredSoftwareSetId())
                {
                    context.Writer.WritePropertyName("desiredSoftwareSetId");
                    context.Writer.Write(publicRequest.DesiredSoftwareSetId);
                }

                if(publicRequest.IsSetDesktopArn())
                {
                    context.Writer.WritePropertyName("desktopArn");
                    context.Writer.Write(publicRequest.DesktopArn);
                }

                if(publicRequest.IsSetDesktopEndpoint())
                {
                    context.Writer.WritePropertyName("desktopEndpoint");
                    context.Writer.Write(publicRequest.DesktopEndpoint);
                }

                if(publicRequest.IsSetDeviceCreationTags())
                {
                    context.Writer.WritePropertyName("deviceCreationTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestDeviceCreationTagsKvp in publicRequest.DeviceCreationTags)
                    {
                        context.Writer.WritePropertyName(publicRequestDeviceCreationTagsKvp.Key);
                        var publicRequestDeviceCreationTagsValue = publicRequestDeviceCreationTagsKvp.Value;

                            context.Writer.Write(publicRequestDeviceCreationTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaintenanceWindow())
                {
                    context.Writer.WritePropertyName("maintenanceWindow");
                    context.Writer.WriteObjectStart();

                    var marshaller = MaintenanceWindowMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MaintenanceWindow, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetSoftwareSetUpdateMode())
                {
                    context.Writer.WritePropertyName("softwareSetUpdateMode");
                    context.Writer.Write(publicRequest.SoftwareSetUpdateMode);
                }

                if(publicRequest.IsSetSoftwareSetUpdateSchedule())
                {
                    context.Writer.WritePropertyName("softwareSetUpdateSchedule");
                    context.Writer.Write(publicRequest.SoftwareSetUpdateSchedule);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"api.";

            return request;
        }
        private static UpdateEnvironmentRequestMarshaller _instance = new UpdateEnvironmentRequestMarshaller();        

        internal static UpdateEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}