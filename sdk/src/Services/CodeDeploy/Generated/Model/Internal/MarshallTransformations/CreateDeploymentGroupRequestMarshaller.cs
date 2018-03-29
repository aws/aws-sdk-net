/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

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
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAlarmConfiguration())
                {
                    context.Writer.WritePropertyName("alarmConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AlarmConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AlarmConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetApplicationName())
                {
                    context.Writer.WritePropertyName("applicationName");
                    context.Writer.Write(publicRequest.ApplicationName);
                }

                if(publicRequest.IsSetAutoRollbackConfiguration())
                {
                    context.Writer.WritePropertyName("autoRollbackConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AutoRollbackConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutoRollbackConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAutoScalingGroups())
                {
                    context.Writer.WritePropertyName("autoScalingGroups");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAutoScalingGroupsListValue in publicRequest.AutoScalingGroups)
                    {
                            context.Writer.Write(publicRequestAutoScalingGroupsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetBlueGreenDeploymentConfiguration())
                {
                    context.Writer.WritePropertyName("blueGreenDeploymentConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = BlueGreenDeploymentConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BlueGreenDeploymentConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDeploymentConfigName())
                {
                    context.Writer.WritePropertyName("deploymentConfigName");
                    context.Writer.Write(publicRequest.DeploymentConfigName);
                }

                if(publicRequest.IsSetDeploymentGroupName())
                {
                    context.Writer.WritePropertyName("deploymentGroupName");
                    context.Writer.Write(publicRequest.DeploymentGroupName);
                }

                if(publicRequest.IsSetDeploymentStyle())
                {
                    context.Writer.WritePropertyName("deploymentStyle");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeploymentStyleMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeploymentStyle, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEc2TagFilters())
                {
                    context.Writer.WritePropertyName("ec2TagFilters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEc2TagFiltersListValue in publicRequest.Ec2TagFilters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EC2TagFilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestEc2TagFiltersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEc2TagSet())
                {
                    context.Writer.WritePropertyName("ec2TagSet");
                    context.Writer.WriteObjectStart();

                    var marshaller = EC2TagSetMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Ec2TagSet, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLoadBalancerInfo())
                {
                    context.Writer.WritePropertyName("loadBalancerInfo");
                    context.Writer.WriteObjectStart();

                    var marshaller = LoadBalancerInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LoadBalancerInfo, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOnPremisesInstanceTagFilters())
                {
                    context.Writer.WritePropertyName("onPremisesInstanceTagFilters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOnPremisesInstanceTagFiltersListValue in publicRequest.OnPremisesInstanceTagFilters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagFilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestOnPremisesInstanceTagFiltersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOnPremisesTagSet())
                {
                    context.Writer.WritePropertyName("onPremisesTagSet");
                    context.Writer.WriteObjectStart();

                    var marshaller = OnPremisesTagSetMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OnPremisesTagSet, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetServiceRoleArn())
                {
                    context.Writer.WritePropertyName("serviceRoleArn");
                    context.Writer.Write(publicRequest.ServiceRoleArn);
                }

                if(publicRequest.IsSetTriggerConfigurations())
                {
                    context.Writer.WritePropertyName("triggerConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTriggerConfigurationsListValue in publicRequest.TriggerConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TriggerConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestTriggerConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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