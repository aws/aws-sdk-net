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

using Amazon.StepFunctions.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.StepFunctions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TestState Request Marshaller
    /// </summary>
    public partial class TestStateRequestMarshaller : IMarshaller<IRequest, TestStateRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TestStateRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(TestStateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StepFunctions");
            string target = "AWSStepFunctions.TestState";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-23";
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
            if (publicRequest.IsSetContext())
            {
                context.Writer.WritePropertyName("context");
                context.Writer.WriteStringValue(publicRequest.Context);
            }
            if (publicRequest.IsSetDefinition())
            {
                context.Writer.WritePropertyName("definition");
                context.Writer.WriteStringValue(publicRequest.Definition);
            }
            if (publicRequest.IsSetInput())
            {
                context.Writer.WritePropertyName("input");
                context.Writer.WriteStringValue(publicRequest.Input);
            }
            if (publicRequest.IsSetInspectionLevel())
            {
                context.Writer.WritePropertyName("inspectionLevel");
                context.Writer.WriteStringValue(publicRequest.InspectionLevel);
            }
            if (publicRequest.IsSetMock())
            {
                context.Writer.WritePropertyName("mock");
                context.Writer.WriteStartObject();

                var marshaller = MockInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.Mock, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetRevealSecrets())
            {
                context.Writer.WritePropertyName("revealSecrets");
                context.Writer.WriteBooleanValue(publicRequest.RevealSecrets.Value);
            }
            if (publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }
            if (publicRequest.IsSetStateConfiguration())
            {
                context.Writer.WritePropertyName("stateConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TestStateConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.StateConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetStateName())
            {
                context.Writer.WritePropertyName("stateName");
                context.Writer.WriteStringValue(publicRequest.StateName);
            }
            if (publicRequest.IsSetVariables())
            {
                context.Writer.WritePropertyName("variables");
                context.Writer.WriteStringValue(publicRequest.Variables);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.HostPrefix = $"sync-";

            return request;
        }

        private static readonly TestStateRequestMarshaller _instance = new();

        internal static TestStateRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TestStateRequestMarshaller Instance => _instance;
    }
}
