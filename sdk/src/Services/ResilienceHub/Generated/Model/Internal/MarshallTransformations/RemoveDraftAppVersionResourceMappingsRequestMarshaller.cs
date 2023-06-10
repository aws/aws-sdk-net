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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemoveDraftAppVersionResourceMappings Request Marshaller
    /// </summary>       
    public class RemoveDraftAppVersionResourceMappingsRequestMarshaller : IMarshaller<IRequest, RemoveDraftAppVersionResourceMappingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RemoveDraftAppVersionResourceMappingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RemoveDraftAppVersionResourceMappingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResilienceHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-04-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/remove-draft-app-version-resource-mappings";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAppArn())
                {
                    context.Writer.WritePropertyName("appArn");
                    context.Writer.Write(publicRequest.AppArn);
                }

                if(publicRequest.IsSetAppRegistryAppNames())
                {
                    context.Writer.WritePropertyName("appRegistryAppNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAppRegistryAppNamesListValue in publicRequest.AppRegistryAppNames)
                    {
                            context.Writer.Write(publicRequestAppRegistryAppNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEksSourceNames())
                {
                    context.Writer.WritePropertyName("eksSourceNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEksSourceNamesListValue in publicRequest.EksSourceNames)
                    {
                            context.Writer.Write(publicRequestEksSourceNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLogicalStackNames())
                {
                    context.Writer.WritePropertyName("logicalStackNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLogicalStackNamesListValue in publicRequest.LogicalStackNames)
                    {
                            context.Writer.Write(publicRequestLogicalStackNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetResourceGroupNames())
                {
                    context.Writer.WritePropertyName("resourceGroupNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourceGroupNamesListValue in publicRequest.ResourceGroupNames)
                    {
                            context.Writer.Write(publicRequestResourceGroupNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetResourceNames())
                {
                    context.Writer.WritePropertyName("resourceNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourceNamesListValue in publicRequest.ResourceNames)
                    {
                            context.Writer.Write(publicRequestResourceNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTerraformSourceNames())
                {
                    context.Writer.WritePropertyName("terraformSourceNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTerraformSourceNamesListValue in publicRequest.TerraformSourceNames)
                    {
                            context.Writer.Write(publicRequestTerraformSourceNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RemoveDraftAppVersionResourceMappingsRequestMarshaller _instance = new RemoveDraftAppVersionResourceMappingsRequestMarshaller();        

        internal static RemoveDraftAppVersionResourceMappingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RemoveDraftAppVersionResourceMappingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}