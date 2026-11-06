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

using Amazon.Route53.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateTrafficPolicyInstance operation.
    /// </summary>
    public partial class CreateTrafficPolicyInstanceResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            CreateTrafficPolicyInstanceResponse unmarshalledObject = new CreateTrafficPolicyInstanceResponse();
            UnmarshallResult(context, unmarshalledObject);
            if (context.ResponseData.IsHeaderPresent("Location"))
            {
                unmarshalledObject.Location = context.ResponseData.GetHeaderValue("Location");
            }

            PostUnmarshallCustomization(context, unmarshalledObject);
            return unmarshalledObject;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, CreateTrafficPolicyInstanceResponse unmarshalledObject)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 1;
            }
            if (context.IsEmptyResponse)
            {
                return;
            }
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("TrafficPolicyInstance", targetDepth))
                    {
                        var unmarshaller = TrafficPolicyInstanceUnmarshaller.Instance;
                        unmarshalledObject.TrafficPolicyInstance = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
            return;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidInput"))
                    {
                        return InvalidInputExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchHostedZone"))
                    {
                        return NoSuchHostedZoneExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchTrafficPolicy"))
                    {
                        return NoSuchTrafficPolicyExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyTrafficPolicyInstances"))
                    {
                        return TooManyTrafficPolicyInstancesExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("TrafficPolicyInstanceAlreadyExists"))
                    {
                        return TrafficPolicyInstanceAlreadyExistsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                }
            }
            return new AmazonRoute53Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, CreateTrafficPolicyInstanceResponse unmarshalledObject);
        private static CreateTrafficPolicyInstanceResponseUnmarshaller _instance = new CreateTrafficPolicyInstanceResponseUnmarshaller();

        internal static CreateTrafficPolicyInstanceResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateTrafficPolicyInstanceResponseUnmarshaller Instance => _instance;
    }
}
