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
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeLoggingStatus operation
    /// </summary>  
    public class DescribeLoggingStatusResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            DescribeLoggingStatusResponse response = new DescribeLoggingStatusResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("DescribeLoggingStatusResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, DescribeLoggingStatusResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("BucketName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.BucketName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LastFailureMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.LastFailureMessage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LastFailureTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        response.LastFailureTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LastSuccessfulDeliveryTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        response.LastSuccessfulDeliveryTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LoggingEnabled", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        response.LoggingEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3KeyPrefix", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.S3KeyPrefix = unmarshaller.Unmarshall(context);
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
            return new AmazonRedshiftException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static DescribeLoggingStatusResponseUnmarshaller _instance = new DescribeLoggingStatusResponseUnmarshaller();        

        internal static DescribeLoggingStatusResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static DescribeLoggingStatusResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}