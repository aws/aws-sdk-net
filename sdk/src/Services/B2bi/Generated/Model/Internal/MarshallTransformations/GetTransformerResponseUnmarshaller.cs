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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.B2bi.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.B2bi.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetTransformer operation
    /// </summary>  
    public class GetTransformerResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetTransformerResponse response = new GetTransformerResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ediType", targetDepth))
                {
                    var unmarshaller = EdiTypeUnmarshaller.Instance;
                    response.EdiType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FileFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputConversion", targetDepth))
                {
                    var unmarshaller = InputConversionUnmarshaller.Instance;
                    response.InputConversion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mapping", targetDepth))
                {
                    var unmarshaller = MappingUnmarshaller.Instance;
                    response.Mapping = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mappingTemplate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MappingTemplate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("modifiedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.ModifiedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputConversion", targetDepth))
                {
                    var unmarshaller = OutputConversionUnmarshaller.Instance;
                    response.OutputConversion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sampleDocument", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SampleDocument = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sampleDocuments", targetDepth))
                {
                    var unmarshaller = SampleDocumentsUnmarshaller.Instance;
                    response.SampleDocuments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transformerArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TransformerArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transformerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TransformerId = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
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
            return new AmazonB2biException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetTransformerResponseUnmarshaller _instance = new GetTransformerResponseUnmarshaller();        

        internal static GetTransformerResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTransformerResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}