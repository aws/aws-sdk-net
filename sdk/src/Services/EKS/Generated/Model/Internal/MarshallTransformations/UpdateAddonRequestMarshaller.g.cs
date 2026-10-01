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

using Amazon.EKS.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAddon Request Marshaller
    /// </summary>
    public partial class UpdateAddonRequestMarshaller : IMarshaller<IRequest, UpdateAddonRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAddonRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateAddonRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EKS");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAddonName())
            {
                throw new AmazonEKSException("Request object does not have required field AddonName set");
            }
            request.AddPathResource("{addonName}", StringUtils.FromString(publicRequest.AddonName));

            if (!publicRequest.IsSetClusterName())
            {
                throw new AmazonEKSException("Request object does not have required field ClusterName set");
            }
            request.AddPathResource("{clusterName}", StringUtils.FromString(publicRequest.ClusterName));

            request.ResourcePath = "/clusters/{clusterName}/addons/{addonName}/update";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAddonVersion())
            {
                context.Writer.WritePropertyName("addonVersion");
                context.Writer.WriteStringValue(publicRequest.AddonVersion);
            }
            if (publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("clientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }
            else
            {
                context.Writer.WritePropertyName("clientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetConfigurationValues())
            {
                context.Writer.WritePropertyName("configurationValues");
                context.Writer.WriteStringValue(publicRequest.ConfigurationValues);
            }
            if (publicRequest.IsSetPodIdentityAssociations())
            {
                context.Writer.WritePropertyName("podIdentityAssociations");
                context.Writer.WriteStartArray();
                foreach (var publicRequestPodIdentityAssociationsListValue in publicRequest.PodIdentityAssociations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AddonPodIdentityAssociationsMarshaller.Instance;
                    marshaller.Marshall(publicRequestPodIdentityAssociationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetResolveConflicts())
            {
                context.Writer.WritePropertyName("resolveConflicts");
                context.Writer.WriteStringValue(publicRequest.ResolveConflicts);
            }
            if (publicRequest.IsSetServiceAccountRoleArn())
            {
                context.Writer.WritePropertyName("serviceAccountRoleArn");
                context.Writer.WriteStringValue(publicRequest.ServiceAccountRoleArn);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateAddonRequestMarshaller _instance = new();

        internal static UpdateAddonRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateAddonRequestMarshaller Instance => _instance;
    }
}
