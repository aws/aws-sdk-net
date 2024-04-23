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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeResourceScan operation
    /// </summary>  
    public class DescribeResourceScanResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            DescribeResourceScanResponse response = new DescribeResourceScanResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("DescribeResourceScanResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, DescribeResourceScanResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("EndTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        response.EndTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PercentageCompleted", targetDepth))
                    {
                        var unmarshaller = DoubleUnmarshaller.Instance;
                        response.PercentageCompleted = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourceScanId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ResourceScanId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourcesRead", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.ResourcesRead = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourcesScanned", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.ResourcesScanned = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourceTypes/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.ResourceTypes == null)
                        {
                            response.ResourceTypes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ResourceTypes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("StartTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        response.StartTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StatusReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.StatusReason = unmarshaller.Unmarshall(context);
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
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceScanNotFound"))
                {
                    return ResourceScanNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCloudFormationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static DescribeResourceScanResponseUnmarshaller _instance = new DescribeResourceScanResponseUnmarshaller();        

        internal static DescribeResourceScanResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeResourceScanResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618