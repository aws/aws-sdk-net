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

using Amazon.WorkMail.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.WorkMail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetMobileDeviceAccessEffect Request Marshaller
    /// </summary>
    public partial class GetMobileDeviceAccessEffectRequestMarshaller : IMarshaller<IRequest, GetMobileDeviceAccessEffectRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetMobileDeviceAccessEffectRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetMobileDeviceAccessEffectRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkMail");
            string target = "WorkMailService.GetMobileDeviceAccessEffect";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetDeviceModel())
            {
                context.Writer.WritePropertyName("DeviceModel");
                context.Writer.WriteStringValue(publicRequest.DeviceModel);
            }
            if (publicRequest.IsSetDeviceOperatingSystem())
            {
                context.Writer.WritePropertyName("DeviceOperatingSystem");
                context.Writer.WriteStringValue(publicRequest.DeviceOperatingSystem);
            }
            if (publicRequest.IsSetDeviceType())
            {
                context.Writer.WritePropertyName("DeviceType");
                context.Writer.WriteStringValue(publicRequest.DeviceType);
            }
            if (publicRequest.IsSetDeviceUserAgent())
            {
                context.Writer.WritePropertyName("DeviceUserAgent");
                context.Writer.WriteStringValue(publicRequest.DeviceUserAgent);
            }
            if (publicRequest.IsSetOrganizationId())
            {
                context.Writer.WritePropertyName("OrganizationId");
                context.Writer.WriteStringValue(publicRequest.OrganizationId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly GetMobileDeviceAccessEffectRequestMarshaller _instance = new();

        internal static GetMobileDeviceAccessEffectRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetMobileDeviceAccessEffectRequestMarshaller Instance => _instance;
    }
}
