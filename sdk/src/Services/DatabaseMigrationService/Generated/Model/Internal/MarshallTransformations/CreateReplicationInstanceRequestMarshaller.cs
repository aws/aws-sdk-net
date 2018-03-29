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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateReplicationInstance Request Marshaller
    /// </summary>       
    public class CreateReplicationInstanceRequestMarshaller : IMarshaller<IRequest, CreateReplicationInstanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateReplicationInstanceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateReplicationInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.CreateReplicationInstance";
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
                if(publicRequest.IsSetAllocatedStorage())
                {
                    context.Writer.WritePropertyName("AllocatedStorage");
                    context.Writer.Write(publicRequest.AllocatedStorage);
                }

                if(publicRequest.IsSetAutoMinorVersionUpgrade())
                {
                    context.Writer.WritePropertyName("AutoMinorVersionUpgrade");
                    context.Writer.Write(publicRequest.AutoMinorVersionUpgrade);
                }

                if(publicRequest.IsSetAvailabilityZone())
                {
                    context.Writer.WritePropertyName("AvailabilityZone");
                    context.Writer.Write(publicRequest.AvailabilityZone);
                }

                if(publicRequest.IsSetEngineVersion())
                {
                    context.Writer.WritePropertyName("EngineVersion");
                    context.Writer.Write(publicRequest.EngineVersion);
                }

                if(publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WritePropertyName("KmsKeyId");
                    context.Writer.Write(publicRequest.KmsKeyId);
                }

                if(publicRequest.IsSetMultiAZ())
                {
                    context.Writer.WritePropertyName("MultiAZ");
                    context.Writer.Write(publicRequest.MultiAZ);
                }

                if(publicRequest.IsSetPreferredMaintenanceWindow())
                {
                    context.Writer.WritePropertyName("PreferredMaintenanceWindow");
                    context.Writer.Write(publicRequest.PreferredMaintenanceWindow);
                }

                if(publicRequest.IsSetPubliclyAccessible())
                {
                    context.Writer.WritePropertyName("PubliclyAccessible");
                    context.Writer.Write(publicRequest.PubliclyAccessible);
                }

                if(publicRequest.IsSetReplicationInstanceClass())
                {
                    context.Writer.WritePropertyName("ReplicationInstanceClass");
                    context.Writer.Write(publicRequest.ReplicationInstanceClass);
                }

                if(publicRequest.IsSetReplicationInstanceIdentifier())
                {
                    context.Writer.WritePropertyName("ReplicationInstanceIdentifier");
                    context.Writer.Write(publicRequest.ReplicationInstanceIdentifier);
                }

                if(publicRequest.IsSetReplicationSubnetGroupIdentifier())
                {
                    context.Writer.WritePropertyName("ReplicationSubnetGroupIdentifier");
                    context.Writer.Write(publicRequest.ReplicationSubnetGroupIdentifier);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
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

                if(publicRequest.IsSetVpcSecurityGroupIds())
                {
                    context.Writer.WritePropertyName("VpcSecurityGroupIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestVpcSecurityGroupIdsListValue in publicRequest.VpcSecurityGroupIds)
                    {
                            context.Writer.Write(publicRequestVpcSecurityGroupIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateReplicationInstanceRequestMarshaller _instance = new CreateReplicationInstanceRequestMarshaller();        

        internal static CreateReplicationInstanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateReplicationInstanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}