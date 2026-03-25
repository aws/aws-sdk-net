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
 * Do not modify this file. This file is generated from the uxc-2024-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Uxc.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Uxc.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAccountCustomizations Request Marshaller
    /// </summary>       
    public class UpdateAccountCustomizationsRequestMarshaller : IMarshaller<IRequest, UpdateAccountCustomizationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAccountCustomizationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAccountCustomizationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Uxc");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-07-01";
            request.HttpMethod = "PATCH";

            request.ResourcePath = "/v1/account-customizations";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountColor())
                {
                    context.Writer.WritePropertyName("accountColor");
                    context.Writer.Write(publicRequest.AccountColor);
                }

                if(publicRequest.IsSetVisibleRegions())
                {
                    context.Writer.WritePropertyName("visibleRegions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestVisibleRegionsListValue in publicRequest.VisibleRegions)
                    {
                            context.Writer.Write(publicRequestVisibleRegionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetVisibleServices())
                {
                    context.Writer.WritePropertyName("visibleServices");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestVisibleServicesListValue in publicRequest.VisibleServices)
                    {
                            context.Writer.Write(publicRequestVisibleServicesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAccountCustomizationsRequestMarshaller _instance = new UpdateAccountCustomizationsRequestMarshaller();        

        internal static UpdateAccountCustomizationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAccountCustomizationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}