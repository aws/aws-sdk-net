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

using Amazon.QBusiness.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutGroup Request Marshaller
    /// </summary>
    public partial class PutGroupRequestMarshaller : IMarshaller<IRequest, PutGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QBusiness");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-27";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetApplicationId())
            {
                throw new AmazonQBusinessException("Request object does not have required field ApplicationId set");
            }
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));

            if (!publicRequest.IsSetIndexId())
            {
                throw new AmazonQBusinessException("Request object does not have required field IndexId set");
            }
            request.AddPathResource("{indexId}", StringUtils.FromString(publicRequest.IndexId));

            request.ResourcePath = "/applications/{applicationId}/indices/{indexId}/groups";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetDataSourceId())
            {
                context.Writer.WritePropertyName("dataSourceId");
                context.Writer.WriteStringValue(publicRequest.DataSourceId);
            }
            if (publicRequest.IsSetGroupMembers())
            {
                context.Writer.WritePropertyName("groupMembers");
                context.Writer.WriteStartObject();

                var marshaller = GroupMembersMarshaller.Instance;
                marshaller.Marshall(publicRequest.GroupMembers, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetGroupName())
            {
                context.Writer.WritePropertyName("groupName");
                context.Writer.WriteStringValue(publicRequest.GroupName);
            }
            if (publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }
            if (publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(publicRequest.Type);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly PutGroupRequestMarshaller _instance = new();

        internal static PutGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutGroupRequestMarshaller Instance => _instance;
    }
}
