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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceAgreement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceAgreement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAgreementRequest Request Marshaller
    /// </summary>       
    public class CreateAgreementRequestRequestMarshaller : IMarshaller<IRequest, CreateAgreementRequestRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAgreementRequestRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAgreementRequestRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MarketplaceAgreement");
            string target = "AWSMPCommerceService_v20200301.CreateAgreementRequest";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAgreementProposalIdentifier())
            {
                context.Writer.WritePropertyName("agreementProposalIdentifier");
                context.Writer.WriteStringValue(publicRequest.AgreementProposalIdentifier);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetIntent())
            {
                context.Writer.WritePropertyName("intent");
                context.Writer.WriteStringValue(publicRequest.Intent);
            }

            if(publicRequest.IsSetRequestedTerms())
            {
                context.Writer.WritePropertyName("requestedTerms");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRequestedTermsListValue in publicRequest.RequestedTerms)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RequestedTermMarshaller.Instance;
                    marshaller.Marshall(publicRequestRequestedTermsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSourceAgreementIdentifier())
            {
                context.Writer.WritePropertyName("sourceAgreementIdentifier");
                context.Writer.WriteStringValue(publicRequest.SourceAgreementIdentifier);
            }

            if(publicRequest.IsSetTaxConfiguration())
            {
                context.Writer.WritePropertyName("taxConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TaxConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.TaxConfiguration, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateAgreementRequestRequestMarshaller _instance = new CreateAgreementRequestRequestMarshaller();        

        internal static CreateAgreementRequestRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAgreementRequestRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}