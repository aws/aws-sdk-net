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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCloudExadataInfrastructure Request Marshaller
    /// </summary>       
    public class CreateCloudExadataInfrastructureRequestMarshaller : IMarshaller<IRequest, CreateCloudExadataInfrastructureRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCloudExadataInfrastructureRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCloudExadataInfrastructureRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Odb");
            string target = "Odb.CreateCloudExadataInfrastructure";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-08-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAvailabilityZone())
                {
                    context.Writer.WritePropertyName("availabilityZone");
                    context.Writer.Write(publicRequest.AvailabilityZone);
                }

                if(publicRequest.IsSetAvailabilityZoneId())
                {
                    context.Writer.WritePropertyName("availabilityZoneId");
                    context.Writer.Write(publicRequest.AvailabilityZoneId);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetComputeCount())
                {
                    context.Writer.WritePropertyName("computeCount");
                    context.Writer.Write(publicRequest.ComputeCount);
                }

                if(publicRequest.IsSetCustomerContactsToSendToOCI())
                {
                    context.Writer.WritePropertyName("customerContactsToSendToOCI");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCustomerContactsToSendToOCIListValue in publicRequest.CustomerContactsToSendToOCI)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CustomerContactMarshaller.Instance;
                        marshaller.Marshall(publicRequestCustomerContactsToSendToOCIListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDatabaseServerType())
                {
                    context.Writer.WritePropertyName("databaseServerType");
                    context.Writer.Write(publicRequest.DatabaseServerType);
                }

                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("displayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetMaintenanceWindow())
                {
                    context.Writer.WritePropertyName("maintenanceWindow");
                    context.Writer.WriteObjectStart();

                    var marshaller = MaintenanceWindowMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MaintenanceWindow, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetShape())
                {
                    context.Writer.WritePropertyName("shape");
                    context.Writer.Write(publicRequest.Shape);
                }

                if(publicRequest.IsSetStorageCount())
                {
                    context.Writer.WritePropertyName("storageCount");
                    context.Writer.Write(publicRequest.StorageCount);
                }

                if(publicRequest.IsSetStorageServerType())
                {
                    context.Writer.WritePropertyName("storageServerType");
                    context.Writer.Write(publicRequest.StorageServerType);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateCloudExadataInfrastructureRequestMarshaller _instance = new CreateCloudExadataInfrastructureRequestMarshaller();        

        internal static CreateCloudExadataInfrastructureRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCloudExadataInfrastructureRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}