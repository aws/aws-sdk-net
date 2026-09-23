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

using Amazon.LexModelBuildingService.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateIntentVersion operation.
    /// </summary>
    public partial class CreateIntentVersionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new CreateIntentVersionResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("checksum", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Checksum = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("conclusionStatement", targetDepth, ref reader))
                {
                    var unmarshaller = StatementUnmarshaller.Instance;
                    unmarshalledObject.ConclusionStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("confirmationPrompt", targetDepth, ref reader))
                {
                    var unmarshaller = PromptUnmarshaller.Instance;
                    unmarshalledObject.ConfirmationPrompt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("createdDate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("description", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("dialogCodeHook", targetDepth, ref reader))
                {
                    var unmarshaller = CodeHookUnmarshaller.Instance;
                    unmarshalledObject.DialogCodeHook = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("followUpPrompt", targetDepth, ref reader))
                {
                    var unmarshaller = FollowUpPromptUnmarshaller.Instance;
                    unmarshalledObject.FollowUpPrompt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("fulfillmentActivity", targetDepth, ref reader))
                {
                    var unmarshaller = FulfillmentActivityUnmarshaller.Instance;
                    unmarshalledObject.FulfillmentActivity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("inputContexts", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<InputContext, InputContextUnmarshaller>(InputContextUnmarshaller.Instance);
                    unmarshalledObject.InputContexts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("kendraConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = KendraConfigurationUnmarshaller.Instance;
                    unmarshalledObject.KendraConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("lastUpdatedDate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("name", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("outputContexts", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<OutputContext, OutputContextUnmarshaller>(OutputContextUnmarshaller.Instance);
                    unmarshalledObject.OutputContexts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("parentIntentSignature", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParentIntentSignature = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("rejectionStatement", targetDepth, ref reader))
                {
                    var unmarshaller = StatementUnmarshaller.Instance;
                    unmarshalledObject.RejectionStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("sampleUtterances", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SampleUtterances = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("slots", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Slot, SlotUnmarshaller>(SlotUnmarshaller.Instance);
                    unmarshalledObject.Slots = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("version", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Version = unmarshaller.Unmarshall(context, ref reader);
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
                    {
                        return InternalFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceededException"))
                    {
                        return LimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
                    {
                        return NotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("PreconditionFailedException"))
                    {
                        return PreconditionFailedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonLexModelBuildingServiceException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static CreateIntentVersionResponseUnmarshaller _instance = new CreateIntentVersionResponseUnmarshaller();

        internal static CreateIntentVersionResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateIntentVersionResponseUnmarshaller Instance => _instance;
    }
}
