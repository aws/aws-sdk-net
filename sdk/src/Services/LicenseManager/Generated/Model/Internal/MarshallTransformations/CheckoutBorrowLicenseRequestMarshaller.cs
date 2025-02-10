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
    /// CheckoutBorrowLicense Request Marshaller
    /// </summary>       
    public class CheckoutBorrowLicenseRequestMarshaller : IMarshaller<IRequest, CheckoutBorrowLicenseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CheckoutBorrowLicenseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CheckoutBorrowLicenseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LicenseManager");
            string target = "AWSLicenseManager.CheckoutBorrowLicense";
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
            if(publicRequest.IsSetCheckoutMetadata())
            {
                context.Writer.WritePropertyName("CheckoutMetadata");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCheckoutMetadataListValue in publicRequest.CheckoutMetadata)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MetadataMarshaller.Instance;
                    marshaller.Marshall(publicRequestCheckoutMetadataListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetDigitalSignatureMethod())
            {
                context.Writer.WritePropertyName("DigitalSignatureMethod");
                context.Writer.WriteStringValue(publicRequest.DigitalSignatureMethod);
            }

            if(publicRequest.IsSetEntitlements())
            {
                context.Writer.WritePropertyName("Entitlements");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEntitlementsListValue in publicRequest.Entitlements)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EntitlementDataMarshaller.Instance;
                    marshaller.Marshall(publicRequestEntitlementsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLicenseArn())
            {
                context.Writer.WritePropertyName("LicenseArn");
                context.Writer.WriteStringValue(publicRequest.LicenseArn);
            }

            if(publicRequest.IsSetNodeId())
            {
                context.Writer.WritePropertyName("NodeId");
                context.Writer.WriteStringValue(publicRequest.NodeId);
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
        private static CheckoutBorrowLicenseRequestMarshaller _instance = new CheckoutBorrowLicenseRequestMarshaller();        

        internal static CheckoutBorrowLicenseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CheckoutBorrowLicenseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}