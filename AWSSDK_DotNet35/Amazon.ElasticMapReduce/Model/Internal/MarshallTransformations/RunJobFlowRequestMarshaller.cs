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
                if(publicRequest.IsSetAdditionalInfo())
                {
                    writer.WritePropertyName("AdditionalInfo");
                    writer.Write(publicRequest.AdditionalInfo);
                }

                if(publicRequest.IsSetAmiVersion())
                {
                    writer.WritePropertyName("AmiVersion");
                    writer.Write(publicRequest.AmiVersion);
                }

                if(publicRequest.IsSetBootstrapActions())
                {
                    writer.WritePropertyName("BootstrapActions");
                    writer.WriteArrayStart();
                    foreach(var publicRequestBootstrapActionsListValue in publicRequest.BootstrapActions)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestBootstrapActionsListValue.IsSetName())
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(publicRequestBootstrapActionsListValue.Name);
                        }

                        if(publicRequestBootstrapActionsListValue.IsSetScriptBootstrapAction())
                        {
                            writer.WritePropertyName("ScriptBootstrapAction");
                            writer.WriteObjectStart();
                            if(publicRequestBootstrapActionsListValue.ScriptBootstrapAction.IsSetArgs())
                            {
                                writer.WritePropertyName("Args");
                                writer.WriteArrayStart();
                                foreach(var publicRequestBootstrapActionsListValueScriptBootstrapActionArgsListValue in publicRequestBootstrapActionsListValue.ScriptBootstrapAction.Args)
                                {
                                    writer.Write(publicRequestBootstrapActionsListValueScriptBootstrapActionArgsListValue);
                                }
                                writer.WriteArrayEnd();
                            }

                            if(publicRequestBootstrapActionsListValue.ScriptBootstrapAction.IsSetPath())
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

                if(publicRequest.IsSetInstances())
                {
                    writer.WritePropertyName("Instances");
                    writer.WriteObjectStart();
                    if(publicRequest.Instances.IsSetEc2KeyName())
                    {
                        writer.WritePropertyName("Ec2KeyName");
                        writer.Write(publicRequest.Instances.Ec2KeyName);
                    }

                    if(publicRequest.Instances.IsSetEc2SubnetId())
                    {
                        writer.WritePropertyName("Ec2SubnetId");
                        writer.Write(publicRequest.Instances.Ec2SubnetId);
                    }

                    if(publicRequest.Instances.IsSetHadoopVersion())
                    {
                        writer.WritePropertyName("HadoopVersion");
                        writer.Write(publicRequest.Instances.HadoopVersion);
                    }

                    if(publicRequest.Instances.IsSetInstanceCount())
                    {
                        writer.WritePropertyName("InstanceCount");
                        writer.Write(publicRequest.Instances.InstanceCount);
                    }

                    if(publicRequest.Instances.IsSetInstanceGroups())
                    {
                        writer.WritePropertyName("InstanceGroups");
                        writer.WriteArrayStart();
                        foreach(var publicRequestInstancesInstanceGroupsListValue in publicRequest.Instances.InstanceGroups)
                        {
                            writer.WriteObjectStart();
                            if(publicRequestInstancesInstanceGroupsListValue.IsSetBidPrice())
                            {
                                writer.WritePropertyName("BidPrice");
                                writer.Write(publicRequestInstancesInstanceGroupsListValue.BidPrice);
                            }

                            if(publicRequestInstancesInstanceGroupsListValue.IsSetInstanceCount())
                            {
                                writer.WritePropertyName("InstanceCount");
                                writer.Write(publicRequestInstancesInstanceGroupsListValue.InstanceCount);
                            }

                            if(publicRequestInstancesInstanceGroupsListValue.IsSetInstanceRole())
                            {
                                writer.WritePropertyName("InstanceRole");
                                writer.Write(publicRequestInstancesInstanceGroupsListValue.InstanceRole);
                            }

                            if(publicRequestInstancesInstanceGroupsListValue.IsSetInstanceType())
                            {
                                writer.WritePropertyName("InstanceType");
                                writer.Write(publicRequestInstancesInstanceGroupsListValue.InstanceType);
                            }

                            if(publicRequestInstancesInstanceGroupsListValue.IsSetMarket())
                            {
                                writer.WritePropertyName("Market");
                                writer.Write(publicRequestInstancesInstanceGroupsListValue.Market);
                            }

                            if(publicRequestInstancesInstanceGroupsListValue.IsSetName())
                            {
                                writer.WritePropertyName("Name");
                                writer.Write(publicRequestInstancesInstanceGroupsListValue.Name);
                            }

                            writer.WriteObjectEnd();
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.Instances.IsSetKeepJobFlowAliveWhenNoSteps())
                    {
                        writer.WritePropertyName("KeepJobFlowAliveWhenNoSteps");
                        writer.Write(publicRequest.Instances.KeepJobFlowAliveWhenNoSteps);
                    }

                    if(publicRequest.Instances.IsSetMasterInstanceType())
                    {
                        writer.WritePropertyName("MasterInstanceType");
                        writer.Write(publicRequest.Instances.MasterInstanceType);
                    }

                    if(publicRequest.Instances.IsSetPlacement())
                    {
                        writer.WritePropertyName("Placement");
                        writer.WriteObjectStart();
                        if(publicRequest.Instances.Placement.IsSetAvailabilityZone())
                        {
                            writer.WritePropertyName("AvailabilityZone");
                            writer.Write(publicRequest.Instances.Placement.AvailabilityZone);
                        }

                        writer.WriteObjectEnd();
                    }

                    if(publicRequest.Instances.IsSetSlaveInstanceType())
                    {
                        writer.WritePropertyName("SlaveInstanceType");
                        writer.Write(publicRequest.Instances.SlaveInstanceType);
                    }

                    if(publicRequest.Instances.IsSetTerminationProtected())
                    {
                        writer.WritePropertyName("TerminationProtected");
                        writer.Write(publicRequest.Instances.TerminationProtected);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetJobFlowRole())
                {
                    writer.WritePropertyName("JobFlowRole");
                    writer.Write(publicRequest.JobFlowRole);
                }

                if(publicRequest.IsSetLogUri())
                {
                    writer.WritePropertyName("LogUri");
                    writer.Write(publicRequest.LogUri);
                }

                if(publicRequest.IsSetName())
                {
                    writer.WritePropertyName("Name");
                    writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNewSupportedProducts())
                {
                    writer.WritePropertyName("NewSupportedProducts");
                    writer.WriteArrayStart();
                    foreach(var publicRequestNewSupportedProductsListValue in publicRequest.NewSupportedProducts)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestNewSupportedProductsListValue.IsSetArgs())
                        {
                            writer.WritePropertyName("Args");
                            writer.WriteArrayStart();
                            foreach(var publicRequestNewSupportedProductsListValueArgsListValue in publicRequestNewSupportedProductsListValue.Args)
                            {
                                writer.Write(publicRequestNewSupportedProductsListValueArgsListValue);
                            }
                            writer.WriteArrayEnd();
                        }

                        if(publicRequestNewSupportedProductsListValue.IsSetName())
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(publicRequestNewSupportedProductsListValue.Name);
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetServiceRole())
                {
                    writer.WritePropertyName("ServiceRole");
                    writer.Write(publicRequest.ServiceRole);
                }

                if(publicRequest.IsSetSteps())
                {
                    writer.WritePropertyName("Steps");
                    writer.WriteArrayStart();
                    foreach(var publicRequestStepsListValue in publicRequest.Steps)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestStepsListValue.IsSetActionOnFailure())
                        {
                            writer.WritePropertyName("ActionOnFailure");
                            writer.Write(publicRequestStepsListValue.ActionOnFailure);
                        }

                        if(publicRequestStepsListValue.IsSetHadoopJarStep())
                        {
                            writer.WritePropertyName("HadoopJarStep");
                            writer.WriteObjectStart();
                            if(publicRequestStepsListValue.HadoopJarStep.IsSetArgs())
                            {
                                writer.WritePropertyName("Args");
                                writer.WriteArrayStart();
                                foreach(var publicRequestStepsListValueHadoopJarStepArgsListValue in publicRequestStepsListValue.HadoopJarStep.Args)
                                {
                                    writer.Write(publicRequestStepsListValueHadoopJarStepArgsListValue);
                                }
                                writer.WriteArrayEnd();
                            }

                            if(publicRequestStepsListValue.HadoopJarStep.IsSetJar())
                            {
                                writer.WritePropertyName("Jar");
                                writer.Write(publicRequestStepsListValue.HadoopJarStep.Jar);
                            }

                            if(publicRequestStepsListValue.HadoopJarStep.IsSetMainClass())
                            {
                                writer.WritePropertyName("MainClass");
                                writer.Write(publicRequestStepsListValue.HadoopJarStep.MainClass);
                            }

                            if(publicRequestStepsListValue.HadoopJarStep.IsSetProperties())
                            {
                                writer.WritePropertyName("Properties");
                                writer.WriteArrayStart();
                                foreach(var publicRequestStepsListValueHadoopJarStepPropertiesListValue in publicRequestStepsListValue.HadoopJarStep.Properties)
                                {
                                    writer.WriteObjectStart();
                                    if(publicRequestStepsListValueHadoopJarStepPropertiesListValue.IsSetKey())
                                    {
                                        writer.WritePropertyName("Key");
                                        writer.Write(publicRequestStepsListValueHadoopJarStepPropertiesListValue.Key);
                                    }

                                    if(publicRequestStepsListValueHadoopJarStepPropertiesListValue.IsSetValue())
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

                        if(publicRequestStepsListValue.IsSetName())
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(publicRequestStepsListValue.Name);
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSupportedProducts())
                {
                    writer.WritePropertyName("SupportedProducts");
                    writer.WriteArrayStart();
                    foreach(var publicRequestSupportedProductsListValue in publicRequest.SupportedProducts)
                    {
                        writer.Write(publicRequestSupportedProductsListValue);
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    writer.WritePropertyName("Tags");
                    writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestTagsListValue.IsSetKey())
                        {
                            writer.WritePropertyName("Key");
                            writer.Write(publicRequestTagsListValue.Key);
                        }

                        if(publicRequestTagsListValue.IsSetValue())
                        {
                            writer.WritePropertyName("Value");
                            writer.Write(publicRequestTagsListValue.Value);
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetVisibleToAllUsers())
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