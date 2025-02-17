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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SupplyChain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SupplyChain.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataIntegrationFlow Request Marshaller
    /// </summary>       
    public class CreateDataIntegrationFlowRequestMarshaller : IMarshaller<IRequest, CreateDataIntegrationFlowRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDataIntegrationFlowRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDataIntegrationFlowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SupplyChain");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-01-01";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetInstanceId())
                throw new AmazonSupplyChainException("Request object does not have required field InstanceId set");
            request.AddPathResource("{instanceId}", StringUtils.FromString(publicRequest.InstanceId));
            if (!publicRequest.IsSetName())
                throw new AmazonSupplyChainException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/api/data-integration/instance/{instanceId}/data-integration-flows/{name}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetSources())
                {
                    context.Writer.WritePropertyName("sources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourcesListValue in publicRequest.Sources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DataIntegrationFlowSourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestSourcesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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

                if(publicRequest.IsSetTarget())
                {
                    context.Writer.WritePropertyName("target");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataIntegrationFlowTargetMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Target, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTransformation())
                {
                    context.Writer.WritePropertyName("transformation");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataIntegrationFlowTransformationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Transformation, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateDataIntegrationFlowRequestMarshaller _instance = new CreateDataIntegrationFlowRequestMarshaller();        

        internal static CreateDataIntegrationFlowRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDataIntegrationFlowRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}