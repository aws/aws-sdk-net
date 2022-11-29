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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetBucketStatistics operation
    /// </summary>  
    public class GetBucketStatisticsResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetBucketStatisticsResponse response = new GetBucketStatisticsResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("bucketCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.BucketCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bucketCountByEffectivePermission", targetDepth))
                {
                    var unmarshaller = BucketCountByEffectivePermissionUnmarshaller.Instance;
                    response.BucketCountByEffectivePermission = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bucketCountByEncryptionType", targetDepth))
                {
                    var unmarshaller = BucketCountByEncryptionTypeUnmarshaller.Instance;
                    response.BucketCountByEncryptionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bucketCountByObjectEncryptionRequirement", targetDepth))
                {
                    var unmarshaller = BucketCountPolicyAllowsUnencryptedObjectUploadsUnmarshaller.Instance;
                    response.BucketCountByObjectEncryptionRequirement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bucketCountBySharedAccessType", targetDepth))
                {
                    var unmarshaller = BucketCountBySharedAccessTypeUnmarshaller.Instance;
                    response.BucketCountBySharedAccessType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bucketStatisticsBySensitivity", targetDepth))
                {
                    var unmarshaller = BucketStatisticsBySensitivityUnmarshaller.Instance;
                    response.BucketStatisticsBySensitivity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("classifiableObjectCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.ClassifiableObjectCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("classifiableSizeInBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.ClassifiableSizeInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdated", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastUpdated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("objectCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.ObjectCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sizeInBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.SizeInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sizeInBytesCompressed", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.SizeInBytesCompressed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("unclassifiableObjectCount", targetDepth))
                {
                    var unmarshaller = ObjectLevelStatisticsUnmarshaller.Instance;
                    response.UnclassifiableObjectCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("unclassifiableObjectSizeInBytes", targetDepth))
                {
                    var unmarshaller = ObjectLevelStatisticsUnmarshaller.Instance;
                    response.UnclassifiableObjectSizeInBytes = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceQuotaExceededException"))
                {
                    return ServiceQuotaExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonMacie2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetBucketStatisticsResponseUnmarshaller _instance = new GetBucketStatisticsResponseUnmarshaller();        

        internal static GetBucketStatisticsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetBucketStatisticsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}