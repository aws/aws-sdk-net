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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDeploymentGroup Request Marshaller
    /// </summary>       
    public class CreateDeploymentGroupRequestMarshaller : IMarshaller<IRequest, CreateDeploymentGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDeploymentGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDeploymentGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeDeploy");
            string target = "CodeDeploy_20141006.CreateDeploymentGroup";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-10-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAlarmConfiguration())
            {
                context.Writer.WritePropertyName("alarmConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AlarmConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AlarmConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetApplicationName())
            {
                context.Writer.WritePropertyName("applicationName");
                context.Writer.WriteStringValue(publicRequest.ApplicationName);
            }

            if(publicRequest.IsSetAutoRollbackConfiguration())
            {
                context.Writer.WritePropertyName("autoRollbackConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AutoRollbackConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutoRollbackConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAutoScalingGroups())
            {
                context.Writer.WritePropertyName("autoScalingGroups");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAutoScalingGroupsListValue in publicRequest.AutoScalingGroups)
                {
                        context.Writer.WriteStringValue(publicRequestAutoScalingGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetBlueGreenDeploymentConfiguration())
            {
                context.Writer.WritePropertyName("blueGreenDeploymentConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = BlueGreenDeploymentConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.BlueGreenDeploymentConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeploymentConfigName())
            {
                context.Writer.WritePropertyName("deploymentConfigName");
                context.Writer.WriteStringValue(publicRequest.DeploymentConfigName);
            }

            if(publicRequest.IsSetDeploymentGroupName())
            {
                context.Writer.WritePropertyName("deploymentGroupName");
                context.Writer.WriteStringValue(publicRequest.DeploymentGroupName);
            }

            if(publicRequest.IsSetDeploymentStyle())
            {
                context.Writer.WritePropertyName("deploymentStyle");
                context.Writer.WriteStartObject();

                var marshaller = DeploymentStyleMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeploymentStyle, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEc2TagFilters())
            {
                context.Writer.WritePropertyName("ec2TagFilters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEc2TagFiltersListValue in publicRequest.Ec2TagFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EC2TagFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequestEc2TagFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEc2TagSet())
            {
                context.Writer.WritePropertyName("ec2TagSet");
                context.Writer.WriteStartObject();

                var marshaller = EC2TagSetMarshaller.Instance;
                marshaller.Marshall(publicRequest.Ec2TagSet, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEcsServices())
            {
                context.Writer.WritePropertyName("ecsServices");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEcsServicesListValue in publicRequest.EcsServices)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ECSServiceMarshaller.Instance;
                    marshaller.Marshall(publicRequestEcsServicesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLoadBalancerInfo())
            {
                context.Writer.WritePropertyName("loadBalancerInfo");
                context.Writer.WriteStartObject();

                var marshaller = LoadBalancerInfoMarshaller.Instance;
                marshaller.Marshall(publicRequest.LoadBalancerInfo, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOnPremisesInstanceTagFilters())
            {
                context.Writer.WritePropertyName("onPremisesInstanceTagFilters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOnPremisesInstanceTagFiltersListValue in publicRequest.OnPremisesInstanceTagFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequestOnPremisesInstanceTagFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOnPremisesTagSet())
            {
                context.Writer.WritePropertyName("onPremisesTagSet");
                context.Writer.WriteStartObject();

                var marshaller = OnPremisesTagSetMarshaller.Instance;
                marshaller.Marshall(publicRequest.OnPremisesTagSet, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutdatedInstancesStrategy())
            {
                context.Writer.WritePropertyName("outdatedInstancesStrategy");
                context.Writer.WriteStringValue(publicRequest.OutdatedInstancesStrategy);
            }

            if(publicRequest.IsSetServiceRoleArn())
            {
                context.Writer.WritePropertyName("serviceRoleArn");
                context.Writer.WriteStringValue(publicRequest.ServiceRoleArn);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTerminationHookEnabled())
            {
                context.Writer.WritePropertyName("terminationHookEnabled");
                context.Writer.WriteBooleanValue(publicRequest.TerminationHookEnabled.Value);
            }

            if(publicRequest.IsSetTriggerConfigurations())
            {
                context.Writer.WritePropertyName("triggerConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTriggerConfigurationsListValue in publicRequest.TriggerConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TriggerConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestTriggerConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateDeploymentGroupRequestMarshaller _instance = new CreateDeploymentGroupRequestMarshaller();        

        internal static CreateDeploymentGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDeploymentGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}