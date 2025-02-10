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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
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
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyInstanceProfile Request Marshaller
    /// </summary>       
    public class ModifyInstanceProfileRequestMarshaller : IMarshaller<IRequest, ModifyInstanceProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyInstanceProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyInstanceProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.ModifyInstanceProfile";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-01-01";
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
            if(publicRequest.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("AvailabilityZone");
                context.Writer.WriteStringValue(publicRequest.AvailabilityZone);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetInstanceProfileIdentifier())
            {
                context.Writer.WritePropertyName("InstanceProfileIdentifier");
                context.Writer.WriteStringValue(publicRequest.InstanceProfileIdentifier);
            }

            if(publicRequest.IsSetInstanceProfileName())
            {
                context.Writer.WritePropertyName("InstanceProfileName");
                context.Writer.WriteStringValue(publicRequest.InstanceProfileName);
            }

            if(publicRequest.IsSetKmsKeyArn())
            {
                context.Writer.WritePropertyName("KmsKeyArn");
                context.Writer.WriteStringValue(publicRequest.KmsKeyArn);
            }

            if(publicRequest.IsSetNetworkType())
            {
                context.Writer.WritePropertyName("NetworkType");
                context.Writer.WriteStringValue(publicRequest.NetworkType);
            }

            if(publicRequest.IsSetPubliclyAccessible())
            {
                context.Writer.WritePropertyName("PubliclyAccessible");
                context.Writer.WriteBooleanValue(publicRequest.PubliclyAccessible.Value);
            }

            if(publicRequest.IsSetSubnetGroupIdentifier())
            {
                context.Writer.WritePropertyName("SubnetGroupIdentifier");
                context.Writer.WriteStringValue(publicRequest.SubnetGroupIdentifier);
            }

            if(publicRequest.IsSetVpcSecurityGroups())
            {
                context.Writer.WritePropertyName("VpcSecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var publicRequestVpcSecurityGroupsListValue in publicRequest.VpcSecurityGroups)
                {
                        context.Writer.WriteStringValue(publicRequestVpcSecurityGroupsListValue);
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
        private static ModifyInstanceProfileRequestMarshaller _instance = new ModifyInstanceProfileRequestMarshaller();        

        internal static ModifyInstanceProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyInstanceProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}