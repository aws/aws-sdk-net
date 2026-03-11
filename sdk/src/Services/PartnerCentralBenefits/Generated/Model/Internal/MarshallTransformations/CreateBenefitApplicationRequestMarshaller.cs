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
    /// CreateBenefitApplication Request Marshaller
    /// </summary>       
    public class CreateBenefitApplicationRequestMarshaller : IMarshaller<IRequest, CreateBenefitApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBenefitApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBenefitApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralBenefits");
            string target = "PartnerCentralBenefitsService.CreateBenefitApplication";
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
            if(publicRequest.IsSetAssociatedResources())
            {
                context.Writer.WritePropertyName("AssociatedResources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAssociatedResourcesListValue in publicRequest.AssociatedResources)
                {
                        context.Writer.WriteStringValue(publicRequestAssociatedResourcesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetBenefitApplicationDetails())
            {
                context.Writer.WritePropertyName("BenefitApplicationDetails");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, publicRequest.BenefitApplicationDetails);
            }

            if(publicRequest.IsSetBenefitIdentifier())
            {
                context.Writer.WritePropertyName("BenefitIdentifier");
                context.Writer.WriteStringValue(publicRequest.BenefitIdentifier);
            }

            if(publicRequest.IsSetCatalog())
            {
                context.Writer.WritePropertyName("Catalog");
                context.Writer.WriteStringValue(publicRequest.Catalog);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetFileDetails())
            {
                context.Writer.WritePropertyName("FileDetails");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFileDetailsListValue in publicRequest.FileDetails)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FileInputMarshaller.Instance;
                    marshaller.Marshall(publicRequestFileDetailsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetPartnerContacts())
            {
                context.Writer.WritePropertyName("PartnerContacts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPartnerContactsListValue in publicRequest.PartnerContacts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ContactMarshaller.Instance;
                    marshaller.Marshall(publicRequestPartnerContactsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
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
        private static CreateBenefitApplicationRequestMarshaller _instance = new CreateBenefitApplicationRequestMarshaller();        

        internal static CreateBenefitApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBenefitApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}