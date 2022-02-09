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
    /// CreateRoute Request Marshaller
    /// </summary>       
    public class CreateRouteRequestMarshaller : IMarshaller<IRequest, CreateRouteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRouteRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRouteRequest publicRequest)
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
            request.ResourcePath = "/environments/{EnvironmentIdentifier}/applications/{ApplicationIdentifier}/routes";
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
                if(publicRequest.IsSetRouteType())
                {
                    context.Writer.WritePropertyName("RouteType");
                    context.Writer.Write(publicRequest.RouteType);
                }

                if(publicRequest.IsSetServiceIdentifier())
                {
                    context.Writer.WritePropertyName("ServiceIdentifier");
                    context.Writer.Write(publicRequest.ServiceIdentifier);
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

                if(publicRequest.IsSetUriPathRoute())
                {
                    context.Writer.WritePropertyName("UriPathRoute");
                    context.Writer.WriteObjectStart();

                    var marshaller = UriPathRouteInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.UriPathRoute, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateRouteRequestMarshaller _instance = new CreateRouteRequestMarshaller();        

        internal static CreateRouteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRouteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}