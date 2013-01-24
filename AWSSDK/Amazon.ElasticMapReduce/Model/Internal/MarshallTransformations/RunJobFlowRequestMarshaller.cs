/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Run Job Flow Request Marshaller
    /// </summary>       
    public class RunJobFlowRequestMarshaller : IMarshaller<IRequest, RunJobFlowRequest>
    {
        public IRequest Marshall(RunJobFlowRequest runJobFlowRequest)
        {
            IRequest request = new DefaultRequest(runJobFlowRequest, "AmazonElasticMapReduce");
            request.Parameters.Add("Action", "RunJobFlow");
            request.Parameters.Add("Version", "2009-03-31");
            if (runJobFlowRequest != null && runJobFlowRequest.IsSetName())
            {
                request.Parameters.Add("Name", StringUtils.FromString(runJobFlowRequest.Name));
            }
            if (runJobFlowRequest != null && runJobFlowRequest.IsSetLogUri())
            {
                request.Parameters.Add("LogUri", StringUtils.FromString(runJobFlowRequest.LogUri));
            }
            if (runJobFlowRequest != null && runJobFlowRequest.IsSetAdditionalInfo())
            {
                request.Parameters.Add("AdditionalInfo", StringUtils.FromString(runJobFlowRequest.AdditionalInfo));
            }
            if (runJobFlowRequest != null && runJobFlowRequest.IsSetAmiVersion())
            {
                request.Parameters.Add("AmiVersion", StringUtils.FromString(runJobFlowRequest.AmiVersion));
            }
            if (runJobFlowRequest != null)
            {
                JobFlowInstancesConfig instances = runJobFlowRequest.Instances;
                if (instances != null && instances.IsSetMasterInstanceType())
                {
                    request.Parameters.Add("Instances.MasterInstanceType", StringUtils.FromString(instances.MasterInstanceType));
                }
                if (instances != null && instances.IsSetSlaveInstanceType())
                {
                    request.Parameters.Add("Instances.SlaveInstanceType", StringUtils.FromString(instances.SlaveInstanceType));
                }
                if (instances != null && instances.IsSetInstanceCount())
                {
                    request.Parameters.Add("Instances.InstanceCount", StringUtils.FromInt(instances.InstanceCount));
                }

                if (instances != null)
                {
                    List<InstanceGroupConfig> instanceGroupsList = instances.InstanceGroups;
                    int instanceGroupsListIndex = 1;
                    foreach (InstanceGroupConfig instanceGroupsListValue in instanceGroupsList)
                    {
                        if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetName())
                        {
                            request.Parameters.Add("Instances.InstanceGroups.member." + instanceGroupsListIndex + ".Name", StringUtils.FromString(instanceGroupsListValue.Name));
                        }
                        if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetMarket())
                        {
                            request.Parameters.Add("Instances.InstanceGroups.member." + instanceGroupsListIndex + ".Market", StringUtils.FromString(instanceGroupsListValue.Market));
                        }
                        if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceRole())
                        {
                            request.Parameters.Add("Instances.InstanceGroups.member." + instanceGroupsListIndex + ".InstanceRole", StringUtils.FromString(instanceGroupsListValue.InstanceRole));
                        }
                        if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetBidPrice())
                        {
                            request.Parameters.Add("Instances.InstanceGroups.member." + instanceGroupsListIndex + ".BidPrice", StringUtils.FromString(instanceGroupsListValue.BidPrice));
                        }
                        if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceType())
                        {
                            request.Parameters.Add("Instances.InstanceGroups.member." + instanceGroupsListIndex + ".InstanceType", StringUtils.FromString(instanceGroupsListValue.InstanceType));
                        }
                        if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceCount())
                        {
                            request.Parameters.Add("Instances.InstanceGroups.member." + instanceGroupsListIndex + ".InstanceCount", StringUtils.FromInt(instanceGroupsListValue.InstanceCount));
                        }

                        instanceGroupsListIndex++;
                    }
                }
                if (instances != null && instances.IsSetEc2KeyName())
                {
                    request.Parameters.Add("Instances.Ec2KeyName", StringUtils.FromString(instances.Ec2KeyName));
                }
                if (instances != null)
                {
                    PlacementType placement = instances.Placement;
                    if (placement != null && placement.IsSetAvailabilityZone())
                    {
                        request.Parameters.Add("Instances.Placement.AvailabilityZone", StringUtils.FromString(placement.AvailabilityZone));
                    }
                }
                if (instances != null && instances.IsSetKeepJobFlowAliveWhenNoSteps())
                {
                    request.Parameters.Add("Instances.KeepJobFlowAliveWhenNoSteps", StringUtils.FromBool(instances.KeepJobFlowAliveWhenNoSteps));
                }
                if (instances != null && instances.IsSetTerminationProtected())
                {
                    request.Parameters.Add("Instances.TerminationProtected", StringUtils.FromBool(instances.TerminationProtected));
                }
                if (instances != null && instances.IsSetHadoopVersion())
                {
                    request.Parameters.Add("Instances.HadoopVersion", StringUtils.FromString(instances.HadoopVersion));
                }
                if (instances != null && instances.IsSetEc2SubnetId())
                {
                    request.Parameters.Add("Instances.Ec2SubnetId", StringUtils.FromString(instances.Ec2SubnetId));
                }
            }

            if (runJobFlowRequest != null)
            {
                List<StepConfig> stepsList = runJobFlowRequest.Steps;
                int stepsListIndex = 1;
                foreach (StepConfig stepsListValue in stepsList)
                {
                    if (stepsListValue != null && stepsListValue.IsSetName())
                    {
                        request.Parameters.Add("Steps.member." + stepsListIndex + ".Name", StringUtils.FromString(stepsListValue.Name));
                    }
                    if (stepsListValue != null && stepsListValue.IsSetActionOnFailure())
                    {
                        request.Parameters.Add("Steps.member." + stepsListIndex + ".ActionOnFailure", StringUtils.FromString(stepsListValue.ActionOnFailure));
                    }
                    if (stepsListValue != null)
                    {
                        HadoopJarStepConfig hadoopJarStep = stepsListValue.HadoopJarStep;

                        if (hadoopJarStep != null)
                        {
                            List<KeyValue> propertiesList = hadoopJarStep.Properties;
                            int propertiesListIndex = 1;
                            foreach (KeyValue propertiesListValue in propertiesList)
                            {
                                if (propertiesListValue != null && propertiesListValue.IsSetKey())
                                {
                                    request.Parameters.Add("Steps.member." + stepsListIndex + ".HadoopJarStep.Properties.member." + propertiesListIndex + ".Key", StringUtils.FromString(propertiesListValue.Key));
                                }
                                if (propertiesListValue != null && propertiesListValue.IsSetValue())
                                {
                                    request.Parameters.Add("Steps.member." + stepsListIndex + ".HadoopJarStep.Properties.member." + propertiesListIndex + ".Value", StringUtils.FromString(propertiesListValue.Value));
                                }

                                propertiesListIndex++;
                            }
                        }
                        if (hadoopJarStep != null && hadoopJarStep.IsSetJar())
                        {
                            request.Parameters.Add("Steps.member." + stepsListIndex + ".HadoopJarStep.Jar", StringUtils.FromString(hadoopJarStep.Jar));
                        }
                        if (hadoopJarStep != null && hadoopJarStep.IsSetMainClass())
                        {
                            request.Parameters.Add("Steps.member." + stepsListIndex + ".HadoopJarStep.MainClass", StringUtils.FromString(hadoopJarStep.MainClass));
                        }
                        if (hadoopJarStep != null)
                        {
                            List<string> argsList = hadoopJarStep.Args;

                            int argsListIndex = 1;
                            foreach (string argsListValue in argsList)
                            { 
                                request.Parameters.Add("Steps.member." + stepsListIndex + ".HadoopJarStep.Args.member." + argsListIndex, StringUtils.FromString(argsListValue));
                                argsListIndex++;
                            }
                        }
                    }

                    stepsListIndex++;
                }
            }

            if (runJobFlowRequest != null)
            {
                List<BootstrapActionConfig> bootstrapActionsList = runJobFlowRequest.BootstrapActions;
                int bootstrapActionsListIndex = 1;
                foreach (BootstrapActionConfig bootstrapActionsListValue in bootstrapActionsList)
                {
                    if (bootstrapActionsListValue != null && bootstrapActionsListValue.IsSetName())
                    {
                        request.Parameters.Add("BootstrapActions.member." + bootstrapActionsListIndex + ".Name", StringUtils.FromString(bootstrapActionsListValue.Name));
                    }
                    if (bootstrapActionsListValue != null)
                    {
                        ScriptBootstrapActionConfig scriptBootstrapAction = bootstrapActionsListValue.ScriptBootstrapAction;
                        if (scriptBootstrapAction != null && scriptBootstrapAction.IsSetPath())
                        {
                            request.Parameters.Add("BootstrapActions.member." + bootstrapActionsListIndex + ".ScriptBootstrapAction.Path", StringUtils.FromString(scriptBootstrapAction.Path));
                        }
                        if (scriptBootstrapAction != null)
                        {
                            List<string> argsList = scriptBootstrapAction.Args;

                            int argsListIndex = 1;
                            foreach (string argsListValue in argsList)
                            { 
                                request.Parameters.Add("BootstrapActions.member." + bootstrapActionsListIndex + ".ScriptBootstrapAction.Args.member." + argsListIndex, StringUtils.FromString(argsListValue));
                                argsListIndex++;
                            }
                        }
                    }

                    bootstrapActionsListIndex++;
                }
            }
            if (runJobFlowRequest != null)
            {
                List<string> supportedProductsList = runJobFlowRequest.SupportedProducts;

                int supportedProductsListIndex = 1;
                foreach (string supportedProductsListValue in supportedProductsList)
                { 
                    request.Parameters.Add("SupportedProducts.member." + supportedProductsListIndex, StringUtils.FromString(supportedProductsListValue));
                    supportedProductsListIndex++;
                }
            }
            if (runJobFlowRequest != null && runJobFlowRequest.IsSetVisibleToAllUsers())
            {
                request.Parameters.Add("VisibleToAllUsers", StringUtils.FromBool(runJobFlowRequest.VisibleToAllUsers));
            }
            if (runJobFlowRequest != null && runJobFlowRequest.IsSetJobFlowRole())
            {
                request.Parameters.Add("JobFlowRole", StringUtils.FromString(runJobFlowRequest.JobFlowRole));
            }

            return request;
        }
    }
}
