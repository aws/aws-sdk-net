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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLayer Request Marshaller
    /// </summary>       
    public class UpdateLayerRequestMarshaller : IMarshaller<IRequest, UpdateLayerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLayerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLayerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.UpdateLayer";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-02-18";
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
            if(publicRequest.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                {
                    context.Writer.WritePropertyName(publicRequestAttributesKvp.Key);
                    var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAutoAssignElasticIps())
            {
                context.Writer.WritePropertyName("AutoAssignElasticIps");
                context.Writer.WriteBooleanValue(publicRequest.AutoAssignElasticIps.Value);
            }

            if(publicRequest.IsSetAutoAssignPublicIps())
            {
                context.Writer.WritePropertyName("AutoAssignPublicIps");
                context.Writer.WriteBooleanValue(publicRequest.AutoAssignPublicIps.Value);
            }

            if(publicRequest.IsSetCloudWatchLogsConfiguration())
            {
                context.Writer.WritePropertyName("CloudWatchLogsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchLogsConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.CloudWatchLogsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCustomInstanceProfileArn())
            {
                context.Writer.WritePropertyName("CustomInstanceProfileArn");
                context.Writer.WriteStringValue(publicRequest.CustomInstanceProfileArn);
            }

            if(publicRequest.IsSetCustomJson())
            {
                context.Writer.WritePropertyName("CustomJson");
                context.Writer.WriteStringValue(publicRequest.CustomJson);
            }

            if(publicRequest.IsSetCustomRecipes())
            {
                context.Writer.WritePropertyName("CustomRecipes");
                context.Writer.WriteStartObject();

                var marshaller = RecipesMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomRecipes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCustomSecurityGroupIds())
            {
                context.Writer.WritePropertyName("CustomSecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCustomSecurityGroupIdsListValue in publicRequest.CustomSecurityGroupIds)
                {
                        context.Writer.WriteStringValue(publicRequestCustomSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEnableAutoHealing())
            {
                context.Writer.WritePropertyName("EnableAutoHealing");
                context.Writer.WriteBooleanValue(publicRequest.EnableAutoHealing.Value);
            }

            if(publicRequest.IsSetInstallUpdatesOnBoot())
            {
                context.Writer.WritePropertyName("InstallUpdatesOnBoot");
                context.Writer.WriteBooleanValue(publicRequest.InstallUpdatesOnBoot.Value);
            }

            if(publicRequest.IsSetLayerId())
            {
                context.Writer.WritePropertyName("LayerId");
                context.Writer.WriteStringValue(publicRequest.LayerId);
            }

            if(publicRequest.IsSetLifecycleEventConfiguration())
            {
                context.Writer.WritePropertyName("LifecycleEventConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LifecycleEventConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.LifecycleEventConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetPackages())
            {
                context.Writer.WritePropertyName("Packages");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPackagesListValue in publicRequest.Packages)
                {
                        context.Writer.WriteStringValue(publicRequestPackagesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetShortname())
            {
                context.Writer.WritePropertyName("Shortname");
                context.Writer.WriteStringValue(publicRequest.Shortname);
            }

            if(publicRequest.IsSetUseEbsOptimizedInstances())
            {
                context.Writer.WritePropertyName("UseEbsOptimizedInstances");
                context.Writer.WriteBooleanValue(publicRequest.UseEbsOptimizedInstances.Value);
            }

            if(publicRequest.IsSetVolumeConfigurations())
            {
                context.Writer.WritePropertyName("VolumeConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestVolumeConfigurationsListValue in publicRequest.VolumeConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VolumeConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestVolumeConfigurationsListValue, context);

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
        private static UpdateLayerRequestMarshaller _instance = new UpdateLayerRequestMarshaller();        

        internal static UpdateLayerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLayerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}