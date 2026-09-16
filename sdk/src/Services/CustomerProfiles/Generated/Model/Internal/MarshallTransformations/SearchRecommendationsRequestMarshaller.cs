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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
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
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchRecommendations Request Marshaller
    /// </summary>       
    public class SearchRecommendationsRequestMarshaller : IMarshaller<IRequest, SearchRecommendationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchRecommendationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchRecommendationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CustomerProfiles");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainName())
                throw new AmazonCustomerProfilesException("Request object does not have required field DomainName set");
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));
            request.ResourcePath = "/domains/{DomainName}/recommendations";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCandidateIds())
            {
                context.Writer.WritePropertyName("CandidateIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCandidateIdsListValue in publicRequest.CandidateIds)
                {
                        context.Writer.WriteStringValue(publicRequestCandidateIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetContext())
            {
                context.Writer.WritePropertyName("Context");
                context.Writer.WriteStartObject();
                foreach (var publicRequestContextKvp in publicRequest.Context)
                {
                    context.Writer.WritePropertyName(publicRequestContextKvp.Key);
                    var publicRequestContextValue = publicRequestContextKvp.Value;

                        context.Writer.WriteStringValue(publicRequestContextValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDiversity())
            {
                context.Writer.WritePropertyName("Diversity");
                context.Writer.WriteStartObject();

                var marshaller = RecommendationDiversityConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.Diversity, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKeyName())
            {
                context.Writer.WritePropertyName("KeyName");
                context.Writer.WriteStringValue(publicRequest.KeyName);
            }

            if(publicRequest.IsSetKeyValues())
            {
                context.Writer.WritePropertyName("KeyValues");
                context.Writer.WriteStartArray();
                foreach(var publicRequestKeyValuesListValue in publicRequest.KeyValues)
                {
                        context.Writer.WriteStringValue(publicRequestKeyValuesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMaxRecommendations())
            {
                context.Writer.WritePropertyName("MaxRecommendations");
                context.Writer.WriteNumberValue(publicRequest.MaxRecommendations.Value);
            }

            if(publicRequest.IsSetMetadata())
            {
                context.Writer.WritePropertyName("Metadata");
                context.Writer.WriteStartObject();

                var marshaller = RecommendationMetadataMarshaller.Instance;
                marshaller.Marshall(publicRequest.Metadata, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRecommender())
            {
                context.Writer.WritePropertyName("Recommender");
                context.Writer.WriteStartObject();

                var marshaller = RecommenderMarshaller.Instance;
                marshaller.Marshall(publicRequest.Recommender, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static SearchRecommendationsRequestMarshaller _instance = new SearchRecommendationsRequestMarshaller();        

        internal static SearchRecommendationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchRecommendationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}