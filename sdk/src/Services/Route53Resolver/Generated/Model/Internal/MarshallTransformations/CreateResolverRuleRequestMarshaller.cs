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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53Resolver.Model;
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
namespace Amazon.Route53Resolver.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateResolverRule Request Marshaller
    /// </summary>       
    public class CreateResolverRuleRequestMarshaller : IMarshaller<IRequest, CreateResolverRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateResolverRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateResolverRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53Resolver");
            string target = "Route53Resolver.CreateResolverRule";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
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
            if(publicRequest.IsSetCreatorRequestId())
            {
                context.Writer.WritePropertyName("CreatorRequestId");
                context.Writer.WriteStringValue(publicRequest.CreatorRequestId);
            }

            if(publicRequest.IsSetDelegationRecord())
            {
                context.Writer.WritePropertyName("DelegationRecord");
                context.Writer.WriteStringValue(publicRequest.DelegationRecord);
            }

            if(publicRequest.IsSetDomainName())
            {
                context.Writer.WritePropertyName("DomainName");
                context.Writer.WriteStringValue(publicRequest.DomainName);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetResolverEndpointId())
            {
                context.Writer.WritePropertyName("ResolverEndpointId");
                context.Writer.WriteStringValue(publicRequest.ResolverEndpointId);
            }

            if(publicRequest.IsSetRuleType())
            {
                context.Writer.WritePropertyName("RuleType");
                context.Writer.WriteStringValue(publicRequest.RuleType);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTargetIps())
            {
                context.Writer.WritePropertyName("TargetIps");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTargetIpsListValue in publicRequest.TargetIps)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetAddressMarshaller.Instance;
                    marshaller.Marshall(publicRequestTargetIpsListValue, context);

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
        private static CreateResolverRuleRequestMarshaller _instance = new CreateResolverRuleRequestMarshaller();        

        internal static CreateResolverRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateResolverRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}