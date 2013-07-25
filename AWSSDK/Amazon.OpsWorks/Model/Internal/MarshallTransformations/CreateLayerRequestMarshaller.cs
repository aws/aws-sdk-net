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

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Layer Request Marshaller
    /// </summary>       
    internal class CreateLayerRequestMarshaller : IMarshaller<IRequest, CreateLayerRequest> 
    {
        

        public IRequest Marshall(CreateLayerRequest createLayerRequest) 
        {

            IRequest request = new DefaultRequest(createLayerRequest, "AmazonOpsWorks");
            string target = "OpsWorks_20130218.CreateLayer";
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
                
                if (createLayerRequest != null && createLayerRequest.IsSetStackId()) 
                {
                    writer.WritePropertyName("StackId");
                    writer.Write(createLayerRequest.StackId);
                }
                if (createLayerRequest != null && createLayerRequest.IsSetType()) 
                {
                    writer.WritePropertyName("Type");
                    writer.Write(createLayerRequest.Type);
                }
                if (createLayerRequest != null && createLayerRequest.IsSetName()) 
                {
                    writer.WritePropertyName("Name");
                    writer.Write(createLayerRequest.Name);
                }
                if (createLayerRequest != null && createLayerRequest.IsSetShortname()) 
                {
                    writer.WritePropertyName("Shortname");
                    writer.Write(createLayerRequest.Shortname);
                }
                if (createLayerRequest != null) 
                {
                    if (createLayerRequest.Attributes != null && createLayerRequest.Attributes.Count > 0)
                    {
                        writer.WritePropertyName("Attributes");
                        writer.WriteObjectStart();
                        foreach (string createLayerRequestAttributesKey in createLayerRequest.Attributes.Keys)
                        {
                            string attributesListValue;
                            bool attributesListValueHasValue = createLayerRequest.Attributes.TryGetValue(createLayerRequestAttributesKey, out attributesListValue);
                            writer.WritePropertyName(createLayerRequestAttributesKey);

                        writer.Write(attributesListValue);
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (createLayerRequest != null && createLayerRequest.IsSetCustomInstanceProfileArn()) 
                {
                    writer.WritePropertyName("CustomInstanceProfileArn");
                    writer.Write(createLayerRequest.CustomInstanceProfileArn);
                }

                if (createLayerRequest != null && createLayerRequest.CustomSecurityGroupIds != null && createLayerRequest.CustomSecurityGroupIds.Count > 0) 
                {
                    List<string> customSecurityGroupIdsList = createLayerRequest.CustomSecurityGroupIds;
                    writer.WritePropertyName("CustomSecurityGroupIds");
                    writer.WriteArrayStart();

                    foreach (string customSecurityGroupIdsListValue in customSecurityGroupIdsList) 
                    { 
                        writer.Write(StringUtils.FromString(customSecurityGroupIdsListValue));
                    }

                    writer.WriteArrayEnd();
                }

                if (createLayerRequest != null && createLayerRequest.Packages != null && createLayerRequest.Packages.Count > 0) 
                {
                    List<string> packagesList = createLayerRequest.Packages;
                    writer.WritePropertyName("Packages");
                    writer.WriteArrayStart();

                    foreach (string packagesListValue in packagesList) 
                    { 
                        writer.Write(StringUtils.FromString(packagesListValue));
                    }

                    writer.WriteArrayEnd();
                }

                if (createLayerRequest != null && createLayerRequest.VolumeConfigurations != null && createLayerRequest.VolumeConfigurations.Count > 0)
                {
                    List<VolumeConfiguration> volumeConfigurationsList = createLayerRequest.VolumeConfigurations;
                    writer.WritePropertyName("VolumeConfigurations");
                    writer.WriteArrayStart();

                    foreach (VolumeConfiguration volumeConfigurationsListValue in volumeConfigurationsList) 
                    {
                        writer.WriteObjectStart();
                        if (volumeConfigurationsListValue != null && volumeConfigurationsListValue.IsSetMountPoint()) 
                        {
                            writer.WritePropertyName("MountPoint");
                            writer.Write(volumeConfigurationsListValue.MountPoint);
                        }
                        if (volumeConfigurationsListValue != null && volumeConfigurationsListValue.IsSetRaidLevel()) 
                        {
                            writer.WritePropertyName("RaidLevel");
                            writer.Write(volumeConfigurationsListValue.RaidLevel);
                        }
                        if (volumeConfigurationsListValue != null && volumeConfigurationsListValue.IsSetNumberOfDisks()) 
                        {
                            writer.WritePropertyName("NumberOfDisks");
                            writer.Write(volumeConfigurationsListValue.NumberOfDisks);
                        }
                        if (volumeConfigurationsListValue != null && volumeConfigurationsListValue.IsSetSize()) 
                        {
                            writer.WritePropertyName("Size");
                            writer.Write(volumeConfigurationsListValue.Size);
                        }
                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }
                if (createLayerRequest != null && createLayerRequest.IsSetEnableAutoHealing()) 
                {
                    writer.WritePropertyName("EnableAutoHealing");
                    writer.Write(createLayerRequest.EnableAutoHealing);
                }
                if (createLayerRequest != null && createLayerRequest.IsSetAutoAssignElasticIps()) 
                {
                    writer.WritePropertyName("AutoAssignElasticIps");
                    writer.Write(createLayerRequest.AutoAssignElasticIps);
                }

                if (createLayerRequest != null) 
                {
                    Recipes customRecipes = createLayerRequest.CustomRecipes;
                    if (customRecipes != null)
                    {
                        writer.WritePropertyName("CustomRecipes");
                        writer.WriteObjectStart();

                        if (customRecipes != null && customRecipes.Setup != null && customRecipes.Setup.Count > 0) 
                        {
                            List<string> setupList = customRecipes.Setup;
                            writer.WritePropertyName("Setup");
                            writer.WriteArrayStart();

                            foreach (string setupListValue in setupList) 
                            { 
                                writer.Write(StringUtils.FromString(setupListValue));
                            }

                            writer.WriteArrayEnd();
                        }

                        if (customRecipes != null && customRecipes.Configure != null && customRecipes.Configure.Count > 0) 
                        {
                            List<string> configureList = customRecipes.Configure;
                            writer.WritePropertyName("Configure");
                            writer.WriteArrayStart();

                            foreach (string configureListValue in configureList) 
                            { 
                                writer.Write(StringUtils.FromString(configureListValue));
                            }

                            writer.WriteArrayEnd();
                        }

                        if (customRecipes != null && customRecipes.Deploy != null && customRecipes.Deploy.Count > 0) 
                        {
                            List<string> deployList = customRecipes.Deploy;
                            writer.WritePropertyName("Deploy");
                            writer.WriteArrayStart();

                            foreach (string deployListValue in deployList) 
                            { 
                                writer.Write(StringUtils.FromString(deployListValue));
                            }

                            writer.WriteArrayEnd();
                        }

                        if (customRecipes != null && customRecipes.Undeploy != null && customRecipes.Undeploy.Count > 0) 
                        {
                            List<string> undeployList = customRecipes.Undeploy;
                            writer.WritePropertyName("Undeploy");
                            writer.WriteArrayStart();

                            foreach (string undeployListValue in undeployList) 
                            { 
                                writer.Write(StringUtils.FromString(undeployListValue));
                            }

                            writer.WriteArrayEnd();
                        }

                        if (customRecipes != null && customRecipes.Shutdown != null && customRecipes.Shutdown.Count > 0) 
                        {
                            List<string> shutdownList = customRecipes.Shutdown;
                            writer.WritePropertyName("Shutdown");
                            writer.WriteArrayStart();

                            foreach (string shutdownListValue in shutdownList) 
                            { 
                                writer.Write(StringUtils.FromString(shutdownListValue));
                            }

                            writer.WriteArrayEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (createLayerRequest != null && createLayerRequest.IsSetInstallUpdatesOnBoot()) 
                {
                    writer.WritePropertyName("InstallUpdatesOnBoot");
                    writer.Write(createLayerRequest.InstallUpdatesOnBoot);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
