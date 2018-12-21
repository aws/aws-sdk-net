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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Macie.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateS3Resources Request Marshaller
    /// </summary>       
    public class UpdateS3ResourcesRequestMarshaller : IMarshaller<IRequest, UpdateS3ResourcesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateS3ResourcesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateS3ResourcesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Macie");
            string target = "MacieService.UpdateS3Resources";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-12-19";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetMemberAccountId())
                {
                    context.Writer.WritePropertyName("memberAccountId");
                    context.Writer.Write(publicRequest.MemberAccountId);
                }

                if(publicRequest.IsSetS3ResourcesUpdate())
                {
                    context.Writer.WritePropertyName("s3ResourcesUpdate");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestS3ResourcesUpdateListValue in publicRequest.S3ResourcesUpdate)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = S3ResourceClassificationUpdateMarshaller.Instance;
                        marshaller.Marshall(publicRequestS3ResourcesUpdateListValue, context);

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
        private static UpdateS3ResourcesRequestMarshaller _instance = new UpdateS3ResourcesRequestMarshaller();        

        internal static UpdateS3ResourcesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateS3ResourcesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}