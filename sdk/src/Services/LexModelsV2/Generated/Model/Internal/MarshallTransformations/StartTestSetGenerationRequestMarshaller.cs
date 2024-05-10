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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartTestSetGeneration Request Marshaller
    /// </summary>       
    public class StartTestSetGenerationRequestMarshaller : IMarshaller<IRequest, StartTestSetGenerationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartTestSetGenerationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartTestSetGenerationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelsV2");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-07";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/testsetgenerations";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetGenerationDataSource())
                {
                    context.Writer.WritePropertyName("generationDataSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = TestSetGenerationDataSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GenerationDataSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetStorageLocation())
                {
                    context.Writer.WritePropertyName("storageLocation");
                    context.Writer.WriteObjectStart();

                    var marshaller = TestSetStorageLocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StorageLocation, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTestSetName())
                {
                    context.Writer.WritePropertyName("testSetName");
                    context.Writer.Write(publicRequest.TestSetName);
                }

                if(publicRequest.IsSetTestSetTags())
                {
                    context.Writer.WritePropertyName("testSetTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTestSetTagsKvp in publicRequest.TestSetTags)
                    {
                        context.Writer.WritePropertyName(publicRequestTestSetTagsKvp.Key);
                        var publicRequestTestSetTagsValue = publicRequestTestSetTagsKvp.Value;

                            context.Writer.Write(publicRequestTestSetTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartTestSetGenerationRequestMarshaller _instance = new StartTestSetGenerationRequestMarshaller();        

        internal static StartTestSetGenerationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartTestSetGenerationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}