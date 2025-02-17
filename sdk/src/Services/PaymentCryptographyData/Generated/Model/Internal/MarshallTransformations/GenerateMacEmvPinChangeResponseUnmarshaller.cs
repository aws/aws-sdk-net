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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PaymentCryptographyData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PaymentCryptographyData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GenerateMacEmvPinChange operation
    /// </summary>  
    public class GenerateMacEmvPinChangeResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GenerateMacEmvPinChangeResponse response = new GenerateMacEmvPinChangeResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EncryptedPinBlock", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EncryptedPinBlock = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Mac", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Mac = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NewPinPekArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.NewPinPekArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NewPinPekKeyCheckValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.NewPinPekKeyCheckValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecureMessagingConfidentialityKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SecureMessagingConfidentialityKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecureMessagingConfidentialityKeyCheckValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SecureMessagingConfidentialityKeyCheckValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecureMessagingIntegrityKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SecureMessagingIntegrityKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecureMessagingIntegrityKeyCheckValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SecureMessagingIntegrityKeyCheckValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VisaAmexDerivationOutputs", targetDepth))
                {
                    var unmarshaller = VisaAmexDerivationOutputsUnmarshaller.Instance;
                    response.VisaAmexDerivationOutputs = unmarshaller.Unmarshall(context);
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
            return new AmazonPaymentCryptographyDataException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GenerateMacEmvPinChangeResponseUnmarshaller _instance = new GenerateMacEmvPinChangeResponseUnmarshaller();        

        internal static GenerateMacEmvPinChangeResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GenerateMacEmvPinChangeResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}