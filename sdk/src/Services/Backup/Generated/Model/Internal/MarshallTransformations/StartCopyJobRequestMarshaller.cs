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

namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartCopyJob Request Marshaller
    /// </summary>       
    public class StartCopyJobRequestMarshaller : IMarshaller<IRequest, StartCopyJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartCopyJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartCopyJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/copy-jobs";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDestinationBackupVaultArn())
                {
                    context.Writer.WritePropertyName("DestinationBackupVaultArn");
                    context.Writer.Write(publicRequest.DestinationBackupVaultArn);
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

                if(publicRequest.IsSetLifecycle())
                {
                    context.Writer.WritePropertyName("Lifecycle");
                    context.Writer.WriteObjectStart();

                    var marshaller = LifecycleMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Lifecycle, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRecoveryPointArn())
                {
                    context.Writer.WritePropertyName("RecoveryPointArn");
                    context.Writer.Write(publicRequest.RecoveryPointArn);
                }

                if(publicRequest.IsSetSourceBackupVaultName())
                {
                    context.Writer.WritePropertyName("SourceBackupVaultName");
                    context.Writer.Write(publicRequest.SourceBackupVaultName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartCopyJobRequestMarshaller _instance = new StartCopyJobRequestMarshaller();        

        internal static StartCopyJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartCopyJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}