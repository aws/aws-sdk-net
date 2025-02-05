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
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UpdateSlot operation
    /// </summary>  
    public class UpdateSlotResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            UpdateSlotResponse response = new UpdateSlotResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("botId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BotId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("botVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BotVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("creationDateTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.CreationDateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("intentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IntentId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastUpdatedDateTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.LastUpdatedDateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LocaleId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("multipleValuesSetting", targetDepth))
                {
                    var unmarshaller = MultipleValuesSettingUnmarshaller.Instance;
                    response.MultipleValuesSetting = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("obfuscationSetting", targetDepth))
                {
                    var unmarshaller = ObfuscationSettingUnmarshaller.Instance;
                    response.ObfuscationSetting = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("slotId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SlotId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("slotName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SlotName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("slotTypeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SlotTypeId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("subSlotSetting", targetDepth))
                {
                    var unmarshaller = SubSlotSettingUnmarshaller.Instance;
                    response.SubSlotSetting = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("valueElicitationSetting", targetDepth))
                {
                    var unmarshaller = SlotValueElicitationSettingUnmarshaller.Instance;
                    response.ValueElicitationSetting = unmarshaller.Unmarshall(context, ref reader);
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
            return new AmazonLexModelsV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static UpdateSlotResponseUnmarshaller _instance = new UpdateSlotResponseUnmarshaller();        

        internal static UpdateSlotResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSlotResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}