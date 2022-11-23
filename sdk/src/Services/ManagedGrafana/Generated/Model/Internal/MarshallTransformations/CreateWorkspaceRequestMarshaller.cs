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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedGrafana.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ManagedGrafana.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateWorkspace Request Marshaller
    /// </summary>       
    public class CreateWorkspaceRequestMarshaller : IMarshaller<IRequest, CreateWorkspaceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWorkspaceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateWorkspaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ManagedGrafana");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-18";
            request.HttpMethod = "POST";

            request.ResourcePath = "/workspaces";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountAccessType())
                {
                    context.Writer.WritePropertyName("accountAccessType");
                    context.Writer.Write(publicRequest.AccountAccessType);
                }

                if(publicRequest.IsSetAuthenticationProviders())
                {
                    context.Writer.WritePropertyName("authenticationProviders");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAuthenticationProvidersListValue in publicRequest.AuthenticationProviders)
                    {
                            context.Writer.Write(publicRequestAuthenticationProvidersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

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
                if(publicRequest.IsSetConfiguration())
                {
                    context.Writer.WritePropertyName("configuration");
                    context.Writer.Write(publicRequest.Configuration);
                }

                if(publicRequest.IsSetOrganizationRoleName())
                {
                    context.Writer.WritePropertyName("organizationRoleName");
                    context.Writer.Write(publicRequest.OrganizationRoleName);
                }

                if(publicRequest.IsSetPermissionType())
                {
                    context.Writer.WritePropertyName("permissionType");
                    context.Writer.Write(publicRequest.PermissionType);
                }

                if(publicRequest.IsSetStackSetName())
                {
                    context.Writer.WritePropertyName("stackSetName");
                    context.Writer.Write(publicRequest.StackSetName);
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

                if(publicRequest.IsSetVpcConfiguration())
                {
                    context.Writer.WritePropertyName("vpcConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = VpcConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetWorkspaceDataSources())
                {
                    context.Writer.WritePropertyName("workspaceDataSources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWorkspaceDataSourcesListValue in publicRequest.WorkspaceDataSources)
                    {
                            context.Writer.Write(publicRequestWorkspaceDataSourcesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetWorkspaceDescription())
                {
                    context.Writer.WritePropertyName("workspaceDescription");
                    context.Writer.Write(publicRequest.WorkspaceDescription);
                }

                if(publicRequest.IsSetWorkspaceName())
                {
                    context.Writer.WritePropertyName("workspaceName");
                    context.Writer.Write(publicRequest.WorkspaceName);
                }

                if(publicRequest.IsSetWorkspaceNotificationDestinations())
                {
                    context.Writer.WritePropertyName("workspaceNotificationDestinations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWorkspaceNotificationDestinationsListValue in publicRequest.WorkspaceNotificationDestinations)
                    {
                            context.Writer.Write(publicRequestWorkspaceNotificationDestinationsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetWorkspaceOrganizationalUnits())
                {
                    context.Writer.WritePropertyName("workspaceOrganizationalUnits");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWorkspaceOrganizationalUnitsListValue in publicRequest.WorkspaceOrganizationalUnits)
                    {
                            context.Writer.Write(publicRequestWorkspaceOrganizationalUnitsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetWorkspaceRoleArn())
                {
                    context.Writer.WritePropertyName("workspaceRoleArn");
                    context.Writer.Write(publicRequest.WorkspaceRoleArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateWorkspaceRequestMarshaller _instance = new CreateWorkspaceRequestMarshaller();        

        internal static CreateWorkspaceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateWorkspaceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}