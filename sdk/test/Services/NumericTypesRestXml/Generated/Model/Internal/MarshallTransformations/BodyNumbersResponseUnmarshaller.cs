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
 * Do not modify this file. This file is generated from the numerictypesrestxml-2026-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NumericTypesRestXml.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.NumericTypesRestXml.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BodyNumbers operation
    /// </summary>  
    public partial class BodyNumbersResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            BodyNumbersResponse response = new BodyNumbersResponse();
            UnmarshallResult(context,response);
            
            PostUnmarshallCustomization(context, response);
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, BodyNumbersResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
                   targetDepth += 1;
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
                        if (response.BigDecimalList == null)
                        {
                            response.BigDecimalList = new List<Amazon.Extensions.Numerics.BigDecimal>();
                        }
                        var unmarshaller = BigDecimalUnmarshaller.Instance;
                        response.BigDecimalList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("BigDecimalMap", targetDepth))
                    {
                        var unmarshaller = new XmlDictionaryUnmarshaller<string, Amazon.Extensions.Numerics.BigDecimal, StringUnmarshaller, BigDecimalUnmarshaller>(StringUnmarshaller.Instance, BigDecimalUnmarshaller.Instance, "key", "value");
                        response.BigDecimalMap = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BigDecimalValue", targetDepth))
                    {
                        var unmarshaller = NullableBigDecimalUnmarshaller.Instance;
                        response.BigDecimalValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BigIntegerList/member", targetDepth))
                    {
                        if (response.BigIntegerList == null)
                        {
                            response.BigIntegerList = new List<System.Numerics.BigInteger>();
                        }
                        var unmarshaller = BigIntegerUnmarshaller.Instance;
                        response.BigIntegerList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("BigIntegerMap", targetDepth))
                    {
                        var unmarshaller = new XmlDictionaryUnmarshaller<string, System.Numerics.BigInteger, StringUnmarshaller, BigIntegerUnmarshaller>(StringUnmarshaller.Instance, BigIntegerUnmarshaller.Instance, "key", "value");
                        response.BigIntegerMap = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BigIntegerValue", targetDepth))
                    {
                        var unmarshaller = NullableBigIntegerUnmarshaller.Instance;
                        response.BigIntegerValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ByteList/member", targetDepth))
                    {
                        if (response.ByteList == null)
                        {
                            response.ByteList = new List<sbyte>();
                        }
                        var unmarshaller = SByteUnmarshaller.Instance;
                        response.ByteList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("ByteMap", targetDepth))
                    {
                        var unmarshaller = new XmlDictionaryUnmarshaller<string, sbyte, StringUnmarshaller, SByteUnmarshaller>(StringUnmarshaller.Instance, SByteUnmarshaller.Instance, "key", "value");
                        response.ByteMap = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ByteValue", targetDepth))
                    {
                        var unmarshaller = NullableSByteUnmarshaller.Instance;
                        response.ByteValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Nested", targetDepth))
                    {
                        var unmarshaller = NestedNumbersUnmarshaller.Instance;
                        response.Nested = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NestedList/member", targetDepth))
                    {
                        if (response.NestedList == null)
                        {
                            response.NestedList = new List<NestedNumbers>();
                        }
                        var unmarshaller = NestedNumbersUnmarshaller.Instance;
                        response.NestedList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("ShortList/member", targetDepth))
                    {
                        if (response.ShortList == null)
                        {
                            response.ShortList = new List<short>();
                        }
                        var unmarshaller = ShortUnmarshaller.Instance;
                        response.ShortList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("ShortMap", targetDepth))
                    {
                        var unmarshaller = new XmlDictionaryUnmarshaller<string, short, StringUnmarshaller, ShortUnmarshaller>(StringUnmarshaller.Instance, ShortUnmarshaller.Instance, "key", "value");
                        response.ShortMap = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ShortValue", targetDepth))
                    {
                        var unmarshaller = NullableShortUnmarshaller.Instance;
                        response.ShortValue = unmarshaller.Unmarshall(context);
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
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
            }
            return new AmazonNumericTypesRestXmlException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, BodyNumbersResponse response);

        private static BodyNumbersResponseUnmarshaller _instance = new BodyNumbersResponseUnmarshaller();        

        internal static BodyNumbersResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BodyNumbersResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}