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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MemoryDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MemoryDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateACL Request Marshaller
    /// </summary>       
    public class UpdateACLRequestMarshaller : IMarshaller<IRequest, UpdateACLRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateACLRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateACLRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MemoryDB");
            string target = "AmazonMemoryDB.UpdateACL";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetACLName())
                {
                    context.Writer.WritePropertyName("ACLName");
                    context.Writer.Write(publicRequest.ACLName);
                }

                if(publicRequest.IsSetUserNamesToAdd())
                {
                    context.Writer.WritePropertyName("UserNamesToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUserNamesToAddListValue in publicRequest.UserNamesToAdd)
                    {
                            context.Writer.Write(publicRequestUserNamesToAddListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUserNamesToRemove())
                {
                    context.Writer.WritePropertyName("UserNamesToRemove");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUserNamesToRemoveListValue in publicRequest.UserNamesToRemove)
                    {
                            context.Writer.Write(publicRequestUserNamesToRemoveListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateACLRequestMarshaller _instance = new UpdateACLRequestMarshaller();        

        internal static UpdateACLRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateACLRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}