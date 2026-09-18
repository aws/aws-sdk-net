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

using Amazon.MediaPackageV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetHarvestJob operation.
    /// </summary>
    public partial class GetHarvestJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new GetHarvestJobResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Arn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ChannelGroupName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelGroupName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ChannelName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("CreatedAt", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Description", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Destination", targetDepth, ref reader))
                {
                    var unmarshaller = DestinationUnmarshaller.Instance;
                    unmarshalledObject.Destination = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ETag", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ETag = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ErrorMessage", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorMessage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("HarvestJobName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HarvestJobName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("HarvestedManifests", targetDepth, ref reader))
                {
                    var unmarshaller = HarvestedManifestsUnmarshaller.Instance;
                    unmarshalledObject.HarvestedManifests = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ModifiedAt", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.ModifiedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("OriginEndpointName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OriginEndpointName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ScheduleConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = HarvesterScheduleConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ScheduleConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Status", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Tags", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
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
            return new AmazonMediaPackageV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetHarvestJobResponseUnmarshaller _instance = new GetHarvestJobResponseUnmarshaller();

        internal static GetHarvestJobResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetHarvestJobResponseUnmarshaller Instance => _instance;
    }
}
