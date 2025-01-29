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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
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
namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeApplications Request Marshaller
    /// </summary>       
    public class DescribeApplicationsRequestMarshaller : IMarshaller<IRequest, DescribeApplicationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeApplicationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeApplicationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpaces");
            string target = "WorkspacesService.DescribeApplications";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-08";
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
            if(publicRequest.IsSetApplicationIds())
            {
                context.Writer.WritePropertyName("ApplicationIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestApplicationIdsListValue in publicRequest.ApplicationIds)
                {
                        context.Writer.WriteStringValue(publicRequestApplicationIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetComputeTypeNames())
            {
                context.Writer.WritePropertyName("ComputeTypeNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestComputeTypeNamesListValue in publicRequest.ComputeTypeNames)
                {
                        context.Writer.WriteStringValue(publicRequestComputeTypeNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLicenseType())
            {
                context.Writer.WritePropertyName("LicenseType");
                context.Writer.WriteStringValue(publicRequest.LicenseType);
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

            if(publicRequest.IsSetOperatingSystemNames())
            {
                context.Writer.WritePropertyName("OperatingSystemNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOperatingSystemNamesListValue in publicRequest.OperatingSystemNames)
                {
                        context.Writer.WriteStringValue(publicRequestOperatingSystemNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOwner())
            {
                context.Writer.WritePropertyName("Owner");
                context.Writer.WriteStringValue(publicRequest.Owner);
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
        private static DescribeApplicationsRequestMarshaller _instance = new DescribeApplicationsRequestMarshaller();        

        internal static DescribeApplicationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeApplicationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}