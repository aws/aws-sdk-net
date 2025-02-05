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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
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
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSubscriptionTarget Request Marshaller
    /// </summary>       
    public class UpdateSubscriptionTargetRequestMarshaller : IMarshaller<IRequest, UpdateSubscriptionTargetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSubscriptionTargetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSubscriptionTargetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            if (!publicRequest.IsSetEnvironmentIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field EnvironmentIdentifier set");
            request.AddPathResource("{environmentIdentifier}", StringUtils.FromString(publicRequest.EnvironmentIdentifier));
            if (!publicRequest.IsSetIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field Identifier set");
            request.AddPathResource("{identifier}", StringUtils.FromString(publicRequest.Identifier));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/environments/{environmentIdentifier}/subscription-targets/{identifier}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetApplicableAssetTypes())
            {
                context.Writer.WritePropertyName("applicableAssetTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestApplicableAssetTypesListValue in publicRequest.ApplicableAssetTypes)
                {
                        context.Writer.WriteStringValue(publicRequestApplicableAssetTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAuthorizedPrincipals())
            {
                context.Writer.WritePropertyName("authorizedPrincipals");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAuthorizedPrincipalsListValue in publicRequest.AuthorizedPrincipals)
                {
                        context.Writer.WriteStringValue(publicRequestAuthorizedPrincipalsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetManageAccessRole())
            {
                context.Writer.WritePropertyName("manageAccessRole");
                context.Writer.WriteStringValue(publicRequest.ManageAccessRole);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetProvider())
            {
                context.Writer.WritePropertyName("provider");
                context.Writer.WriteStringValue(publicRequest.Provider);
            }

            if(publicRequest.IsSetSubscriptionTargetConfig())
            {
                context.Writer.WritePropertyName("subscriptionTargetConfig");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSubscriptionTargetConfigListValue in publicRequest.SubscriptionTargetConfig)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SubscriptionTargetFormMarshaller.Instance;
                    marshaller.Marshall(publicRequestSubscriptionTargetConfigListValue, context);

                    context.Writer.WriteEndObject();
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
        private static UpdateSubscriptionTargetRequestMarshaller _instance = new UpdateSubscriptionTargetRequestMarshaller();        

        internal static UpdateSubscriptionTargetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSubscriptionTargetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}