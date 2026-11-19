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

using Amazon.CodeBuild.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFleet Request Marshaller
    /// </summary>
    public partial class CreateFleetRequestMarshaller : IMarshaller<IRequest, CreateFleetRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFleetRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeBuild");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-10-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/CodeBuild_20161006/operation/CreateFleet";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetBaseCapacity())
                {
                    context.Writer.WriteTextString("baseCapacity");
                    context.Writer.WriteInt32(publicRequest.BaseCapacity.Value);
                }
                if (publicRequest.IsSetComputeConfiguration())
                {
                    context.Writer.WriteTextString("computeConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ComputeConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ComputeConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetComputeType())
                {
                    context.Writer.WriteTextString("computeType");
                    context.Writer.WriteTextString(publicRequest.ComputeType);
                }
                if (publicRequest.IsSetEnvironmentType())
                {
                    context.Writer.WriteTextString("environmentType");
                    context.Writer.WriteTextString(publicRequest.EnvironmentType);
                }
                if (publicRequest.IsSetFleetServiceRole())
                {
                    context.Writer.WriteTextString("fleetServiceRole");
                    context.Writer.WriteTextString(publicRequest.FleetServiceRole);
                }
                if (publicRequest.IsSetImageId())
                {
                    context.Writer.WriteTextString("imageId");
                    context.Writer.WriteTextString(publicRequest.ImageId);
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetOverflowBehavior())
                {
                    context.Writer.WriteTextString("overflowBehavior");
                    context.Writer.WriteTextString(publicRequest.OverflowBehavior);
                }
                if (publicRequest.IsSetProxyConfiguration())
                {
                    context.Writer.WriteTextString("proxyConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ProxyConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ProxyConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetScalingConfiguration())
                {
                    context.Writer.WriteTextString("scalingConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ScalingConfigurationInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ScalingConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("tags");
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
                if (publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WriteTextString("vpcConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = VpcConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfig, context);

                    context.Writer.WriteEndMap();
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

        private static readonly CreateFleetRequestMarshaller _instance = new();

        internal static CreateFleetRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateFleetRequestMarshaller Instance => _instance;
    }
}
