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
using System.Globalization;
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
    /// Update Layer Request Marshaller
    /// </summary>       
    internal class UpdateLayerRequestMarshaller : IMarshaller<IRequest, UpdateLayerRequest> 
    {
        

        public IRequest Marshall(UpdateLayerRequest updateLayerRequest) 
        {

            IRequest request = new DefaultRequest(updateLayerRequest, "AmazonOpsWorks");
            string target = "OpsWorks_20130218.UpdateLayer";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                int queryPosition = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryPosition + 1);
                uriResourcePath    = uriResourcePath.Substring(0, queryPosition);
        
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
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (updateLayerRequest != null && updateLayerRequest.IsSetLayerId()) 
                {
                    writer.WritePropertyName("LayerId");
                    writer.Write(updateLayerRequest.LayerId);
                }
                if (updateLayerRequest != null && updateLayerRequest.IsSetName()) 
                {
                    writer.WritePropertyName("Name");
                    writer.Write(updateLayerRequest.Name);
                }
                if (updateLayerRequest != null && updateLayerRequest.IsSetShortname()) 
                {
                    writer.WritePropertyName("Shortname");
                    writer.Write(updateLayerRequest.Shortname);
                }
                if (updateLayerRequest != null) 
                {
                    if (updateLayerRequest.Attributes != null && updateLayerRequest.Attributes.Count > 0)
                    {
                        writer.WritePropertyName("Attributes");
                        writer.WriteObjectStart();
                        foreach (string updateLayerRequestAttributesKey in updateLayerRequest.Attributes.Keys)
                        {
                            string attributesListValue;
                            bool attributesListValueHasValue = updateLayerRequest.Attributes.TryGetValue(updateLayerRequestAttributesKey, out attributesListValue);
                            writer.WritePropertyName(updateLayerRequestAttributesKey);

                        writer.Write(attributesListValue);
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (updateLayerRequest != null && updateLayerRequest.IsSetCustomInstanceProfileArn()) 
                {
                    writer.WritePropertyName("CustomInstanceProfileArn");
                    writer.Write(updateLayerRequest.CustomInstanceProfileArn);
                }

                if (updateLayerRequest != null && updateLayerRequest.CustomSecurityGroupIds != null && updateLayerRequest.CustomSecurityGroupIds.Count > 0) 
                {
                    List<string> customSecurityGroupIdsList = updateLayerRequest.CustomSecurityGroupIds;
                    writer.WritePropertyName("CustomSecurityGroupIds");
                    writer.WriteArrayStart();

                    foreach (string customSecurityGroupIdsListValue in customSecurityGroupIdsList) 
                    { 
                        writer.Write(StringUtils.FromString(customSecurityGroupIdsListValue));
                    }

                    writer.WriteArrayEnd();
                }

                if (updateLayerRequest != null && updateLayerRequest.Packages != null && updateLayerRequest.Packages.Count > 0) 
                {
                    List<string> packagesList = updateLayerRequest.Packages;
                    writer.WritePropertyName("Packages");
                    writer.WriteArrayStart();

                    foreach (string packagesListValue in packagesList) 
                    { 
                        writer.Write(StringUtils.FromString(packagesListValue));
                    }

                    writer.WriteArrayEnd();
                }

                if (updateLayerRequest != null && updateLayerRequest.VolumeConfigurations != null && updateLayerRequest.VolumeConfigurations.Count > 0)
                {
                    List<VolumeConfiguration> volumeConfigurationsList = updateLayerRequest.VolumeConfigurations;
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
                if (updateLayerRequest != null && updateLayerRequest.IsSetEnableAutoHealing()) 
                {
                    writer.WritePropertyName("EnableAutoHealing");
                    writer.Write(updateLayerRequest.EnableAutoHealing);
                }
                if (updateLayerRequest != null && updateLayerRequest.IsSetAutoAssignElasticIps()) 
                {
                    writer.WritePropertyName("AutoAssignElasticIps");
                    writer.Write(updateLayerRequest.AutoAssignElasticIps);
                }
                if (updateLayerRequest != null && updateLayerRequest.IsSetAutoAssignPublicIps()) 
                {
                    writer.WritePropertyName("AutoAssignPublicIps");
                    writer.Write(updateLayerRequest.AutoAssignPublicIps);
                }

                if (updateLayerRequest != null) 
                {
                    Recipes customRecipes = updateLayerRequest.CustomRecipes;
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
                if (updateLayerRequest != null && updateLayerRequest.IsSetInstallUpdatesOnBoot()) 
                {
                    writer.WritePropertyName("InstallUpdatesOnBoot");
                    writer.Write(updateLayerRequest.InstallUpdatesOnBoot);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
