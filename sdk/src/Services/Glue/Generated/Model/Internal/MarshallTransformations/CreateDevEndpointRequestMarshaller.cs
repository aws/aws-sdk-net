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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
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
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDevEndpoint Request Marshaller
    /// </summary>       
    public class CreateDevEndpointRequestMarshaller : IMarshaller<IRequest, CreateDevEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDevEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDevEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.CreateDevEndpoint";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
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
            if(publicRequest.IsSetArguments())
            {
                context.Writer.WritePropertyName("Arguments");
                context.Writer.WriteStartObject();
                foreach (var publicRequestArgumentsKvp in publicRequest.Arguments)
                {
                    context.Writer.WritePropertyName(publicRequestArgumentsKvp.Key);
                    var publicRequestArgumentsValue = publicRequestArgumentsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestArgumentsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEndpointName())
            {
                context.Writer.WritePropertyName("EndpointName");
                context.Writer.WriteStringValue(publicRequest.EndpointName);
            }

            if(publicRequest.IsSetExtraJarsS3Path())
            {
                context.Writer.WritePropertyName("ExtraJarsS3Path");
                context.Writer.WriteStringValue(publicRequest.ExtraJarsS3Path);
            }

            if(publicRequest.IsSetExtraPythonLibsS3Path())
            {
                context.Writer.WritePropertyName("ExtraPythonLibsS3Path");
                context.Writer.WriteStringValue(publicRequest.ExtraPythonLibsS3Path);
            }

            if(publicRequest.IsSetGlueVersion())
            {
                context.Writer.WritePropertyName("GlueVersion");
                context.Writer.WriteStringValue(publicRequest.GlueVersion);
            }

            if(publicRequest.IsSetNumberOfNodes())
            {
                context.Writer.WritePropertyName("NumberOfNodes");
                context.Writer.WriteNumberValue(publicRequest.NumberOfNodes.Value);
            }

            if(publicRequest.IsSetNumberOfWorkers())
            {
                context.Writer.WritePropertyName("NumberOfWorkers");
                context.Writer.WriteNumberValue(publicRequest.NumberOfWorkers.Value);
            }

            if(publicRequest.IsSetPublicKey())
            {
                context.Writer.WritePropertyName("PublicKey");
                context.Writer.WriteStringValue(publicRequest.PublicKey);
            }

            if(publicRequest.IsSetPublicKeys())
            {
                context.Writer.WritePropertyName("PublicKeys");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPublicKeysListValue in publicRequest.PublicKeys)
                {
                        context.Writer.WriteStringValue(publicRequestPublicKeysListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetSecurityConfiguration())
            {
                context.Writer.WritePropertyName("SecurityConfiguration");
                context.Writer.WriteStringValue(publicRequest.SecurityConfiguration);
            }

            if(publicRequest.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("SecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecurityGroupIdsListValue in publicRequest.SecurityGroupIds)
                {
                        context.Writer.WriteStringValue(publicRequestSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("SubnetId");
                context.Writer.WriteStringValue(publicRequest.SubnetId);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWorkerType())
            {
                context.Writer.WritePropertyName("WorkerType");
                context.Writer.WriteStringValue(publicRequest.WorkerType);
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
        private static CreateDevEndpointRequestMarshaller _instance = new CreateDevEndpointRequestMarshaller();        

        internal static CreateDevEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDevEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}