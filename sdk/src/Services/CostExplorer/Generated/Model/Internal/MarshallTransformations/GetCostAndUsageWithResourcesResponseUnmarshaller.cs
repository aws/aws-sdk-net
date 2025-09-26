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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetCostAndUsageWithResources operation
    /// </summary>  
    public class GetCostAndUsageWithResourcesResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetCostAndUsageWithResourcesResponse response = new GetCostAndUsageWithResourcesResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DimensionValueAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DimensionValuesWithAttributes, DimensionValuesWithAttributesUnmarshaller>(DimensionValuesWithAttributesUnmarshaller.Instance);
                    response.DimensionValueAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GroupDefinitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<GroupDefinition, GroupDefinitionUnmarshaller>(GroupDefinitionUnmarshaller.Instance);
                    response.GroupDefinitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NextPageToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.NextPageToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResultsByTime", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ResultByTime, ResultByTimeUnmarshaller>(ResultByTimeUnmarshaller.Instance);
                    response.ResultsByTime = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("BillExpirationException"))
                {
                    return BillExpirationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("BillingViewHealthStatusException"))
                {
                    return BillingViewHealthStatusExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("DataUnavailableException"))
                {
                    return DataUnavailableExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidNextTokenException"))
                {
                    return InvalidNextTokenExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceededException"))
                {
                    return LimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("RequestChangedException"))
                {
                    return RequestChangedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCostExplorerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetCostAndUsageWithResourcesResponseUnmarshaller _instance = new GetCostAndUsageWithResourcesResponseUnmarshaller();        

        internal static GetCostAndUsageWithResourcesResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetCostAndUsageWithResourcesResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}