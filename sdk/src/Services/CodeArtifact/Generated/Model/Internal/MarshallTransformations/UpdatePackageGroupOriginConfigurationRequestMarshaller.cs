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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeArtifact.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeArtifact.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePackageGroupOriginConfiguration Request Marshaller
    /// </summary>       
    public class UpdatePackageGroupOriginConfigurationRequestMarshaller : IMarshaller<IRequest, UpdatePackageGroupOriginConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePackageGroupOriginConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePackageGroupOriginConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeArtifact");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-22";
            request.HttpMethod = "PUT";

            
            if (publicRequest.IsSetDomain())
                request.Parameters.Add("domain", StringUtils.FromString(publicRequest.Domain));
            
            if (publicRequest.IsSetDomainOwner())
                request.Parameters.Add("domain-owner", StringUtils.FromString(publicRequest.DomainOwner));
            
            if (publicRequest.IsSetPackageGroup())
                request.Parameters.Add("package-group", StringUtils.FromString(publicRequest.PackageGroup));
            request.ResourcePath = "/v1/package-group-origin-configuration";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAddAllowedRepositories())
                {
                    context.Writer.WritePropertyName("addAllowedRepositories");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAddAllowedRepositoriesListValue in publicRequest.AddAllowedRepositories)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PackageGroupAllowedRepositoryMarshaller.Instance;
                        marshaller.Marshall(publicRequestAddAllowedRepositoriesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRemoveAllowedRepositories())
                {
                    context.Writer.WritePropertyName("removeAllowedRepositories");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRemoveAllowedRepositoriesListValue in publicRequest.RemoveAllowedRepositories)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PackageGroupAllowedRepositoryMarshaller.Instance;
                        marshaller.Marshall(publicRequestRemoveAllowedRepositoriesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRestrictions())
                {
                    context.Writer.WritePropertyName("restrictions");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestRestrictionsKvp in publicRequest.Restrictions)
                    {
                        context.Writer.WritePropertyName(publicRequestRestrictionsKvp.Key);
                        var publicRequestRestrictionsValue = publicRequestRestrictionsKvp.Value;

                            context.Writer.Write(publicRequestRestrictionsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static UpdatePackageGroupOriginConfigurationRequestMarshaller _instance = new UpdatePackageGroupOriginConfigurationRequestMarshaller();        

        internal static UpdatePackageGroupOriginConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePackageGroupOriginConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}