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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeLocationHdfs operation
    /// </summary>  
    public class DescribeLocationHdfsResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeLocationHdfsResponse response = new DescribeLocationHdfsResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AgentArns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.AgentArns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AuthenticationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AuthenticationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BlockSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.BlockSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KerberosPrincipal", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.KerberosPrincipal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KmsKeyProviderUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.KmsKeyProviderUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LocationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocationUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LocationUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NameNodes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<HdfsNameNode, HdfsNameNodeUnmarshaller>(HdfsNameNodeUnmarshaller.Instance);
                    response.NameNodes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QopConfiguration", targetDepth))
                {
                    var unmarshaller = QopConfigurationUnmarshaller.Instance;
                    response.QopConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationFactor", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.ReplicationFactor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SimpleUser", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SimpleUser = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalException"))
                {
                    return InternalExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
                {
                    return InvalidRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonDataSyncException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeLocationHdfsResponseUnmarshaller _instance = new DescribeLocationHdfsResponseUnmarshaller();        

        internal static DescribeLocationHdfsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeLocationHdfsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618