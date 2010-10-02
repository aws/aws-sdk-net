﻿/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime.Internal;

using System;
namespace Amazon.Runtime.Internal.Transform
{
    /// <summary>
    ///    Response Unmarshaller for all Errors
    /// </summary>
    public class ErrorResponseUnmarshaller : IUnmarshaller<ErrorResponse, UnmarshallerContext>
    {
        /// <summary>
        /// Build an ErrorResponse from XML 
        /// </summary>
        /// <param name="context">The XML parsing context. 
        /// Usually an <c>Amazon.Runtime.Internal.UnmarshallerContext</c>.</param>
        /// <returns>An <c>ErrorResponse</c> object.</returns>
        public ErrorResponse Unmarshall(UnmarshallerContext context)
        {
            ErrorResponse response = new ErrorResponse();

            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    if (context.TestExpression("Error/Type", 2))
                    {
                        try
                        {
                            response.Type = (ErrorType)Enum.Parse(typeof(ErrorType), StringUnmarshaller.GetInstance().Unmarshall(context));
                        }
                        catch (ArgumentException)
                        {
                            response.Type = ErrorType.Unknown;
                        }
                        continue;
                    }
                    if (context.TestExpression("Error/Code", 2))
                    {
                        response.Code = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Error/Message", 2))
                    {
                        response.Message = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequestId", 2))
                    {
                        response.RequestId = StringUnmarshaller.GetInstance().Unmarshall(context);
                
                    }
                }
            }

            return response;
        }

        private static ErrorResponseUnmarshaller instance;

        /// <summary>
        /// Return an instance of and ErrorResponseUnmarshaller.
        /// </summary>
        /// <returns></returns>
        public static ErrorResponseUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ErrorResponseUnmarshaller();

            return instance;
        }
    }
}
