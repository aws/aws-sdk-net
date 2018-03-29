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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
    /// CreateLayer Request Marshaller
    /// </summary>       
    public class CreateLayerRequestMarshaller : IMarshaller<IRequest, CreateLayerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLayerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLayerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.CreateLayer";
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
                if(publicRequest.IsSetAttributes())
                {
                    context.Writer.WritePropertyName("Attributes");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                    {
                        context.Writer.WritePropertyName(publicRequestAttributesKvp.Key);
                        var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                            context.Writer.Write(publicRequestAttributesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAutoAssignElasticIps())
                {
                    context.Writer.WritePropertyName("AutoAssignElasticIps");
                    context.Writer.Write(publicRequest.AutoAssignElasticIps);
                }

                if(publicRequest.IsSetAutoAssignPublicIps())
                {
                    context.Writer.WritePropertyName("AutoAssignPublicIps");
                    context.Writer.Write(publicRequest.AutoAssignPublicIps);
                }

                if(publicRequest.IsSetCloudWatchLogsConfiguration())
                {
                    context.Writer.WritePropertyName("CloudWatchLogsConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CloudWatchLogsConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CloudWatchLogsConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCustomInstanceProfileArn())
                {
                    context.Writer.WritePropertyName("CustomInstanceProfileArn");
                    context.Writer.Write(publicRequest.CustomInstanceProfileArn);
                }

                if(publicRequest.IsSetCustomJson())
                {
                    context.Writer.WritePropertyName("CustomJson");
                    context.Writer.Write(publicRequest.CustomJson);
                }

                if(publicRequest.IsSetCustomRecipes())
                {
                    context.Writer.WritePropertyName("CustomRecipes");
                    context.Writer.WriteObjectStart();

                    var marshaller = RecipesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CustomRecipes, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCustomSecurityGroupIds())
                {
                    context.Writer.WritePropertyName("CustomSecurityGroupIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCustomSecurityGroupIdsListValue in publicRequest.CustomSecurityGroupIds)
                    {
                            context.Writer.Write(publicRequestCustomSecurityGroupIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEnableAutoHealing())
                {
                    context.Writer.WritePropertyName("EnableAutoHealing");
                    context.Writer.Write(publicRequest.EnableAutoHealing);
                }

                if(publicRequest.IsSetInstallUpdatesOnBoot())
                {
                    context.Writer.WritePropertyName("InstallUpdatesOnBoot");
                    context.Writer.Write(publicRequest.InstallUpdatesOnBoot);
                }

                if(publicRequest.IsSetLifecycleEventConfiguration())
                {
                    context.Writer.WritePropertyName("LifecycleEventConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = LifecycleEventConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LifecycleEventConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPackages())
                {
                    context.Writer.WritePropertyName("Packages");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPackagesListValue in publicRequest.Packages)
                    {
                            context.Writer.Write(publicRequestPackagesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetShortname())
                {
                    context.Writer.WritePropertyName("Shortname");
                    context.Writer.Write(publicRequest.Shortname);
                }

                if(publicRequest.IsSetStackId())
                {
                    context.Writer.WritePropertyName("StackId");
                    context.Writer.Write(publicRequest.StackId);
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("Type");
                    context.Writer.Write(publicRequest.Type);
                }

                if(publicRequest.IsSetUseEbsOptimizedInstances())
                {
                    context.Writer.WritePropertyName("UseEbsOptimizedInstances");
                    context.Writer.Write(publicRequest.UseEbsOptimizedInstances);
                }

                if(publicRequest.IsSetVolumeConfigurations())
                {
                    context.Writer.WritePropertyName("VolumeConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestVolumeConfigurationsListValue in publicRequest.VolumeConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = VolumeConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestVolumeConfigurationsListValue, context);

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
        private static CreateLayerRequestMarshaller _instance = new CreateLayerRequestMarshaller();        

        internal static CreateLayerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLayerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}