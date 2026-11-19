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
    /// UpdateDeploymentGroup Request Marshaller
    /// </summary>
    public partial class UpdateDeploymentGroupRequestMarshaller : IMarshaller<IRequest, UpdateDeploymentGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDeploymentGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateDeploymentGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeDeploy");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-10-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/CodeDeploy_20141006/operation/UpdateDeploymentGroup";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAlarmConfiguration())
                {
                    context.Writer.WriteTextString("alarmConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = AlarmConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AlarmConfiguration, context);

                    context.Writer.WriteEndMap();
                }
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
                if (publicRequest.IsSetAutoScalingGroups())
                {
                    context.Writer.WriteTextString("autoScalingGroups");
                    context.Writer.WriteStartArray(publicRequest.AutoScalingGroups.Count);
                    foreach (var publicRequestAutoScalingGroupsListValue in publicRequest.AutoScalingGroups)
                    {
                        context.Writer.WriteTextString(publicRequestAutoScalingGroupsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetBlueGreenDeploymentConfiguration())
                {
                    context.Writer.WriteTextString("blueGreenDeploymentConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = BlueGreenDeploymentConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BlueGreenDeploymentConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetCurrentDeploymentGroupName())
                {
                    context.Writer.WriteTextString("currentDeploymentGroupName");
                    context.Writer.WriteTextString(publicRequest.CurrentDeploymentGroupName);
                }
                if (publicRequest.IsSetDeploymentConfigName())
                {
                    context.Writer.WriteTextString("deploymentConfigName");
                    context.Writer.WriteTextString(publicRequest.DeploymentConfigName);
                }
                if (publicRequest.IsSetDeploymentStyle())
                {
                    context.Writer.WriteTextString("deploymentStyle");
                    context.Writer.WriteStartMap(null);

                    var marshaller = DeploymentStyleMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeploymentStyle, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetEc2DeploymentOptions())
                {
                    context.Writer.WriteTextString("ec2DeploymentOptions");
                    context.Writer.WriteStartMap(null);

                    var marshaller = EC2DeploymentOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Ec2DeploymentOptions, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetEc2TagFilters())
                {
                    context.Writer.WriteTextString("ec2TagFilters");
                    context.Writer.WriteStartArray(publicRequest.Ec2TagFilters.Count);
                    foreach (var publicRequestEc2TagFiltersListValue in publicRequest.Ec2TagFilters)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = EC2TagFilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestEc2TagFiltersListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetEc2TagSet())
                {
                    context.Writer.WriteTextString("ec2TagSet");
                    context.Writer.WriteStartMap(null);

                    var marshaller = EC2TagSetMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Ec2TagSet, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetEcsServices())
                {
                    context.Writer.WriteTextString("ecsServices");
                    context.Writer.WriteStartArray(publicRequest.EcsServices.Count);
                    foreach (var publicRequestEcsServicesListValue in publicRequest.EcsServices)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ECSServiceMarshaller.Instance;
                        marshaller.Marshall(publicRequestEcsServicesListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetLoadBalancerInfo())
                {
                    context.Writer.WriteTextString("loadBalancerInfo");
                    context.Writer.WriteStartMap(null);

                    var marshaller = LoadBalancerInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LoadBalancerInfo, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetNewDeploymentGroupName())
                {
                    context.Writer.WriteTextString("newDeploymentGroupName");
                    context.Writer.WriteTextString(publicRequest.NewDeploymentGroupName);
                }
                if (publicRequest.IsSetOnPremisesInstanceTagFilters())
                {
                    context.Writer.WriteTextString("onPremisesInstanceTagFilters");
                    context.Writer.WriteStartArray(publicRequest.OnPremisesInstanceTagFilters.Count);
                    foreach (var publicRequestOnPremisesInstanceTagFiltersListValue in publicRequest.OnPremisesInstanceTagFilters)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagFilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestOnPremisesInstanceTagFiltersListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetOnPremisesTagSet())
                {
                    context.Writer.WriteTextString("onPremisesTagSet");
                    context.Writer.WriteStartMap(null);

                    var marshaller = OnPremisesTagSetMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OnPremisesTagSet, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetOutdatedInstancesStrategy())
                {
                    context.Writer.WriteTextString("outdatedInstancesStrategy");
                    context.Writer.WriteTextString(publicRequest.OutdatedInstancesStrategy);
                }
                if (publicRequest.IsSetServiceRoleArn())
                {
                    context.Writer.WriteTextString("serviceRoleArn");
                    context.Writer.WriteTextString(publicRequest.ServiceRoleArn);
                }
                if (publicRequest.IsSetTerminationHookEnabled())
                {
                    context.Writer.WriteTextString("terminationHookEnabled");
                    context.Writer.WriteBoolean(publicRequest.TerminationHookEnabled.Value);
                }
                if (publicRequest.IsSetTriggerConfigurations())
                {
                    context.Writer.WriteTextString("triggerConfigurations");
                    context.Writer.WriteStartArray(publicRequest.TriggerConfigurations.Count);
                    foreach (var publicRequestTriggerConfigurationsListValue in publicRequest.TriggerConfigurations)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TriggerConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestTriggerConfigurationsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
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

        private static readonly UpdateDeploymentGroupRequestMarshaller _instance = new();

        internal static UpdateDeploymentGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateDeploymentGroupRequestMarshaller Instance => _instance;
    }
}
