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
using System.Net;
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
    /// Response Unmarshaller for DescribeBackupVault operation
    /// </summary>  
    public class DescribeBackupVaultResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeBackupVaultResponse response = new DescribeBackupVaultResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BackupVaultArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BackupVaultArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackupVaultName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BackupVaultName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatorRequestId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CreatorRequestId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncryptionKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EncryptionKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncryptionKeyType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EncryptionKeyType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestMpaApprovalTeamUpdate", targetDepth))
                {
                    var unmarshaller = LatestMpaApprovalTeamUpdateUnmarshaller.Instance;
                    response.LatestMpaApprovalTeamUpdate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LockDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LockDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Locked", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.Locked = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxRetentionDays", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.MaxRetentionDays = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinRetentionDays", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.MinRetentionDays = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MpaApprovalTeamArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MpaApprovalTeamArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MpaSessionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MpaSessionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfRecoveryPoints", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.NumberOfRecoveryPoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceBackupVaultArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceBackupVaultArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VaultState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VaultState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VaultType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VaultType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
                {
                    return InvalidParameterValueExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("MissingParameterValueException"))
                {
                    return MissingParameterValueExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException"))
                {
                    return ServiceUnavailableExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonBackupException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeBackupVaultResponseUnmarshaller _instance = new DescribeBackupVaultResponseUnmarshaller();        

        internal static DescribeBackupVaultResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeBackupVaultResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}