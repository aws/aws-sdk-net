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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateProxyRule Request Marshaller
    /// </summary>
    public partial class UpdateProxyRuleRequestMarshaller : IMarshaller<IRequest, UpdateProxyRuleRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateProxyRuleRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateProxyRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/NetworkFirewall_20201112/operation/UpdateProxyRule";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAction())
                {
                    context.Writer.WriteTextString("Action");
                    context.Writer.WriteTextString(publicRequest.Action);
                }
                if (publicRequest.IsSetAddConditions())
                {
                    context.Writer.WriteTextString("AddConditions");
                    context.Writer.WriteStartArray(publicRequest.AddConditions.Count);
                    foreach (var publicRequestAddConditionsListValue in publicRequest.AddConditions)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ProxyRuleConditionMarshaller.Instance;
                        marshaller.Marshall(publicRequestAddConditionsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetProxyRuleGroupArn())
                {
                    context.Writer.WriteTextString("ProxyRuleGroupArn");
                    context.Writer.WriteTextString(publicRequest.ProxyRuleGroupArn);
                }
                if (publicRequest.IsSetProxyRuleGroupName())
                {
                    context.Writer.WriteTextString("ProxyRuleGroupName");
                    context.Writer.WriteTextString(publicRequest.ProxyRuleGroupName);
                }
                if (publicRequest.IsSetProxyRuleName())
                {
                    context.Writer.WriteTextString("ProxyRuleName");
                    context.Writer.WriteTextString(publicRequest.ProxyRuleName);
                }
                if (publicRequest.IsSetRemoveConditions())
                {
                    context.Writer.WriteTextString("RemoveConditions");
                    context.Writer.WriteStartArray(publicRequest.RemoveConditions.Count);
                    foreach (var publicRequestRemoveConditionsListValue in publicRequest.RemoveConditions)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ProxyRuleConditionMarshaller.Instance;
                        marshaller.Marshall(publicRequestRemoveConditionsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetUpdateToken())
                {
                    context.Writer.WriteTextString("UpdateToken");
                    context.Writer.WriteTextString(publicRequest.UpdateToken);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly UpdateProxyRuleRequestMarshaller _instance = new();

        internal static UpdateProxyRuleRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateProxyRuleRequestMarshaller Instance => _instance;
    }
}
