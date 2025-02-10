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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CancelExportTask operation
    /// </summary>  
    public class CancelExportTaskResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            CancelExportTaskResponse response = new CancelExportTaskResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("CancelExportTaskResult", 2))
                    {
                        UnmarshallResult(context, response);                        
                        continue;
                    }
                    
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.Instance.Unmarshall(context);
                    }
                }
            }

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, CancelExportTaskResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("ExportOnly/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.ExportOnly == null)
                        {
                            response.ExportOnly = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ExportOnly.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ExportTaskIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ExportTaskIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("FailureCause", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.FailureCause = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IamRoleArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.IamRoleArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("KmsKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.KmsKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PercentProgress", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.PercentProgress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3Bucket", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.S3Bucket = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3Prefix", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.S3Prefix = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SnapshotTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.SnapshotTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SourceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.SourceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SourceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.SourceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TaskEndTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.TaskEndTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TaskStartTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.TaskStartTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TotalExtractedDataInGB", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.TotalExtractedDataInGB = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("WarningMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.WarningMessage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
           }

            return;
        }


        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("ExportTaskNotFound"))
                {
                    return ExportTaskNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidExportTaskStateFault"))
                {
                    return InvalidExportTaskStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonRDSException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static CancelExportTaskResponseUnmarshaller _instance = new CancelExportTaskResponseUnmarshaller();        

        internal static CancelExportTaskResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CancelExportTaskResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}