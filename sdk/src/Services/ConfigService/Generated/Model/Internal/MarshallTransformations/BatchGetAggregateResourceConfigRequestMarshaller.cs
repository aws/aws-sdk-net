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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchGetAggregateResourceConfig Request Marshaller
    /// </summary>       
    public class BatchGetAggregateResourceConfigRequestMarshaller : IMarshaller<IRequest, BatchGetAggregateResourceConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchGetAggregateResourceConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchGetAggregateResourceConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConfigService");
            string target = "StarlingDoveService.BatchGetAggregateResourceConfig";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-12";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConfigurationAggregatorName())
                {
                    context.Writer.WritePropertyName("ConfigurationAggregatorName");
                    context.Writer.Write(publicRequest.ConfigurationAggregatorName);
                }

                if(publicRequest.IsSetResourceIdentifiers())
                {
                    context.Writer.WritePropertyName("ResourceIdentifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourceIdentifiersListValue in publicRequest.ResourceIdentifiers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AggregateResourceIdentifierMarshaller.Instance;
                        marshaller.Marshall(publicRequestResourceIdentifiersListValue, context);

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
        private static BatchGetAggregateResourceConfigRequestMarshaller _instance = new BatchGetAggregateResourceConfigRequestMarshaller();        

        internal static BatchGetAggregateResourceConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchGetAggregateResourceConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}