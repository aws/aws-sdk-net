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

using Amazon.QuickSight.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutPolicyAssignment Request Marshaller
    /// </summary>
    public partial class PutPolicyAssignmentRequestMarshaller : IMarshaller<IRequest, PutPolicyAssignmentRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutPolicyAssignmentRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutPolicyAssignmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAccountId())
            {
                throw new AmazonQuickSightException("Request object does not have required field AccountId set");
            }
            request.AddPathResource("{AccountId}", StringUtils.FromString(publicRequest.AccountId));

            request.ResourcePath = "/governance-policy-mgmt/accounts/{AccountId}/policy-assignments";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetExistingPolicyArn())
            {
                context.Writer.WritePropertyName("ExistingPolicyArn");
                context.Writer.WriteStringValue(publicRequest.ExistingPolicyArn);
            }
            if (publicRequest.IsSetPolicyArn())
            {
                context.Writer.WritePropertyName("PolicyArn");
                context.Writer.WriteStringValue(publicRequest.PolicyArn);
            }
            if (publicRequest.IsSetPrincipalArn())
            {
                context.Writer.WritePropertyName("PrincipalArn");
                context.Writer.WriteStringValue(publicRequest.PrincipalArn);
            }
            if (publicRequest.IsSetRevision())
            {
                context.Writer.WritePropertyName("Revision");
                context.Writer.WriteNumberValue(publicRequest.Revision.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly PutPolicyAssignmentRequestMarshaller _instance = new();

        internal static PutPolicyAssignmentRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutPolicyAssignmentRequestMarshaller Instance => _instance;
    }
}
