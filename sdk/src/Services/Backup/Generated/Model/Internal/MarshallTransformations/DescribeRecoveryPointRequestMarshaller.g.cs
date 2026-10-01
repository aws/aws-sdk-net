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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.Backup.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeRecoveryPoint Request Marshaller
    /// </summary>
    public partial class DescribeRecoveryPointRequestMarshaller : IMarshaller<IRequest, DescribeRecoveryPointRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeRecoveryPointRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeRecoveryPointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetBackupVaultAccountId())
            {
                request.Parameters.Add("backupVaultAccountId", StringUtils.FromString(publicRequest.BackupVaultAccountId));
            }

            if (!publicRequest.IsSetBackupVaultName())
            {
                throw new AmazonBackupException("Request object does not have required field BackupVaultName set");
            }
            request.AddPathResource("{BackupVaultName}", StringUtils.FromString(publicRequest.BackupVaultName));

            if (!publicRequest.IsSetRecoveryPointArn())
            {
                throw new AmazonBackupException("Request object does not have required field RecoveryPointArn set");
            }
            request.AddPathResource("{RecoveryPointArn}", StringUtils.FromString(publicRequest.RecoveryPointArn));

            request.ResourcePath = "/backup-vaults/{BackupVaultName}/recovery-points/{RecoveryPointArn}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DescribeRecoveryPointRequestMarshaller _instance = new();

        internal static DescribeRecoveryPointRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeRecoveryPointRequestMarshaller Instance => _instance;
    }
}
