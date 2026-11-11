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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

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
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-10-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/CodeDeploy_20141006/operation/CreateDeployment";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetApplicationName())
                {
                    context.Writer.WriteTextString("applicationName");
                    context.Writer.WriteTextString(publicRequest.ApplicationName);
                }
                if (publicRequest.IsSetAutoRollbackConfiguration())
                {
                    context.Writer.WriteTextString("autoRollbackConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = AutoRollbackConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutoRollbackConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDeploymentConfigName())
                {
                    context.Writer.WriteTextString("deploymentConfigName");
                    context.Writer.WriteTextString(publicRequest.DeploymentConfigName);
                }
                if (publicRequest.IsSetDeploymentGroupName())
                {
                    context.Writer.WriteTextString("deploymentGroupName");
                    context.Writer.WriteTextString(publicRequest.DeploymentGroupName);
                }
                if (publicRequest.IsSetDeploymentMode())
                {
                    context.Writer.WriteTextString("deploymentMode");
                    context.Writer.WriteTextString(publicRequest.DeploymentMode);
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetEc2DeploymentOptions())
                {
                    context.Writer.WriteTextString("ec2DeploymentOptions");
                    context.Writer.WriteStartMap(null);

                    var marshaller = EC2DeploymentOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Ec2DeploymentOptions, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetFileExistsBehavior())
                {
                    context.Writer.WriteTextString("fileExistsBehavior");
                    context.Writer.WriteTextString(publicRequest.FileExistsBehavior);
                }
                if (publicRequest.IsSetIgnoreApplicationStopFailures())
                {
                    context.Writer.WriteTextString("ignoreApplicationStopFailures");
                    context.Writer.WriteBoolean(publicRequest.IgnoreApplicationStopFailures.Value);
                }
                if (publicRequest.IsSetOverrideAlarmConfiguration())
                {
                    context.Writer.WriteTextString("overrideAlarmConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = AlarmConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OverrideAlarmConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetRevision())
                {
                    context.Writer.WriteTextString("revision");
                    context.Writer.WriteStartMap(null);

                    var marshaller = RevisionLocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Revision, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetTargetInstances())
                {
                    context.Writer.WriteTextString("targetInstances");
                    context.Writer.WriteStartMap(null);

                    var marshaller = TargetInstancesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TargetInstances, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetUpdateOutdatedInstancesOnly())
                {
                    context.Writer.WriteTextString("updateOutdatedInstancesOnly");
                    context.Writer.WriteBoolean(publicRequest.UpdateOutdatedInstancesOnly.Value);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

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
