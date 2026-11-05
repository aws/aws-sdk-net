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

using Amazon.CloudWatch.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeAlarms operation.
    /// </summary>
    public partial class DescribeAlarmsResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new DescribeAlarmsResponse();
            var reader = context.Reader;

            context.AddPathSegment("DescribeAlarms");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "CompositeAlarms":
                        context.AddPathSegment("CompositeAlarms");
                        unmarshalledObject.CompositeAlarms = new CborListUnmarshaller<CompositeAlarm, CompositeAlarmUnmarshaller>(CompositeAlarmUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LogAlarms":
                        context.AddPathSegment("LogAlarms");
                        unmarshalledObject.LogAlarms = new CborListUnmarshaller<LogAlarm, LogAlarmUnmarshaller>(LogAlarmUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MetricAlarms":
                        context.AddPathSegment("MetricAlarms");
                        unmarshalledObject.MetricAlarms = new CborListUnmarshaller<MetricAlarm, MetricAlarmUnmarshaller>(MetricAlarmUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NextToken":
                        context.AddPathSegment("NextToken");
                        unmarshalledObject.NextToken = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            context.PopPathSegment();

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(CborUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = CborErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new CborUnmarshallerContext(streamCopy, true, context.ResponseData))
                {
                    var errorTypeName = errorResponse.Code;
                    Amazon.Runtime.Internal.Transform.AwsQueryCompatibleErrorHandler.ApplyQueryErrorHeader(errorResponse, context.ResponseData);
                    if (errorTypeName != null && errorTypeName.Equals("InvalidNextToken"))
                    {
                        return InvalidNextTokenExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                }
            }
            return new AmazonCloudWatchException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeAlarmsResponseUnmarshaller _instance = new DescribeAlarmsResponseUnmarshaller();

        internal static DescribeAlarmsResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeAlarmsResponseUnmarshaller Instance => _instance;
    }
}
