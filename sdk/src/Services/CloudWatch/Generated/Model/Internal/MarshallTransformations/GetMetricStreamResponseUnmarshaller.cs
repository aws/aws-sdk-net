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
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetMetricStream operation
    /// </summary>  
    public class GetMetricStreamResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetMetricStreamResponse response = new GetMetricStreamResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("GetMetricStreamResult", 2))
                    {
                        UnmarshallResult(context, response);                        
                        continue;
                    }
                    
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.Instance.Unmarshall(context);
                    }
                }
            }

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, GetMetricStreamResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("Arn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Arn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreationDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.CreationDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ExcludeFilters/member", targetDepth))
                    {
                        var unmarshaller = MetricStreamFilterUnmarshaller.Instance;
                        if (response.ExcludeFilters == null)
                        {
                            response.ExcludeFilters = new List<MetricStreamFilter>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ExcludeFilters.Add(item);
                        continue;
                    }
                    if (context.TestExpression("FirehoseArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.FirehoseArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IncludeFilters/member", targetDepth))
                    {
                        var unmarshaller = MetricStreamFilterUnmarshaller.Instance;
                        if (response.IncludeFilters == null)
                        {
                            response.IncludeFilters = new List<MetricStreamFilter>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.IncludeFilters.Add(item);
                        continue;
                    }
                    if (context.TestExpression("IncludeLinkedAccountsMetrics", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.IncludeLinkedAccountsMetrics = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LastUpdateDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.LastUpdateDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Name = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OutputFormat", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.OutputFormat = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RoleArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.RoleArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("State", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StatisticsConfigurations/member", targetDepth))
                    {
                        var unmarshaller = MetricStreamStatisticsConfigurationUnmarshaller.Instance;
                        if (response.StatisticsConfigurations == null)
                        {
                            response.StatisticsConfigurations = new List<MetricStreamStatisticsConfiguration>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.StatisticsConfigurations.Add(item);
                        continue;
                    }
                } 
           }

            return;
        }


        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServiceError"))
                {
                    return InternalServiceExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterCombination"))
                {
                    return InvalidParameterCombinationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValue"))
                {
                    return InvalidParameterValueExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("MissingParameter"))
                {
                    return MissingRequiredParameterExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCloudWatchException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static GetMetricStreamResponseUnmarshaller _instance = new GetMetricStreamResponseUnmarshaller();        

        internal static GetMetricStreamResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMetricStreamResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}