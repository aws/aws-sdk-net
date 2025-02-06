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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
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
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccountAccessType())
            {
                context.Writer.WritePropertyName("accountAccessType");
                context.Writer.WriteStringValue(publicRequest.AccountAccessType);
            }

            if(publicRequest.IsSetAuthenticationProviders())
            {
                context.Writer.WritePropertyName("authenticationProviders");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAuthenticationProvidersListValue in publicRequest.AuthenticationProviders)
                {
                        context.Writer.WriteStringValue(publicRequestAuthenticationProvidersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetConfiguration())
            {
                context.Writer.WritePropertyName("configuration");
                context.Writer.WriteStringValue(publicRequest.Configuration);
            }

            if(publicRequest.IsSetGrafanaVersion())
            {
                context.Writer.WritePropertyName("grafanaVersion");
                context.Writer.WriteStringValue(publicRequest.GrafanaVersion);
            }

            if(publicRequest.IsSetNetworkAccessControl())
            {
                context.Writer.WritePropertyName("networkAccessControl");
                context.Writer.WriteStartObject();

                var marshaller = NetworkAccessConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.NetworkAccessControl, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOrganizationRoleName())
            {
                context.Writer.WritePropertyName("organizationRoleName");
                context.Writer.WriteStringValue(publicRequest.OrganizationRoleName);
            }

            if(publicRequest.IsSetPermissionType())
            {
                context.Writer.WritePropertyName("permissionType");
                context.Writer.WriteStringValue(publicRequest.PermissionType);
            }

            if(publicRequest.IsSetStackSetName())
            {
                context.Writer.WritePropertyName("stackSetName");
                context.Writer.WriteStringValue(publicRequest.StackSetName);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVpcConfiguration())
            {
                context.Writer.WritePropertyName("vpcConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = VpcConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.VpcConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWorkspaceDataSources())
            {
                context.Writer.WritePropertyName("workspaceDataSources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWorkspaceDataSourcesListValue in publicRequest.WorkspaceDataSources)
                {
                        context.Writer.WriteStringValue(publicRequestWorkspaceDataSourcesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetWorkspaceDescription())
            {
                context.Writer.WritePropertyName("workspaceDescription");
                context.Writer.WriteStringValue(publicRequest.WorkspaceDescription);
            }

            if(publicRequest.IsSetWorkspaceName())
            {
                context.Writer.WritePropertyName("workspaceName");
                context.Writer.WriteStringValue(publicRequest.WorkspaceName);
            }

            if(publicRequest.IsSetWorkspaceNotificationDestinations())
            {
                context.Writer.WritePropertyName("workspaceNotificationDestinations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWorkspaceNotificationDestinationsListValue in publicRequest.WorkspaceNotificationDestinations)
                {
                        context.Writer.WriteStringValue(publicRequestWorkspaceNotificationDestinationsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetWorkspaceOrganizationalUnits())
            {
                context.Writer.WritePropertyName("workspaceOrganizationalUnits");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWorkspaceOrganizationalUnitsListValue in publicRequest.WorkspaceOrganizationalUnits)
                {
                        context.Writer.WriteStringValue(publicRequestWorkspaceOrganizationalUnitsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetWorkspaceRoleArn())
            {
                context.Writer.WritePropertyName("workspaceRoleArn");
                context.Writer.WriteStringValue(publicRequest.WorkspaceRoleArn);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


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