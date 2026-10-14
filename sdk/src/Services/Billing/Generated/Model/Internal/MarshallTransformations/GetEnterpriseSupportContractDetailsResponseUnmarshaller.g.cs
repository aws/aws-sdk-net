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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Billing.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.Billing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetEnterpriseSupportContractDetails operation.
    /// </summary>
    public partial class GetEnterpriseSupportContractDetailsResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new GetEnterpriseSupportContractDetailsResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("additionalSupportCharge", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AdditionalCharge, AdditionalChargeUnmarshaller>(AdditionalChargeUnmarshaller.Instance);
                    unmarshalledObject.AdditionalSupportCharge = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("additionalSupportEligibleUsageSpend", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AdditionalCharge, AdditionalChargeUnmarshaller>(AdditionalChargeUnmarshaller.Instance);
                    unmarshalledObject.AdditionalSupportEligibleUsageSpend = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("chargedPayerAccountIds", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ChargeAccount, ChargeAccountUnmarshaller>(ChargeAccountUnmarshaller.Instance);
                    unmarshalledObject.ChargedPayerAccountIds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("contractPayerAccountIds", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ContractAccount, ContractAccountUnmarshaller>(ContractAccountUnmarshaller.Instance);
                    unmarshalledObject.ContractPayerAccountIds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("isContractActive", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsContractActive = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("pricingPlans", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<PricingPlan, PricingPlanUnmarshaller>(PricingPlanUnmarshaller.Instance);
                    unmarshalledObject.PricingPlans = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("supportAllocationMethod", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SupportAllocationMethod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("supportProrateStartDate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.SupportProrateStartDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("supportReservedInstanceAmortizationStartDate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.SupportReservedInstanceAmortizationStartDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("supportReservedInstanceTreatmentMethod", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SupportReservedInstanceTreatmentMethod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("supportSavingsPlansAmortizationStartDate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.SupportSavingsPlansAmortizationStartDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("supportSavingsPlansTreatmentMethod", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SupportSavingsPlansTreatmentMethod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);

            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
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
            }
            return new AmazonBillingException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetEnterpriseSupportContractDetailsResponseUnmarshaller _instance = new GetEnterpriseSupportContractDetailsResponseUnmarshaller();

        internal static GetEnterpriseSupportContractDetailsResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetEnterpriseSupportContractDetailsResponseUnmarshaller Instance => _instance;
    }
}
