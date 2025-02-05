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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetProfileObjectTypeTemplate operation
    /// </summary>  
    public class GetProfileObjectTypeTemplateResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetProfileObjectTypeTemplateResponse response = new GetProfileObjectTypeTemplateResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AllowProfileCreation", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.AllowProfileCreation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Fields", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, ObjectTypeField, StringUnmarshaller, ObjectTypeFieldUnmarshaller>(StringUnmarshaller.Instance, ObjectTypeFieldUnmarshaller.Instance);
                    response.Fields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Keys", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, List<ObjectTypeKey>, StringUnmarshaller, JsonListUnmarshaller<ObjectTypeKey,ObjectTypeKeyUnmarshaller>>(StringUnmarshaller.Instance, new JsonListUnmarshaller<ObjectTypeKey, ObjectTypeKeyUnmarshaller>(ObjectTypeKeyUnmarshaller.Instance));
                    response.Keys = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceLastUpdatedTimestampFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceLastUpdatedTimestampFormat = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceObject", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceObject = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TemplateId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TemplateId = unmarshaller.Unmarshall(context, ref reader);
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
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
                {
                    return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonCustomerProfilesException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetProfileObjectTypeTemplateResponseUnmarshaller _instance = new GetProfileObjectTypeTemplateResponseUnmarshaller();        

        internal static GetProfileObjectTypeTemplateResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetProfileObjectTypeTemplateResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}