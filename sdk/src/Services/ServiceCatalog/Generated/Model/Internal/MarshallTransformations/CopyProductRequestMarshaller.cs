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
    /// CopyProduct Request Marshaller
    /// </summary>       
    public class CopyProductRequestMarshaller : IMarshaller<IRequest, CopyProductRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CopyProductRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CopyProductRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceCatalog");
            string target = "AWS242ServiceCatalogService.CopyProduct";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-12-10";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
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

                if(publicRequest.IsSetCopyOptions())
                {
                    context.Writer.WritePropertyName("CopyOptions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCopyOptionsListValue in publicRequest.CopyOptions)
                    {
                            context.Writer.Write(publicRequestCopyOptionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIdempotencyToken())
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(publicRequest.IdempotencyToken);
                }

                else if(!(publicRequest.IsSetIdempotencyToken()))
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetSourceProductArn())
                {
                    context.Writer.WritePropertyName("SourceProductArn");
                    context.Writer.Write(publicRequest.SourceProductArn);
                }

                if(publicRequest.IsSetSourceProvisioningArtifactIdentifiers())
                {
                    context.Writer.WritePropertyName("SourceProvisioningArtifactIdentifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourceProvisioningArtifactIdentifiersListValue in publicRequest.SourceProvisioningArtifactIdentifiers)
                    {
                        context.Writer.WriteObjectStart();
                        foreach (var publicRequestSourceProvisioningArtifactIdentifiersListValueKvp in publicRequestSourceProvisioningArtifactIdentifiersListValue)
                        {
                            context.Writer.WritePropertyName(publicRequestSourceProvisioningArtifactIdentifiersListValueKvp.Key);
                            var publicRequestSourceProvisioningArtifactIdentifiersListValueValue = publicRequestSourceProvisioningArtifactIdentifiersListValueKvp.Value;

                                context.Writer.Write(publicRequestSourceProvisioningArtifactIdentifiersListValueValue);
                        }
                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTargetProductId())
                {
                    context.Writer.WritePropertyName("TargetProductId");
                    context.Writer.Write(publicRequest.TargetProductId);
                }

                if(publicRequest.IsSetTargetProductName())
                {
                    context.Writer.WritePropertyName("TargetProductName");
                    context.Writer.Write(publicRequest.TargetProductName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CopyProductRequestMarshaller _instance = new CopyProductRequestMarshaller();        

        internal static CopyProductRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CopyProductRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}