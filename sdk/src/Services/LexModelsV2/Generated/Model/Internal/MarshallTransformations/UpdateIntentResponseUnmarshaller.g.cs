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

using Amazon.LexModelsV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UpdateIntent operation.
    /// </summary>
    public partial class UpdateIntentResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new UpdateIntentResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("botId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BotId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("botVersion", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BotVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("creationDateTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationDateTime = unmarshaller.Unmarshall(context, ref reader);
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
                    var unmarshaller = DialogCodeHookSettingsUnmarshaller.Instance;
                    unmarshalledObject.DialogCodeHook = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("fulfillmentCodeHook", targetDepth, ref reader))
                {
                    var unmarshaller = FulfillmentCodeHookSettingsUnmarshaller.Instance;
                    unmarshalledObject.FulfillmentCodeHook = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("initialResponseSetting", targetDepth, ref reader))
                {
                    var unmarshaller = InitialResponseSettingUnmarshaller.Instance;
                    unmarshalledObject.InitialResponseSetting = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("inputContexts", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<InputContext, InputContextUnmarshaller>(InputContextUnmarshaller.Instance);
                    unmarshalledObject.InputContexts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("intentClosingSetting", targetDepth, ref reader))
                {
                    var unmarshaller = IntentClosingSettingUnmarshaller.Instance;
                    unmarshalledObject.IntentClosingSetting = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("intentConfirmationSetting", targetDepth, ref reader))
                {
                    var unmarshaller = IntentConfirmationSettingUnmarshaller.Instance;
                    unmarshalledObject.IntentConfirmationSetting = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("intentDisplayName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IntentDisplayName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("intentId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IntentId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("intentName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IntentName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("kendraConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = KendraConfigurationUnmarshaller.Instance;
                    unmarshalledObject.KendraConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("lastUpdatedDateTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedDateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("localeId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocaleId = unmarshaller.Unmarshall(context, ref reader);
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

                if (context.TestExpression("qInConnectIntentConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = QInConnectIntentConfigurationUnmarshaller.Instance;
                    unmarshalledObject.QInConnectIntentConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("qnAIntentConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = QnAIntentConfigurationUnmarshaller.Instance;
                    unmarshalledObject.QnAIntentConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("sampleUtterances", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<SampleUtterance, SampleUtteranceUnmarshaller>(SampleUtteranceUnmarshaller.Instance);
                    unmarshalledObject.SampleUtterances = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("slotPriorities", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<SlotPriority, SlotPriorityUnmarshaller>(SlotPriorityUnmarshaller.Instance);
                    unmarshalledObject.SlotPriorities = unmarshaller.Unmarshall(context, ref reader);
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                    {
                        return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                    {
                        return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("PreconditionFailedException"))
                    {
                        return PreconditionFailedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceQuotaExceededException"))
                    {
                        return ServiceQuotaExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
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
            return new AmazonLexModelsV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static UpdateIntentResponseUnmarshaller _instance = new UpdateIntentResponseUnmarshaller();

        internal static UpdateIntentResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateIntentResponseUnmarshaller Instance => _instance;
    }
}
