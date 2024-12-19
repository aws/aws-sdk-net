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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
using System.Text.Json;
using System.Buffers;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RunJobFlow Request Marshaller
    /// </summary>       
    public class RunJobFlowRequestMarshaller : IMarshaller<IRequest, RunJobFlowRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RunJobFlowRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RunJobFlowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticMapReduce");
            string target = "ElasticMapReduce.RunJobFlow";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2009-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if NETCOREAPP3_1_OR_GREATER
            ArrayBufferWriter<byte> arrayBufferWriter = new ArrayBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAdditionalInfo())
            {
                context.Writer.WritePropertyName("AdditionalInfo");
                context.Writer.WriteStringValue(publicRequest.AdditionalInfo);
            }

            if(publicRequest.IsSetAmiVersion())
            {
                context.Writer.WritePropertyName("AmiVersion");
                context.Writer.WriteStringValue(publicRequest.AmiVersion);
            }

            if(publicRequest.IsSetApplications())
            {
                context.Writer.WritePropertyName("Applications");
                context.Writer.WriteStartArray();
                foreach(var publicRequestApplicationsListValue in publicRequest.Applications)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ApplicationMarshaller.Instance;
                    marshaller.Marshall(publicRequestApplicationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAutoScalingRole())
            {
                context.Writer.WritePropertyName("AutoScalingRole");
                context.Writer.WriteStringValue(publicRequest.AutoScalingRole);
            }

            if(publicRequest.IsSetAutoTerminationPolicy())
            {
                context.Writer.WritePropertyName("AutoTerminationPolicy");
                context.Writer.WriteStartObject();

                var marshaller = AutoTerminationPolicyMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutoTerminationPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetBootstrapActions())
            {
                context.Writer.WritePropertyName("BootstrapActions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestBootstrapActionsListValue in publicRequest.BootstrapActions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BootstrapActionConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestBootstrapActionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetConfigurations())
            {
                context.Writer.WritePropertyName("Configurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestConfigurationsListValue in publicRequest.Configurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCustomAmiId())
            {
                context.Writer.WritePropertyName("CustomAmiId");
                context.Writer.WriteStringValue(publicRequest.CustomAmiId);
            }

            if(publicRequest.IsSetEbsRootVolumeIops())
            {
                context.Writer.WritePropertyName("EbsRootVolumeIops");
                context.Writer.WriteNumberValue(publicRequest.EbsRootVolumeIops.Value);
            }

            if(publicRequest.IsSetEbsRootVolumeSize())
            {
                context.Writer.WritePropertyName("EbsRootVolumeSize");
                context.Writer.WriteNumberValue(publicRequest.EbsRootVolumeSize.Value);
            }

            if(publicRequest.IsSetEbsRootVolumeThroughput())
            {
                context.Writer.WritePropertyName("EbsRootVolumeThroughput");
                context.Writer.WriteNumberValue(publicRequest.EbsRootVolumeThroughput.Value);
            }

            if(publicRequest.IsSetInstances())
            {
                context.Writer.WritePropertyName("Instances");
                context.Writer.WriteStartObject();

                var marshaller = JobFlowInstancesConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.Instances, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetJobFlowRole())
            {
                context.Writer.WritePropertyName("JobFlowRole");
                context.Writer.WriteStringValue(publicRequest.JobFlowRole);
            }

            if(publicRequest.IsSetKerberosAttributes())
            {
                context.Writer.WritePropertyName("KerberosAttributes");
                context.Writer.WriteStartObject();

                var marshaller = KerberosAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.KerberosAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLogEncryptionKmsKeyId())
            {
                context.Writer.WritePropertyName("LogEncryptionKmsKeyId");
                context.Writer.WriteStringValue(publicRequest.LogEncryptionKmsKeyId);
            }

            if(publicRequest.IsSetLogUri())
            {
                context.Writer.WritePropertyName("LogUri");
                context.Writer.WriteStringValue(publicRequest.LogUri);
            }

            if(publicRequest.IsSetManagedScalingPolicy())
            {
                context.Writer.WritePropertyName("ManagedScalingPolicy");
                context.Writer.WriteStartObject();

                var marshaller = ManagedScalingPolicyMarshaller.Instance;
                marshaller.Marshall(publicRequest.ManagedScalingPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNewSupportedProducts())
            {
                context.Writer.WritePropertyName("NewSupportedProducts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNewSupportedProductsListValue in publicRequest.NewSupportedProducts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SupportedProductConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestNewSupportedProductsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOSReleaseLabel())
            {
                context.Writer.WritePropertyName("OSReleaseLabel");
                context.Writer.WriteStringValue(publicRequest.OSReleaseLabel);
            }

            if(publicRequest.IsSetPlacementGroupConfigs())
            {
                context.Writer.WritePropertyName("PlacementGroupConfigs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPlacementGroupConfigsListValue in publicRequest.PlacementGroupConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PlacementGroupConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestPlacementGroupConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetReleaseLabel())
            {
                context.Writer.WritePropertyName("ReleaseLabel");
                context.Writer.WriteStringValue(publicRequest.ReleaseLabel);
            }

            if(publicRequest.IsSetRepoUpgradeOnBoot())
            {
                context.Writer.WritePropertyName("RepoUpgradeOnBoot");
                context.Writer.WriteStringValue(publicRequest.RepoUpgradeOnBoot);
            }

            if(publicRequest.IsSetScaleDownBehavior())
            {
                context.Writer.WritePropertyName("ScaleDownBehavior");
                context.Writer.WriteStringValue(publicRequest.ScaleDownBehavior);
            }

            if(publicRequest.IsSetSecurityConfiguration())
            {
                context.Writer.WritePropertyName("SecurityConfiguration");
                context.Writer.WriteStringValue(publicRequest.SecurityConfiguration);
            }

            if(publicRequest.IsSetServiceRole())
            {
                context.Writer.WritePropertyName("ServiceRole");
                context.Writer.WriteStringValue(publicRequest.ServiceRole);
            }

            if(publicRequest.IsSetStepConcurrencyLevel())
            {
                context.Writer.WritePropertyName("StepConcurrencyLevel");
                context.Writer.WriteNumberValue(publicRequest.StepConcurrencyLevel.Value);
            }

            if(publicRequest.IsSetSteps())
            {
                context.Writer.WritePropertyName("Steps");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStepsListValue in publicRequest.Steps)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StepConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestStepsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSupportedProducts())
            {
                context.Writer.WritePropertyName("SupportedProducts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSupportedProductsListValue in publicRequest.SupportedProducts)
                {
                        context.Writer.WriteStringValue(publicRequestSupportedProductsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetVisibleToAllUsers())
            {
                context.Writer.WritePropertyName("VisibleToAllUsers");
                context.Writer.WriteBooleanValue(publicRequest.VisibleToAllUsers.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETCOREAPP3_1_OR_GREATER
            request.Content = arrayBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static RunJobFlowRequestMarshaller _instance = new RunJobFlowRequestMarshaller();        

        internal static RunJobFlowRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RunJobFlowRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}