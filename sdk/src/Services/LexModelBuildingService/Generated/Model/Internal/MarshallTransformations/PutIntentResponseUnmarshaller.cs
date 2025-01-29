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
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PutIntent operation
    /// </summary>  
    public class PutIntentResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            PutIntentResponse response = new PutIntentResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("checksum", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Checksum = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("conclusionStatement", targetDepth))
                {
                    var unmarshaller = StatementUnmarshaller.Instance;
                    response.ConclusionStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("confirmationPrompt", targetDepth))
                {
                    var unmarshaller = PromptUnmarshaller.Instance;
                    response.ConfirmationPrompt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createdDate", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.CreatedDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createVersion", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.CreateVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dialogCodeHook", targetDepth))
                {
                    var unmarshaller = CodeHookUnmarshaller.Instance;
                    response.DialogCodeHook = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("followUpPrompt", targetDepth))
                {
                    var unmarshaller = FollowUpPromptUnmarshaller.Instance;
                    response.FollowUpPrompt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fulfillmentActivity", targetDepth))
                {
                    var unmarshaller = FulfillmentActivityUnmarshaller.Instance;
                    response.FulfillmentActivity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("inputContexts", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<InputContext, InputContextUnmarshaller>(InputContextUnmarshaller.Instance);
                    response.InputContexts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kendraConfiguration", targetDepth))
                {
                    var unmarshaller = KendraConfigurationUnmarshaller.Instance;
                    response.KendraConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastUpdatedDate", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.LastUpdatedDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("outputContexts", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<OutputContext, OutputContextUnmarshaller>(OutputContextUnmarshaller.Instance);
                    response.OutputContexts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parentIntentSignature", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ParentIntentSignature = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("rejectionStatement", targetDepth))
                {
                    var unmarshaller = StatementUnmarshaller.Instance;
                    response.RejectionStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sampleUtterances", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.SampleUtterances = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("slots", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Slot, SlotUnmarshaller>(SlotUnmarshaller.Instance);
                    response.Slots = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("version", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Version = unmarshaller.Unmarshall(context, ref reader);
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
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("PreconditionFailedException"))
                {
                    return PreconditionFailedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonLexModelBuildingServiceException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static PutIntentResponseUnmarshaller _instance = new PutIntentResponseUnmarshaller();        

        internal static PutIntentResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutIntentResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}