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

using Amazon.EventBridgeV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.EventBridgeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeSubscriber operation.
    /// </summary>
    public partial class DescribeSubscriberResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new DescribeSubscriberResponse();
            var reader = context.Reader;

            context.AddPathSegment("DescribeSubscriber");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "BatchConfiguration":
                        context.AddPathSegment("BatchConfiguration");
                        unmarshalledObject.BatchConfiguration = BatchConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreationTime":
                        context.AddPathSegment("CreationTime");
                        unmarshalledObject.CreationTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EventBusArn":
                        context.AddPathSegment("EventBusArn");
                        unmarshalledObject.EventBusArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FilterConfiguration":
                        context.AddPathSegment("FilterConfiguration");
                        unmarshalledObject.FilterConfiguration = FilterConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InvokeConfiguration":
                        context.AddPathSegment("InvokeConfiguration");
                        unmarshalledObject.InvokeConfiguration = InvokeConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastModifiedTime":
                        context.AddPathSegment("LastModifiedTime");
                        unmarshalledObject.LastModifiedTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LogConfiguration":
                        context.AddPathSegment("LogConfiguration");
                        unmarshalledObject.LogConfiguration = LogConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OnFailureConfiguration":
                        context.AddPathSegment("OnFailureConfiguration");
                        unmarshalledObject.OnFailureConfiguration = OnFailureConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PointInTimeConfiguration":
                        context.AddPathSegment("PointInTimeConfiguration");
                        unmarshalledObject.PointInTimeConfiguration = PointInTimeConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RetryPolicy":
                        context.AddPathSegment("RetryPolicy");
                        unmarshalledObject.RetryPolicy = RetryPolicyUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Revoked":
                        context.AddPathSegment("Revoked");
                        unmarshalledObject.Revoked = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StartingPosition":
                        context.AddPathSegment("StartingPosition");
                        unmarshalledObject.StartingPosition = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "State":
                        context.AddPathSegment("State");
                        unmarshalledObject.State = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SubscriberArn":
                        context.AddPathSegment("SubscriberArn");
                        unmarshalledObject.SubscriberArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Transformer":
                        context.AddPathSegment("Transformer");
                        unmarshalledObject.Transformer = TransformerUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Type":
                        context.AddPathSegment("Type");
                        unmarshalledObject.Type = CborStringUnmarshaller.Instance.Unmarshall(context);
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
                using (var contextCopy = new CborUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                    {
                        return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalException"))
                    {
                        return InternalExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidInputException"))
                    {
                        return InvalidInputExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                    {
                        return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                    {
                        return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                }
            }
            return new AmazonEventBridgeV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeSubscriberResponseUnmarshaller _instance = new DescribeSubscriberResponseUnmarshaller();

        internal static DescribeSubscriberResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeSubscriberResponseUnmarshaller Instance => _instance;
    }
}
