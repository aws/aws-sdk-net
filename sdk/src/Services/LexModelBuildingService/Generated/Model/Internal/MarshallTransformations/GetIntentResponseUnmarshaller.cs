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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelBuildingService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetIntent operation
    /// </summary>  
    public class GetIntentResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetIntentResponse response = new GetIntentResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("checksum", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Checksum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("conclusionStatement", targetDepth))
                {
                    var unmarshaller = StatementUnmarshaller.Instance;
                    response.ConclusionStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("confirmationPrompt", targetDepth))
                {
                    var unmarshaller = PromptUnmarshaller.Instance;
                    response.ConfirmationPrompt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreatedDate = unmarshaller.Unmarshall(context);
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
                    var unmarshaller = CodeHookUnmarshaller.Instance;
                    response.DialogCodeHook = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("followUpPrompt", targetDepth))
                {
                    var unmarshaller = FollowUpPromptUnmarshaller.Instance;
                    response.FollowUpPrompt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fulfillmentActivity", targetDepth))
                {
                    var unmarshaller = FulfillmentActivityUnmarshaller.Instance;
                    response.FulfillmentActivity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputContexts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<InputContext, InputContextUnmarshaller>(InputContextUnmarshaller.Instance);
                    response.InputContexts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kendraConfiguration", targetDepth))
                {
                    var unmarshaller = KendraConfigurationUnmarshaller.Instance;
                    response.KendraConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdatedDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastUpdatedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("rejectionStatement", targetDepth))
                {
                    var unmarshaller = StatementUnmarshaller.Instance;
                    response.RejectionStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sampleUtterances", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.SampleUtterances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("slots", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Slot, SlotUnmarshaller>(SlotUnmarshaller.Instance);
                    response.Slots = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("version", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Version = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
                {
                    return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
                {
                    return InternalFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceededException"))
                {
                    return LimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
                {
                    return NotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonLexModelBuildingServiceException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetIntentResponseUnmarshaller _instance = new GetIntentResponseUnmarshaller();        

        internal static GetIntentResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetIntentResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}