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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.EKSAuth.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.EKSAuth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssumeRoleForPodIdentity Request Marshaller
    /// </summary>
    public partial class AssumeRoleForPodIdentityRequestMarshaller : IMarshaller<IRequest, AssumeRoleForPodIdentityRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssumeRoleForPodIdentityRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AssumeRoleForPodIdentityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EKSAuth");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-26";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetClusterName())
            {
                throw new AmazonEKSAuthException("Request object does not have required field ClusterName set");
            }
            request.AddPathResource("{clusterName}", StringUtils.FromString(publicRequest.ClusterName));

            request.ResourcePath = "/clusters/{clusterName}/assume-role-for-pod-identity";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetEksNodeName())
            {
                context.Writer.WritePropertyName("eksNodeName");
                context.Writer.WriteStringValue(publicRequest.EksNodeName);
            }
            if (publicRequest.IsSetInstanceId())
            {
                context.Writer.WritePropertyName("instanceId");
                context.Writer.WriteStringValue(publicRequest.InstanceId);
            }
            if (publicRequest.IsSetToken())
            {
                context.Writer.WritePropertyName("token");
                context.Writer.WriteStringValue(publicRequest.Token);
            }
            if (publicRequest.IsSetZone())
            {
                context.Writer.WritePropertyName("zone");
                context.Writer.WriteStringValue(publicRequest.Zone);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly AssumeRoleForPodIdentityRequestMarshaller _instance = new();

        internal static AssumeRoleForPodIdentityRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AssumeRoleForPodIdentityRequestMarshaller Instance => _instance;
    }
}
