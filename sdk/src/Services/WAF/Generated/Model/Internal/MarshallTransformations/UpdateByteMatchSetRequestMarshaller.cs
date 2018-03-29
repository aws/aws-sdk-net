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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAF.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WAF.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateByteMatchSet Request Marshaller
    /// </summary>       
    public class UpdateByteMatchSetRequestMarshaller : IMarshaller<IRequest, UpdateByteMatchSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateByteMatchSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateByteMatchSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WAF");
            string target = "AWSWAF_20150824.UpdateByteMatchSet";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetByteMatchSetId())
                {
                    context.Writer.WritePropertyName("ByteMatchSetId");
                    context.Writer.Write(publicRequest.ByteMatchSetId);
                }

                if(publicRequest.IsSetChangeToken())
                {
                    context.Writer.WritePropertyName("ChangeToken");
                    context.Writer.Write(publicRequest.ChangeToken);
                }

                if(publicRequest.IsSetUpdates())
                {
                    context.Writer.WritePropertyName("Updates");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUpdatesListValue in publicRequest.Updates)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ByteMatchSetUpdateMarshaller.Instance;
                        marshaller.Marshall(publicRequestUpdatesListValue, context);

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
        private static UpdateByteMatchSetRequestMarshaller _instance = new UpdateByteMatchSetRequestMarshaller();        

        internal static UpdateByteMatchSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateByteMatchSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}