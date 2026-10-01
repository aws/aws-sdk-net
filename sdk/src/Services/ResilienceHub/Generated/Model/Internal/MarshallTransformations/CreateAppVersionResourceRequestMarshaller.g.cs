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

using Amazon.ResilienceHub.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAppVersionResource Request Marshaller
    /// </summary>
    public partial class CreateAppVersionResourceRequestMarshaller : IMarshaller<IRequest, CreateAppVersionResourceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAppVersionResourceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateAppVersionResourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResilienceHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-04-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/create-app-version-resource";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAdditionalInfo())
            {
                context.Writer.WritePropertyName("additionalInfo");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAdditionalInfoKvp in publicRequest.AdditionalInfo)
                {
                    context.Writer.WritePropertyName(publicRequestAdditionalInfoKvp.Key);
                    var publicRequestAdditionalInfoValue = publicRequestAdditionalInfoKvp.Value;
                    context.Writer.WriteStartArray();
                    foreach (var publicRequestAdditionalInfoValueListValue in publicRequestAdditionalInfoValue)
                    {
                        context.Writer.WriteStringValue(publicRequestAdditionalInfoValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetAppArn())
            {
                context.Writer.WritePropertyName("appArn");
                context.Writer.WriteStringValue(publicRequest.AppArn);
            }
            if (publicRequest.IsSetAppComponents())
            {
                context.Writer.WritePropertyName("appComponents");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAppComponentsListValue in publicRequest.AppComponents)
                {
                    context.Writer.WriteStringValue(publicRequestAppComponentsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetAwsAccountId())
            {
                context.Writer.WritePropertyName("awsAccountId");
                context.Writer.WriteStringValue(publicRequest.AwsAccountId);
            }
            if (publicRequest.IsSetAwsRegion())
            {
                context.Writer.WritePropertyName("awsRegion");
                context.Writer.WriteStringValue(publicRequest.AwsRegion);
            }
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetLogicalResourceId())
            {
                context.Writer.WritePropertyName("logicalResourceId");
                context.Writer.WriteStartObject();

                var marshaller = LogicalResourceIdMarshaller.Instance;
                marshaller.Marshall(publicRequest.LogicalResourceId, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetPhysicalResourceId())
            {
                context.Writer.WritePropertyName("physicalResourceId");
                context.Writer.WriteStringValue(publicRequest.PhysicalResourceId);
            }
            if (publicRequest.IsSetResourceName())
            {
                context.Writer.WritePropertyName("resourceName");
                context.Writer.WriteStringValue(publicRequest.ResourceName);
            }
            if (publicRequest.IsSetResourceType())
            {
                context.Writer.WritePropertyName("resourceType");
                context.Writer.WriteStringValue(publicRequest.ResourceType);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateAppVersionResourceRequestMarshaller _instance = new();

        internal static CreateAppVersionResourceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateAppVersionResourceRequestMarshaller Instance => _instance;
    }
}
