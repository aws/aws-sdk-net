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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MainframeModernization.Model;
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
namespace Amazon.MainframeModernization.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEnvironment Request Marshaller
    /// </summary>       
    public class CreateEnvironmentRequestMarshaller : IMarshaller<IRequest, CreateEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MainframeModernization");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-04-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/environments";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEngineType())
            {
                context.Writer.WritePropertyName("engineType");
                context.Writer.WriteStringValue(publicRequest.EngineType);
            }

            if(publicRequest.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("engineVersion");
                context.Writer.WriteStringValue(publicRequest.EngineVersion);
            }

            if(publicRequest.IsSetHighAvailabilityConfig())
            {
                context.Writer.WritePropertyName("highAvailabilityConfig");
                context.Writer.WriteStartObject();

                var marshaller = HighAvailabilityConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.HighAvailabilityConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("instanceType");
                context.Writer.WriteStringValue(publicRequest.InstanceType);
            }

            if(publicRequest.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("kmsKeyId");
                context.Writer.WriteStringValue(publicRequest.KmsKeyId);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNetworkType())
            {
                context.Writer.WritePropertyName("networkType");
                context.Writer.WriteStringValue(publicRequest.NetworkType);
            }

            if(publicRequest.IsSetPreferredMaintenanceWindow())
            {
                context.Writer.WritePropertyName("preferredMaintenanceWindow");
                context.Writer.WriteStringValue(publicRequest.PreferredMaintenanceWindow);
            }

            if(publicRequest.IsSetPubliclyAccessible())
            {
                context.Writer.WritePropertyName("publiclyAccessible");
                context.Writer.WriteBooleanValue(publicRequest.PubliclyAccessible.Value);
            }

            if(publicRequest.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("securityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecurityGroupIdsListValue in publicRequest.SecurityGroupIds)
                {
                        context.Writer.WriteStringValue(publicRequestSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStorageConfigurations())
            {
                context.Writer.WritePropertyName("storageConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStorageConfigurationsListValue in publicRequest.StorageConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StorageConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestStorageConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSubnetIds())
            {
                context.Writer.WritePropertyName("subnetIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSubnetIdsListValue in publicRequest.SubnetIds)
                {
                        context.Writer.WriteStringValue(publicRequestSubnetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
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
        private static CreateEnvironmentRequestMarshaller _instance = new CreateEnvironmentRequestMarshaller();        

        internal static CreateEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}