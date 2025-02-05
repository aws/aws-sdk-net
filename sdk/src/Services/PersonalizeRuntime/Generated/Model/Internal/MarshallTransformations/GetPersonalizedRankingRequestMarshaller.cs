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
 * Do not modify this file. This file is generated from the personalize-runtime-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PersonalizeRuntime.Model;
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
namespace Amazon.PersonalizeRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetPersonalizedRanking Request Marshaller
    /// </summary>       
    public class GetPersonalizedRankingRequestMarshaller : IMarshaller<IRequest, GetPersonalizedRankingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetPersonalizedRankingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetPersonalizedRankingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PersonalizeRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-22";
            request.HttpMethod = "POST";

            request.ResourcePath = "/personalize-ranking";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCampaignArn())
            {
                context.Writer.WritePropertyName("campaignArn");
                context.Writer.WriteStringValue(publicRequest.CampaignArn);
            }

            if(publicRequest.IsSetContext())
            {
                context.Writer.WritePropertyName("context");
                context.Writer.WriteStartObject();
                foreach (var publicRequestContextKvp in publicRequest.Context)
                {
                    context.Writer.WritePropertyName(publicRequestContextKvp.Key);
                    var publicRequestContextValue = publicRequestContextKvp.Value;

                        context.Writer.WriteStringValue(publicRequestContextValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFilterArn())
            {
                context.Writer.WritePropertyName("filterArn");
                context.Writer.WriteStringValue(publicRequest.FilterArn);
            }

            if(publicRequest.IsSetFilterValues())
            {
                context.Writer.WritePropertyName("filterValues");
                context.Writer.WriteStartObject();
                foreach (var publicRequestFilterValuesKvp in publicRequest.FilterValues)
                {
                    context.Writer.WritePropertyName(publicRequestFilterValuesKvp.Key);
                    var publicRequestFilterValuesValue = publicRequestFilterValuesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestFilterValuesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputList())
            {
                context.Writer.WritePropertyName("inputList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInputListListValue in publicRequest.InputList)
                {
                        context.Writer.WriteStringValue(publicRequestInputListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMetadataColumns())
            {
                context.Writer.WritePropertyName("metadataColumns");
                context.Writer.WriteStartObject();
                foreach (var publicRequestMetadataColumnsKvp in publicRequest.MetadataColumns)
                {
                    context.Writer.WritePropertyName(publicRequestMetadataColumnsKvp.Key);
                    var publicRequestMetadataColumnsValue = publicRequestMetadataColumnsKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var publicRequestMetadataColumnsValueListValue in publicRequestMetadataColumnsValue)
                    {
                            context.Writer.WriteStringValue(publicRequestMetadataColumnsValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUserId())
            {
                context.Writer.WritePropertyName("userId");
                context.Writer.WriteStringValue(publicRequest.UserId);
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
        private static GetPersonalizedRankingRequestMarshaller _instance = new GetPersonalizedRankingRequestMarshaller();        

        internal static GetPersonalizedRankingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetPersonalizedRankingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}