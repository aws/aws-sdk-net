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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MainframeModernization.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MainframeModernization.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartBatchJob Request Marshaller
    /// </summary>       
    public class StartBatchJobRequestMarshaller : IMarshaller<IRequest, StartBatchJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartBatchJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartBatchJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MainframeModernization");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-04-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonMainframeModernizationException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            request.ResourcePath = "/applications/{applicationId}/batch-job";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthSecretsManagerArn())
                {
                    context.Writer.WritePropertyName("authSecretsManagerArn");
                    context.Writer.Write(publicRequest.AuthSecretsManagerArn);
                }

                if(publicRequest.IsSetBatchJobIdentifier())
                {
                    context.Writer.WritePropertyName("batchJobIdentifier");
                    context.Writer.WriteObjectStart();

                    var marshaller = BatchJobIdentifierMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BatchJobIdentifier, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetJobParams())
                {
                    context.Writer.WritePropertyName("jobParams");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestJobParamsKvp in publicRequest.JobParams)
                    {
                        context.Writer.WritePropertyName(publicRequestJobParamsKvp.Key);
                        var publicRequestJobParamsValue = publicRequestJobParamsKvp.Value;

                            context.Writer.Write(publicRequestJobParamsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartBatchJobRequestMarshaller _instance = new StartBatchJobRequestMarshaller();        

        internal static StartBatchJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartBatchJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}