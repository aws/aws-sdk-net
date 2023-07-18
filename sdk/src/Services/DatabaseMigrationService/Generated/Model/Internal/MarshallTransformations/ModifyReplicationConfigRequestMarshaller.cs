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
    /// ModifyReplicationConfig Request Marshaller
    /// </summary>       
    public class ModifyReplicationConfigRequestMarshaller : IMarshaller<IRequest, ModifyReplicationConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyReplicationConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyReplicationConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.ModifyReplicationConfig";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComputeConfig())
                {
                    context.Writer.WritePropertyName("ComputeConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ComputeConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ComputeConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetReplicationConfigArn())
                {
                    context.Writer.WritePropertyName("ReplicationConfigArn");
                    context.Writer.Write(publicRequest.ReplicationConfigArn);
                }

                if(publicRequest.IsSetReplicationConfigIdentifier())
                {
                    context.Writer.WritePropertyName("ReplicationConfigIdentifier");
                    context.Writer.Write(publicRequest.ReplicationConfigIdentifier);
                }

                if(publicRequest.IsSetReplicationSettings())
                {
                    context.Writer.WritePropertyName("ReplicationSettings");
                    context.Writer.Write(publicRequest.ReplicationSettings);
                }

                if(publicRequest.IsSetReplicationType())
                {
                    context.Writer.WritePropertyName("ReplicationType");
                    context.Writer.Write(publicRequest.ReplicationType);
                }

                if(publicRequest.IsSetSourceEndpointArn())
                {
                    context.Writer.WritePropertyName("SourceEndpointArn");
                    context.Writer.Write(publicRequest.SourceEndpointArn);
                }

                if(publicRequest.IsSetSupplementalSettings())
                {
                    context.Writer.WritePropertyName("SupplementalSettings");
                    context.Writer.Write(publicRequest.SupplementalSettings);
                }

                if(publicRequest.IsSetTableMappings())
                {
                    context.Writer.WritePropertyName("TableMappings");
                    context.Writer.Write(publicRequest.TableMappings);
                }

                if(publicRequest.IsSetTargetEndpointArn())
                {
                    context.Writer.WritePropertyName("TargetEndpointArn");
                    context.Writer.Write(publicRequest.TargetEndpointArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ModifyReplicationConfigRequestMarshaller _instance = new ModifyReplicationConfigRequestMarshaller();        

        internal static ModifyReplicationConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyReplicationConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}