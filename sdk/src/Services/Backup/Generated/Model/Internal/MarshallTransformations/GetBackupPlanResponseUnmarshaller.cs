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
    /// Response Unmarshaller for GetBackupPlan operation
    /// </summary>  
    public class GetBackupPlanResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetBackupPlanResponse response = new GetBackupPlanResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdvancedBackupSettings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AdvancedBackupSetting, AdvancedBackupSettingUnmarshaller>(AdvancedBackupSettingUnmarshaller.Instance);
                    response.AdvancedBackupSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackupPlan", targetDepth))
                {
                    var unmarshaller = BackupPlanUnmarshaller.Instance;
                    response.BackupPlan = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackupPlanArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BackupPlanArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackupPlanId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BackupPlanId = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("DeletionDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.DeletionDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastExecutionDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastExecutionDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduledRunsPreview", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ScheduledPlanExecutionMember, ScheduledPlanExecutionMemberUnmarshaller>(ScheduledPlanExecutionMemberUnmarshaller.Instance);
                    response.ScheduledRunsPreview = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VersionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VersionId = unmarshaller.Unmarshall(context);
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

        private static GetBackupPlanResponseUnmarshaller _instance = new GetBackupPlanResponseUnmarshaller();        

        internal static GetBackupPlanResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetBackupPlanResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}