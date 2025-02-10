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
using Amazon.Runtime.Internal.Transform;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public class ErrorUnmarshaller : IXmlUnmarshaller<ErrorDetails, XmlUnmarshallerContext>, IXmlUnmarshaller<ErrorDetails, JsonUnmarshallerContext>
    {
        public ErrorDetails Unmarshall(XmlUnmarshallerContext context)
        {
            ErrorDetails errorDetails = new ErrorDetails();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ErrorMessage", targetDepth))
                    {
                        errorDetails.ErrorMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ErrorCode", targetDepth))
                    {
                        errorDetails.ErrorCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return errorDetails;
                }
            }

            return errorDetails;
        }

        /// <summary>
        /// Not implemented and always returns null.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ErrorDetails Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static ErrorUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static ErrorUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ErrorUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
