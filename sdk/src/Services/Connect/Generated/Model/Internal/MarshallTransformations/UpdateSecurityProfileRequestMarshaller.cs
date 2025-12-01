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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSecurityProfile Request Marshaller
    /// </summary>       
    public class UpdateSecurityProfileRequestMarshaller : IMarshaller<IRequest, UpdateSecurityProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSecurityProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSecurityProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            if (!publicRequest.IsSetSecurityProfileId())
                throw new AmazonConnectException("Request object does not have required field SecurityProfileId set");
            request.AddPathResource("{SecurityProfileId}", StringUtils.FromString(publicRequest.SecurityProfileId));
            request.ResourcePath = "/security-profiles/{InstanceId}/{SecurityProfileId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAllowedAccessControlHierarchyGroupId())
                {
                    context.Writer.WritePropertyName("AllowedAccessControlHierarchyGroupId");
                    context.Writer.Write(publicRequest.AllowedAccessControlHierarchyGroupId);
                }

                if(publicRequest.IsSetAllowedAccessControlTags())
                {
                    context.Writer.WritePropertyName("AllowedAccessControlTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAllowedAccessControlTagsKvp in publicRequest.AllowedAccessControlTags)
                    {
                        context.Writer.WritePropertyName(publicRequestAllowedAccessControlTagsKvp.Key);
                        var publicRequestAllowedAccessControlTagsValue = publicRequestAllowedAccessControlTagsKvp.Value;

                            context.Writer.Write(publicRequestAllowedAccessControlTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAllowedFlowModules())
                {
                    context.Writer.WritePropertyName("AllowedFlowModules");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAllowedFlowModulesListValue in publicRequest.AllowedFlowModules)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = FlowModuleMarshaller.Instance;
                        marshaller.Marshall(publicRequestAllowedFlowModulesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetApplications())
                {
                    context.Writer.WritePropertyName("Applications");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestApplicationsListValue in publicRequest.Applications)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ApplicationMarshaller.Instance;
                        marshaller.Marshall(publicRequestApplicationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetGranularAccessControlConfiguration())
                {
                    context.Writer.WritePropertyName("GranularAccessControlConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = GranularAccessControlConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GranularAccessControlConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetHierarchyRestrictedResources())
                {
                    context.Writer.WritePropertyName("HierarchyRestrictedResources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestHierarchyRestrictedResourcesListValue in publicRequest.HierarchyRestrictedResources)
                    {
                            context.Writer.Write(publicRequestHierarchyRestrictedResourcesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPermissions())
                {
                    context.Writer.WritePropertyName("Permissions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPermissionsListValue in publicRequest.Permissions)
                    {
                            context.Writer.Write(publicRequestPermissionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTagRestrictedResources())
                {
                    context.Writer.WritePropertyName("TagRestrictedResources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagRestrictedResourcesListValue in publicRequest.TagRestrictedResources)
                    {
                            context.Writer.Write(publicRequestTagRestrictedResourcesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateSecurityProfileRequestMarshaller _instance = new UpdateSecurityProfileRequestMarshaller();        

        internal static UpdateSecurityProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSecurityProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}