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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.RestJsonProtocol.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AllQueryStringTypes Request Marshaller
    /// </summary>
    public partial class AllQueryStringTypesRequestMarshaller : IMarshaller<IRequest, AllQueryStringTypesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AllQueryStringTypesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AllQueryStringTypesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetQueryBoolean())
            {
                request.Parameters.Add("Boolean", StringUtils.FromBool(publicRequest.QueryBoolean.Value));
            }

            if (publicRequest.IsSetQueryBooleanList())
            {
                request.ParameterCollection.Add("BooleanList", publicRequest.QueryBooleanList.ConvertAll<string>(item => StringUtils.FromBool(item)));
            }

            if (publicRequest.IsSetQueryByte())
            {
                request.Parameters.Add("Byte", StringUtils.FromInt(publicRequest.QueryByte.Value));
            }

            if (publicRequest.IsSetQueryDouble())
            {
                request.Parameters.Add("Double", StringUtils.FromDouble(publicRequest.QueryDouble.Value));
            }

            if (publicRequest.IsSetQueryDoubleList())
            {
                request.ParameterCollection.Add("DoubleList", publicRequest.QueryDoubleList.ConvertAll<string>(item => StringUtils.FromDouble(item)));
            }

            if (publicRequest.IsSetQueryEnum())
            {
                request.Parameters.Add("Enum", StringUtils.FromString(publicRequest.QueryEnum));
            }

            if (publicRequest.IsSetQueryEnumList())
            {
                request.ParameterCollection.Add("EnumList", publicRequest.QueryEnumList);
            }

            if (publicRequest.IsSetQueryFloat())
            {
                request.Parameters.Add("Float", StringUtils.FromFloat(publicRequest.QueryFloat.Value));
            }

            if (publicRequest.IsSetQueryInteger())
            {
                request.Parameters.Add("Integer", StringUtils.FromInt(publicRequest.QueryInteger.Value));
            }

            if (publicRequest.IsSetQueryIntegerEnum())
            {
                request.Parameters.Add("IntegerEnum", StringUtils.FromInt(publicRequest.QueryIntegerEnum.Value));
            }

            if (publicRequest.IsSetQueryIntegerEnumList())
            {
                request.ParameterCollection.Add("IntegerEnumList", publicRequest.QueryIntegerEnumList.ConvertAll<string>(item => StringUtils.FromInt(item)));
            }

            if (publicRequest.IsSetQueryIntegerList())
            {
                request.ParameterCollection.Add("IntegerList", publicRequest.QueryIntegerList.ConvertAll<string>(item => StringUtils.FromInt(item)));
            }

            if (publicRequest.IsSetQueryIntegerSet())
            {
                request.ParameterCollection.Add("IntegerSet", publicRequest.QueryIntegerSet.ConvertAll<string>(item => StringUtils.FromInt(item)));
            }

            if (publicRequest.IsSetQueryLong())
            {
                request.Parameters.Add("Long", StringUtils.FromLong(publicRequest.QueryLong.Value));
            }

            if (publicRequest.IsSetQueryShort())
            {
                request.Parameters.Add("Short", StringUtils.FromInt(publicRequest.QueryShort.Value));
            }

            if (publicRequest.IsSetQueryString())
            {
                request.Parameters.Add("String", StringUtils.FromString(publicRequest.QueryString));
            }

            if (publicRequest.IsSetQueryStringList())
            {
                request.ParameterCollection.Add("StringList", publicRequest.QueryStringList);
            }

            if (publicRequest.IsSetQueryStringSet())
            {
                request.ParameterCollection.Add("StringSet", publicRequest.QueryStringSet);
            }

            if (publicRequest.IsSetQueryTimestamp())
            {
                request.Parameters.Add("Timestamp", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.QueryTimestamp));
            }

            if (publicRequest.IsSetQueryTimestampList())
            {
                request.ParameterCollection.Add("TimestampList", publicRequest.QueryTimestampList.ConvertAll<string>(item => StringUtils.FromDateTimeToISO8601WithOptionalMs(item)));
            }

            if (publicRequest.IsSetQueryParamsMapOfStringList())
            {
                foreach (var kvp in publicRequest.QueryParamsMapOfStringList)
                {
                    if (!request.ParameterCollection.ContainsKey(kvp.Key))
                    {
                        request.ParameterCollection.Add(kvp.Key, kvp.Value);
                    }
                }
            }

            request.ResourcePath = "/AllQueryStringTypesInput";

            request.UseQueryString = true;

            return request;
        }

        private static readonly AllQueryStringTypesRequestMarshaller _instance = new();

        internal static AllQueryStringTypesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AllQueryStringTypesRequestMarshaller Instance => _instance;
    }
}
