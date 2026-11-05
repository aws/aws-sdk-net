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

using Amazon.Inspector2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEc2DeepInspectionConfiguration Request Marshaller
    /// </summary>
    public partial class UpdateEc2DeepInspectionConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateEc2DeepInspectionConfigurationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEc2DeepInspectionConfigurationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateEc2DeepInspectionConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Inspector2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-06-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "/ec2deepinspectionconfiguration/update";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetActivateDeepInspection())
            {
                context.Writer.WritePropertyName("activateDeepInspection");
                context.Writer.WriteBooleanValue(publicRequest.ActivateDeepInspection.Value);
            }
            if (publicRequest.IsSetPackagePaths())
            {
                context.Writer.WritePropertyName("packagePaths");
                context.Writer.WriteStartArray();
                foreach (var publicRequestPackagePathsListValue in publicRequest.PackagePaths)
                {
                    context.Writer.WriteStringValue(publicRequestPackagePathsListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateEc2DeepInspectionConfigurationRequestMarshaller _instance = new();

        internal static UpdateEc2DeepInspectionConfigurationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateEc2DeepInspectionConfigurationRequestMarshaller Instance => _instance;
    }
}
