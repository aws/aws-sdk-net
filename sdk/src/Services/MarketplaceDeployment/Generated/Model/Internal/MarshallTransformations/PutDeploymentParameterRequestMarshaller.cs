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
 * Do not modify this file. This file is generated from the marketplace-deployment-2023-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceDeployment.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceDeployment.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutDeploymentParameter Request Marshaller
    /// </summary>       
    public class PutDeploymentParameterRequestMarshaller : IMarshaller<IRequest, PutDeploymentParameterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutDeploymentParameterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutDeploymentParameterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MarketplaceDeployment");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-01-25";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetCatalog())
                throw new AmazonMarketplaceDeploymentException("Request object does not have required field Catalog set");
            request.AddPathResource("{catalog}", StringUtils.FromString(publicRequest.Catalog));
            if (!publicRequest.IsSetProductId())
                throw new AmazonMarketplaceDeploymentException("Request object does not have required field ProductId set");
            request.AddPathResource("{productId}", StringUtils.FromString(publicRequest.ProductId));
            request.ResourcePath = "/catalogs/{catalog}/products/{productId}/deployment-parameters";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAgreementId())
                {
                    context.Writer.WritePropertyName("agreementId");
                    context.Writer.Write(publicRequest.AgreementId);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDeploymentParameter())
                {
                    context.Writer.WritePropertyName("deploymentParameter");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeploymentParameterInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeploymentParameter, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExpirationDate())
                {
                    context.Writer.WritePropertyName("expirationDate");
                    context.Writer.Write(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ExpirationDate));
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutDeploymentParameterRequestMarshaller _instance = new PutDeploymentParameterRequestMarshaller();        

        internal static PutDeploymentParameterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutDeploymentParameterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}