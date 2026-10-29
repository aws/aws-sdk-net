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

using Amazon.CodeDeploy.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDeployment Request Marshaller
    /// </summary>
    public partial class CreateDeploymentRequestMarshaller : IMarshaller<IRequest, CreateDeploymentRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDeploymentRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateDeploymentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeDeploy");
            string target = "CodeDeploy_20141006.CreateDeployment";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-10-06";
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
            if (publicRequest.IsSetApplicationName())
            {
                context.Writer.WritePropertyName("applicationName");
                context.Writer.WriteStringValue(publicRequest.ApplicationName);
            }
            if (publicRequest.IsSetAutoRollbackConfiguration())
            {
                context.Writer.WritePropertyName("autoRollbackConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AutoRollbackConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutoRollbackConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDeploymentConfigName())
            {
                context.Writer.WritePropertyName("deploymentConfigName");
                context.Writer.WriteStringValue(publicRequest.DeploymentConfigName);
            }
            if (publicRequest.IsSetDeploymentGroupName())
            {
                context.Writer.WritePropertyName("deploymentGroupName");
                context.Writer.WriteStringValue(publicRequest.DeploymentGroupName);
            }
            if (publicRequest.IsSetDeploymentMode())
            {
                context.Writer.WritePropertyName("deploymentMode");
                context.Writer.WriteStringValue(publicRequest.DeploymentMode);
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetEc2DeploymentOptions())
            {
                context.Writer.WritePropertyName("ec2DeploymentOptions");
                context.Writer.WriteStartObject();

                var marshaller = EC2DeploymentOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Ec2DeploymentOptions, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetFileExistsBehavior())
            {
                context.Writer.WritePropertyName("fileExistsBehavior");
                context.Writer.WriteStringValue(publicRequest.FileExistsBehavior);
            }
            if (publicRequest.IsSetIgnoreApplicationStopFailures())
            {
                context.Writer.WritePropertyName("ignoreApplicationStopFailures");
                context.Writer.WriteBooleanValue(publicRequest.IgnoreApplicationStopFailures.Value);
            }
            if (publicRequest.IsSetOverrideAlarmConfiguration())
            {
                context.Writer.WritePropertyName("overrideAlarmConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AlarmConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.OverrideAlarmConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetRevision())
            {
                context.Writer.WritePropertyName("revision");
                context.Writer.WriteStartObject();

                var marshaller = RevisionLocationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Revision, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTargetInstances())
            {
                context.Writer.WritePropertyName("targetInstances");
                context.Writer.WriteStartObject();

                var marshaller = TargetInstancesMarshaller.Instance;
                marshaller.Marshall(publicRequest.TargetInstances, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetUpdateOutdatedInstancesOnly())
            {
                context.Writer.WritePropertyName("updateOutdatedInstancesOnly");
                context.Writer.WriteBooleanValue(publicRequest.UpdateOutdatedInstancesOnly.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateDeploymentRequestMarshaller _instance = new();

        internal static CreateDeploymentRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateDeploymentRequestMarshaller Instance => _instance;
    }
}
