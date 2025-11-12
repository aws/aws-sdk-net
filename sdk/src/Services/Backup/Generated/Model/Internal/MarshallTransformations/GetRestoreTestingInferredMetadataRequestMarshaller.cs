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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetRestoreTestingInferredMetadata Request Marshaller
    /// </summary>       
    public class GetRestoreTestingInferredMetadataRequestMarshaller : IMarshaller<IRequest, GetRestoreTestingInferredMetadataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetRestoreTestingInferredMetadataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetRestoreTestingInferredMetadataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetBackupVaultAccountId())
                request.Parameters.Add("BackupVaultAccountId", StringUtils.FromString(publicRequest.BackupVaultAccountId));
            if (string.IsNullOrEmpty(publicRequest.BackupVaultName))
                throw new AmazonBackupException("Request object does not have required field BackupVaultName set");
            
            if (publicRequest.IsSetBackupVaultName())
                request.Parameters.Add("BackupVaultName", StringUtils.FromString(publicRequest.BackupVaultName));
            if (string.IsNullOrEmpty(publicRequest.RecoveryPointArn))
                throw new AmazonBackupException("Request object does not have required field RecoveryPointArn set");
            
            if (publicRequest.IsSetRecoveryPointArn())
                request.Parameters.Add("RecoveryPointArn", StringUtils.FromString(publicRequest.RecoveryPointArn));
            request.ResourcePath = "/restore-testing/inferred-metadata";
            request.UseQueryString = true;

            return request;
        }
        private static GetRestoreTestingInferredMetadataRequestMarshaller _instance = new GetRestoreTestingInferredMetadataRequestMarshaller();        

        internal static GetRestoreTestingInferredMetadataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetRestoreTestingInferredMetadataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}