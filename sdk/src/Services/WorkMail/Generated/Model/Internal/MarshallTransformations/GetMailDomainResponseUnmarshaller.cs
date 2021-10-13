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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkMail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkMail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetMailDomain operation
    /// </summary>  
    public class GetMailDomainResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetMailDomainResponse response = new GetMailDomainResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DkimVerificationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DkimVerificationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsDefault", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.IsDefault = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsTestDomain", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.IsTestDomain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OwnershipVerificationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OwnershipVerificationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Records", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DnsRecord, DnsRecordUnmarshaller>(DnsRecordUnmarshaller.Instance);
                    response.Records = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterException"))
                {
                    return InvalidParameterExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("MailDomainNotFoundException"))
                {
                    return MailDomainNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("OrganizationNotFoundException"))
                {
                    return OrganizationNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("OrganizationStateException"))
                {
                    return OrganizationStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonWorkMailException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetMailDomainResponseUnmarshaller _instance = new GetMailDomainResponseUnmarshaller();        

        internal static GetMailDomainResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMailDomainResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}