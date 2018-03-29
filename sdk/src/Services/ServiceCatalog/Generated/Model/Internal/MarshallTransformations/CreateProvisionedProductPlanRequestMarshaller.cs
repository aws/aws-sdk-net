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
    /// CreateProvisionedProductPlan Request Marshaller
    /// </summary>       
    public class CreateProvisionedProductPlanRequestMarshaller : IMarshaller<IRequest, CreateProvisionedProductPlanRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProvisionedProductPlanRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateProvisionedProductPlanRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceCatalog");
            string target = "AWS242ServiceCatalogService.CreateProvisionedProductPlan";
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
                if(publicRequest.IsSetNotificationArns())
                {
                    context.Writer.WritePropertyName("NotificationArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNotificationArnsListValue in publicRequest.NotificationArns)
                    {
                            context.Writer.Write(publicRequestNotificationArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPathId())
                {
                    context.Writer.WritePropertyName("PathId");
                    context.Writer.Write(publicRequest.PathId);
                }

                if(publicRequest.IsSetPlanName())
                {
                    context.Writer.WritePropertyName("PlanName");
                    context.Writer.Write(publicRequest.PlanName);
                }

                if(publicRequest.IsSetPlanType())
                {
                    context.Writer.WritePropertyName("PlanType");
                    context.Writer.Write(publicRequest.PlanType);
                }

                if(publicRequest.IsSetProductId())
                {
                    context.Writer.WritePropertyName("ProductId");
                    context.Writer.Write(publicRequest.ProductId);
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

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

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
        private static CreateProvisionedProductPlanRequestMarshaller _instance = new CreateProvisionedProductPlanRequestMarshaller();        

        internal static CreateProvisionedProductPlanRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateProvisionedProductPlanRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}