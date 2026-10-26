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
 * Do not modify this file. This file is generated from the numerictypesec2-2026-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NumericTypesEC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.NumericTypesEC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BodyNumbers operation
    /// </summary>  
    public class BodyNumbersResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            BodyNumbersResponse response = new BodyNumbersResponse();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth = 2;

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("bigDecimalList/member", targetDepth))
                    {
                        var unmarshaller = BigDecimalUnmarshaller.Instance;
                        if (response.BigDecimalList == null)
                        {
                            response.BigDecimalList = new List<Amazon.Extensions.Numerics.BigDecimal>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.BigDecimalList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("bigDecimalMap/entry", targetDepth))
                    {
                        var unmarshaller = new XmlKeyValueUnmarshaller<string, Amazon.Extensions.Numerics.BigDecimal, StringUnmarshaller, BigDecimalUnmarshaller>(StringUnmarshaller.Instance, BigDecimalUnmarshaller.Instance, "key", "value");
                        if (response.BigDecimalMap == null)
                        {
                            response.BigDecimalMap = new Dictionary<string, Amazon.Extensions.Numerics.BigDecimal>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.BigDecimalMap.Add(item);
                        continue;
                    }
                    if (context.TestExpression("bigDecimalValue", targetDepth))
                    {
                        var unmarshaller = NullableBigDecimalUnmarshaller.Instance;
                        response.BigDecimalValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("bigIntegerList/member", targetDepth))
                    {
                        var unmarshaller = BigIntegerUnmarshaller.Instance;
                        if (response.BigIntegerList == null)
                        {
                            response.BigIntegerList = new List<System.Numerics.BigInteger>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.BigIntegerList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("bigIntegerMap/entry", targetDepth))
                    {
                        var unmarshaller = new XmlKeyValueUnmarshaller<string, System.Numerics.BigInteger, StringUnmarshaller, BigIntegerUnmarshaller>(StringUnmarshaller.Instance, BigIntegerUnmarshaller.Instance, "key", "value");
                        if (response.BigIntegerMap == null)
                        {
                            response.BigIntegerMap = new Dictionary<string, System.Numerics.BigInteger>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.BigIntegerMap.Add(item);
                        continue;
                    }
                    if (context.TestExpression("bigIntegerValue", targetDepth))
                    {
                        var unmarshaller = NullableBigIntegerUnmarshaller.Instance;
                        response.BigIntegerValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("byteList/member", targetDepth))
                    {
                        var unmarshaller = SByteUnmarshaller.Instance;
                        if (response.ByteList == null)
                        {
                            response.ByteList = new List<sbyte>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ByteList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("byteMap/entry", targetDepth))
                    {
                        var unmarshaller = new XmlKeyValueUnmarshaller<string, sbyte, StringUnmarshaller, SByteUnmarshaller>(StringUnmarshaller.Instance, SByteUnmarshaller.Instance, "key", "value");
                        if (response.ByteMap == null)
                        {
                            response.ByteMap = new Dictionary<string, sbyte>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ByteMap.Add(item);
                        continue;
                    }
                    if (context.TestExpression("byteValue", targetDepth))
                    {
                        var unmarshaller = NullableSByteUnmarshaller.Instance;
                        response.ByteValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("nested", targetDepth))
                    {
                        var unmarshaller = NestedNumbersUnmarshaller.Instance;
                        response.Nested = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("nestedList/member", targetDepth))
                    {
                        var unmarshaller = NestedNumbersUnmarshaller.Instance;
                        if (response.NestedList == null)
                        {
                            response.NestedList = new List<NestedNumbers>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.NestedList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("shortList/member", targetDepth))
                    {
                        var unmarshaller = ShortUnmarshaller.Instance;
                        if (response.ShortList == null)
                        {
                            response.ShortList = new List<short>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ShortList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("shortMap/entry", targetDepth))
                    {
                        var unmarshaller = new XmlKeyValueUnmarshaller<string, short, StringUnmarshaller, ShortUnmarshaller>(StringUnmarshaller.Instance, ShortUnmarshaller.Instance, "key", "value");
                        if (response.ShortMap == null)
                        {
                            response.ShortMap = new Dictionary<string, short>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ShortMap.Add(item);
                        continue;
                    }
                    if (context.TestExpression("shortValue", targetDepth))
                    {
                        var unmarshaller = NullableShortUnmarshaller.Instance;
                        response.ShortValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
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
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            return new AmazonNumericTypesEC2Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
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