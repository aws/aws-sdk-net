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
    /// CreateBackupSelection Request Marshaller
    /// </summary>       
    public class CreateBackupSelectionRequestMarshaller : IMarshaller<IRequest, CreateBackupSelectionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBackupSelectionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBackupSelectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";            
            request.HttpMethod = "PUT";

            string uriResourcePath = "/backup/plans/{backupPlanId}/selections/";
            if (!publicRequest.IsSetBackupPlanId())
                throw new AmazonBackupException("Request object does not have required field BackupPlanId set");
            uriResourcePath = uriResourcePath.Replace("{backupPlanId}", StringUtils.FromStringWithSlashEncoding(publicRequest.BackupPlanId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBackupSelection())
                {
                    context.Writer.WritePropertyName("BackupSelection");
                    context.Writer.WriteObjectStart();

                    var marshaller = BackupSelectionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BackupSelection, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCreatorRequestId())
                {
                    context.Writer.WritePropertyName("CreatorRequestId");
                    context.Writer.Write(publicRequest.CreatorRequestId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateBackupSelectionRequestMarshaller _instance = new CreateBackupSelectionRequestMarshaller();        

        internal static CreateBackupSelectionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBackupSelectionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}