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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/environments";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDeploymentOrder())
                {
                    context.Writer.WritePropertyName("deploymentOrder");
                    context.Writer.Write(publicRequest.DeploymentOrder);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEnvironmentAccountIdentifier())
                {
                    context.Writer.WritePropertyName("environmentAccountIdentifier");
                    context.Writer.Write(publicRequest.EnvironmentAccountIdentifier);
                }

                if(publicRequest.IsSetEnvironmentAccountRegion())
                {
                    context.Writer.WritePropertyName("environmentAccountRegion");
                    context.Writer.Write(publicRequest.EnvironmentAccountRegion);
                }

                if(publicRequest.IsSetEnvironmentBlueprintIdentifier())
                {
                    context.Writer.WritePropertyName("environmentBlueprintIdentifier");
                    context.Writer.Write(publicRequest.EnvironmentBlueprintIdentifier);
                }

                if(publicRequest.IsSetEnvironmentConfigurationId())
                {
                    context.Writer.WritePropertyName("environmentConfigurationId");
                    context.Writer.Write(publicRequest.EnvironmentConfigurationId);
                }

                if(publicRequest.IsSetEnvironmentProfileIdentifier())
                {
                    context.Writer.WritePropertyName("environmentProfileIdentifier");
                    context.Writer.Write(publicRequest.EnvironmentProfileIdentifier);
                }

                if(publicRequest.IsSetGlossaryTerms())
                {
                    context.Writer.WritePropertyName("glossaryTerms");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGlossaryTermsListValue in publicRequest.GlossaryTerms)
                    {
                            context.Writer.Write(publicRequestGlossaryTermsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetProjectIdentifier())
                {
                    context.Writer.WritePropertyName("projectIdentifier");
                    context.Writer.Write(publicRequest.ProjectIdentifier);
                }

                if(publicRequest.IsSetUserParameters())
                {
                    context.Writer.WritePropertyName("userParameters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUserParametersListValue in publicRequest.UserParameters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EnvironmentParameterMarshaller.Instance;
                        marshaller.Marshall(publicRequestUserParametersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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