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

using Amazon.GuardDuty.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCustomDetectionRuleAssociation Request Marshaller
    /// </summary>
    public partial class UpdateCustomDetectionRuleAssociationRequestMarshaller : IMarshaller<IRequest, UpdateCustomDetectionRuleAssociationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCustomDetectionRuleAssociationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateCustomDetectionRuleAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GuardDuty");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-28";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAssociationId())
            {
                throw new AmazonGuardDutyException("Request object does not have required field AssociationId set");
            }
            request.AddPathResource("{AssociationId}", StringUtils.FromString(publicRequest.AssociationId));

            if (!publicRequest.IsSetRuleId())
            {
                throw new AmazonGuardDutyException("Request object does not have required field RuleId set");
            }
            request.AddPathResource("{RuleId}", StringUtils.FromString(publicRequest.RuleId));

            request.ResourcePath = "/custom-detection-rule/rule/{RuleId}/association/{AssociationId}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetMode())
            {
                context.Writer.WritePropertyName("mode");
                context.Writer.WriteStringValue(publicRequest.Mode);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateCustomDetectionRuleAssociationRequestMarshaller _instance = new();

        internal static UpdateCustomDetectionRuleAssociationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateCustomDetectionRuleAssociationRequestMarshaller Instance => _instance;
    }
}
