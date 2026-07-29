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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MailManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetTrafficPolicy operation
    /// </summary>  
    public class GetTrafficPolicyResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            GetTrafficPolicyResponse response = new GetTrafficPolicyResponse();
            var reader = context.Reader;
            context.AddPathSegment("GetTrafficPolicy");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "CreatedTimestamp":
                        {
                            context.AddPathSegment("CreatedTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            response.CreatedTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DefaultAction":
                        {
                            context.AddPathSegment("DefaultAction");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.DefaultAction = unmarshaller.Unmarshall(context);
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
                    case "MaxMessageSizeBytes":
                        {
                            context.AddPathSegment("MaxMessageSizeBytes");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            response.MaxMessageSizeBytes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PolicyStatements":
                        {
                            context.AddPathSegment("PolicyStatements");
                            var unmarshaller = new CborListUnmarshaller<PolicyStatement, PolicyStatementUnmarshaller>(PolicyStatementUnmarshaller.Instance);
                            response.PolicyStatements = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TrafficPolicyArn":
                        {
                            context.AddPathSegment("TrafficPolicyArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.TrafficPolicyArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TrafficPolicyId":
                        {
                            context.AddPathSegment("TrafficPolicyId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.TrafficPolicyId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TrafficPolicyName":
                        {
                            context.AddPathSegment("TrafficPolicyName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.TrafficPolicyName = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonMailManagerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetTrafficPolicyResponseUnmarshaller _instance = new GetTrafficPolicyResponseUnmarshaller();        

        internal static GetTrafficPolicyResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTrafficPolicyResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}