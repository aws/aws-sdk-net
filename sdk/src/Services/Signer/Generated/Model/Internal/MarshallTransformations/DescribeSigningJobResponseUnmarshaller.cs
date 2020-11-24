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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Signer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Signer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeSigningJob operation
    /// </summary>  
    public class DescribeSigningJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeSigningJobResponse response = new DescribeSigningJobResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("completedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CompletedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobInvoker", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobInvoker = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobOwner", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobOwner = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("overrides", targetDepth))
                {
                    var unmarshaller = SigningPlatformOverridesUnmarshaller.Instance;
                    response.Overrides = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("platformDisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PlatformDisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("platformId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PlatformId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("profileName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProfileName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("profileVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProfileVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requestedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RequestedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("revocationRecord", targetDepth))
                {
                    var unmarshaller = SigningJobRevocationRecordUnmarshaller.Instance;
                    response.RevocationRecord = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("signatureExpiresAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.SignatureExpiresAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("signedObject", targetDepth))
                {
                    var unmarshaller = SignedObjectUnmarshaller.Instance;
                    response.SignedObject = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("signingMaterial", targetDepth))
                {
                    var unmarshaller = SigningMaterialUnmarshaller.Instance;
                    response.SigningMaterial = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("signingParameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.SigningParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("source", targetDepth))
                {
                    var unmarshaller = SourceUnmarshaller.Instance;
                    response.Source = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StatusReason = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServiceErrorException"))
                {
                    return InternalServiceErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                {
                    return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonSignerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeSigningJobResponseUnmarshaller _instance = new DescribeSigningJobResponseUnmarshaller();        

        internal static DescribeSigningJobResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeSigningJobResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}