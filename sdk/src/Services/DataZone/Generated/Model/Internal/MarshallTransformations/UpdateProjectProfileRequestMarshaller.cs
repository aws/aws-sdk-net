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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateProjectProfile Request Marshaller
    /// </summary>       
    public class UpdateProjectProfileRequestMarshaller : IMarshaller<IRequest, UpdateProjectProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateProjectProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateProjectProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            if (!publicRequest.IsSetIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field Identifier set");
            request.AddPathResource("{identifier}", StringUtils.FromString(publicRequest.Identifier));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/project-profiles/{identifier}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAllowCustomProjectResourceTags())
                {
                    context.Writer.WritePropertyName("allowCustomProjectResourceTags");
                    context.Writer.Write(publicRequest.AllowCustomProjectResourceTags);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDomainUnitIdentifier())
                {
                    context.Writer.WritePropertyName("domainUnitIdentifier");
                    context.Writer.Write(publicRequest.DomainUnitIdentifier);
                }

                if(publicRequest.IsSetEnvironmentConfigurations())
                {
                    context.Writer.WritePropertyName("environmentConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEnvironmentConfigurationsListValue in publicRequest.EnvironmentConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EnvironmentConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestEnvironmentConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetProjectResourceTags())
                {
                    context.Writer.WritePropertyName("projectResourceTags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestProjectResourceTagsListValue in publicRequest.ProjectResourceTags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ResourceTagParameterMarshaller.Instance;
                        marshaller.Marshall(publicRequestProjectResourceTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetProjectResourceTagsDescription())
                {
                    context.Writer.WritePropertyName("projectResourceTagsDescription");
                    context.Writer.Write(publicRequest.ProjectResourceTagsDescription);
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("status");
                    context.Writer.Write(publicRequest.Status);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateProjectProfileRequestMarshaller _instance = new UpdateProjectProfileRequestMarshaller();        

        internal static UpdateProjectProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateProjectProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}