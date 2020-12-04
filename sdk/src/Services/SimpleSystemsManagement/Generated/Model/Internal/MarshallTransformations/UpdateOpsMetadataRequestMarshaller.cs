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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateOpsMetadata Request Marshaller
    /// </summary>       
    public class UpdateOpsMetadataRequestMarshaller : IMarshaller<IRequest, UpdateOpsMetadataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateOpsMetadataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateOpsMetadataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleSystemsManagement");
            string target = "AmazonSSM.UpdateOpsMetadata";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-06";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetKeysToDelete())
                {
                    context.Writer.WritePropertyName("KeysToDelete");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestKeysToDeleteListValue in publicRequest.KeysToDelete)
                    {
                            context.Writer.Write(publicRequestKeysToDeleteListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMetadataToUpdate())
                {
                    context.Writer.WritePropertyName("MetadataToUpdate");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestMetadataToUpdateKvp in publicRequest.MetadataToUpdate)
                    {
                        context.Writer.WritePropertyName(publicRequestMetadataToUpdateKvp.Key);
                        var publicRequestMetadataToUpdateValue = publicRequestMetadataToUpdateKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = MetadataValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestMetadataToUpdateValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOpsMetadataArn())
                {
                    context.Writer.WritePropertyName("OpsMetadataArn");
                    context.Writer.Write(publicRequest.OpsMetadataArn);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateOpsMetadataRequestMarshaller _instance = new UpdateOpsMetadataRequestMarshaller();        

        internal static UpdateOpsMetadataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateOpsMetadataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}