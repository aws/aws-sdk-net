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

using Amazon.ApplicationInsights.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ApplicationInsights.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateApplication Request Marshaller
    /// </summary>
    public partial class CreateApplicationRequestMarshaller : IMarshaller<IRequest, CreateApplicationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateApplicationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApplicationInsights");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/EC2WindowsBarleyService/operation/CreateApplication";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAttachMissingPermission())
                {
                    context.Writer.WriteTextString("AttachMissingPermission");
                    context.Writer.WriteBoolean(publicRequest.AttachMissingPermission.Value);
                }
                if (publicRequest.IsSetAutoConfigEnabled())
                {
                    context.Writer.WriteTextString("AutoConfigEnabled");
                    context.Writer.WriteBoolean(publicRequest.AutoConfigEnabled.Value);
                }
                if (publicRequest.IsSetAutoCreate())
                {
                    context.Writer.WriteTextString("AutoCreate");
                    context.Writer.WriteBoolean(publicRequest.AutoCreate.Value);
                }
                if (publicRequest.IsSetCWEMonitorEnabled())
                {
                    context.Writer.WriteTextString("CWEMonitorEnabled");
                    context.Writer.WriteBoolean(publicRequest.CWEMonitorEnabled.Value);
                }
                if (publicRequest.IsSetGroupingType())
                {
                    context.Writer.WriteTextString("GroupingType");
                    context.Writer.WriteTextString(publicRequest.GroupingType);
                }
                if (publicRequest.IsSetOpsCenterEnabled())
                {
                    context.Writer.WriteTextString("OpsCenterEnabled");
                    context.Writer.WriteBoolean(publicRequest.OpsCenterEnabled.Value);
                }
                if (publicRequest.IsSetOpsItemSNSTopicArn())
                {
                    context.Writer.WriteTextString("OpsItemSNSTopicArn");
                    context.Writer.WriteTextString(publicRequest.OpsItemSNSTopicArn);
                }
                if (publicRequest.IsSetResourceGroupName())
                {
                    context.Writer.WriteTextString("ResourceGroupName");
                    context.Writer.WriteTextString(publicRequest.ResourceGroupName);
                }
                if (publicRequest.IsSetSNSNotificationArn())
                {
                    context.Writer.WriteTextString("SNSNotificationArn");
                    context.Writer.WriteTextString(publicRequest.SNSNotificationArn);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach (var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
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

        private static readonly CreateApplicationRequestMarshaller _instance = new();

        internal static CreateApplicationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateApplicationRequestMarshaller Instance => _instance;
    }
}
