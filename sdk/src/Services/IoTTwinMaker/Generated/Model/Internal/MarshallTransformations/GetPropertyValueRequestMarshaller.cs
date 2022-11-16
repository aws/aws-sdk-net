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
    /// GetPropertyValue Request Marshaller
    /// </summary>       
    public class GetPropertyValueRequestMarshaller : IMarshaller<IRequest, GetPropertyValueRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetPropertyValueRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetPropertyValueRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTTwinMaker");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-11-29";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetWorkspaceId())
                throw new AmazonIoTTwinMakerException("Request object does not have required field WorkspaceId set");
            request.AddPathResource("{workspaceId}", StringUtils.FromString(publicRequest.WorkspaceId));
            request.ResourcePath = "/workspaces/{workspaceId}/entity-properties/value";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComponentName())
                {
                    context.Writer.WritePropertyName("componentName");
                    context.Writer.Write(publicRequest.ComponentName);
                }

                if(publicRequest.IsSetComponentTypeId())
                {
                    context.Writer.WritePropertyName("componentTypeId");
                    context.Writer.Write(publicRequest.ComponentTypeId);
                }

                if(publicRequest.IsSetEntityId())
                {
                    context.Writer.WritePropertyName("entityId");
                    context.Writer.Write(publicRequest.EntityId);
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetPropertyGroupName())
                {
                    context.Writer.WritePropertyName("propertyGroupName");
                    context.Writer.Write(publicRequest.PropertyGroupName);
                }

                if(publicRequest.IsSetSelectedProperties())
                {
                    context.Writer.WritePropertyName("selectedProperties");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSelectedPropertiesListValue in publicRequest.SelectedProperties)
                    {
                            context.Writer.Write(publicRequestSelectedPropertiesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTabularConditions())
                {
                    context.Writer.WritePropertyName("tabularConditions");
                    context.Writer.WriteObjectStart();

                    var marshaller = TabularConditionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TabularConditions, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"data.";

            return request;
        }
        private static GetPropertyValueRequestMarshaller _instance = new GetPropertyValueRequestMarshaller();        

        internal static GetPropertyValueRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetPropertyValueRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}