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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComprehendMedical.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ComprehendMedical.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DetectEntitiesV2 operation
    /// </summary>  
    public class DetectEntitiesV2ResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DetectEntitiesV2Response response = new DetectEntitiesV2Response();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Entities", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Entity, EntityUnmarshaller>(EntityUnmarshaller.Instance);
                    response.Entities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PaginationToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PaginationToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UnmappedAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<UnmappedAttribute, UnmappedAttributeUnmarshaller>(UnmappedAttributeUnmarshaller.Instance);
                    response.UnmappedAttributes = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidEncodingException"))
                {
                    return InvalidEncodingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
                {
                    return InvalidRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException"))
                {
                    return ServiceUnavailableExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TextSizeLimitExceededException"))
                {
                    return TextSizeLimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                {
                    return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonComprehendMedicalException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DetectEntitiesV2ResponseUnmarshaller _instance = new DetectEntitiesV2ResponseUnmarshaller();        

        internal static DetectEntitiesV2ResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DetectEntitiesV2ResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}