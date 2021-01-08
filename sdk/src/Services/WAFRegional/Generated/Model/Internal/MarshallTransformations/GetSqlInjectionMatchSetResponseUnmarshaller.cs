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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFRegional.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WAFRegional.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetSqlInjectionMatchSet operation
    /// </summary>  
    public class GetSqlInjectionMatchSetResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetSqlInjectionMatchSetResponse response = new GetSqlInjectionMatchSetResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("SqlInjectionMatchSet", targetDepth))
                {
                    var unmarshaller = SqlInjectionMatchSetUnmarshaller.Instance;
                    response.SqlInjectionMatchSet = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("WAFInternalErrorException"))
                {
                    return WAFInternalErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("WAFInvalidAccountException"))
                {
                    return WAFInvalidAccountExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("WAFNonexistentItemException"))
                {
                    return WAFNonexistentItemExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonWAFRegionalException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetSqlInjectionMatchSetResponseUnmarshaller _instance = new GetSqlInjectionMatchSetResponseUnmarshaller();        

        internal static GetSqlInjectionMatchSetResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSqlInjectionMatchSetResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}