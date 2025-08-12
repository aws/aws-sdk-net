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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetLogAnomalyDetector operation
    /// </summary>  
    public class GetLogAnomalyDetectorResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            GetLogAnomalyDetectorResponse response = new GetLogAnomalyDetectorResponse();
            var reader = context.Reader;
            context.AddPathSegment("GetLogAnomalyDetector");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "anomalyDetectorStatus":
                        {
                            context.AddPathSegment("AnomalyDetectorStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.AnomalyDetectorStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "anomalyVisibilityTime":
                        {
                            context.AddPathSegment("AnomalyVisibilityTime");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            response.AnomalyVisibilityTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "creationTimeStamp":
                        {
                            context.AddPathSegment("CreationTimeStamp");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            response.CreationTimeStamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "detectorName":
                        {
                            context.AddPathSegment("DetectorName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.DetectorName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "evaluationFrequency":
                        {
                            context.AddPathSegment("EvaluationFrequency");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.EvaluationFrequency = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "filterPattern":
                        {
                            context.AddPathSegment("FilterPattern");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.FilterPattern = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "kmsKeyId":
                        {
                            context.AddPathSegment("KmsKeyId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.KmsKeyId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastModifiedTimeStamp":
                        {
                            context.AddPathSegment("LastModifiedTimeStamp");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            response.LastModifiedTimeStamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "logGroupArnList":
                        {
                            context.AddPathSegment("LogGroupArnList");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            response.LogGroupArnList = unmarshaller.Unmarshall(context);
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
            using (var contextCopy = new CborUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterException"))
                {
                    return InvalidParameterExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("OperationAbortedException"))
                {
                    return OperationAbortedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException"))
                {
                    return ServiceUnavailableExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCloudWatchLogsException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetLogAnomalyDetectorResponseUnmarshaller _instance = new GetLogAnomalyDetectorResponseUnmarshaller();        

        internal static GetLogAnomalyDetectorResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetLogAnomalyDetectorResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}