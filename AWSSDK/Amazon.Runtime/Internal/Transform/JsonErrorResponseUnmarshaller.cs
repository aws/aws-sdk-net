/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml;


namespace Amazon.Runtime.Internal.Transform
{
    /// <summary>
    ///    Response Unmarshaller for all Errors
    /// </summary>
    public class JsonErrorResponseUnmarshaller : IUnmarshaller<ErrorResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Build an ErrorResponse from json 
        /// </summary>
        /// <param name="context">The json parsing context. 
        /// Usually an <c>Amazon.Runtime.Internal.JsonUnmarshallerContext</c>.</param>
        /// <returns>An <c>ErrorResponse</c> object.</returns>
        public ErrorResponse Unmarshall(JsonUnmarshallerContext context)
        {
            ErrorResponse response = new ErrorResponse();

            if (context.Peek() == 60) //starts with '<' so assuming XML.
            {
                ErrorResponseUnmarshaller xmlUnmarshaller = new ErrorResponseUnmarshaller();
                context.Stream.Position = 0;
                XmlUnmarshallerContext xmlContext = new XmlUnmarshallerContext(context.Stream, null);
                response = xmlUnmarshaller.Unmarshall(xmlContext);
            }
            else
            {
                while (context.Read())
                {
                    if (context.IsLeafValue)
                    {
                        if (context.TestExpression("__type"))
                        {
                            string type = StringUnmarshaller.GetInstance().Unmarshall(context);
                            response.Code = type.Substring(type.LastIndexOf("#")+1);
                            if (Enum.IsDefined(typeof(ErrorType), type))
                            {
                                response.Type = (ErrorType)Enum.Parse(typeof(ErrorType), type);
                            }
                            else
                            {
                                response.Type = ErrorType.Unknown;
                            }
                            continue;
                        }
                        if (context.TestExpression("code"))
                        {
                            response.Code = StringUnmarshaller.GetInstance().Unmarshall(context);
                            continue;
                        }
                        if (context.TestExpression("message"))
                        {
                            response.Message = StringUnmarshaller.GetInstance().Unmarshall(context);
                            continue;
                        }

                        // When all expressions fall through, push the current node as a string into Metadata
                        int keyIndex = context.CurrentPath.LastIndexOf('/') + 1;
                        string key = context.CurrentPath.Substring(keyIndex);
                        string value = StringUnmarshaller.GetInstance().Unmarshall(context);
                        response.Metadata.Add(key, value);
                    }
                }
            }

            return response;
        }

        private static JsonErrorResponseUnmarshaller instance;

        /// <summary>
        /// Return an instance of JsonErrorResponseUnmarshaller.
        /// </summary>
        /// <returns></returns>
        public static JsonErrorResponseUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new JsonErrorResponseUnmarshaller();

            return instance;
        }
    }
}
