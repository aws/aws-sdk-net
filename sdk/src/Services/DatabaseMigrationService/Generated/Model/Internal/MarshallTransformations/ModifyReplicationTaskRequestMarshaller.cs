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
    /// ModifyReplicationTask Request Marshaller
    /// </summary>       
    public class ModifyReplicationTaskRequestMarshaller : IMarshaller<IRequest, ModifyReplicationTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyReplicationTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyReplicationTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.ModifyReplicationTask";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-01-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCdcStartPosition())
                {
                    context.Writer.WritePropertyName("CdcStartPosition");
                    context.Writer.Write(publicRequest.CdcStartPosition);
                }

                if(publicRequest.IsSetCdcStartTime())
                {
                    context.Writer.WritePropertyName("CdcStartTime");
                    context.Writer.Write(publicRequest.CdcStartTime);
                }

                if(publicRequest.IsSetCdcStopPosition())
                {
                    context.Writer.WritePropertyName("CdcStopPosition");
                    context.Writer.Write(publicRequest.CdcStopPosition);
                }

                if(publicRequest.IsSetMigrationType())
                {
                    context.Writer.WritePropertyName("MigrationType");
                    context.Writer.Write(publicRequest.MigrationType);
                }

                if(publicRequest.IsSetReplicationTaskArn())
                {
                    context.Writer.WritePropertyName("ReplicationTaskArn");
                    context.Writer.Write(publicRequest.ReplicationTaskArn);
                }

                if(publicRequest.IsSetReplicationTaskIdentifier())
                {
                    context.Writer.WritePropertyName("ReplicationTaskIdentifier");
                    context.Writer.Write(publicRequest.ReplicationTaskIdentifier);
                }

                if(publicRequest.IsSetReplicationTaskSettings())
                {
                    context.Writer.WritePropertyName("ReplicationTaskSettings");
                    context.Writer.Write(publicRequest.ReplicationTaskSettings);
                }

                if(publicRequest.IsSetTableMappings())
                {
                    context.Writer.WritePropertyName("TableMappings");
                    context.Writer.Write(publicRequest.TableMappings);
                }

                if(publicRequest.IsSetTaskData())
                {
                    context.Writer.WritePropertyName("TaskData");
                    context.Writer.Write(publicRequest.TaskData);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ModifyReplicationTaskRequestMarshaller _instance = new ModifyReplicationTaskRequestMarshaller();        

        internal static ModifyReplicationTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyReplicationTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}