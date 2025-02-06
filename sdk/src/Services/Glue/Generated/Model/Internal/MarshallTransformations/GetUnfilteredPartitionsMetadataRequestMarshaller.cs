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
    /// GetUnfilteredPartitionsMetadata Request Marshaller
    /// </summary>       
    public class GetUnfilteredPartitionsMetadataRequestMarshaller : IMarshaller<IRequest, GetUnfilteredPartitionsMetadataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetUnfilteredPartitionsMetadataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetUnfilteredPartitionsMetadataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.GetUnfilteredPartitionsMetadata";
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
            if(publicRequest.IsSetAuditContext())
            {
                context.Writer.WritePropertyName("AuditContext");
                context.Writer.WriteStartObject();

                var marshaller = AuditContextMarshaller.Instance;
                marshaller.Marshall(publicRequest.AuditContext, context);

                context.Writer.WriteEndObject();
            }

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

            if(publicRequest.IsSetExpression())
            {
                context.Writer.WritePropertyName("Expression");
                context.Writer.WriteStringValue(publicRequest.Expression);
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetQuerySessionContext())
            {
                context.Writer.WritePropertyName("QuerySessionContext");
                context.Writer.WriteStartObject();

                var marshaller = QuerySessionContextMarshaller.Instance;
                marshaller.Marshall(publicRequest.QuerySessionContext, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRegion())
            {
                context.Writer.WritePropertyName("Region");
                context.Writer.WriteStringValue(publicRequest.Region);
            }

            if(publicRequest.IsSetSegment())
            {
                context.Writer.WritePropertyName("Segment");
                context.Writer.WriteStartObject();

                var marshaller = SegmentMarshaller.Instance;
                marshaller.Marshall(publicRequest.Segment, context);

                context.Writer.WriteEndObject();
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

            if(publicRequest.IsSetTableName())
            {
                context.Writer.WritePropertyName("TableName");
                context.Writer.WriteStringValue(publicRequest.TableName);
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
        private static GetUnfilteredPartitionsMetadataRequestMarshaller _instance = new GetUnfilteredPartitionsMetadataRequestMarshaller();        

        internal static GetUnfilteredPartitionsMetadataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetUnfilteredPartitionsMetadataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}