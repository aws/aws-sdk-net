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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterWorkspaceDirectory Request Marshaller
    /// </summary>       
    public class RegisterWorkspaceDirectoryRequestMarshaller : IMarshaller<IRequest, RegisterWorkspaceDirectoryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterWorkspaceDirectoryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterWorkspaceDirectoryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpaces");
            string target = "WorkspacesService.RegisterWorkspaceDirectory";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-08";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDirectoryId())
                {
                    context.Writer.WritePropertyName("DirectoryId");
                    context.Writer.Write(publicRequest.DirectoryId);
                }

                if(publicRequest.IsSetEnableSelfService())
                {
                    context.Writer.WritePropertyName("EnableSelfService");
                    context.Writer.Write(publicRequest.EnableSelfService);
                }

                if(publicRequest.IsSetEnableWorkDocs())
                {
                    context.Writer.WritePropertyName("EnableWorkDocs");
                    context.Writer.Write(publicRequest.EnableWorkDocs);
                }

                if(publicRequest.IsSetSubnetIds())
                {
                    context.Writer.WritePropertyName("SubnetIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubnetIdsListValue in publicRequest.SubnetIds)
                    {
                            context.Writer.Write(publicRequestSubnetIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
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

                if(publicRequest.IsSetTenancy())
                {
                    context.Writer.WritePropertyName("Tenancy");
                    context.Writer.Write(publicRequest.Tenancy);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RegisterWorkspaceDirectoryRequestMarshaller _instance = new RegisterWorkspaceDirectoryRequestMarshaller();        

        internal static RegisterWorkspaceDirectoryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterWorkspaceDirectoryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}