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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralBenefits.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralBenefits.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AmendBenefitApplication Request Marshaller
    /// </summary>       
    public class AmendBenefitApplicationRequestMarshaller : IMarshaller<IRequest, AmendBenefitApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AmendBenefitApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AmendBenefitApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralBenefits");
            string target = "PartnerCentralBenefitsService.AmendBenefitApplication";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAmendmentReason())
                {
                    context.Writer.WritePropertyName("AmendmentReason");
                    context.Writer.Write(publicRequest.AmendmentReason);
                }

                if(publicRequest.IsSetAmendments())
                {
                    context.Writer.WritePropertyName("Amendments");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAmendmentsListValue in publicRequest.Amendments)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AmendmentMarshaller.Instance;
                        marshaller.Marshall(publicRequestAmendmentsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCatalog())
                {
                    context.Writer.WritePropertyName("Catalog");
                    context.Writer.Write(publicRequest.Catalog);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                if(publicRequest.IsSetIdentifier())
                {
                    context.Writer.WritePropertyName("Identifier");
                    context.Writer.Write(publicRequest.Identifier);
                }

                if(publicRequest.IsSetRevision())
                {
                    context.Writer.WritePropertyName("Revision");
                    context.Writer.Write(publicRequest.Revision);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static AmendBenefitApplicationRequestMarshaller _instance = new AmendBenefitApplicationRequestMarshaller();        

        internal static AmendBenefitApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AmendBenefitApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}