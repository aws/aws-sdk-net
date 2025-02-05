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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
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
namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeAppVersionResource Request Marshaller
    /// </summary>       
    public class DescribeAppVersionResourceRequestMarshaller : IMarshaller<IRequest, DescribeAppVersionResourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeAppVersionResourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeAppVersionResourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResilienceHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-04-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/describe-app-version-resource";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAppArn())
            {
                context.Writer.WritePropertyName("appArn");
                context.Writer.WriteStringValue(publicRequest.AppArn);
            }

            if(publicRequest.IsSetAppVersion())
            {
                context.Writer.WritePropertyName("appVersion");
                context.Writer.WriteStringValue(publicRequest.AppVersion);
            }

            if(publicRequest.IsSetAwsAccountId())
            {
                context.Writer.WritePropertyName("awsAccountId");
                context.Writer.WriteStringValue(publicRequest.AwsAccountId);
            }

            if(publicRequest.IsSetAwsRegion())
            {
                context.Writer.WritePropertyName("awsRegion");
                context.Writer.WriteStringValue(publicRequest.AwsRegion);
            }

            if(publicRequest.IsSetLogicalResourceId())
            {
                context.Writer.WritePropertyName("logicalResourceId");
                context.Writer.WriteStartObject();

                var marshaller = LogicalResourceIdMarshaller.Instance;
                marshaller.Marshall(publicRequest.LogicalResourceId, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPhysicalResourceId())
            {
                context.Writer.WritePropertyName("physicalResourceId");
                context.Writer.WriteStringValue(publicRequest.PhysicalResourceId);
            }

            if(publicRequest.IsSetResourceName())
            {
                context.Writer.WritePropertyName("resourceName");
                context.Writer.WriteStringValue(publicRequest.ResourceName);
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
        private static DescribeAppVersionResourceRequestMarshaller _instance = new DescribeAppVersionResourceRequestMarshaller();        

        internal static DescribeAppVersionResourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAppVersionResourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}