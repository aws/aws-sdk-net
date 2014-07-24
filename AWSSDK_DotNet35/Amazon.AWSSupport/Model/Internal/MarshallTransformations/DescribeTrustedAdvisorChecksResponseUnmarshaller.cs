/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSSupport.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeTrustedAdvisorChecks operation
    /// </summary>  
    public class DescribeTrustedAdvisorChecksResponseUnmarshaller : JsonResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeTrustedAdvisorChecksResponse response = new DescribeTrustedAdvisorChecksResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("checks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TrustedAdvisorCheckDescription, TrustedAdvisorCheckDescriptionUnmarshaller>(TrustedAdvisorCheckDescriptionUnmarshaller.Instance);
                    response.Checks = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
 

            return response;
        }

        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerError"))
            {
                return new InternalServerErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonAWSSupportException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeTrustedAdvisorChecksResponseUnmarshaller _instance = new DescribeTrustedAdvisorChecksResponseUnmarshaller();        

        internal static DescribeTrustedAdvisorChecksResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static DescribeTrustedAdvisorChecksResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}