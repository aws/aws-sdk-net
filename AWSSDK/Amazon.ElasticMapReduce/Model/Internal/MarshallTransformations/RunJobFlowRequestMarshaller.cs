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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RunJobFlow Request Marshaller
    /// </summary>       
    public class RunJobFlowRequestMarshaller : IMarshaller<IRequest, RunJobFlowRequest> 
    {
        public IRequest Marshall(RunJobFlowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticMapReduce");
            string target = "ElasticMapReduce.RunJobFlow";
            request.Headers["X-Amz-Target"] = target;

            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest != null && publicRequest.IsSetAdditionalInfo())
                {
                    writer.WritePropertyName("AdditionalInfo");
                    writer.Write(publicRequest.AdditionalInfo);
                }

                if(publicRequest != null && publicRequest.IsSetAmiVersion())
                {
                    writer.WritePropertyName("AmiVersion");
                    writer.Write(publicRequest.AmiVersion);
                }

                if(publicRequest != null && publicRequest.IsSetBootstrapActions() && publicRequest.BootstrapActions.Count > 0)
                {
                    writer.WritePropertyName("BootstrapActions");
                    writer.WriteArrayStart();
                    foreach(var publicRequestBootstrapActionsListValue in publicRequest.BootstrapActions)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestBootstrapActionsListValue != null && publicRequestBootstrapActionsListValue.IsSetName())
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(publicRequestBootstrapActionsListValue.Name);
                        }

                        if(publicRequestBootstrapActionsListValue != null && publicRequestBootstrapActionsListValue.IsSetScriptBootstrapAction())
                        {
                            writer.WritePropertyName("ScriptBootstrapAction");
                            writer.WriteObjectStart();
                            if(publicRequestBootstrapActionsListValue.ScriptBootstrapAction != null && publicRequestBootstrapActionsListValue.ScriptBootstrapAction.IsSetArgs() && publicRequestBootstrapActionsListValue.ScriptBootstrapAction.Args.Count > 0)
                            {
                                writer.WritePropertyName("Args");
                                writer.WriteArrayStart();
                                foreach(var publicRequestBootstrapActionsListValueScriptBootstrapActionArgsListValue in publicRequestBootstrapActionsListValue.ScriptBootstrapAction.Args)
                                {
                                    writer.Write(publicRequestBootstrapActionsListValueScriptBootstrapActionArgsListValue);
                                }
                                writer.WriteArrayEnd();
                            }

                            if(publicRequestBootstrapActionsListValue.ScriptBootstrapAction != null && publicRequestBootstrapActionsListValue.ScriptBootstrapAction.IsSetPath())
                            {
                                writer.WritePropertyName("Path");
                                writer.Write(publicRequestBootstrapActionsListValue.ScriptBootstrapAction.Path);
                            }

                            writer.WriteObjectEnd();
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest != null && publicRequest.IsSetInstances())
                {
                    writer.WritePropertyName("Instances");
                    writer.WriteObjectStart();
                    if(publicRequest.Instances != null && publicRequest.Instances.IsSetEc2KeyName())
                    {
                        writer.WritePropertyName("Ec2KeyName");
                        writer.Write(publicRequest.Instances.Ec2KeyName);
                    }

                    if(publicRequest.Instances != null && publicRequest.Instances.IsSetEc2SubnetId())
                    {
                        writer.WritePropertyName("Ec2SubnetId");
                        writer.Write(publicRequest.Instances.Ec2SubnetId);
                    }

                    if(publicRequest.Instances != null && publicRequest.Instances.IsSetHadoopVersion())
                    {
                        writer.WritePropertyName("HadoopVersion");
                        writer.Write(publicRequest.Instances.HadoopVersion);
                    }

                    if(publicRequest.Instances != null && publicRequest.Instances.IsSetInstanceCount())
                    {
                        writer.WritePropertyName("InstanceCount");
                        writer.Write(publicRequest.Instances.InstanceCount);
                    }

                    if(publicRequest.Instances != null && publicRequest.Instances.IsSetInstanceGroups() && publicRequest.Instances.InstanceGroups.Count > 0)
                    {
                        writer.WritePropertyName("InstanceGroups");
                        writer.WriteArrayStart();
                        foreach(var publicRequestInstancesInstanceGroupsListValue in publicRequest.Instances.InstanceGroups)
                        {
                            writer.WriteObjectStart();
                            if(publicRequestInstancesInstanceGroupsListValue != null && publicRequestInstancesInstanceGroupsListValue.IsSetBidPrice())
                            {
                                writer.WritePropertyName("BidPrice");
                                writer.Write(publicRequestInstancesInstanceGroupsListValue.BidPrice);
                            }

                            if(publicRequestInstancesInstanceGroupsListValue != null && publicRequestInstancesInstanceGroupsListValue.IsSetInstanceCount())
                            {
                                writer.WritePropertyName("InstanceCount");
                                writer.Write(publicRequestInstancesInstanceGroupsListValue.InstanceCount);
                            }

                            if(publicRequestInstancesInstanceGroupsListValue != null && publicRequestInstancesInstanceGroupsListValue.IsSetInstanceRole())
                            {
                                writer.WritePropertyName("InstanceRole");
                                writer.Write(publicRequestInstancesInstanceGroupsListValue.InstanceRole);
                            }

                            if(publicRequestInstancesInstanceGroupsListValue != null && publicRequestInstancesInstanceGroupsListValue.IsSetInstanceType())
                            {
                                writer.WritePropertyName("InstanceType");
                                writer.Write(publicRequestInstancesInstanceGroupsListValue.InstanceType);
                            }

                            if(publicRequestInstancesInstanceGroupsListValue != null && publicRequestInstancesInstanceGroupsListValue.IsSetMarket())
                            {
                                writer.WritePropertyName("Market");
                                writer.Write(publicRequestInstancesInstanceGroupsListValue.Market);
                            }

                            if(publicRequestInstancesInstanceGroupsListValue != null && publicRequestInstancesInstanceGroupsListValue.IsSetName())
                            {
                                writer.WritePropertyName("Name");
                                writer.Write(publicRequestInstancesInstanceGroupsListValue.Name);
                            }

                            writer.WriteObjectEnd();
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.Instances != null && publicRequest.Instances.IsSetKeepJobFlowAliveWhenNoSteps())
                    {
                        writer.WritePropertyName("KeepJobFlowAliveWhenNoSteps");
                        writer.Write(publicRequest.Instances.KeepJobFlowAliveWhenNoSteps);
                    }

                    if(publicRequest.Instances != null && publicRequest.Instances.IsSetMasterInstanceType())
                    {
                        writer.WritePropertyName("MasterInstanceType");
                        writer.Write(publicRequest.Instances.MasterInstanceType);
                    }

                    if(publicRequest.Instances != null && publicRequest.Instances.IsSetPlacement())
                    {
                        writer.WritePropertyName("Placement");
                        writer.WriteObjectStart();
                        if(publicRequest.Instances.Placement != null && publicRequest.Instances.Placement.IsSetAvailabilityZone())
                        {
                            writer.WritePropertyName("AvailabilityZone");
                            writer.Write(publicRequest.Instances.Placement.AvailabilityZone);
                        }

                        writer.WriteObjectEnd();
                    }

                    if(publicRequest.Instances != null && publicRequest.Instances.IsSetSlaveInstanceType())
                    {
                        writer.WritePropertyName("SlaveInstanceType");
                        writer.Write(publicRequest.Instances.SlaveInstanceType);
                    }

                    if(publicRequest.Instances != null && publicRequest.Instances.IsSetTerminationProtected())
                    {
                        writer.WritePropertyName("TerminationProtected");
                        writer.Write(publicRequest.Instances.TerminationProtected);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest != null && publicRequest.IsSetJobFlowRole())
                {
                    writer.WritePropertyName("JobFlowRole");
                    writer.Write(publicRequest.JobFlowRole);
                }

                if(publicRequest != null && publicRequest.IsSetLogUri())
                {
                    writer.WritePropertyName("LogUri");
                    writer.Write(publicRequest.LogUri);
                }

                if(publicRequest != null && publicRequest.IsSetName())
                {
                    writer.WritePropertyName("Name");
                    writer.Write(publicRequest.Name);
                }

                if(publicRequest != null && publicRequest.IsSetNewSupportedProducts() && publicRequest.NewSupportedProducts.Count > 0)
                {
                    writer.WritePropertyName("NewSupportedProducts");
                    writer.WriteArrayStart();
                    foreach(var publicRequestNewSupportedProductsListValue in publicRequest.NewSupportedProducts)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestNewSupportedProductsListValue != null && publicRequestNewSupportedProductsListValue.IsSetArgs() && publicRequestNewSupportedProductsListValue.Args.Count > 0)
                        {
                            writer.WritePropertyName("Args");
                            writer.WriteArrayStart();
                            foreach(var publicRequestNewSupportedProductsListValueArgsListValue in publicRequestNewSupportedProductsListValue.Args)
                            {
                                writer.Write(publicRequestNewSupportedProductsListValueArgsListValue);
                            }
                            writer.WriteArrayEnd();
                        }

                        if(publicRequestNewSupportedProductsListValue != null && publicRequestNewSupportedProductsListValue.IsSetName())
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(publicRequestNewSupportedProductsListValue.Name);
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest != null && publicRequest.IsSetServiceRole())
                {
                    writer.WritePropertyName("ServiceRole");
                    writer.Write(publicRequest.ServiceRole);
                }

                if(publicRequest != null && publicRequest.IsSetSteps() && publicRequest.Steps.Count > 0)
                {
                    writer.WritePropertyName("Steps");
                    writer.WriteArrayStart();
                    foreach(var publicRequestStepsListValue in publicRequest.Steps)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestStepsListValue != null && publicRequestStepsListValue.IsSetActionOnFailure())
                        {
                            writer.WritePropertyName("ActionOnFailure");
                            writer.Write(publicRequestStepsListValue.ActionOnFailure);
                        }

                        if(publicRequestStepsListValue != null && publicRequestStepsListValue.IsSetHadoopJarStep())
                        {
                            writer.WritePropertyName("HadoopJarStep");
                            writer.WriteObjectStart();
                            if(publicRequestStepsListValue.HadoopJarStep != null && publicRequestStepsListValue.HadoopJarStep.IsSetArgs() && publicRequestStepsListValue.HadoopJarStep.Args.Count > 0)
                            {
                                writer.WritePropertyName("Args");
                                writer.WriteArrayStart();
                                foreach(var publicRequestStepsListValueHadoopJarStepArgsListValue in publicRequestStepsListValue.HadoopJarStep.Args)
                                {
                                    writer.Write(publicRequestStepsListValueHadoopJarStepArgsListValue);
                                }
                                writer.WriteArrayEnd();
                            }

                            if(publicRequestStepsListValue.HadoopJarStep != null && publicRequestStepsListValue.HadoopJarStep.IsSetJar())
                            {
                                writer.WritePropertyName("Jar");
                                writer.Write(publicRequestStepsListValue.HadoopJarStep.Jar);
                            }

                            if(publicRequestStepsListValue.HadoopJarStep != null && publicRequestStepsListValue.HadoopJarStep.IsSetMainClass())
                            {
                                writer.WritePropertyName("MainClass");
                                writer.Write(publicRequestStepsListValue.HadoopJarStep.MainClass);
                            }

                            if(publicRequestStepsListValue.HadoopJarStep != null && publicRequestStepsListValue.HadoopJarStep.IsSetProperties() && publicRequestStepsListValue.HadoopJarStep.Properties.Count > 0)
                            {
                                writer.WritePropertyName("Properties");
                                writer.WriteArrayStart();
                                foreach(var publicRequestStepsListValueHadoopJarStepPropertiesListValue in publicRequestStepsListValue.HadoopJarStep.Properties)
                                {
                                    writer.WriteObjectStart();
                                    if(publicRequestStepsListValueHadoopJarStepPropertiesListValue != null && publicRequestStepsListValueHadoopJarStepPropertiesListValue.IsSetKey())
                                    {
                                        writer.WritePropertyName("Key");
                                        writer.Write(publicRequestStepsListValueHadoopJarStepPropertiesListValue.Key);
                                    }

                                    if(publicRequestStepsListValueHadoopJarStepPropertiesListValue != null && publicRequestStepsListValueHadoopJarStepPropertiesListValue.IsSetValue())
                                    {
                                        writer.WritePropertyName("Value");
                                        writer.Write(publicRequestStepsListValueHadoopJarStepPropertiesListValue.Value);
                                    }

                                    writer.WriteObjectEnd();
                                }
                                writer.WriteArrayEnd();
                            }

                            writer.WriteObjectEnd();
                        }

                        if(publicRequestStepsListValue != null && publicRequestStepsListValue.IsSetName())
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(publicRequestStepsListValue.Name);
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest != null && publicRequest.IsSetSupportedProducts() && publicRequest.SupportedProducts.Count > 0)
                {
                    writer.WritePropertyName("SupportedProducts");
                    writer.WriteArrayStart();
                    foreach(var publicRequestSupportedProductsListValue in publicRequest.SupportedProducts)
                    {
                        writer.Write(publicRequestSupportedProductsListValue);
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest != null && publicRequest.IsSetTags() && publicRequest.Tags.Count > 0)
                {
                    writer.WritePropertyName("Tags");
                    writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestTagsListValue != null && publicRequestTagsListValue.IsSetKey())
                        {
                            writer.WritePropertyName("Key");
                            writer.Write(publicRequestTagsListValue.Key);
                        }

                        if(publicRequestTagsListValue != null && publicRequestTagsListValue.IsSetValue())
                        {
                            writer.WritePropertyName("Value");
                            writer.Write(publicRequestTagsListValue.Value);
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest != null && publicRequest.IsSetVisibleToAllUsers())
                {
                    writer.WritePropertyName("VisibleToAllUsers");
                    writer.Write(publicRequest.VisibleToAllUsers);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            return request;
        }


    }
}