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
    /// UpdateRuleGroup Request Marshaller
    /// </summary>
    public partial class UpdateRuleGroupRequestMarshaller : IMarshaller<IRequest, UpdateRuleGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRuleGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateRuleGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/NetworkFirewall_20201112/operation/UpdateRuleGroup";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAnalyzeRuleGroup())
                {
                    context.Writer.WriteTextString("AnalyzeRuleGroup");
                    context.Writer.WriteBoolean(publicRequest.AnalyzeRuleGroup.Value);
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetDryRun())
                {
                    context.Writer.WriteTextString("DryRun");
                    context.Writer.WriteBoolean(publicRequest.DryRun.Value);
                }
                if (publicRequest.IsSetEncryptionConfiguration())
                {
                    context.Writer.WriteTextString("EncryptionConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = EncryptionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetFirewallRuleGroup())
                {
                    context.Writer.WriteTextString("FirewallRuleGroup");
                    context.Writer.WriteStartMap(null);

                    var marshaller = FirewallRuleGroupMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FirewallRuleGroup, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetIpsRuleGroup())
                {
                    context.Writer.WriteTextString("IpsRuleGroup");
                    context.Writer.WriteStartMap(null);

                    var marshaller = IpsRuleGroupMarshaller.Instance;
                    marshaller.Marshall(publicRequest.IpsRuleGroup, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetRuleGroup())
                {
                    context.Writer.WriteTextString("RuleGroup");
                    context.Writer.WriteStartMap(null);

                    var marshaller = RuleGroupMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RuleGroup, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetRuleGroupArn())
                {
                    context.Writer.WriteTextString("RuleGroupArn");
                    context.Writer.WriteTextString(publicRequest.RuleGroupArn);
                }
                if (publicRequest.IsSetRuleGroupName())
                {
                    context.Writer.WriteTextString("RuleGroupName");
                    context.Writer.WriteTextString(publicRequest.RuleGroupName);
                }
                if (publicRequest.IsSetRules())
                {
                    context.Writer.WriteTextString("Rules");
                    context.Writer.WriteTextString(publicRequest.Rules);
                }
                if (publicRequest.IsSetSourceMetadata())
                {
                    context.Writer.WriteTextString("SourceMetadata");
                    context.Writer.WriteStartMap(null);

                    var marshaller = SourceMetadataMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceMetadata, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSummaryConfiguration())
                {
                    context.Writer.WriteTextString("SummaryConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = SummaryConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SummaryConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetType())
                {
                    context.Writer.WriteTextString("Type");
                    context.Writer.WriteTextString(publicRequest.Type);
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

        private static readonly UpdateRuleGroupRequestMarshaller _instance = new();

        internal static UpdateRuleGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateRuleGroupRequestMarshaller Instance => _instance;
    }
}
