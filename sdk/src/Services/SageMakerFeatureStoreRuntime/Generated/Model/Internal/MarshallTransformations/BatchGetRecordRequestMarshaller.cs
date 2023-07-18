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
 * Do not modify this file. This file is generated from the sagemaker-featurestore-runtime-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerFeatureStoreRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMakerFeatureStoreRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchGetRecord Request Marshaller
    /// </summary>       
    public class BatchGetRecordRequestMarshaller : IMarshaller<IRequest, BatchGetRecordRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchGetRecordRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchGetRecordRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMakerFeatureStoreRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/BatchGetRecord";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetExpirationTimeResponse())
                {
                    context.Writer.WritePropertyName("ExpirationTimeResponse");
                    context.Writer.Write(publicRequest.ExpirationTimeResponse);
                }

                if(publicRequest.IsSetIdentifiers())
                {
                    context.Writer.WritePropertyName("Identifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIdentifiersListValue in publicRequest.Identifiers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BatchGetRecordIdentifierMarshaller.Instance;
                        marshaller.Marshall(publicRequestIdentifiersListValue, context);

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
        private static BatchGetRecordRequestMarshaller _instance = new BatchGetRecordRequestMarshaller();        

        internal static BatchGetRecordRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchGetRecordRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}