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
    /// Run Job Flow Request Marshaller
    /// </summary>       
    internal class RunJobFlowRequestMarshaller : IMarshaller<IRequest, RunJobFlowRequest> 
    {
        

        public IRequest Marshall(RunJobFlowRequest runJobFlowRequest) 
        {

            IRequest request = new DefaultRequest(runJobFlowRequest, "AmazonElasticMapReduce");
            string target = "ElasticMapReduce.RunJobFlow";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";

            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                string queryString = uriResourcePath.Substring(uriResourcePath.IndexOf("?") + 1);
                uriResourcePath    = uriResourcePath.Substring(0, uriResourcePath.IndexOf("?"));
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (runJobFlowRequest != null && runJobFlowRequest.IsSetName()) 
                {
                    writer.WritePropertyName("Name");
                    writer.Write(runJobFlowRequest.Name);
                }
                if (runJobFlowRequest != null && runJobFlowRequest.IsSetLogUri()) 
                {
                    writer.WritePropertyName("LogUri");
                    writer.Write(runJobFlowRequest.LogUri);
                }
                if (runJobFlowRequest != null && runJobFlowRequest.IsSetAdditionalInfo()) 
                {
                    writer.WritePropertyName("AdditionalInfo");
                    writer.Write(runJobFlowRequest.AdditionalInfo);
                }
                if (runJobFlowRequest != null && runJobFlowRequest.IsSetAmiVersion()) 
                {
                    writer.WritePropertyName("AmiVersion");
                    writer.Write(runJobFlowRequest.AmiVersion);
                }

                if (runJobFlowRequest != null) 
                {
                    JobFlowInstancesConfig instances = runJobFlowRequest.Instances;
                    if (instances != null)
                    {
                        writer.WritePropertyName("Instances");
                        writer.WriteObjectStart();
                        if (instances != null && instances.IsSetMasterInstanceType()) 
                        {
                            writer.WritePropertyName("MasterInstanceType");
                            writer.Write(instances.MasterInstanceType);
                        }
                        if (instances != null && instances.IsSetSlaveInstanceType()) 
                        {
                            writer.WritePropertyName("SlaveInstanceType");
                            writer.Write(instances.SlaveInstanceType);
                        }
                        if (instances != null && instances.IsSetInstanceCount()) 
                        {
                            writer.WritePropertyName("InstanceCount");
                            writer.Write(instances.InstanceCount);
                        }

                        if (instances != null && instances.InstanceGroups != null && instances.InstanceGroups.Count > 0)
                        {
                            List<InstanceGroupConfig> instanceGroupsList = instances.InstanceGroups;
                            writer.WritePropertyName("InstanceGroups");
                            writer.WriteArrayStart();

                            foreach (InstanceGroupConfig instanceGroupsListValue in instanceGroupsList) 
                            {
                                writer.WriteObjectStart();
                                if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetName()) 
                                {
                                    writer.WritePropertyName("Name");
                                    writer.Write(instanceGroupsListValue.Name);
                                }
                                if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetMarket()) 
                                {
                                    writer.WritePropertyName("Market");
                                    writer.Write(instanceGroupsListValue.Market);
                                }
                                if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceRole()) 
                                {
                                    writer.WritePropertyName("InstanceRole");
                                    writer.Write(instanceGroupsListValue.InstanceRole);
                                }
                                if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetBidPrice()) 
                                {
                                    writer.WritePropertyName("BidPrice");
                                    writer.Write(instanceGroupsListValue.BidPrice);
                                }
                                if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceType()) 
                                {
                                    writer.WritePropertyName("InstanceType");
                                    writer.Write(instanceGroupsListValue.InstanceType);
                                }
                                if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceCount()) 
                                {
                                    writer.WritePropertyName("InstanceCount");
                                    writer.Write(instanceGroupsListValue.InstanceCount);
                                }
                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }
                        if (instances != null && instances.IsSetEc2KeyName()) 
                        {
                            writer.WritePropertyName("Ec2KeyName");
                            writer.Write(instances.Ec2KeyName);
                        }

                        if (instances != null) 
                        {
                            PlacementType placement = instances.Placement;
                            if (placement != null)
                            {
                                writer.WritePropertyName("Placement");
                                writer.WriteObjectStart();
                                if (placement != null && placement.IsSetAvailabilityZone()) 
                                {
                                    writer.WritePropertyName("AvailabilityZone");
                                    writer.Write(placement.AvailabilityZone);
                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        if (instances != null && instances.IsSetKeepJobFlowAliveWhenNoSteps()) 
                        {
                            writer.WritePropertyName("KeepJobFlowAliveWhenNoSteps");
                            writer.Write(instances.KeepJobFlowAliveWhenNoSteps);
                        }
                        if (instances != null && instances.IsSetTerminationProtected()) 
                        {
                            writer.WritePropertyName("TerminationProtected");
                            writer.Write(instances.TerminationProtected);
                        }
                        if (instances != null && instances.IsSetHadoopVersion()) 
                        {
                            writer.WritePropertyName("HadoopVersion");
                            writer.Write(instances.HadoopVersion);
                        }
                        if (instances != null && instances.IsSetEc2SubnetId()) 
                        {
                            writer.WritePropertyName("Ec2SubnetId");
                            writer.Write(instances.Ec2SubnetId);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (runJobFlowRequest != null && runJobFlowRequest.Steps != null && runJobFlowRequest.Steps.Count > 0)
                {
                    List<StepConfig> stepsList = runJobFlowRequest.Steps;
                    writer.WritePropertyName("Steps");
                    writer.WriteArrayStart();

                    foreach (StepConfig stepsListValue in stepsList) 
                    {
                        writer.WriteObjectStart();
                        if (stepsListValue != null && stepsListValue.IsSetName()) 
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(stepsListValue.Name);
                        }
                        if (stepsListValue != null && stepsListValue.IsSetActionOnFailure()) 
                        {
                            writer.WritePropertyName("ActionOnFailure");
                            writer.Write(stepsListValue.ActionOnFailure);
                        }

                        if (stepsListValue != null) 
                        {
                            HadoopJarStepConfig hadoopJarStep = stepsListValue.HadoopJarStep;
                            if (hadoopJarStep != null)
                            {
                                writer.WritePropertyName("HadoopJarStep");
                                writer.WriteObjectStart();

                                if (hadoopJarStep != null && hadoopJarStep.Properties != null && hadoopJarStep.Properties.Count > 0)
                                {
                                    List<KeyValue> propertiesList = hadoopJarStep.Properties;
                                    writer.WritePropertyName("Properties");
                                    writer.WriteArrayStart();

                                    foreach (KeyValue propertiesListValue in propertiesList) 
                                    {
                                        writer.WriteObjectStart();
                                        if (propertiesListValue != null && propertiesListValue.IsSetKey()) 
                                        {
                                            writer.WritePropertyName("Key");
                                            writer.Write(propertiesListValue.Key);
                                        }
                                        if (propertiesListValue != null && propertiesListValue.IsSetValue()) 
                                        {
                                            writer.WritePropertyName("Value");
                                            writer.Write(propertiesListValue.Value);
                                        }
                                        writer.WriteObjectEnd();
                                    }
                                    writer.WriteArrayEnd();
                                }
                                if (hadoopJarStep != null && hadoopJarStep.IsSetJar()) 
                                {
                                    writer.WritePropertyName("Jar");
                                    writer.Write(hadoopJarStep.Jar);
                                }
                                if (hadoopJarStep != null && hadoopJarStep.IsSetMainClass()) 
                                {
                                    writer.WritePropertyName("MainClass");
                                    writer.Write(hadoopJarStep.MainClass);
                                }

                                if (hadoopJarStep != null && hadoopJarStep.Args != null && hadoopJarStep.Args.Count > 0) 
                                {
                                    List<string> argsList = hadoopJarStep.Args;
                                    writer.WritePropertyName("Args");
                                    writer.WriteArrayStart();

                                    foreach (string argsListValue in argsList) 
                                    { 
                                        writer.Write(StringUtils.FromString(argsListValue));
                                    }

                                    writer.WriteArrayEnd();
                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                if (runJobFlowRequest != null && runJobFlowRequest.BootstrapActions != null && runJobFlowRequest.BootstrapActions.Count > 0)
                {
                    List<BootstrapActionConfig> bootstrapActionsList = runJobFlowRequest.BootstrapActions;
                    writer.WritePropertyName("BootstrapActions");
                    writer.WriteArrayStart();

                    foreach (BootstrapActionConfig bootstrapActionsListValue in bootstrapActionsList) 
                    {
                        writer.WriteObjectStart();
                        if (bootstrapActionsListValue != null && bootstrapActionsListValue.IsSetName()) 
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(bootstrapActionsListValue.Name);
                        }

                        if (bootstrapActionsListValue != null) 
                        {
                            ScriptBootstrapActionConfig scriptBootstrapAction = bootstrapActionsListValue.ScriptBootstrapAction;
                            if (scriptBootstrapAction != null)
                            {
                                writer.WritePropertyName("ScriptBootstrapAction");
                                writer.WriteObjectStart();
                                if (scriptBootstrapAction != null && scriptBootstrapAction.IsSetPath()) 
                                {
                                    writer.WritePropertyName("Path");
                                    writer.Write(scriptBootstrapAction.Path);
                                }

                                if (scriptBootstrapAction != null && scriptBootstrapAction.Args != null && scriptBootstrapAction.Args.Count > 0) 
                                {
                                    List<string> argsList = scriptBootstrapAction.Args;
                                    writer.WritePropertyName("Args");
                                    writer.WriteArrayStart();

                                    foreach (string argsListValue in argsList) 
                                    { 
                                        writer.Write(StringUtils.FromString(argsListValue));
                                    }

                                    writer.WriteArrayEnd();
                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                if (runJobFlowRequest != null && runJobFlowRequest.SupportedProducts != null && runJobFlowRequest.SupportedProducts.Count > 0) 
                {
                    List<string> supportedProductsList = runJobFlowRequest.SupportedProducts;
                    writer.WritePropertyName("SupportedProducts");
                    writer.WriteArrayStart();

                    foreach (string supportedProductsListValue in supportedProductsList) 
                    { 
                        writer.Write(StringUtils.FromString(supportedProductsListValue));
                    }

                    writer.WriteArrayEnd();
                }

                if (runJobFlowRequest != null && runJobFlowRequest.NewSupportedProducts != null && runJobFlowRequest.NewSupportedProducts.Count > 0)
                {
                    List<SupportedProductConfig> newSupportedProductsList = runJobFlowRequest.NewSupportedProducts;
                    writer.WritePropertyName("NewSupportedProducts");
                    writer.WriteArrayStart();

                    foreach (SupportedProductConfig newSupportedProductsListValue in newSupportedProductsList) 
                    {
                        writer.WriteObjectStart();
                        if (newSupportedProductsListValue != null && newSupportedProductsListValue.IsSetName()) 
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(newSupportedProductsListValue.Name);
                        }

                        if (newSupportedProductsListValue != null && newSupportedProductsListValue.Args != null && newSupportedProductsListValue.Args.Count > 0) 
                        {
                            List<string> argsList = newSupportedProductsListValue.Args;
                            writer.WritePropertyName("Args");
                            writer.WriteArrayStart();

                            foreach (string argsListValue in argsList) 
                            { 
                                writer.Write(StringUtils.FromString(argsListValue));
                            }

                            writer.WriteArrayEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }
                if (runJobFlowRequest != null && runJobFlowRequest.IsSetVisibleToAllUsers()) 
                {
                    writer.WritePropertyName("VisibleToAllUsers");
                    writer.Write(runJobFlowRequest.VisibleToAllUsers);
                }
                if (runJobFlowRequest != null && runJobFlowRequest.IsSetJobFlowRole()) 
                {
                    writer.WritePropertyName("JobFlowRole");
                    writer.Write(runJobFlowRequest.JobFlowRole);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
