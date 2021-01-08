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
using ThirdParty.Json.LitJson;

namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDiskFromSnapshot Request Marshaller
    /// </summary>       
    public class CreateDiskFromSnapshotRequestMarshaller : IMarshaller<IRequest, CreateDiskFromSnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDiskFromSnapshotRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDiskFromSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.CreateDiskFromSnapshot";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAddOns())
                {
                    context.Writer.WritePropertyName("addOns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAddOnsListValue in publicRequest.AddOns)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AddOnRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestAddOnsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAvailabilityZone())
                {
                    context.Writer.WritePropertyName("availabilityZone");
                    context.Writer.Write(publicRequest.AvailabilityZone);
                }

                if(publicRequest.IsSetDiskName())
                {
                    context.Writer.WritePropertyName("diskName");
                    context.Writer.Write(publicRequest.DiskName);
                }

                if(publicRequest.IsSetDiskSnapshotName())
                {
                    context.Writer.WritePropertyName("diskSnapshotName");
                    context.Writer.Write(publicRequest.DiskSnapshotName);
                }

                if(publicRequest.IsSetRestoreDate())
                {
                    context.Writer.WritePropertyName("restoreDate");
                    context.Writer.Write(publicRequest.RestoreDate);
                }

                if(publicRequest.IsSetSizeInGb())
                {
                    context.Writer.WritePropertyName("sizeInGb");
                    context.Writer.Write(publicRequest.SizeInGb);
                }

                if(publicRequest.IsSetSourceDiskName())
                {
                    context.Writer.WritePropertyName("sourceDiskName");
                    context.Writer.Write(publicRequest.SourceDiskName);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUseLatestRestorableAutoSnapshot())
                {
                    context.Writer.WritePropertyName("useLatestRestorableAutoSnapshot");
                    context.Writer.Write(publicRequest.UseLatestRestorableAutoSnapshot);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateDiskFromSnapshotRequestMarshaller _instance = new CreateDiskFromSnapshotRequestMarshaller();        

        internal static CreateDiskFromSnapshotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDiskFromSnapshotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}