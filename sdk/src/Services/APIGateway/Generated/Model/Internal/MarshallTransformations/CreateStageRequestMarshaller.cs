/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateStage Request Marshaller
    /// </summary>       
    public class CreateStageRequestMarshaller : IMarshaller<IRequest, CreateStageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateStageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/restapis/{restapi_id}/stages";
            if (!publicRequest.IsSetRestApiId())
                throw new AmazonAPIGatewayException("Request object does not have required field RestApiId set");
            uriResourcePath = uriResourcePath.Replace("{restapi_id}", StringUtils.FromString(publicRequest.RestApiId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCacheClusterEnabled())
                {
                    context.Writer.WritePropertyName("cacheClusterEnabled");
                    context.Writer.Write(publicRequest.CacheClusterEnabled);
                }

                if(publicRequest.IsSetCacheClusterSize())
                {
                    context.Writer.WritePropertyName("cacheClusterSize");
                    context.Writer.Write(publicRequest.CacheClusterSize);
                }

                if(publicRequest.IsSetCanarySettings())
                {
                    context.Writer.WritePropertyName("canarySettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = CanarySettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CanarySettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDeploymentId())
                {
                    context.Writer.WritePropertyName("deploymentId");
                    context.Writer.Write(publicRequest.DeploymentId);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDocumentationVersion())
                {
                    context.Writer.WritePropertyName("documentationVersion");
                    context.Writer.Write(publicRequest.DocumentationVersion);
                }

                if(publicRequest.IsSetStageName())
                {
                    context.Writer.WritePropertyName("stageName");
                    context.Writer.Write(publicRequest.StageName);
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

                if(publicRequest.IsSetVariables())
                {
                    context.Writer.WritePropertyName("variables");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestVariablesKvp in publicRequest.Variables)
                    {
                        context.Writer.WritePropertyName(publicRequestVariablesKvp.Key);
                        var publicRequestVariablesValue = publicRequestVariablesKvp.Value;

                            context.Writer.Write(publicRequestVariablesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateStageRequestMarshaller _instance = new CreateStageRequestMarshaller();        

        internal static CreateStageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateStageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}