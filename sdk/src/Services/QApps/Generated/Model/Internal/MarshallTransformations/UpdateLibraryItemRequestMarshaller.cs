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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QApps.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QApps.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLibraryItem Request Marshaller
    /// </summary>       
    public class UpdateLibraryItemRequestMarshaller : IMarshaller<IRequest, UpdateLibraryItemRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLibraryItemRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLibraryItemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QApps");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/catalog.updateItem";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCategories())
                {
                    context.Writer.WritePropertyName("categories");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCategoriesListValue in publicRequest.Categories)
                    {
                            context.Writer.Write(publicRequestCategoriesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLibraryItemId())
                {
                    context.Writer.WritePropertyName("libraryItemId");
                    context.Writer.Write(publicRequest.LibraryItemId);
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("status");
                    context.Writer.Write(publicRequest.Status);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if (publicRequest.IsSetInstanceId()) 
            {
                request.Headers["instance-id"] = publicRequest.InstanceId;
            }

            return request;
        }
        private static UpdateLibraryItemRequestMarshaller _instance = new UpdateLibraryItemRequestMarshaller();        

        internal static UpdateLibraryItemRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLibraryItemRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}