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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppRunner.Model;
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
namespace Amazon.AppRunner.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateVpcConnector Request Marshaller
    /// </summary>       
    public class CreateVpcConnectorRequestMarshaller : IMarshaller<IRequest, CreateVpcConnectorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVpcConnectorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateVpcConnectorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppRunner");
            string target = "AppRunner.CreateVpcConnector";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-05-15";
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
            if(publicRequest.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("SecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecurityGroupsListValue in publicRequest.SecurityGroups)
                {
                        context.Writer.WriteStringValue(publicRequestSecurityGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSubnets())
            {
                context.Writer.WritePropertyName("Subnets");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSubnetsListValue in publicRequest.Subnets)
                {
                        context.Writer.WriteStringValue(publicRequestSubnetsListValue);
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

            if(publicRequest.IsSetVpcConnectorName())
            {
                context.Writer.WritePropertyName("VpcConnectorName");
                context.Writer.WriteStringValue(publicRequest.VpcConnectorName);
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
        private static CreateVpcConnectorRequestMarshaller _instance = new CreateVpcConnectorRequestMarshaller();        

        internal static CreateVpcConnectorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateVpcConnectorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}