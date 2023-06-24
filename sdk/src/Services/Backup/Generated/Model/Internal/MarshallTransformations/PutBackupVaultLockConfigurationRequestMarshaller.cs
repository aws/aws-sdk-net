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
    /// PutBackupVaultLockConfiguration Request Marshaller
    /// </summary>       
    public class PutBackupVaultLockConfigurationRequestMarshaller : IMarshaller<IRequest, PutBackupVaultLockConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBackupVaultLockConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBackupVaultLockConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBackupVaultName())
                throw new AmazonBackupException("Request object does not have required field BackupVaultName set");
            request.AddPathResource("{backupVaultName}", StringUtils.FromString(publicRequest.BackupVaultName));
            request.ResourcePath = "/backup-vaults/{backupVaultName}/vault-lock";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetChangeableForDays())
                {
                    context.Writer.WritePropertyName("ChangeableForDays");
                    context.Writer.Write(publicRequest.ChangeableForDays);
                }

                if(publicRequest.IsSetMaxRetentionDays())
                {
                    context.Writer.WritePropertyName("MaxRetentionDays");
                    context.Writer.Write(publicRequest.MaxRetentionDays);
                }

                if(publicRequest.IsSetMinRetentionDays())
                {
                    context.Writer.WritePropertyName("MinRetentionDays");
                    context.Writer.Write(publicRequest.MinRetentionDays);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutBackupVaultLockConfigurationRequestMarshaller _instance = new PutBackupVaultLockConfigurationRequestMarshaller();        

        internal static PutBackupVaultLockConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBackupVaultLockConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}