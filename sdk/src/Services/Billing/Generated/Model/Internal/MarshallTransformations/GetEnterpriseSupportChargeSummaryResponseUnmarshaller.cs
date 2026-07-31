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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Billing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Billing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetEnterpriseSupportChargeSummary operation
    /// </summary>  
    public class GetEnterpriseSupportChargeSummaryResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetEnterpriseSupportChargeSummaryResponse response = new GetEnterpriseSupportChargeSummaryResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("billDate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.BillDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("billingMonth", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BillingMonth = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("billingPeriodEndDate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.BillingPeriodEndDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("billingPeriodStartDate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.BillingPeriodStartDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isEstimated", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.IsEstimated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("payerAccountId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PayerAccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("supportCharge", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SupportCharge = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("supportChargePercentage", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SupportChargePercentage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("supportDiscount", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SupportDiscount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("supportEffectivePricingPlan", targetDepth, ref reader))
                {
                    var unmarshaller = PricingPlanUnmarshaller.Instance;
                    response.SupportEffectivePricingPlan = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("totalSupportCharge", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TotalSupportCharge = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("totalSupportEligibleReservedInstanceSpend", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TotalSupportEligibleReservedInstanceSpend = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("totalSupportEligibleSavingsPlanSpend", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TotalSupportEligibleSavingsPlanSpend = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("totalSupportEligibleSpend", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TotalSupportEligibleSpend = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("totalSupportEligibleUsageSpend", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TotalSupportEligibleUsageSpend = unmarshaller.Unmarshall(context, ref reader);
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
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonBillingException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetEnterpriseSupportChargeSummaryResponseUnmarshaller _instance = new GetEnterpriseSupportChargeSummaryResponseUnmarshaller();        

        internal static GetEnterpriseSupportChargeSummaryResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetEnterpriseSupportChargeSummaryResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}