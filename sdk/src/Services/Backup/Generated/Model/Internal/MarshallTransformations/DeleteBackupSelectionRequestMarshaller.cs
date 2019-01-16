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
    /// DeleteBackupSelection Request Marshaller
    /// </summary>       
    public class DeleteBackupSelectionRequestMarshaller : IMarshaller<IRequest, DeleteBackupSelectionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteBackupSelectionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteBackupSelectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";            
            request.HttpMethod = "DELETE";

            string uriResourcePath = "/backup/plans/{backupPlanId}/selections/{selectionId}";
            if (!publicRequest.IsSetBackupPlanId())
                throw new AmazonBackupException("Request object does not have required field BackupPlanId set");
            uriResourcePath = uriResourcePath.Replace("{backupPlanId}", StringUtils.FromStringWithSlashEncoding(publicRequest.BackupPlanId));
            if (!publicRequest.IsSetSelectionId())
                throw new AmazonBackupException("Request object does not have required field SelectionId set");
            uriResourcePath = uriResourcePath.Replace("{selectionId}", StringUtils.FromStringWithSlashEncoding(publicRequest.SelectionId));
            request.ResourcePath = uriResourcePath;

            return request;
        }
        private static DeleteBackupSelectionRequestMarshaller _instance = new DeleteBackupSelectionRequestMarshaller();        

        internal static DeleteBackupSelectionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteBackupSelectionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}