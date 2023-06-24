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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UpdateLaunchConfiguration operation
    /// </summary>  
    public class UpdateLaunchConfigurationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            UpdateLaunchConfigurationResponse response = new UpdateLaunchConfigurationResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("bootMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BootMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("copyPrivateIp", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.CopyPrivateIp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("copyTags", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.CopyTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2LaunchTemplateID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Ec2LaunchTemplateID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enableMapAutoTagging", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.EnableMapAutoTagging = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("launchDisposition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LaunchDisposition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("licensing", targetDepth))
                {
                    var unmarshaller = LicensingUnmarshaller.Instance;
                    response.Licensing = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mapAutoTaggingMpeID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MapAutoTaggingMpeID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("postLaunchActions", targetDepth))
                {
                    var unmarshaller = PostLaunchActionsUnmarshaller.Instance;
                    response.PostLaunchActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceServerID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceServerID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetInstanceTypeRightSizingMethod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TargetInstanceTypeRightSizingMethod = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UninitializedAccountException"))
                {
                    return UninitializedAccountExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonMgnException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static UpdateLaunchConfigurationResponseUnmarshaller _instance = new UpdateLaunchConfigurationResponseUnmarshaller();        

        internal static UpdateLaunchConfigurationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLaunchConfigurationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}