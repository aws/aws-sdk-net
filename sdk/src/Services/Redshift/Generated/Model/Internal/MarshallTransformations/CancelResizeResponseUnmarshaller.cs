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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CancelResize operation
    /// </summary>  
    public class CancelResizeResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            CancelResizeResponse response = new CancelResizeResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("CancelResizeResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, CancelResizeResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("AvgResizeRateInMegaBytesPerSecond", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        response.AvgResizeRateInMegaBytesPerSecond = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DataTransferProgressPercent", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        response.DataTransferProgressPercent = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ElapsedTimeInSeconds", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        response.ElapsedTimeInSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EstimatedTimeToCompletionInSeconds", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        response.EstimatedTimeToCompletionInSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ImportTablesCompleted/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.ImportTablesCompleted == null)
                        {
                            response.ImportTablesCompleted = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ImportTablesCompleted.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ImportTablesInProgress/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.ImportTablesInProgress == null)
                        {
                            response.ImportTablesInProgress = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ImportTablesInProgress.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ImportTablesNotStarted/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.ImportTablesNotStarted == null)
                        {
                            response.ImportTablesNotStarted = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ImportTablesNotStarted.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Message", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Message = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ProgressInMegaBytes", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        response.ProgressInMegaBytes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResizeType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ResizeType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetClusterType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.TargetClusterType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetEncryptionType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.TargetEncryptionType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetNodeType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.TargetNodeType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetNumberOfNodes", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.TargetNumberOfNodes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TotalResizeDataInMegaBytes", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        response.TotalResizeDataInMegaBytes = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ClusterNotFound"))
                {
                    return ClusterNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidClusterState"))
                {
                    return InvalidClusterStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResizeNotFound"))
                {
                    return ResizeNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnsupportedOperation"))
                {
                    return UnsupportedOperationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonRedshiftException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static CancelResizeResponseUnmarshaller _instance = new CancelResizeResponseUnmarshaller();        

        internal static CancelResizeResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CancelResizeResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}