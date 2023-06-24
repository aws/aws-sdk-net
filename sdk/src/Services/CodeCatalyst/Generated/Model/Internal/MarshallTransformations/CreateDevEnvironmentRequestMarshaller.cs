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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeCatalyst.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeCatalyst.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDevEnvironment Request Marshaller
    /// </summary>       
    public class CreateDevEnvironmentRequestMarshaller : IMarshaller<IRequest, CreateDevEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDevEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDevEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeCatalyst");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-09-28";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetProjectName())
                throw new AmazonCodeCatalystException("Request object does not have required field ProjectName set");
            request.AddPathResource("{projectName}", StringUtils.FromString(publicRequest.ProjectName));
            if (!publicRequest.IsSetSpaceName())
                throw new AmazonCodeCatalystException("Request object does not have required field SpaceName set");
            request.AddPathResource("{spaceName}", StringUtils.FromString(publicRequest.SpaceName));
            request.ResourcePath = "/v1/spaces/{spaceName}/projects/{projectName}/devEnvironments";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAlias())
                {
                    context.Writer.WritePropertyName("alias");
                    context.Writer.Write(publicRequest.Alias);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                if(publicRequest.IsSetIdes())
                {
                    context.Writer.WritePropertyName("ides");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIdesListValue in publicRequest.Ides)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = IdeConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestIdesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetInactivityTimeoutMinutes())
                {
                    context.Writer.WritePropertyName("inactivityTimeoutMinutes");
                    context.Writer.Write(publicRequest.InactivityTimeoutMinutes);
                }

                if(publicRequest.IsSetInstanceType())
                {
                    context.Writer.WritePropertyName("instanceType");
                    context.Writer.Write(publicRequest.InstanceType);
                }

                if(publicRequest.IsSetPersistentStorage())
                {
                    context.Writer.WritePropertyName("persistentStorage");
                    context.Writer.WriteObjectStart();

                    var marshaller = PersistentStorageConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PersistentStorage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRepositories())
                {
                    context.Writer.WritePropertyName("repositories");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRepositoriesListValue in publicRequest.Repositories)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RepositoryInputMarshaller.Instance;
                        marshaller.Marshall(publicRequestRepositoriesListValue, context);

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
        private static CreateDevEnvironmentRequestMarshaller _instance = new CreateDevEnvironmentRequestMarshaller();        

        internal static CreateDevEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDevEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}