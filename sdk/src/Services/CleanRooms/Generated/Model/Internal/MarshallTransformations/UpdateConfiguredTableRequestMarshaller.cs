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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
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
namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateConfiguredTable Request Marshaller
    /// </summary>       
    public class UpdateConfiguredTableRequestMarshaller : IMarshaller<IRequest, UpdateConfiguredTableRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateConfiguredTableRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateConfiguredTableRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRooms");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-17";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetConfiguredTableIdentifier())
                throw new AmazonCleanRoomsException("Request object does not have required field ConfiguredTableIdentifier set");
            request.AddPathResource("{configuredTableIdentifier}", StringUtils.FromString(publicRequest.ConfiguredTableIdentifier));
            request.ResourcePath = "/configuredTables/{configuredTableIdentifier}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAllowedColumns())
            {
                context.Writer.WritePropertyName("allowedColumns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAllowedColumnsListValue in publicRequest.AllowedColumns)
                {
                        context.Writer.WriteStringValue(publicRequestAllowedColumnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAnalysisMethod())
            {
                context.Writer.WritePropertyName("analysisMethod");
                context.Writer.WriteStringValue(publicRequest.AnalysisMethod);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetSelectedAnalysisMethods())
            {
                context.Writer.WritePropertyName("selectedAnalysisMethods");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSelectedAnalysisMethodsListValue in publicRequest.SelectedAnalysisMethods)
                {
                        context.Writer.WriteStringValue(publicRequestSelectedAnalysisMethodsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTableReference())
            {
                context.Writer.WritePropertyName("tableReference");
                context.Writer.WriteStartObject();

                var marshaller = TableReferenceMarshaller.Instance;
                marshaller.Marshall(publicRequest.TableReference, context);

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
        private static UpdateConfiguredTableRequestMarshaller _instance = new UpdateConfiguredTableRequestMarshaller();        

        internal static UpdateConfiguredTableRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateConfiguredTableRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}