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

using Amazon.Lambda.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddPermission Request Marshaller
    /// </summary>
    public partial class AddPermissionRequestMarshaller : IMarshaller<IRequest, AddPermissionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AddPermissionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AddPermissionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetQualifier())
            {
                request.Parameters.Add("Qualifier", StringUtils.FromString(publicRequest.Qualifier));
            }

            if (!publicRequest.IsSetFunctionName())
            {
                throw new AmazonLambdaException("Request object does not have required field FunctionName set");
            }
            request.AddPathResource("{FunctionName}", StringUtils.FromString(publicRequest.FunctionName));

            request.ResourcePath = "/2015-03-31/functions/{FunctionName}/policy";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.WriteStringValue(publicRequest.Action);
            }
            if (publicRequest.IsSetEventSourceToken())
            {
                context.Writer.WritePropertyName("EventSourceToken");
                context.Writer.WriteStringValue(publicRequest.EventSourceToken);
            }
            if (publicRequest.IsSetFunctionUrlAuthType())
            {
                context.Writer.WritePropertyName("FunctionUrlAuthType");
                context.Writer.WriteStringValue(publicRequest.FunctionUrlAuthType);
            }
            if (publicRequest.IsSetInvokedViaFunctionUrl())
            {
                context.Writer.WritePropertyName("InvokedViaFunctionUrl");
                context.Writer.WriteBooleanValue(publicRequest.InvokedViaFunctionUrl.Value);
            }
            if (publicRequest.IsSetPrincipal())
            {
                context.Writer.WritePropertyName("Principal");
                context.Writer.WriteStringValue(publicRequest.Principal);
            }
            if (publicRequest.IsSetPrincipalOrgID())
            {
                context.Writer.WritePropertyName("PrincipalOrgID");
                context.Writer.WriteStringValue(publicRequest.PrincipalOrgID);
            }
            if (publicRequest.IsSetRevisionId())
            {
                context.Writer.WritePropertyName("RevisionId");
                context.Writer.WriteStringValue(publicRequest.RevisionId);
            }
            if (publicRequest.IsSetSourceAccount())
            {
                context.Writer.WritePropertyName("SourceAccount");
                context.Writer.WriteStringValue(publicRequest.SourceAccount);
            }
            if (publicRequest.IsSetSourceArn())
            {
                context.Writer.WritePropertyName("SourceArn");
                context.Writer.WriteStringValue(publicRequest.SourceArn);
            }
            if (publicRequest.IsSetStatementId())
            {
                context.Writer.WritePropertyName("StatementId");
                context.Writer.WriteStringValue(publicRequest.StatementId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.UseQueryString = true;

            return request;
        }

        private static readonly AddPermissionRequestMarshaller _instance = new();

        internal static AddPermissionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AddPermissionRequestMarshaller Instance => _instance;
    }
}
