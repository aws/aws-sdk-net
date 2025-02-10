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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
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
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateIpRestriction Request Marshaller
    /// </summary>       
    public class UpdateIpRestrictionRequestMarshaller : IMarshaller<IRequest, UpdateIpRestrictionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateIpRestrictionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateIpRestrictionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            request.ResourcePath = "/accounts/{AwsAccountId}/ip-restriction";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.WriteBooleanValue(publicRequest.Enabled.Value);
            }

            if(publicRequest.IsSetIpRestrictionRuleMap())
            {
                context.Writer.WritePropertyName("IpRestrictionRuleMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestIpRestrictionRuleMapKvp in publicRequest.IpRestrictionRuleMap)
                {
                    context.Writer.WritePropertyName(publicRequestIpRestrictionRuleMapKvp.Key);
                    var publicRequestIpRestrictionRuleMapValue = publicRequestIpRestrictionRuleMapKvp.Value;

                        context.Writer.WriteStringValue(publicRequestIpRestrictionRuleMapValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVpcEndpointIdRestrictionRuleMap())
            {
                context.Writer.WritePropertyName("VpcEndpointIdRestrictionRuleMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestVpcEndpointIdRestrictionRuleMapKvp in publicRequest.VpcEndpointIdRestrictionRuleMap)
                {
                    context.Writer.WritePropertyName(publicRequestVpcEndpointIdRestrictionRuleMapKvp.Key);
                    var publicRequestVpcEndpointIdRestrictionRuleMapValue = publicRequestVpcEndpointIdRestrictionRuleMapKvp.Value;

                        context.Writer.WriteStringValue(publicRequestVpcEndpointIdRestrictionRuleMapValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVpcIdRestrictionRuleMap())
            {
                context.Writer.WritePropertyName("VpcIdRestrictionRuleMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestVpcIdRestrictionRuleMapKvp in publicRequest.VpcIdRestrictionRuleMap)
                {
                    context.Writer.WritePropertyName(publicRequestVpcIdRestrictionRuleMapKvp.Key);
                    var publicRequestVpcIdRestrictionRuleMapValue = publicRequestVpcIdRestrictionRuleMapKvp.Value;

                        context.Writer.WriteStringValue(publicRequestVpcIdRestrictionRuleMapValue);
                }
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
        private static UpdateIpRestrictionRequestMarshaller _instance = new UpdateIpRestrictionRequestMarshaller();        

        internal static UpdateIpRestrictionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateIpRestrictionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}