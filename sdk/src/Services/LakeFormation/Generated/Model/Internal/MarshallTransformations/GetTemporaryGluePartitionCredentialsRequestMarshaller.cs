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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
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
namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetTemporaryGluePartitionCredentials Request Marshaller
    /// </summary>       
    public class GetTemporaryGluePartitionCredentialsRequestMarshaller : IMarshaller<IRequest, GetTemporaryGluePartitionCredentialsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTemporaryGluePartitionCredentialsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetTemporaryGluePartitionCredentialsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LakeFormation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/GetTemporaryGluePartitionCredentials";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAuditContext())
            {
                context.Writer.WritePropertyName("AuditContext");
                context.Writer.WriteStartObject();

                var marshaller = AuditContextMarshaller.Instance;
                marshaller.Marshall(publicRequest.AuditContext, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDurationSeconds())
            {
                context.Writer.WritePropertyName("DurationSeconds");
                context.Writer.WriteNumberValue(publicRequest.DurationSeconds.Value);
            }

            if(publicRequest.IsSetPartition())
            {
                context.Writer.WritePropertyName("Partition");
                context.Writer.WriteStartObject();

                var marshaller = PartitionValueListMarshaller.Instance;
                marshaller.Marshall(publicRequest.Partition, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPermissions())
            {
                context.Writer.WritePropertyName("Permissions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPermissionsListValue in publicRequest.Permissions)
                {
                        context.Writer.WriteStringValue(publicRequestPermissionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSupportedPermissionTypes())
            {
                context.Writer.WritePropertyName("SupportedPermissionTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSupportedPermissionTypesListValue in publicRequest.SupportedPermissionTypes)
                {
                        context.Writer.WriteStringValue(publicRequestSupportedPermissionTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTableArn())
            {
                context.Writer.WritePropertyName("TableArn");
                context.Writer.WriteStringValue(publicRequest.TableArn);
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
        private static GetTemporaryGluePartitionCredentialsRequestMarshaller _instance = new GetTemporaryGluePartitionCredentialsRequestMarshaller();        

        internal static GetTemporaryGluePartitionCredentialsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTemporaryGluePartitionCredentialsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}