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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServiceCatalog.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServiceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateProvisionedProduct Request Marshaller
    /// </summary>       
    public class UpdateProvisionedProductRequestMarshaller : IMarshaller<IRequest, UpdateProvisionedProductRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateProvisionedProductRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateProvisionedProductRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceCatalog");
            string target = "AWS242ServiceCatalogService.UpdateProvisionedProduct";
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
                if(publicRequest.IsSetAcceptLanguage())
                {
                    context.Writer.WritePropertyName("AcceptLanguage");
                    context.Writer.Write(publicRequest.AcceptLanguage);
                }

                if(publicRequest.IsSetPathId())
                {
                    context.Writer.WritePropertyName("PathId");
                    context.Writer.Write(publicRequest.PathId);
                }

                if(publicRequest.IsSetProductId())
                {
                    context.Writer.WritePropertyName("ProductId");
                    context.Writer.Write(publicRequest.ProductId);
                }

                if(publicRequest.IsSetProvisionedProductId())
                {
                    context.Writer.WritePropertyName("ProvisionedProductId");
                    context.Writer.Write(publicRequest.ProvisionedProductId);
                }

                if(publicRequest.IsSetProvisionedProductName())
                {
                    context.Writer.WritePropertyName("ProvisionedProductName");
                    context.Writer.Write(publicRequest.ProvisionedProductName);
                }

                if(publicRequest.IsSetProvisioningArtifactId())
                {
                    context.Writer.WritePropertyName("ProvisioningArtifactId");
                    context.Writer.Write(publicRequest.ProvisioningArtifactId);
                }

                if(publicRequest.IsSetProvisioningParameters())
                {
                    context.Writer.WritePropertyName("ProvisioningParameters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestProvisioningParametersListValue in publicRequest.ProvisioningParameters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = UpdateProvisioningParameterMarshaller.Instance;
                        marshaller.Marshall(publicRequestProvisioningParametersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUpdateToken())
                {
                    context.Writer.WritePropertyName("UpdateToken");
                    context.Writer.Write(publicRequest.UpdateToken);
                }

                else if(!(publicRequest.IsSetUpdateToken()))
                {
                    context.Writer.WritePropertyName("UpdateToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateProvisionedProductRequestMarshaller _instance = new UpdateProvisionedProductRequestMarshaller();        

        internal static UpdateProvisionedProductRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateProvisionedProductRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}