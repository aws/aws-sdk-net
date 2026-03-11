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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetInsightRuleReport operation
    /// </summary>  
    public class GetInsightRuleReportResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            GetInsightRuleReportResponse response = new GetInsightRuleReportResponse();
            var reader = context.Reader;
            context.AddPathSegment("GetInsightRuleReport");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "AggregateValue":
                        {
                            context.AddPathSegment("AggregateValue");
                            var unmarshaller = CborNullableDoubleUnmarshaller.Instance;
                            response.AggregateValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AggregationStatistic":
                        {
                            context.AddPathSegment("AggregationStatistic");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.AggregationStatistic = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ApproximateUniqueCount":
                        {
                            context.AddPathSegment("ApproximateUniqueCount");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            response.ApproximateUniqueCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Contributors":
                        {
                            context.AddPathSegment("Contributors");
                            var unmarshaller = new CborListUnmarshaller<InsightRuleContributor, InsightRuleContributorUnmarshaller>(InsightRuleContributorUnmarshaller.Instance);
                            response.Contributors = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "KeyLabels":
                        {
                            context.AddPathSegment("KeyLabels");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            response.KeyLabels = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MetricDatapoints":
                        {
                            context.AddPathSegment("MetricDatapoints");
                            var unmarshaller = new CborListUnmarshaller<InsightRuleMetricDatapoint, InsightRuleMetricDatapointUnmarshaller>(InsightRuleMetricDatapointUnmarshaller.Instance);
                            response.MetricDatapoints = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            context.PopPathSegment();

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(CborUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = CborErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new CborUnmarshallerContext(streamCopy, true, context.ResponseData))
            {
                var errorTypeName = errorResponse.Code;
                var queryHeaderKey = Amazon.Util.HeaderKeys.XAmzQueryError;
                if (context.ResponseData.IsHeaderPresent(queryHeaderKey))
                {
                    var queryError = context.ResponseData.GetHeaderValue(queryHeaderKey);
                    if (!string.IsNullOrEmpty(queryError) && queryError.Contains(";"))
                    {
                        var queryErrorParts = queryError.Split(';');
                        if (queryErrorParts.Length == 2)
                        {
                            errorResponse.Code = queryErrorParts[0];
                            var errorTypeString = queryErrorParts[1];
                            if (Enum.IsDefined(typeof(ErrorType), errorTypeString))
                            {
                                errorResponse.Type = (ErrorType) Enum.Parse(typeof(ErrorType), errorTypeString);
                            }
                        }
                    }
                }
                if (errorTypeName != null && errorTypeName.Equals("InvalidParameterValueException"))
                {
                    return InvalidParameterValueExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("MissingRequiredParameterException"))
                {
                    return MissingRequiredParameterExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCloudWatchException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetInsightRuleReportResponseUnmarshaller _instance = new GetInsightRuleReportResponseUnmarshaller();        

        internal static GetInsightRuleReportResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetInsightRuleReportResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}