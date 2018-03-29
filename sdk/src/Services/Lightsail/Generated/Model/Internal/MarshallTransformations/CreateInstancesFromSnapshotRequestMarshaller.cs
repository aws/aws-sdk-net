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
using ThirdParty.Json.LitJson;

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
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttachedDiskMapping())
                {
                    context.Writer.WritePropertyName("attachedDiskMapping");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAttachedDiskMappingKvp in publicRequest.AttachedDiskMapping)
                    {
                        context.Writer.WritePropertyName(publicRequestAttachedDiskMappingKvp.Key);
                        var publicRequestAttachedDiskMappingValue = publicRequestAttachedDiskMappingKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestAttachedDiskMappingValueListValue in publicRequestAttachedDiskMappingValue)
                        {
                            context.Writer.WriteObjectStart();

                            var marshaller = DiskMapMarshaller.Instance;
                            marshaller.Marshall(publicRequestAttachedDiskMappingValueListValue, context);

                            context.Writer.WriteObjectEnd();
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAvailabilityZone())
                {
                    context.Writer.WritePropertyName("availabilityZone");
                    context.Writer.Write(publicRequest.AvailabilityZone);
                }

                if(publicRequest.IsSetBundleId())
                {
                    context.Writer.WritePropertyName("bundleId");
                    context.Writer.Write(publicRequest.BundleId);
                }

                if(publicRequest.IsSetInstanceNames())
                {
                    context.Writer.WritePropertyName("instanceNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInstanceNamesListValue in publicRequest.InstanceNames)
                    {
                            context.Writer.Write(publicRequestInstanceNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetInstanceSnapshotName())
                {
                    context.Writer.WritePropertyName("instanceSnapshotName");
                    context.Writer.Write(publicRequest.InstanceSnapshotName);
                }

                if(publicRequest.IsSetKeyPairName())
                {
                    context.Writer.WritePropertyName("keyPairName");
                    context.Writer.Write(publicRequest.KeyPairName);
                }

                if(publicRequest.IsSetUserData())
                {
                    context.Writer.WritePropertyName("userData");
                    context.Writer.Write(publicRequest.UserData);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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