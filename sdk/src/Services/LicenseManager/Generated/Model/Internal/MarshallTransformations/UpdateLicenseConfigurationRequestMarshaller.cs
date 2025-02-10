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
    /// UpdateLicenseConfiguration Request Marshaller
    /// </summary>       
    public class UpdateLicenseConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateLicenseConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLicenseConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLicenseConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LicenseManager");
            string target = "AWSLicenseManager.UpdateLicenseConfiguration";
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
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDisassociateWhenNotFound())
            {
                context.Writer.WritePropertyName("DisassociateWhenNotFound");
                context.Writer.WriteBooleanValue(publicRequest.DisassociateWhenNotFound.Value);
            }

            if(publicRequest.IsSetLicenseConfigurationArn())
            {
                context.Writer.WritePropertyName("LicenseConfigurationArn");
                context.Writer.WriteStringValue(publicRequest.LicenseConfigurationArn);
            }

            if(publicRequest.IsSetLicenseConfigurationStatus())
            {
                context.Writer.WritePropertyName("LicenseConfigurationStatus");
                context.Writer.WriteStringValue(publicRequest.LicenseConfigurationStatus);
            }

            if(publicRequest.IsSetLicenseCount())
            {
                context.Writer.WritePropertyName("LicenseCount");
                context.Writer.WriteNumberValue(publicRequest.LicenseCount.Value);
            }

            if(publicRequest.IsSetLicenseCountHardLimit())
            {
                context.Writer.WritePropertyName("LicenseCountHardLimit");
                context.Writer.WriteBooleanValue(publicRequest.LicenseCountHardLimit.Value);
            }

            if(publicRequest.IsSetLicenseRules())
            {
                context.Writer.WritePropertyName("LicenseRules");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLicenseRulesListValue in publicRequest.LicenseRules)
                {
                        context.Writer.WriteStringValue(publicRequestLicenseRulesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetProductInformationList())
            {
                context.Writer.WritePropertyName("ProductInformationList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestProductInformationListListValue in publicRequest.ProductInformationList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProductInformationMarshaller.Instance;
                    marshaller.Marshall(publicRequestProductInformationListListValue, context);

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
        private static UpdateLicenseConfigurationRequestMarshaller _instance = new UpdateLicenseConfigurationRequestMarshaller();        

        internal static UpdateLicenseConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLicenseConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}