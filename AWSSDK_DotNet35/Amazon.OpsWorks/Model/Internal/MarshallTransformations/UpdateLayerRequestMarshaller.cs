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

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLayer Request Marshaller
    /// </summary>       
    public class UpdateLayerRequestMarshaller : IMarshaller<IRequest, UpdateLayerRequest> 
    {
        public IRequest Marshall(UpdateLayerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.UpdateLayer";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetAttributes())
                {
                    writer.WritePropertyName("Attributes");
                    writer.WriteObjectStart();
                    foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                    {
                        writer.WritePropertyName(publicRequestAttributesKvp.Key);
                        var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                        writer.Write(publicRequestAttributesValue);
                    }
                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAutoAssignElasticIps())
                {
                    writer.WritePropertyName("AutoAssignElasticIps");
                    writer.Write(publicRequest.AutoAssignElasticIps);
                }

                if(publicRequest.IsSetAutoAssignPublicIps())
                {
                    writer.WritePropertyName("AutoAssignPublicIps");
                    writer.Write(publicRequest.AutoAssignPublicIps);
                }

                if(publicRequest.IsSetCustomInstanceProfileArn())
                {
                    writer.WritePropertyName("CustomInstanceProfileArn");
                    writer.Write(publicRequest.CustomInstanceProfileArn);
                }

                if(publicRequest.IsSetCustomRecipes())
                {
                    writer.WritePropertyName("CustomRecipes");
                    writer.WriteObjectStart();
                    if(publicRequest.CustomRecipes.IsSetConfigure())
                    {
                        writer.WritePropertyName("Configure");
                        writer.WriteArrayStart();
                        foreach(var publicRequestCustomRecipesConfigureListValue in publicRequest.CustomRecipes.Configure)
                        {
                            writer.Write(publicRequestCustomRecipesConfigureListValue);
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.CustomRecipes.IsSetDeploy())
                    {
                        writer.WritePropertyName("Deploy");
                        writer.WriteArrayStart();
                        foreach(var publicRequestCustomRecipesDeployListValue in publicRequest.CustomRecipes.Deploy)
                        {
                            writer.Write(publicRequestCustomRecipesDeployListValue);
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.CustomRecipes.IsSetSetup())
                    {
                        writer.WritePropertyName("Setup");
                        writer.WriteArrayStart();
                        foreach(var publicRequestCustomRecipesSetupListValue in publicRequest.CustomRecipes.Setup)
                        {
                            writer.Write(publicRequestCustomRecipesSetupListValue);
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.CustomRecipes.IsSetShutdown())
                    {
                        writer.WritePropertyName("Shutdown");
                        writer.WriteArrayStart();
                        foreach(var publicRequestCustomRecipesShutdownListValue in publicRequest.CustomRecipes.Shutdown)
                        {
                            writer.Write(publicRequestCustomRecipesShutdownListValue);
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.CustomRecipes.IsSetUndeploy())
                    {
                        writer.WritePropertyName("Undeploy");
                        writer.WriteArrayStart();
                        foreach(var publicRequestCustomRecipesUndeployListValue in publicRequest.CustomRecipes.Undeploy)
                        {
                            writer.Write(publicRequestCustomRecipesUndeployListValue);
                        }
                        writer.WriteArrayEnd();
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCustomSecurityGroupIds())
                {
                    writer.WritePropertyName("CustomSecurityGroupIds");
                    writer.WriteArrayStart();
                    foreach(var publicRequestCustomSecurityGroupIdsListValue in publicRequest.CustomSecurityGroupIds)
                    {
                        writer.Write(publicRequestCustomSecurityGroupIdsListValue);
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEnableAutoHealing())
                {
                    writer.WritePropertyName("EnableAutoHealing");
                    writer.Write(publicRequest.EnableAutoHealing);
                }

                if(publicRequest.IsSetInstallUpdatesOnBoot())
                {
                    writer.WritePropertyName("InstallUpdatesOnBoot");
                    writer.Write(publicRequest.InstallUpdatesOnBoot);
                }

                if(publicRequest.IsSetLayerId())
                {
                    writer.WritePropertyName("LayerId");
                    writer.Write(publicRequest.LayerId);
                }

                if(publicRequest.IsSetName())
                {
                    writer.WritePropertyName("Name");
                    writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPackages())
                {
                    writer.WritePropertyName("Packages");
                    writer.WriteArrayStart();
                    foreach(var publicRequestPackagesListValue in publicRequest.Packages)
                    {
                        writer.Write(publicRequestPackagesListValue);
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetShortname())
                {
                    writer.WritePropertyName("Shortname");
                    writer.Write(publicRequest.Shortname);
                }

                if(publicRequest.IsSetUseEbsOptimizedInstances())
                {
                    writer.WritePropertyName("UseEbsOptimizedInstances");
                    writer.Write(publicRequest.UseEbsOptimizedInstances);
                }

                if(publicRequest.IsSetVolumeConfigurations())
                {
                    writer.WritePropertyName("VolumeConfigurations");
                    writer.WriteArrayStart();
                    foreach(var publicRequestVolumeConfigurationsListValue in publicRequest.VolumeConfigurations)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestVolumeConfigurationsListValue.IsSetIops())
                        {
                            writer.WritePropertyName("Iops");
                            writer.Write(publicRequestVolumeConfigurationsListValue.Iops);
                        }

                        if(publicRequestVolumeConfigurationsListValue.IsSetMountPoint())
                        {
                            writer.WritePropertyName("MountPoint");
                            writer.Write(publicRequestVolumeConfigurationsListValue.MountPoint);
                        }

                        if(publicRequestVolumeConfigurationsListValue.IsSetNumberOfDisks())
                        {
                            writer.WritePropertyName("NumberOfDisks");
                            writer.Write(publicRequestVolumeConfigurationsListValue.NumberOfDisks);
                        }

                        if(publicRequestVolumeConfigurationsListValue.IsSetRaidLevel())
                        {
                            writer.WritePropertyName("RaidLevel");
                            writer.Write(publicRequestVolumeConfigurationsListValue.RaidLevel);
                        }

                        if(publicRequestVolumeConfigurationsListValue.IsSetSize())
                        {
                            writer.WritePropertyName("Size");
                            writer.Write(publicRequestVolumeConfigurationsListValue.Size);
                        }

                        if(publicRequestVolumeConfigurationsListValue.IsSetVolumeType())
                        {
                            writer.WritePropertyName("VolumeType");
                            writer.Write(publicRequestVolumeConfigurationsListValue.VolumeType);
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}