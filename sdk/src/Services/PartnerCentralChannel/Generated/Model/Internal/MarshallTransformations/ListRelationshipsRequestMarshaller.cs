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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralChannel.Model;
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
namespace Amazon.PartnerCentralChannel.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListRelationships Request Marshaller
    /// </summary>       
    public class ListRelationshipsRequestMarshaller : IMarshaller<IRequest, ListRelationshipsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListRelationshipsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListRelationshipsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralChannel");
            string target = "PartnerCentralChannel.ListRelationships";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-03-18";
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
            if(publicRequest.IsSetAssociatedAccountIds())
            {
                context.Writer.WritePropertyName("associatedAccountIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAssociatedAccountIdsListValue in publicRequest.AssociatedAccountIds)
                {
                        context.Writer.WriteStringValue(publicRequestAssociatedAccountIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAssociationTypes())
            {
                context.Writer.WritePropertyName("associationTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAssociationTypesListValue in publicRequest.AssociationTypes)
                {
                        context.Writer.WriteStringValue(publicRequestAssociationTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCatalog())
            {
                context.Writer.WritePropertyName("catalog");
                context.Writer.WriteStringValue(publicRequest.Catalog);
            }

            if(publicRequest.IsSetDisplayNames())
            {
                context.Writer.WritePropertyName("displayNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDisplayNamesListValue in publicRequest.DisplayNames)
                {
                        context.Writer.WriteStringValue(publicRequestDisplayNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("maxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("nextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetProgramManagementAccountIdentifiers())
            {
                context.Writer.WritePropertyName("programManagementAccountIdentifiers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestProgramManagementAccountIdentifiersListValue in publicRequest.ProgramManagementAccountIdentifiers)
                {
                        context.Writer.WriteStringValue(publicRequestProgramManagementAccountIdentifiersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSort())
            {
                context.Writer.WritePropertyName("sort");
                context.Writer.WriteStartObject();

                var marshaller = ListRelationshipsSortBaseMarshaller.Instance;
                marshaller.Marshall(publicRequest.Sort, context);

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
        private static ListRelationshipsRequestMarshaller _instance = new ListRelationshipsRequestMarshaller();        

        internal static ListRelationshipsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListRelationshipsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}