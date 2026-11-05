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

using Amazon.NumericTypesRestXml.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.NumericTypesRestXml.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BodyNumbers operation.
    /// </summary>
    public partial class BodyNumbersResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            BodyNumbersResponse unmarshalledObject = new BodyNumbersResponse();
            UnmarshallResult(context, unmarshalledObject);

            PostUnmarshallCustomization(context, unmarshalledObject);
            return unmarshalledObject;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, BodyNumbersResponse unmarshalledObject)
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
                    if (context.TestExpression("BigDecimalList/member", targetDepth))
                    {
                        if (unmarshalledObject.BigDecimalList == null)
                        {
                            unmarshalledObject.BigDecimalList = new List<Amazon.Extensions.Numerics.BigDecimal>();
                        }
                        var unmarshaller = BigDecimalUnmarshaller.Instance;
                        unmarshalledObject.BigDecimalList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("BigDecimalMap", targetDepth))
                    {
                        var unmarshaller = new XmlDictionaryUnmarshaller<string, Amazon.Extensions.Numerics.BigDecimal, StringUnmarshaller, BigDecimalUnmarshaller>(StringUnmarshaller.Instance, BigDecimalUnmarshaller.Instance, "key", "value");
                        unmarshalledObject.BigDecimalMap = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("BigDecimalValue", targetDepth))
                    {
                        var unmarshaller = NullableBigDecimalUnmarshaller.Instance;
                        unmarshalledObject.BigDecimalValue = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("BigIntegerList/member", targetDepth))
                    {
                        if (unmarshalledObject.BigIntegerList == null)
                        {
                            unmarshalledObject.BigIntegerList = new List<System.Numerics.BigInteger>();
                        }
                        var unmarshaller = BigIntegerUnmarshaller.Instance;
                        unmarshalledObject.BigIntegerList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("BigIntegerMap", targetDepth))
                    {
                        var unmarshaller = new XmlDictionaryUnmarshaller<string, System.Numerics.BigInteger, StringUnmarshaller, BigIntegerUnmarshaller>(StringUnmarshaller.Instance, BigIntegerUnmarshaller.Instance, "key", "value");
                        unmarshalledObject.BigIntegerMap = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("BigIntegerValue", targetDepth))
                    {
                        var unmarshaller = NullableBigIntegerUnmarshaller.Instance;
                        unmarshalledObject.BigIntegerValue = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ByteList/member", targetDepth))
                    {
                        if (unmarshalledObject.ByteList == null)
                        {
                            unmarshalledObject.ByteList = new List<sbyte>();
                        }
                        var unmarshaller = SByteUnmarshaller.Instance;
                        unmarshalledObject.ByteList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ByteMap", targetDepth))
                    {
                        var unmarshaller = new XmlDictionaryUnmarshaller<string, sbyte, StringUnmarshaller, SByteUnmarshaller>(StringUnmarshaller.Instance, SByteUnmarshaller.Instance, "key", "value");
                        unmarshalledObject.ByteMap = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ByteValue", targetDepth))
                    {
                        var unmarshaller = NullableSByteUnmarshaller.Instance;
                        unmarshalledObject.ByteValue = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Nested", targetDepth))
                    {
                        var unmarshaller = NestedNumbersUnmarshaller.Instance;
                        unmarshalledObject.Nested = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("NestedList/member", targetDepth))
                    {
                        if (unmarshalledObject.NestedList == null)
                        {
                            unmarshalledObject.NestedList = new List<NestedNumbers>();
                        }
                        var unmarshaller = NestedNumbersUnmarshaller.Instance;
                        unmarshalledObject.NestedList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ShortList/member", targetDepth))
                    {
                        if (unmarshalledObject.ShortList == null)
                        {
                            unmarshalledObject.ShortList = new List<short>();
                        }
                        var unmarshaller = ShortUnmarshaller.Instance;
                        unmarshalledObject.ShortList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ShortMap", targetDepth))
                    {
                        var unmarshaller = new XmlDictionaryUnmarshaller<string, short, StringUnmarshaller, ShortUnmarshaller>(StringUnmarshaller.Instance, ShortUnmarshaller.Instance, "key", "value");
                        unmarshalledObject.ShortMap = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ShortValue", targetDepth))
                    {
                        var unmarshaller = NullableShortUnmarshaller.Instance;
                        unmarshalledObject.ShortValue = unmarshaller.Unmarshall(context);
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
            return new AmazonNumericTypesRestXmlException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, BodyNumbersResponse unmarshalledObject);
        private static BodyNumbersResponseUnmarshaller _instance = new BodyNumbersResponseUnmarshaller();

        internal static BodyNumbersResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BodyNumbersResponseUnmarshaller Instance => _instance;
    }
}
