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
    /// CreateEnvironment Request Marshaller
    /// </summary>       
    public class CreateEnvironmentRequestMarshaller : IMarshaller<IRequest, CreateEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpacesThinClient");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-08-22";
            request.HttpMethod = "POST";

            request.ResourcePath = "/environments";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
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

                if(publicRequest.IsSetKmsKeyArn())
                {
                    context.Writer.WritePropertyName("kmsKeyArn");
                    context.Writer.Write(publicRequest.KmsKeyArn);
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

            
            request.HostPrefix = $"api.";

            return request;
        }
        private static CreateEnvironmentRequestMarshaller _instance = new CreateEnvironmentRequestMarshaller();        

        internal static CreateEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}