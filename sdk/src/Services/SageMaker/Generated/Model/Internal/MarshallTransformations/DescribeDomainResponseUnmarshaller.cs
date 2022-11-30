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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeDomain operation
    /// </summary>  
    public class DescribeDomainResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeDomainResponse response = new DescribeDomainResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AppNetworkAccessType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AppNetworkAccessType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AppSecurityGroupManagement", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AppSecurityGroupManagement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AuthMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AuthMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultSpaceSettings", targetDepth))
                {
                    var unmarshaller = DefaultSpaceSettingsUnmarshaller.Instance;
                    response.DefaultSpaceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultUserSettings", targetDepth))
                {
                    var unmarshaller = UserSettingsUnmarshaller.Instance;
                    response.DefaultUserSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DomainArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DomainId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DomainName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainSettings", targetDepth))
                {
                    var unmarshaller = DomainSettingsUnmarshaller.Instance;
                    response.DomainSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HomeEfsFileSystemId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HomeEfsFileSystemId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HomeEfsFileSystemKmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HomeEfsFileSystemKmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.KmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityGroupIdForDomainBoundary", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SecurityGroupIdForDomainBoundary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SingleSignOnManagedApplicationInstanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SingleSignOnManagedApplicationInstanceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.SubnetIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Url", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Url = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VpcId = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFound"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonSageMakerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeDomainResponseUnmarshaller _instance = new DescribeDomainResponseUnmarshaller();        

        internal static DescribeDomainResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeDomainResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}