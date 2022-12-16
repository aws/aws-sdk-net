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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListConnectorEntities Request Marshaller
    /// </summary>       
    public class ListConnectorEntitiesRequestMarshaller : IMarshaller<IRequest, ListConnectorEntitiesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListConnectorEntitiesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListConnectorEntitiesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Appflow");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-23";
            request.HttpMethod = "POST";

            request.ResourcePath = "/list-connector-entities";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApiVersion())
                {
                    context.Writer.WritePropertyName("apiVersion");
                    context.Writer.Write(publicRequest.ApiVersion);
                }

                if(publicRequest.IsSetConnectorProfileName())
                {
                    context.Writer.WritePropertyName("connectorProfileName");
                    context.Writer.Write(publicRequest.ConnectorProfileName);
                }

                if(publicRequest.IsSetConnectorType())
                {
                    context.Writer.WritePropertyName("connectorType");
                    context.Writer.Write(publicRequest.ConnectorType);
                }

                if(publicRequest.IsSetEntitiesPath())
                {
                    context.Writer.WritePropertyName("entitiesPath");
                    context.Writer.Write(publicRequest.EntitiesPath);
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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListConnectorEntitiesRequestMarshaller _instance = new ListConnectorEntitiesRequestMarshaller();        

        internal static ListConnectorEntitiesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListConnectorEntitiesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}