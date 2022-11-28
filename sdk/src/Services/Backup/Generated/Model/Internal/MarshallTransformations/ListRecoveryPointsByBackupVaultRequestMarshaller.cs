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
    /// ListRecoveryPointsByBackupVault Request Marshaller
    /// </summary>       
    public class ListRecoveryPointsByBackupVaultRequestMarshaller : IMarshaller<IRequest, ListRecoveryPointsByBackupVaultRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListRecoveryPointsByBackupVaultRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListRecoveryPointsByBackupVaultRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetBackupVaultName())
                throw new AmazonBackupException("Request object does not have required field BackupVaultName set");
            request.AddPathResource("{backupVaultName}", StringUtils.FromString(publicRequest.BackupVaultName));
            
            if (publicRequest.IsSetByBackupPlanId())
                request.Parameters.Add("backupPlanId", StringUtils.FromString(publicRequest.ByBackupPlanId));
            
            if (publicRequest.IsSetByCreatedAfter())
                request.Parameters.Add("createdAfter", StringUtils.FromDateTimeToISO8601(publicRequest.ByCreatedAfter));
            
            if (publicRequest.IsSetByCreatedBefore())
                request.Parameters.Add("createdBefore", StringUtils.FromDateTimeToISO8601(publicRequest.ByCreatedBefore));
            
            if (publicRequest.IsSetByParentRecoveryPointArn())
                request.Parameters.Add("parentRecoveryPointArn", StringUtils.FromString(publicRequest.ByParentRecoveryPointArn));
            
            if (publicRequest.IsSetByResourceArn())
                request.Parameters.Add("resourceArn", StringUtils.FromString(publicRequest.ByResourceArn));
            
            if (publicRequest.IsSetByResourceType())
                request.Parameters.Add("resourceType", StringUtils.FromString(publicRequest.ByResourceType));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/backup-vaults/{backupVaultName}/recovery-points/";
            request.UseQueryString = true;

            return request;
        }
        private static ListRecoveryPointsByBackupVaultRequestMarshaller _instance = new ListRecoveryPointsByBackupVaultRequestMarshaller();        

        internal static ListRecoveryPointsByBackupVaultRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListRecoveryPointsByBackupVaultRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}