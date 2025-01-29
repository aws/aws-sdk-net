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
 * Do not modify this file. This file is generated from the marketplacecommerceanalytics-2015-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSMarketplaceCommerceAnalytics.Model;
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
namespace Amazon.AWSMarketplaceCommerceAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartSupportDataExport Request Marshaller
    /// </summary>       
    public class StartSupportDataExportRequestMarshaller : IMarshaller<IRequest, StartSupportDataExportRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartSupportDataExportRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartSupportDataExportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AWSMarketplaceCommerceAnalytics");
            string target = "MarketplaceCommerceAnalytics20150701.StartSupportDataExport";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-07-01";
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
            if(publicRequest.IsSetCustomerDefinedValues())
            {
                context.Writer.WritePropertyName("customerDefinedValues");
                context.Writer.WriteStartObject();
                foreach (var publicRequestCustomerDefinedValuesKvp in publicRequest.CustomerDefinedValues)
                {
                    context.Writer.WritePropertyName(publicRequestCustomerDefinedValuesKvp.Key);
                    var publicRequestCustomerDefinedValuesValue = publicRequestCustomerDefinedValuesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestCustomerDefinedValuesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDataSetType())
            {
                context.Writer.WritePropertyName("dataSetType");
                context.Writer.WriteStringValue(publicRequest.DataSetType);
            }

            if(publicRequest.IsSetDestinationS3BucketName())
            {
                context.Writer.WritePropertyName("destinationS3BucketName");
                context.Writer.WriteStringValue(publicRequest.DestinationS3BucketName);
            }

            if(publicRequest.IsSetDestinationS3Prefix())
            {
                context.Writer.WritePropertyName("destinationS3Prefix");
                context.Writer.WriteStringValue(publicRequest.DestinationS3Prefix);
            }

            if(publicRequest.IsSetFromDate())
            {
                context.Writer.WritePropertyName("fromDate");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.FromDate.Value)));
            }

            if(publicRequest.IsSetRoleNameArn())
            {
                context.Writer.WritePropertyName("roleNameArn");
                context.Writer.WriteStringValue(publicRequest.RoleNameArn);
            }

            if(publicRequest.IsSetSnsTopicArn())
            {
                context.Writer.WritePropertyName("snsTopicArn");
                context.Writer.WriteStringValue(publicRequest.SnsTopicArn);
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
        private static StartSupportDataExportRequestMarshaller _instance = new StartSupportDataExportRequestMarshaller();        

        internal static StartSupportDataExportRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartSupportDataExportRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}