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

using Amazon.Kafka.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetBootstrapBrokers operation.
    /// </summary>
    public partial class GetBootstrapBrokersResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new GetBootstrapBrokersResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("bootstrapBrokerString", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapBrokerString = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bootstrapBrokerStringIpv6", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapBrokerStringIpv6 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bootstrapBrokerStringPublicSaslIam", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapBrokerStringPublicSaslIam = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bootstrapBrokerStringPublicSaslScram", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapBrokerStringPublicSaslScram = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bootstrapBrokerStringPublicTls", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapBrokerStringPublicTls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bootstrapBrokerStringSaslIam", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapBrokerStringSaslIam = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bootstrapBrokerStringSaslIamIpv6", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapBrokerStringSaslIamIpv6 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bootstrapBrokerStringSaslScram", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapBrokerStringSaslScram = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bootstrapBrokerStringSaslScramIpv6", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapBrokerStringSaslScramIpv6 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bootstrapBrokerStringTls", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapBrokerStringTls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bootstrapBrokerStringTlsIpv6", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapBrokerStringTlsIpv6 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bootstrapBrokerStringVpcConnectivitySaslIam", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapBrokerStringVpcConnectivitySaslIam = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bootstrapBrokerStringVpcConnectivitySaslScram", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapBrokerStringVpcConnectivitySaslScram = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bootstrapBrokerStringVpcConnectivityTls", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootstrapBrokerStringVpcConnectivityTls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);

            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
                    {
                        return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                    {
                        return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ForbiddenException"))
                    {
                        return ForbiddenExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerErrorException"))
                    {
                        return InternalServerErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("UnauthorizedException"))
                    {
                        return UnauthorizedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonKafkaException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetBootstrapBrokersResponseUnmarshaller _instance = new GetBootstrapBrokersResponseUnmarshaller();

        internal static GetBootstrapBrokersResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetBootstrapBrokersResponseUnmarshaller Instance => _instance;
    }
}
