/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchUnsuspendUser Request Marshaller
    /// </summary>       
    public class BatchUnsuspendUserRequestMarshaller : IMarshaller<IRequest, BatchUnsuspendUserRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchUnsuspendUserRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchUnsuspendUserRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chime");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/console/accounts/{accountId}/users";
            request.AddSubResource("operation", "unsuspend");
            if (!publicRequest.IsSetAccountId())
                throw new AmazonChimeException("Request object does not have required field AccountId set");
            uriResourcePath = uriResourcePath.Replace("{accountId}", StringUtils.FromStringWithSlashEncoding(publicRequest.AccountId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetUserIdList())
                {
                    context.Writer.WritePropertyName("UserIdList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUserIdListListValue in publicRequest.UserIdList)
                    {
                            context.Writer.Write(publicRequestUserIdListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static BatchUnsuspendUserRequestMarshaller _instance = new BatchUnsuspendUserRequestMarshaller();        

        internal static BatchUnsuspendUserRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchUnsuspendUserRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}