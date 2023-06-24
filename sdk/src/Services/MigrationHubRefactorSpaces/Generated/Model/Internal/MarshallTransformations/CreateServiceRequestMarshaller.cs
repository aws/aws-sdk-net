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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubRefactorSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MigrationHubRefactorSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateService Request Marshaller
    /// </summary>       
    public class CreateServiceRequestMarshaller : IMarshaller<IRequest, CreateServiceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateServiceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateServiceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MigrationHubRefactorSpaces");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-10-26";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApplicationIdentifier())
                throw new AmazonMigrationHubRefactorSpacesException("Request object does not have required field ApplicationIdentifier set");
            request.AddPathResource("{ApplicationIdentifier}", StringUtils.FromString(publicRequest.ApplicationIdentifier));
            if (!publicRequest.IsSetEnvironmentIdentifier())
                throw new AmazonMigrationHubRefactorSpacesException("Request object does not have required field EnvironmentIdentifier set");
            request.AddPathResource("{EnvironmentIdentifier}", StringUtils.FromString(publicRequest.EnvironmentIdentifier));
            request.ResourcePath = "/environments/{EnvironmentIdentifier}/applications/{ApplicationIdentifier}/services";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEndpointType())
                {
                    context.Writer.WritePropertyName("EndpointType");
                    context.Writer.Write(publicRequest.EndpointType);
                }

                if(publicRequest.IsSetLambdaEndpoint())
                {
                    context.Writer.WritePropertyName("LambdaEndpoint");
                    context.Writer.WriteObjectStart();

                    var marshaller = LambdaEndpointInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LambdaEndpoint, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUrlEndpoint())
                {
                    context.Writer.WritePropertyName("UrlEndpoint");
                    context.Writer.WriteObjectStart();

                    var marshaller = UrlEndpointInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.UrlEndpoint, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVpcId())
                {
                    context.Writer.WritePropertyName("VpcId");
                    context.Writer.Write(publicRequest.VpcId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateServiceRequestMarshaller _instance = new CreateServiceRequestMarshaller();        

        internal static CreateServiceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateServiceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}