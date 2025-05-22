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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManager.Model;
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
namespace Amazon.LicenseManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLicense Request Marshaller
    /// </summary>       
    public class CreateLicenseRequestMarshaller : IMarshaller<IRequest, CreateLicenseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLicenseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLicenseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LicenseManager");
            string target = "AWSLicenseManager.CreateLicense";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-01";
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
            if(publicRequest.IsSetBeneficiary())
            {
                context.Writer.WritePropertyName("Beneficiary");
                context.Writer.WriteStringValue(publicRequest.Beneficiary);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetConsumptionConfiguration())
            {
                context.Writer.WritePropertyName("ConsumptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ConsumptionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ConsumptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEntitlements())
            {
                context.Writer.WritePropertyName("Entitlements");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEntitlementsListValue in publicRequest.Entitlements)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EntitlementMarshaller.Instance;
                    marshaller.Marshall(publicRequestEntitlementsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetHomeRegion())
            {
                context.Writer.WritePropertyName("HomeRegion");
                context.Writer.WriteStringValue(publicRequest.HomeRegion);
            }

            if(publicRequest.IsSetIssuer())
            {
                context.Writer.WritePropertyName("Issuer");
                context.Writer.WriteStartObject();

                var marshaller = IssuerMarshaller.Instance;
                marshaller.Marshall(publicRequest.Issuer, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLicenseMetadata())
            {
                context.Writer.WritePropertyName("LicenseMetadata");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLicenseMetadataListValue in publicRequest.LicenseMetadata)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MetadataMarshaller.Instance;
                    marshaller.Marshall(publicRequestLicenseMetadataListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLicenseName())
            {
                context.Writer.WritePropertyName("LicenseName");
                context.Writer.WriteStringValue(publicRequest.LicenseName);
            }

            if(publicRequest.IsSetProductName())
            {
                context.Writer.WritePropertyName("ProductName");
                context.Writer.WriteStringValue(publicRequest.ProductName);
            }

            if(publicRequest.IsSetProductSKU())
            {
                context.Writer.WritePropertyName("ProductSKU");
                context.Writer.WriteStringValue(publicRequest.ProductSKU);
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

            if(publicRequest.IsSetValidity())
            {
                context.Writer.WritePropertyName("Validity");
                context.Writer.WriteStartObject();

                var marshaller = DatetimeRangeMarshaller.Instance;
                marshaller.Marshall(publicRequest.Validity, context);

                context.Writer.WriteEndObject();
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
        private static CreateLicenseRequestMarshaller _instance = new CreateLicenseRequestMarshaller();        

        internal static CreateLicenseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLicenseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}