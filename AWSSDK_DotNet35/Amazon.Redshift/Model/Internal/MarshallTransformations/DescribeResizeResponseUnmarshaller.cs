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
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeResize operation
    /// </summary>  
    public class DescribeResizeResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            DescribeResizeResponse response = new DescribeResizeResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("DescribeResizeResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, DescribeResizeResponse response)
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
                        var unmarshaller = DoubleUnmarshaller.Instance;
                        response.AvgResizeRateInMegaBytesPerSecond = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ElapsedTimeInSeconds", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        response.ElapsedTimeInSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EstimatedTimeToCompletionInSeconds", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        response.EstimatedTimeToCompletionInSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ImportTablesCompleted/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        response.ImportTablesCompleted.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ImportTablesInProgress/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        response.ImportTablesInProgress.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ImportTablesNotStarted/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        response.ImportTablesNotStarted.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ProgressInMegaBytes", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        response.ProgressInMegaBytes = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("TargetNodeType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.TargetNodeType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetNumberOfNodes", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.TargetNumberOfNodes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TotalResizeDataInMegaBytes", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        response.TotalResizeDataInMegaBytes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
           }

            return;
        }


        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("ClusterNotFound"))
            {
                return new ClusterNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResizeNotFound"))
            {
                return new ResizeNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonRedshiftException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeResizeResponseUnmarshaller _instance = new DescribeResizeResponseUnmarshaller();        

        internal static DescribeResizeResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static DescribeResizeResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}