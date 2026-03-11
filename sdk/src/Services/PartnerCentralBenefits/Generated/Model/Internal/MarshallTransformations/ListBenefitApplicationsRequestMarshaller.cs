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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralBenefits.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListBenefitApplications Request Marshaller
    /// </summary>       
    public class ListBenefitApplicationsRequestMarshaller : IMarshaller<IRequest, ListBenefitApplicationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListBenefitApplicationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListBenefitApplicationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralBenefits");
            string target = "PartnerCentralBenefitsService.ListBenefitApplications";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAssociatedResourceArns())
            {
                context.Writer.WritePropertyName("AssociatedResourceArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAssociatedResourceArnsListValue in publicRequest.AssociatedResourceArns)
                {
                        context.Writer.WriteStringValue(publicRequestAssociatedResourceArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAssociatedResources())
            {
                context.Writer.WritePropertyName("AssociatedResources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAssociatedResourcesListValue in publicRequest.AssociatedResources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssociatedResourceMarshaller.Instance;
                    marshaller.Marshall(publicRequestAssociatedResourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetBenefitIdentifiers())
            {
                context.Writer.WritePropertyName("BenefitIdentifiers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestBenefitIdentifiersListValue in publicRequest.BenefitIdentifiers)
                {
                        context.Writer.WriteStringValue(publicRequestBenefitIdentifiersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCatalog())
            {
                context.Writer.WritePropertyName("Catalog");
                context.Writer.WriteStringValue(publicRequest.Catalog);
            }

            if(publicRequest.IsSetFulfillmentTypes())
            {
                context.Writer.WritePropertyName("FulfillmentTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFulfillmentTypesListValue in publicRequest.FulfillmentTypes)
                {
                        context.Writer.WriteStringValue(publicRequestFulfillmentTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetPrograms())
            {
                context.Writer.WritePropertyName("Programs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestProgramsListValue in publicRequest.Programs)
                {
                        context.Writer.WriteStringValue(publicRequestProgramsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStages())
            {
                context.Writer.WritePropertyName("Stages");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStagesListValue in publicRequest.Stages)
                {
                        context.Writer.WriteStringValue(publicRequestStagesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStatusListValue in publicRequest.Status)
                {
                        context.Writer.WriteStringValue(publicRequestStatusListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static ListBenefitApplicationsRequestMarshaller _instance = new ListBenefitApplicationsRequestMarshaller();        

        internal static ListBenefitApplicationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListBenefitApplicationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}