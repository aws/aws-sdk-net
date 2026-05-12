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
    /// Response Unmarshaller for GetAlarmMuteRule operation
    /// </summary>  
    public class GetAlarmMuteRuleResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            GetAlarmMuteRuleResponse response = new GetAlarmMuteRuleResponse();
            var reader = context.Reader;
            context.AddPathSegment("GetAlarmMuteRule");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "AlarmMuteRuleArn":
                        {
                            context.AddPathSegment("AlarmMuteRuleArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.AlarmMuteRuleArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Description":
                        {
                            context.AddPathSegment("Description");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.Description = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ExpireDate":
                        {
                            context.AddPathSegment("ExpireDate");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            response.ExpireDate = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LastUpdatedTimestamp":
                        {
                            context.AddPathSegment("LastUpdatedTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            response.LastUpdatedTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MuteTargets":
                        {
                            context.AddPathSegment("MuteTargets");
                            var unmarshaller = MuteTargetsUnmarshaller.Instance;
                            response.MuteTargets = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MuteType":
                        {
                            context.AddPathSegment("MuteType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.MuteType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.Name = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Rule":
                        {
                            context.AddPathSegment("Rule");
                            var unmarshaller = RuleUnmarshaller.Instance;
                            response.Rule = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StartDate":
                        {
                            context.AddPathSegment("StartDate");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            response.StartDate = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.Status = unmarshaller.Unmarshall(context);
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
                if (errorTypeName != null && errorTypeName.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCloudWatchException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetAlarmMuteRuleResponseUnmarshaller _instance = new GetAlarmMuteRuleResponseUnmarshaller();        

        internal static GetAlarmMuteRuleResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAlarmMuteRuleResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}