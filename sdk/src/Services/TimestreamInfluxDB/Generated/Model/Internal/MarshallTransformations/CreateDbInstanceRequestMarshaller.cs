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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamInfluxDB.Model;
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
namespace Amazon.TimestreamInfluxDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDbInstance Request Marshaller
    /// </summary>       
    public class CreateDbInstanceRequestMarshaller : IMarshaller<IRequest, CreateDbInstanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDbInstanceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDbInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TimestreamInfluxDB");
            string target = "AmazonTimestreamInfluxDB.CreateDbInstance";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-01-27";
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
            if(publicRequest.IsSetAllocatedStorage())
            {
                context.Writer.WritePropertyName("allocatedStorage");
                context.Writer.WriteNumberValue(publicRequest.AllocatedStorage.Value);
            }

            if(publicRequest.IsSetBucket())
            {
                context.Writer.WritePropertyName("bucket");
                context.Writer.WriteStringValue(publicRequest.Bucket);
            }

            if(publicRequest.IsSetDbInstanceType())
            {
                context.Writer.WritePropertyName("dbInstanceType");
                context.Writer.WriteStringValue(publicRequest.DbInstanceType);
            }

            if(publicRequest.IsSetDbParameterGroupIdentifier())
            {
                context.Writer.WritePropertyName("dbParameterGroupIdentifier");
                context.Writer.WriteStringValue(publicRequest.DbParameterGroupIdentifier);
            }

            if(publicRequest.IsSetDbStorageType())
            {
                context.Writer.WritePropertyName("dbStorageType");
                context.Writer.WriteStringValue(publicRequest.DbStorageType);
            }

            if(publicRequest.IsSetDeploymentType())
            {
                context.Writer.WritePropertyName("deploymentType");
                context.Writer.WriteStringValue(publicRequest.DeploymentType);
            }

            if(publicRequest.IsSetLogDeliveryConfiguration())
            {
                context.Writer.WritePropertyName("logDeliveryConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LogDeliveryConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.LogDeliveryConfiguration, context);

                context.Writer.WriteEndObject();
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

            if(publicRequest.IsSetOrganization())
            {
                context.Writer.WritePropertyName("organization");
                context.Writer.WriteStringValue(publicRequest.Organization);
            }

            if(publicRequest.IsSetPassword())
            {
                context.Writer.WritePropertyName("password");
                context.Writer.WriteStringValue(publicRequest.Password);
            }

            if(publicRequest.IsSetPort())
            {
                context.Writer.WritePropertyName("port");
                context.Writer.WriteNumberValue(publicRequest.Port.Value);
            }

            if(publicRequest.IsSetPubliclyAccessible())
            {
                context.Writer.WritePropertyName("publiclyAccessible");
                context.Writer.WriteBooleanValue(publicRequest.PubliclyAccessible.Value);
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

            if(publicRequest.IsSetUsername())
            {
                context.Writer.WritePropertyName("username");
                context.Writer.WriteStringValue(publicRequest.Username);
            }

            if(publicRequest.IsSetVpcSecurityGroupIds())
            {
                context.Writer.WritePropertyName("vpcSecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestVpcSecurityGroupIdsListValue in publicRequest.VpcSecurityGroupIds)
                {
                        context.Writer.WriteStringValue(publicRequestVpcSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetVpcSubnetIds())
            {
                context.Writer.WritePropertyName("vpcSubnetIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestVpcSubnetIdsListValue in publicRequest.VpcSubnetIds)
                {
                        context.Writer.WriteStringValue(publicRequestVpcSubnetIdsListValue);
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
        private static CreateDbInstanceRequestMarshaller _instance = new CreateDbInstanceRequestMarshaller();        

        internal static CreateDbInstanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDbInstanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}