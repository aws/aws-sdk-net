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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartBackupJob Request Marshaller
    /// </summary>       
    public class StartBackupJobRequestMarshaller : IMarshaller<IRequest, StartBackupJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartBackupJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartBackupJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/backup-jobs";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBackupOptions())
                {
                    context.Writer.WritePropertyName("BackupOptions");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestBackupOptionsKvp in publicRequest.BackupOptions)
                    {
                        context.Writer.WritePropertyName(publicRequestBackupOptionsKvp.Key);
                        var publicRequestBackupOptionsValue = publicRequestBackupOptionsKvp.Value;

                            context.Writer.Write(publicRequestBackupOptionsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetBackupVaultName())
                {
                    context.Writer.WritePropertyName("BackupVaultName");
                    context.Writer.Write(publicRequest.BackupVaultName);
                }

                if(publicRequest.IsSetCompleteWindowMinutes())
                {
                    context.Writer.WritePropertyName("CompleteWindowMinutes");
                    context.Writer.Write(publicRequest.CompleteWindowMinutes);
                }

                if(publicRequest.IsSetIamRoleArn())
                {
                    context.Writer.WritePropertyName("IamRoleArn");
                    context.Writer.Write(publicRequest.IamRoleArn);
                }

                if(publicRequest.IsSetIdempotencyToken())
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(publicRequest.IdempotencyToken);
                }

                else if(!(publicRequest.IsSetIdempotencyToken()))
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetIndex())
                {
                    context.Writer.WritePropertyName("Index");
                    context.Writer.Write(publicRequest.Index);
                }

                if(publicRequest.IsSetLifecycle())
                {
                    context.Writer.WritePropertyName("Lifecycle");
                    context.Writer.WriteObjectStart();

                    var marshaller = LifecycleMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Lifecycle, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLogicallyAirGappedBackupVaultArn())
                {
                    context.Writer.WritePropertyName("LogicallyAirGappedBackupVaultArn");
                    context.Writer.Write(publicRequest.LogicallyAirGappedBackupVaultArn);
                }

                if(publicRequest.IsSetRecoveryPointTags())
                {
                    context.Writer.WritePropertyName("RecoveryPointTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestRecoveryPointTagsKvp in publicRequest.RecoveryPointTags)
                    {
                        context.Writer.WritePropertyName(publicRequestRecoveryPointTagsKvp.Key);
                        var publicRequestRecoveryPointTagsValue = publicRequestRecoveryPointTagsKvp.Value;

                            context.Writer.Write(publicRequestRecoveryPointTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResourceArn())
                {
                    context.Writer.WritePropertyName("ResourceArn");
                    context.Writer.Write(publicRequest.ResourceArn);
                }

                if(publicRequest.IsSetStartWindowMinutes())
                {
                    context.Writer.WritePropertyName("StartWindowMinutes");
                    context.Writer.Write(publicRequest.StartWindowMinutes);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartBackupJobRequestMarshaller _instance = new StartBackupJobRequestMarshaller();        

        internal static StartBackupJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartBackupJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}