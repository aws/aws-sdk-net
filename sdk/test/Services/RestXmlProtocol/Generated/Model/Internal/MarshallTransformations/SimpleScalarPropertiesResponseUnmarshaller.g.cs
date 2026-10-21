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

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SimpleScalarProperties operation.
    /// </summary>
    public partial class SimpleScalarPropertiesResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            SimpleScalarPropertiesResponse unmarshalledObject = new SimpleScalarPropertiesResponse();
            UnmarshallResult(context, unmarshalledObject);
            if (context.ResponseData.IsHeaderPresent("X-Foo"))
            {
                unmarshalledObject.Foo = context.ResponseData.GetHeaderValue("X-Foo");
            }

            PostUnmarshallCustomization(context, unmarshalledObject);
            return unmarshalledObject;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, SimpleScalarPropertiesResponse unmarshalledObject)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 1;
            }
            if (context.IsEmptyResponse)
            {
                return;
            }
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("byteValue", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.ByteValue = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("DoubleDribble", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.DoubleValue = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("falseBooleanValue", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.FalseBooleanValue = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("floatValue", targetDepth))
                    {
                        var unmarshaller = NullableFloatUnmarshaller.Instance;
                        unmarshalledObject.FloatValue = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("integerValue", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.IntegerValue = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("longValue", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.LongValue = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("shortValue", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.ShortValue = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("stringValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StringValue = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("trueBooleanValue", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.TrueBooleanValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
            return;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                }
            }
            return new AmazonRestXmlProtocolException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, SimpleScalarPropertiesResponse unmarshalledObject);
        private static SimpleScalarPropertiesResponseUnmarshaller _instance = new SimpleScalarPropertiesResponseUnmarshaller();

        internal static SimpleScalarPropertiesResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SimpleScalarPropertiesResponseUnmarshaller Instance => _instance;
    }
}
