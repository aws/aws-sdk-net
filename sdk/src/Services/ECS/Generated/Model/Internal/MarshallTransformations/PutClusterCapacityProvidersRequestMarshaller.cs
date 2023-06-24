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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutClusterCapacityProviders Request Marshaller
    /// </summary>       
    public class PutClusterCapacityProvidersRequestMarshaller : IMarshaller<IRequest, PutClusterCapacityProvidersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutClusterCapacityProvidersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutClusterCapacityProvidersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECS");
            string target = "AmazonEC2ContainerServiceV20141113.PutClusterCapacityProviders";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-13";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCapacityProviders())
                {
                    context.Writer.WritePropertyName("capacityProviders");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCapacityProvidersListValue in publicRequest.CapacityProviders)
                    {
                            context.Writer.Write(publicRequestCapacityProvidersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCluster())
                {
                    context.Writer.WritePropertyName("cluster");
                    context.Writer.Write(publicRequest.Cluster);
                }

                if(publicRequest.IsSetDefaultCapacityProviderStrategy())
                {
                    context.Writer.WritePropertyName("defaultCapacityProviderStrategy");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDefaultCapacityProviderStrategyListValue in publicRequest.DefaultCapacityProviderStrategy)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CapacityProviderStrategyItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestDefaultCapacityProviderStrategyListValue, context);

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
        private static PutClusterCapacityProvidersRequestMarshaller _instance = new PutClusterCapacityProvidersRequestMarshaller();        

        internal static PutClusterCapacityProvidersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutClusterCapacityProvidersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}