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
    /// BodyNumbers Request Marshaller
    /// </summary>       
    public class BodyNumbersRequestMarshaller : IMarshaller<IRequest, BodyNumbersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BodyNumbersRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BodyNumbersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NumericTypesEC2");
            request.Parameters.Add("Action", "BodyNumbers");
            request.Parameters.Add("Version", "2026-10-26");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetBigDecimalList())
                {
                    if (publicRequest.BigDecimalList.Count == 0)
                        request.Parameters.Add("BigDecimalList", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.BigDecimalList)
                         {
                             request.Parameters.Add("BigDecimalList" + "." + publicRequestlistValueIndex, StringUtils.FromBigDecimal(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetBigDecimalMap())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.BigDecimalMap.Keys)
                    {
                        Amazon.Extensions.Numerics.BigDecimal value;
                        bool hasValue = publicRequest.BigDecimalMap.TryGetValue(key, out value);
                        request.Parameters.Add("BigDecimalMap" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            request.Parameters.Add("BigDecimalMap" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromBigDecimal(value));
                        }
                        mapIndex++;
                    }
                }
                if(publicRequest.IsSetBigDecimalValue())
                {
                    request.Parameters.Add("BigDecimalValue", StringUtils.FromBigDecimal(publicRequest.BigDecimalValue));
                }
                if(publicRequest.IsSetBigIntegerList())
                {
                    if (publicRequest.BigIntegerList.Count == 0)
                        request.Parameters.Add("BigIntegerList", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.BigIntegerList)
                         {
                             request.Parameters.Add("BigIntegerList" + "." + publicRequestlistValueIndex, StringUtils.FromBigInteger(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetBigIntegerMap())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.BigIntegerMap.Keys)
                    {
                        System.Numerics.BigInteger value;
                        bool hasValue = publicRequest.BigIntegerMap.TryGetValue(key, out value);
                        request.Parameters.Add("BigIntegerMap" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            request.Parameters.Add("BigIntegerMap" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromBigInteger(value));
                        }
                        mapIndex++;
                    }
                }
                if(publicRequest.IsSetBigIntegerValue())
                {
                    request.Parameters.Add("BigIntegerValue", StringUtils.FromBigInteger(publicRequest.BigIntegerValue));
                }
                if(publicRequest.IsSetByteList())
                {
                    if (publicRequest.ByteList.Count == 0)
                        request.Parameters.Add("ByteList", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ByteList)
                         {
                             request.Parameters.Add("ByteList" + "." + publicRequestlistValueIndex, StringUtils.FromSByte(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetByteMap())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.ByteMap.Keys)
                    {
                        sbyte value;
                        bool hasValue = publicRequest.ByteMap.TryGetValue(key, out value);
                        request.Parameters.Add("ByteMap" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            request.Parameters.Add("ByteMap" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromSByte(value));
                        }
                        mapIndex++;
                    }
                }
                if(publicRequest.IsSetByteValue())
                {
                    request.Parameters.Add("ByteValue", StringUtils.FromSByte(publicRequest.ByteValue));
                }
                if(publicRequest.IsSetNested())
                {
                    if(publicRequest.Nested.IsSetBigDecimalValue())
                    {
                        request.Parameters.Add("Nested" + "." + "BigDecimalValue", StringUtils.FromBigDecimal(publicRequest.Nested.BigDecimalValue));
                    }
                    if(publicRequest.Nested.IsSetBigIntegerValue())
                    {
                        request.Parameters.Add("Nested" + "." + "BigIntegerValue", StringUtils.FromBigInteger(publicRequest.Nested.BigIntegerValue));
                    }
                    if(publicRequest.Nested.IsSetByteValue())
                    {
                        request.Parameters.Add("Nested" + "." + "ByteValue", StringUtils.FromSByte(publicRequest.Nested.ByteValue));
                    }
                    if(publicRequest.Nested.IsSetShortValue())
                    {
                        request.Parameters.Add("Nested" + "." + "ShortValue", StringUtils.FromShort(publicRequest.Nested.ShortValue));
                    }
                }
                if(publicRequest.IsSetNestedList())
                {
                    if (publicRequest.NestedList.Count == 0)
                        request.Parameters.Add("NestedList", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.NestedList)
                         {
                            if(publicRequestlistValue.IsSetBigDecimalValue())
                            {
                                request.Parameters.Add("NestedList" + "." + publicRequestlistValueIndex + "." + "BigDecimalValue", StringUtils.FromBigDecimal(publicRequestlistValue.BigDecimalValue));
                            }
                            if(publicRequestlistValue.IsSetBigIntegerValue())
                            {
                                request.Parameters.Add("NestedList" + "." + publicRequestlistValueIndex + "." + "BigIntegerValue", StringUtils.FromBigInteger(publicRequestlistValue.BigIntegerValue));
                            }
                            if(publicRequestlistValue.IsSetByteValue())
                            {
                                request.Parameters.Add("NestedList" + "." + publicRequestlistValueIndex + "." + "ByteValue", StringUtils.FromSByte(publicRequestlistValue.ByteValue));
                            }
                            if(publicRequestlistValue.IsSetShortValue())
                            {
                                request.Parameters.Add("NestedList" + "." + publicRequestlistValueIndex + "." + "ShortValue", StringUtils.FromShort(publicRequestlistValue.ShortValue));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetShortList())
                {
                    if (publicRequest.ShortList.Count == 0)
                        request.Parameters.Add("ShortList", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ShortList)
                         {
                             request.Parameters.Add("ShortList" + "." + publicRequestlistValueIndex, StringUtils.FromShort(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetShortMap())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.ShortMap.Keys)
                    {
                        short value;
                        bool hasValue = publicRequest.ShortMap.TryGetValue(key, out value);
                        request.Parameters.Add("ShortMap" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            request.Parameters.Add("ShortMap" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromShort(value));
                        }
                        mapIndex++;
                    }
                }
                if(publicRequest.IsSetShortValue())
                {
                    request.Parameters.Add("ShortValue", StringUtils.FromShort(publicRequest.ShortValue));
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif
            return request;
        }
                    private static BodyNumbersRequestMarshaller _instance = new BodyNumbersRequestMarshaller();        

        internal static BodyNumbersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BodyNumbersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}