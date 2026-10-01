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

using Amazon.LakeFormation.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLakeFormationOptIn Request Marshaller
    /// </summary>
    public partial class CreateLakeFormationOptInRequestMarshaller : IMarshaller<IRequest, CreateLakeFormationOptInRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLakeFormationOptInRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateLakeFormationOptInRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LakeFormation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/CreateLakeFormationOptIn";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetCondition())
            {
                context.Writer.WritePropertyName("Condition");
                context.Writer.WriteStartObject();

                var marshaller = ConditionMarshaller.Instance;
                marshaller.Marshall(publicRequest.Condition, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetPrincipal())
            {
                context.Writer.WritePropertyName("Principal");
                context.Writer.WriteStartObject();

                var marshaller = DataLakePrincipalMarshaller.Instance;
                marshaller.Marshall(publicRequest.Principal, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetResource())
            {
                context.Writer.WritePropertyName("Resource");
                context.Writer.WriteStartObject();

                var marshaller = ResourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.Resource, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateLakeFormationOptInRequestMarshaller _instance = new();

        internal static CreateLakeFormationOptInRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateLakeFormationOptInRequestMarshaller Instance => _instance;
    }
}
