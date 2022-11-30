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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetAccessPoint operation
    /// </summary>  
    public class GetAccessPointResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetAccessPointResponse response = new GetAccessPointResponse();
            UnmarshallResult(context,response);
            
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, GetAccessPointResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
                   targetDepth += 1;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AccessPointArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.AccessPointArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Alias", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Alias = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Bucket", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Bucket = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BucketAccountId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.BucketAccountId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreationDate", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        response.CreationDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Endpoints", targetDepth))
                    {
                        var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                        response.Endpoints = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Name = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NetworkOrigin", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.NetworkOrigin = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PublicAccessBlockConfiguration", targetDepth))
                    {
                        var unmarshaller = PublicAccessBlockConfigurationUnmarshaller.Instance;
                        response.PublicAccessBlockConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VpcConfiguration", targetDepth))
                    {
                        var unmarshaller = VpcConfigurationUnmarshaller.Instance;
                        response.VpcConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
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
            }
            return new AmazonS3ControlException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static GetAccessPointResponseUnmarshaller _instance = new GetAccessPointResponseUnmarshaller();        

        internal static GetAccessPointResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAccessPointResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}