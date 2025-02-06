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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
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
namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateInfrastructureConfiguration Request Marshaller
    /// </summary>       
    public class UpdateInfrastructureConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateInfrastructureConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateInfrastructureConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateInfrastructureConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Imagebuilder");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/UpdateInfrastructureConfiguration";
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

            if(publicRequest.IsSetInfrastructureConfigurationArn())
            {
                context.Writer.WritePropertyName("infrastructureConfigurationArn");
                context.Writer.WriteStringValue(publicRequest.InfrastructureConfigurationArn);
            }

            if(publicRequest.IsSetInstanceMetadataOptions())
            {
                context.Writer.WritePropertyName("instanceMetadataOptions");
                context.Writer.WriteStartObject();

                var marshaller = InstanceMetadataOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.InstanceMetadataOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInstanceProfileName())
            {
                context.Writer.WritePropertyName("instanceProfileName");
                context.Writer.WriteStringValue(publicRequest.InstanceProfileName);
            }

            if(publicRequest.IsSetInstanceTypes())
            {
                context.Writer.WritePropertyName("instanceTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInstanceTypesListValue in publicRequest.InstanceTypes)
                {
                        context.Writer.WriteStringValue(publicRequestInstanceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetKeyPair())
            {
                context.Writer.WritePropertyName("keyPair");
                context.Writer.WriteStringValue(publicRequest.KeyPair);
            }

            if(publicRequest.IsSetLogging())
            {
                context.Writer.WritePropertyName("logging");
                context.Writer.WriteStartObject();

                var marshaller = LoggingMarshaller.Instance;
                marshaller.Marshall(publicRequest.Logging, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPlacement())
            {
                context.Writer.WritePropertyName("placement");
                context.Writer.WriteStartObject();

                var marshaller = PlacementMarshaller.Instance;
                marshaller.Marshall(publicRequest.Placement, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResourceTags())
            {
                context.Writer.WritePropertyName("resourceTags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestResourceTagsKvp in publicRequest.ResourceTags)
                {
                    context.Writer.WritePropertyName(publicRequestResourceTagsKvp.Key);
                    var publicRequestResourceTagsValue = publicRequestResourceTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestResourceTagsValue);
                }
                context.Writer.WriteEndObject();
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

            if(publicRequest.IsSetSnsTopicArn())
            {
                context.Writer.WritePropertyName("snsTopicArn");
                context.Writer.WriteStringValue(publicRequest.SnsTopicArn);
            }

            if(publicRequest.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("subnetId");
                context.Writer.WriteStringValue(publicRequest.SubnetId);
            }

            if(publicRequest.IsSetTerminateInstanceOnFailure())
            {
                context.Writer.WritePropertyName("terminateInstanceOnFailure");
                context.Writer.WriteBooleanValue(publicRequest.TerminateInstanceOnFailure.Value);
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
        private static UpdateInfrastructureConfigurationRequestMarshaller _instance = new UpdateInfrastructureConfigurationRequestMarshaller();        

        internal static UpdateInfrastructureConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateInfrastructureConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}