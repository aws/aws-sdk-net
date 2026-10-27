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

using Amazon.MailManager.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetTrafficPolicy operation.
    /// </summary>
    public partial class GetTrafficPolicyResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new GetTrafficPolicyResponse();
            var reader = context.Reader;

            context.AddPathSegment("GetTrafficPolicy");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "CreatedTimestamp":
                        context.AddPathSegment("CreatedTimestamp");
                        unmarshalledObject.CreatedTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DefaultAction":
                        context.AddPathSegment("DefaultAction");
                        unmarshalledObject.DefaultAction = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastUpdatedTimestamp":
                        context.AddPathSegment("LastUpdatedTimestamp");
                        unmarshalledObject.LastUpdatedTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MaxMessageSizeBytes":
                        context.AddPathSegment("MaxMessageSizeBytes");
                        unmarshalledObject.MaxMessageSizeBytes = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PolicyStatements":
                        context.AddPathSegment("PolicyStatements");
                        unmarshalledObject.PolicyStatements = new CborListUnmarshaller<PolicyStatement, PolicyStatementUnmarshaller>(PolicyStatementUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TrafficPolicyArn":
                        context.AddPathSegment("TrafficPolicyArn");
                        unmarshalledObject.TrafficPolicyArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TrafficPolicyId":
                        context.AddPathSegment("TrafficPolicyId");
                        unmarshalledObject.TrafficPolicyId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TrafficPolicyName":
                        context.AddPathSegment("TrafficPolicyName");
                        unmarshalledObject.TrafficPolicyName = CborStringUnmarshaller.Instance.Unmarshall(context);
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                    {
                        return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                    {
                        return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                }
            }
            return new AmazonMailManagerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetTrafficPolicyResponseUnmarshaller _instance = new GetTrafficPolicyResponseUnmarshaller();

        internal static GetTrafficPolicyResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetTrafficPolicyResponseUnmarshaller Instance => _instance;
    }
}
