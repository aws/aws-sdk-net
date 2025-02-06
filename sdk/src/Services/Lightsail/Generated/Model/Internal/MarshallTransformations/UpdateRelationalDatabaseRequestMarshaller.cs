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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
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
namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateRelationalDatabase Request Marshaller
    /// </summary>       
    public class UpdateRelationalDatabaseRequestMarshaller : IMarshaller<IRequest, UpdateRelationalDatabaseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRelationalDatabaseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateRelationalDatabaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.UpdateRelationalDatabase";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";
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
            if(publicRequest.IsSetApplyImmediately())
            {
                context.Writer.WritePropertyName("applyImmediately");
                context.Writer.WriteBooleanValue(publicRequest.ApplyImmediately.Value);
            }

            if(publicRequest.IsSetCaCertificateIdentifier())
            {
                context.Writer.WritePropertyName("caCertificateIdentifier");
                context.Writer.WriteStringValue(publicRequest.CaCertificateIdentifier);
            }

            if(publicRequest.IsSetDisableBackupRetention())
            {
                context.Writer.WritePropertyName("disableBackupRetention");
                context.Writer.WriteBooleanValue(publicRequest.DisableBackupRetention.Value);
            }

            if(publicRequest.IsSetEnableBackupRetention())
            {
                context.Writer.WritePropertyName("enableBackupRetention");
                context.Writer.WriteBooleanValue(publicRequest.EnableBackupRetention.Value);
            }

            if(publicRequest.IsSetMasterUserPassword())
            {
                context.Writer.WritePropertyName("masterUserPassword");
                context.Writer.WriteStringValue(publicRequest.MasterUserPassword);
            }

            if(publicRequest.IsSetPreferredBackupWindow())
            {
                context.Writer.WritePropertyName("preferredBackupWindow");
                context.Writer.WriteStringValue(publicRequest.PreferredBackupWindow);
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

            if(publicRequest.IsSetRelationalDatabaseBlueprintId())
            {
                context.Writer.WritePropertyName("relationalDatabaseBlueprintId");
                context.Writer.WriteStringValue(publicRequest.RelationalDatabaseBlueprintId);
            }

            if(publicRequest.IsSetRelationalDatabaseName())
            {
                context.Writer.WritePropertyName("relationalDatabaseName");
                context.Writer.WriteStringValue(publicRequest.RelationalDatabaseName);
            }

            if(publicRequest.IsSetRotateMasterUserPassword())
            {
                context.Writer.WritePropertyName("rotateMasterUserPassword");
                context.Writer.WriteBooleanValue(publicRequest.RotateMasterUserPassword.Value);
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
        private static UpdateRelationalDatabaseRequestMarshaller _instance = new UpdateRelationalDatabaseRequestMarshaller();        

        internal static UpdateRelationalDatabaseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateRelationalDatabaseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}