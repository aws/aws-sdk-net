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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
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
namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateInstancesFromSnapshot Request Marshaller
    /// </summary>       
    public class CreateInstancesFromSnapshotRequestMarshaller : IMarshaller<IRequest, CreateInstancesFromSnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateInstancesFromSnapshotRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateInstancesFromSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.CreateInstancesFromSnapshot";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";
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
            if(publicRequest.IsSetAddOns())
            {
                context.Writer.WritePropertyName("addOns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAddOnsListValue in publicRequest.AddOns)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AddOnRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestAddOnsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAttachedDiskMapping())
            {
                context.Writer.WritePropertyName("attachedDiskMapping");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAttachedDiskMappingKvp in publicRequest.AttachedDiskMapping)
                {
                    context.Writer.WritePropertyName(publicRequestAttachedDiskMappingKvp.Key);
                    var publicRequestAttachedDiskMappingValue = publicRequestAttachedDiskMappingKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var publicRequestAttachedDiskMappingValueListValue in publicRequestAttachedDiskMappingValue)
                    {
                        context.Writer.WriteStartObject();

                        var marshaller = DiskMapMarshaller.Instance;
                        marshaller.Marshall(publicRequestAttachedDiskMappingValueListValue, context);

                        context.Writer.WriteEndObject();
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("availabilityZone");
                context.Writer.WriteStringValue(publicRequest.AvailabilityZone);
            }

            if(publicRequest.IsSetBundleId())
            {
                context.Writer.WritePropertyName("bundleId");
                context.Writer.WriteStringValue(publicRequest.BundleId);
            }

            if(publicRequest.IsSetInstanceNames())
            {
                context.Writer.WritePropertyName("instanceNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInstanceNamesListValue in publicRequest.InstanceNames)
                {
                        context.Writer.WriteStringValue(publicRequestInstanceNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetInstanceSnapshotName())
            {
                context.Writer.WritePropertyName("instanceSnapshotName");
                context.Writer.WriteStringValue(publicRequest.InstanceSnapshotName);
            }

            if(publicRequest.IsSetIpAddressType())
            {
                context.Writer.WritePropertyName("ipAddressType");
                context.Writer.WriteStringValue(publicRequest.IpAddressType);
            }

            if(publicRequest.IsSetKeyPairName())
            {
                context.Writer.WritePropertyName("keyPairName");
                context.Writer.WriteStringValue(publicRequest.KeyPairName);
            }

            if(publicRequest.IsSetRestoreDate())
            {
                context.Writer.WritePropertyName("restoreDate");
                context.Writer.WriteStringValue(publicRequest.RestoreDate);
            }

            if(publicRequest.IsSetSourceInstanceName())
            {
                context.Writer.WritePropertyName("sourceInstanceName");
                context.Writer.WriteStringValue(publicRequest.SourceInstanceName);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
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

            if(publicRequest.IsSetUseLatestRestorableAutoSnapshot())
            {
                context.Writer.WritePropertyName("useLatestRestorableAutoSnapshot");
                context.Writer.WriteBooleanValue(publicRequest.UseLatestRestorableAutoSnapshot.Value);
            }

            if(publicRequest.IsSetUserData())
            {
                context.Writer.WritePropertyName("userData");
                context.Writer.WriteStringValue(publicRequest.UserData);
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
        private static CreateInstancesFromSnapshotRequestMarshaller _instance = new CreateInstancesFromSnapshotRequestMarshaller();        

        internal static CreateInstancesFromSnapshotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateInstancesFromSnapshotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}