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
    /// UpdateTable Request Marshaller
    /// </summary>       
    public class UpdateTableRequestMarshaller : IMarshaller<IRequest, UpdateTableRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTableRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTableRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.UpdateTable";
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
            if(publicRequest.IsSetCatalogId())
            {
                context.Writer.WritePropertyName("CatalogId");
                context.Writer.WriteStringValue(publicRequest.CatalogId);
            }

            if(publicRequest.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(publicRequest.DatabaseName);
            }

            if(publicRequest.IsSetForce())
            {
                context.Writer.WritePropertyName("Force");
                context.Writer.WriteBooleanValue(publicRequest.Force.Value);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetSkipArchive())
            {
                context.Writer.WritePropertyName("SkipArchive");
                context.Writer.WriteBooleanValue(publicRequest.SkipArchive.Value);
            }

            if(publicRequest.IsSetTableInput())
            {
                context.Writer.WritePropertyName("TableInput");
                context.Writer.WriteStartObject();

                var marshaller = TableInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.TableInput, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTransactionId())
            {
                context.Writer.WritePropertyName("TransactionId");
                context.Writer.WriteStringValue(publicRequest.TransactionId);
            }

            if(publicRequest.IsSetUpdateOpenTableFormatInput())
            {
                context.Writer.WritePropertyName("UpdateOpenTableFormatInput");
                context.Writer.WriteStartObject();

                var marshaller = UpdateOpenTableFormatInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.UpdateOpenTableFormatInput, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVersionId())
            {
                context.Writer.WritePropertyName("VersionId");
                context.Writer.WriteStringValue(publicRequest.VersionId);
            }

            if(publicRequest.IsSetViewUpdateAction())
            {
                context.Writer.WritePropertyName("ViewUpdateAction");
                context.Writer.WriteStringValue(publicRequest.ViewUpdateAction);
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
        private static UpdateTableRequestMarshaller _instance = new UpdateTableRequestMarshaller();        

        internal static UpdateTableRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTableRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}