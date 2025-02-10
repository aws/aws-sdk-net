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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Finspace.Model;
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
namespace Amazon.Finspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateKxCluster Request Marshaller
    /// </summary>       
    public class CreateKxClusterRequestMarshaller : IMarshaller<IRequest, CreateKxClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateKxClusterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateKxClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Finspace");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-03-12";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetEnvironmentId())
                throw new AmazonFinspaceException("Request object does not have required field EnvironmentId set");
            request.AddPathResource("{environmentId}", StringUtils.FromString(publicRequest.EnvironmentId));
            request.ResourcePath = "/kx/environments/{environmentId}/clusters";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAutoScalingConfiguration())
            {
                context.Writer.WritePropertyName("autoScalingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AutoScalingConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutoScalingConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAvailabilityZoneId())
            {
                context.Writer.WritePropertyName("availabilityZoneId");
                context.Writer.WriteStringValue(publicRequest.AvailabilityZoneId);
            }

            if(publicRequest.IsSetAzMode())
            {
                context.Writer.WritePropertyName("azMode");
                context.Writer.WriteStringValue(publicRequest.AzMode);
            }

            if(publicRequest.IsSetCacheStorageConfigurations())
            {
                context.Writer.WritePropertyName("cacheStorageConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCacheStorageConfigurationsListValue in publicRequest.CacheStorageConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = KxCacheStorageConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestCacheStorageConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCapacityConfiguration())
            {
                context.Writer.WritePropertyName("capacityConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CapacityConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.CapacityConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetClusterDescription())
            {
                context.Writer.WritePropertyName("clusterDescription");
                context.Writer.WriteStringValue(publicRequest.ClusterDescription);
            }

            if(publicRequest.IsSetClusterName())
            {
                context.Writer.WritePropertyName("clusterName");
                context.Writer.WriteStringValue(publicRequest.ClusterName);
            }

            if(publicRequest.IsSetClusterType())
            {
                context.Writer.WritePropertyName("clusterType");
                context.Writer.WriteStringValue(publicRequest.ClusterType);
            }

            if(publicRequest.IsSetCode())
            {
                context.Writer.WritePropertyName("code");
                context.Writer.WriteStartObject();

                var marshaller = CodeConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Code, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCommandLineArguments())
            {
                context.Writer.WritePropertyName("commandLineArguments");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCommandLineArgumentsListValue in publicRequest.CommandLineArguments)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = KxCommandLineArgumentMarshaller.Instance;
                    marshaller.Marshall(publicRequestCommandLineArgumentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDatabases())
            {
                context.Writer.WritePropertyName("databases");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDatabasesListValue in publicRequest.Databases)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = KxDatabaseConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestDatabasesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetExecutionRole())
            {
                context.Writer.WritePropertyName("executionRole");
                context.Writer.WriteStringValue(publicRequest.ExecutionRole);
            }

            if(publicRequest.IsSetInitializationScript())
            {
                context.Writer.WritePropertyName("initializationScript");
                context.Writer.WriteStringValue(publicRequest.InitializationScript);
            }

            if(publicRequest.IsSetReleaseLabel())
            {
                context.Writer.WritePropertyName("releaseLabel");
                context.Writer.WriteStringValue(publicRequest.ReleaseLabel);
            }

            if(publicRequest.IsSetSavedownStorageConfiguration())
            {
                context.Writer.WritePropertyName("savedownStorageConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = KxSavedownStorageConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SavedownStorageConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetScalingGroupConfiguration())
            {
                context.Writer.WritePropertyName("scalingGroupConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = KxScalingGroupConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ScalingGroupConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTickerplantLogConfiguration())
            {
                context.Writer.WritePropertyName("tickerplantLogConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TickerplantLogConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.TickerplantLogConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVpcConfiguration())
            {
                context.Writer.WritePropertyName("vpcConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = VpcConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.VpcConfiguration, context);

                context.Writer.WriteEndObject();
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
        private static CreateKxClusterRequestMarshaller _instance = new CreateKxClusterRequestMarshaller();        

        internal static CreateKxClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateKxClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}