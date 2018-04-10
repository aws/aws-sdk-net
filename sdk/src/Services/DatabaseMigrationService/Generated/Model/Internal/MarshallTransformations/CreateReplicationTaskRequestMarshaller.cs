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
    /// CreateReplicationTask Request Marshaller
    /// </summary>       
    public class CreateReplicationTaskRequestMarshaller : IMarshaller<IRequest, CreateReplicationTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateReplicationTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateReplicationTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.CreateReplicationTask";
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

                if(publicRequest.IsSetReplicationInstanceArn())
                {
                    context.Writer.WritePropertyName("ReplicationInstanceArn");
                    context.Writer.Write(publicRequest.ReplicationInstanceArn);
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

                if(publicRequest.IsSetSourceEndpointArn())
                {
                    context.Writer.WritePropertyName("SourceEndpointArn");
                    context.Writer.Write(publicRequest.SourceEndpointArn);
                }

                if(publicRequest.IsSetTableMappings())
                {
                    context.Writer.WritePropertyName("TableMappings");
                    context.Writer.Write(publicRequest.TableMappings);
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
        private static CreateReplicationTaskRequestMarshaller _instance = new CreateReplicationTaskRequestMarshaller();        

        internal static CreateReplicationTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateReplicationTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}