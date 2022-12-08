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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTTwinMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateComponentType Request Marshaller
    /// </summary>       
    public class UpdateComponentTypeRequestMarshaller : IMarshaller<IRequest, UpdateComponentTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateComponentTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateComponentTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTTwinMaker");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-11-29";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetComponentTypeId())
                throw new AmazonIoTTwinMakerException("Request object does not have required field ComponentTypeId set");
            request.AddPathResource("{componentTypeId}", StringUtils.FromString(publicRequest.ComponentTypeId));
            if (!publicRequest.IsSetWorkspaceId())
                throw new AmazonIoTTwinMakerException("Request object does not have required field WorkspaceId set");
            request.AddPathResource("{workspaceId}", StringUtils.FromString(publicRequest.WorkspaceId));
            request.ResourcePath = "/workspaces/{workspaceId}/component-types/{componentTypeId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComponentTypeName())
                {
                    context.Writer.WritePropertyName("componentTypeName");
                    context.Writer.Write(publicRequest.ComponentTypeName);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetExtendsFrom())
                {
                    context.Writer.WritePropertyName("extendsFrom");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestExtendsFromListValue in publicRequest.ExtendsFrom)
                    {
                            context.Writer.Write(publicRequestExtendsFromListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFunctions())
                {
                    context.Writer.WritePropertyName("functions");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestFunctionsKvp in publicRequest.Functions)
                    {
                        context.Writer.WritePropertyName(publicRequestFunctionsKvp.Key);
                        var publicRequestFunctionsValue = publicRequestFunctionsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = FunctionRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestFunctionsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIsSingleton())
                {
                    context.Writer.WritePropertyName("isSingleton");
                    context.Writer.Write(publicRequest.IsSingleton);
                }

                if(publicRequest.IsSetPropertyDefinitions())
                {
                    context.Writer.WritePropertyName("propertyDefinitions");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestPropertyDefinitionsKvp in publicRequest.PropertyDefinitions)
                    {
                        context.Writer.WritePropertyName(publicRequestPropertyDefinitionsKvp.Key);
                        var publicRequestPropertyDefinitionsValue = publicRequestPropertyDefinitionsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = PropertyDefinitionRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestPropertyDefinitionsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPropertyGroups())
                {
                    context.Writer.WritePropertyName("propertyGroups");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestPropertyGroupsKvp in publicRequest.PropertyGroups)
                    {
                        context.Writer.WritePropertyName(publicRequestPropertyGroupsKvp.Key);
                        var publicRequestPropertyGroupsValue = publicRequestPropertyGroupsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = PropertyGroupRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestPropertyGroupsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"api.";

            return request;
        }
        private static UpdateComponentTypeRequestMarshaller _instance = new UpdateComponentTypeRequestMarshaller();        

        internal static UpdateComponentTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateComponentTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}