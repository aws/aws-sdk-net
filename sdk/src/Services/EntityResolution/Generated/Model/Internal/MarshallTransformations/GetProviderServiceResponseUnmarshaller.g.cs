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

using Amazon.EntityResolution.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.EntityResolution.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetProviderService operation.
    /// </summary>
    public partial class GetProviderServiceResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new GetProviderServiceResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("anonymizedOutput", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.AnonymizedOutput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("providerComponentSchema", targetDepth, ref reader))
                {
                    var unmarshaller = ProviderComponentSchemaUnmarshaller.Instance;
                    unmarshalledObject.ProviderComponentSchema = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("providerConfigurationDefinition", targetDepth, ref reader))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    unmarshalledObject.ProviderConfigurationDefinition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("providerEndpointConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = ProviderEndpointConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ProviderEndpointConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("providerEntityOutputDefinition", targetDepth, ref reader))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    unmarshalledObject.ProviderEntityOutputDefinition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("providerIdNameSpaceConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = ProviderIdNameSpaceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ProviderIdNameSpaceConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("providerIntermediateDataAccessConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = ProviderIntermediateDataAccessConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ProviderIntermediateDataAccessConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("providerJobConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    unmarshalledObject.ProviderJobConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("providerName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProviderName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("providerServiceArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProviderServiceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("providerServiceDisplayName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProviderServiceDisplayName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("providerServiceName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProviderServiceName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("providerServiceType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProviderServiceType = unmarshaller.Unmarshall(context, ref reader);
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                    {
                        return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                    {
                        return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                    {
                        return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                    {
                        return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                    {
                        return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonEntityResolutionException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetProviderServiceResponseUnmarshaller _instance = new GetProviderServiceResponseUnmarshaller();

        internal static GetProviderServiceResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetProviderServiceResponseUnmarshaller Instance => _instance;
    }
}
