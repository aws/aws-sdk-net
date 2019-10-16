/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QLDBSession.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QLDBSession.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SendCommand operation
    /// </summary>  
    public class SendCommandResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            SendCommandResponse response = new SendCommandResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AbortTransaction", targetDepth))
                {
                    var unmarshaller = AbortTransactionResultUnmarshaller.Instance;
                    response.AbortTransaction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CommitTransaction", targetDepth))
                {
                    var unmarshaller = CommitTransactionResultUnmarshaller.Instance;
                    response.CommitTransaction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndSession", targetDepth))
                {
                    var unmarshaller = EndSessionResultUnmarshaller.Instance;
                    response.EndSession = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecuteStatement", targetDepth))
                {
                    var unmarshaller = ExecuteStatementResultUnmarshaller.Instance;
                    response.ExecuteStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FetchPage", targetDepth))
                {
                    var unmarshaller = FetchPageResultUnmarshaller.Instance;
                    response.FetchPage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartSession", targetDepth))
                {
                    var unmarshaller = StartSessionResultUnmarshaller.Instance;
                    response.StartSession = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTransaction", targetDepth))
                {
                    var unmarshaller = StartTransactionResultUnmarshaller.Instance;
                    response.StartTransaction = unmarshaller.Unmarshall(context);
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
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
            {
                return new BadRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidSessionException"))
            {
                return new InvalidSessionException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceededException"))
            {
                return new LimitExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("OccConflictException"))
            {
                return new OccConflictException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("RateExceededException"))
            {
                return new RateExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonQLDBSessionException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static SendCommandResponseUnmarshaller _instance = new SendCommandResponseUnmarshaller();        

        internal static SendCommandResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendCommandResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}