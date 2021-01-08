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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLinkAttributes Request Marshaller
    /// </summary>       
    public class UpdateLinkAttributesRequestMarshaller : IMarshaller<IRequest, UpdateLinkAttributesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLinkAttributesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLinkAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudDirectory");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-01-11";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/amazonclouddirectory/2017-01-11/typedlink/attributes/update";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttributeUpdates())
                {
                    context.Writer.WritePropertyName("AttributeUpdates");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAttributeUpdatesListValue in publicRequest.AttributeUpdates)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = LinkAttributeUpdateMarshaller.Instance;
                        marshaller.Marshall(publicRequestAttributeUpdatesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTypedLinkSpecifier())
                {
                    context.Writer.WritePropertyName("TypedLinkSpecifier");
                    context.Writer.WriteObjectStart();

                    var marshaller = TypedLinkSpecifierMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TypedLinkSpecifier, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if(publicRequest.IsSetDirectoryArn())
                request.Headers["x-amz-data-partition"] = publicRequest.DirectoryArn;

            return request;
        }
        private static UpdateLinkAttributesRequestMarshaller _instance = new UpdateLinkAttributesRequestMarshaller();        

        internal static UpdateLinkAttributesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLinkAttributesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}