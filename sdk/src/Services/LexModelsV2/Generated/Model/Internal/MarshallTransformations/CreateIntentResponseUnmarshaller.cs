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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateIntent operation
    /// </summary>  
    public class CreateIntentResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            CreateIntentResponse response = new CreateIntentResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("botId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BotId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("botVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BotVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("creationDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dialogCodeHook", targetDepth))
                {
                    var unmarshaller = DialogCodeHookSettingsUnmarshaller.Instance;
                    response.DialogCodeHook = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fulfillmentCodeHook", targetDepth))
                {
                    var unmarshaller = FulfillmentCodeHookSettingsUnmarshaller.Instance;
                    response.FulfillmentCodeHook = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("initialResponseSetting", targetDepth))
                {
                    var unmarshaller = InitialResponseSettingUnmarshaller.Instance;
                    response.InitialResponseSetting = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputContexts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<InputContext, InputContextUnmarshaller>(InputContextUnmarshaller.Instance);
                    response.InputContexts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("intentClosingSetting", targetDepth))
                {
                    var unmarshaller = IntentClosingSettingUnmarshaller.Instance;
                    response.IntentClosingSetting = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("intentConfirmationSetting", targetDepth))
                {
                    var unmarshaller = IntentConfirmationSettingUnmarshaller.Instance;
                    response.IntentConfirmationSetting = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("intentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IntentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("intentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IntentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kendraConfiguration", targetDepth))
                {
                    var unmarshaller = KendraConfigurationUnmarshaller.Instance;
                    response.KendraConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("localeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LocaleId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputContexts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OutputContext, OutputContextUnmarshaller>(OutputContextUnmarshaller.Instance);
                    response.OutputContexts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parentIntentSignature", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ParentIntentSignature = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("qnAIntentConfiguration", targetDepth))
                {
                    var unmarshaller = QnAIntentConfigurationUnmarshaller.Instance;
                    response.QnAIntentConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sampleUtterances", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SampleUtterance, SampleUtteranceUnmarshaller>(SampleUtteranceUnmarshaller.Instance);
                    response.SampleUtterances = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("PreconditionFailedException"))
                {
                    return PreconditionFailedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceQuotaExceededException"))
                {
                    return ServiceQuotaExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonLexModelsV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static CreateIntentResponseUnmarshaller _instance = new CreateIntentResponseUnmarshaller();        

        internal static CreateIntentResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIntentResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618