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

using Amazon.NumericTypesRestJson.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.NumericTypesRestJson.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HttpNumbers Request Marshaller
    /// </summary>
    public partial class HttpNumbersRequestMarshaller : IMarshaller<IRequest, HttpNumbersRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((HttpNumbersRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(HttpNumbersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NumericTypesRestJson");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-10-26";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetQueryBigDecimal())
            {
                request.Parameters.Add("BigDecimal", StringUtils.FromBigDecimal(publicRequest.QueryBigDecimal.Value));
            }

            if (publicRequest.IsSetQueryBigDecimalList())
            {
                request.ParameterCollection.Add("BigDecimalList", publicRequest.QueryBigDecimalList.ConvertAll<string>(item => StringUtils.FromBigDecimal(item)));
            }

            if (publicRequest.IsSetQueryBigInteger())
            {
                request.Parameters.Add("BigInteger", StringUtils.FromBigInteger(publicRequest.QueryBigInteger.Value));
            }

            if (publicRequest.IsSetQueryBigIntegerList())
            {
                request.ParameterCollection.Add("BigIntegerList", publicRequest.QueryBigIntegerList.ConvertAll<string>(item => StringUtils.FromBigInteger(item)));
            }

            if (publicRequest.IsSetQueryByte())
            {
                request.Parameters.Add("Byte", StringUtils.FromSByte(publicRequest.QueryByte.Value));
            }

            if (publicRequest.IsSetQueryByteList())
            {
                request.ParameterCollection.Add("ByteList", publicRequest.QueryByteList.ConvertAll<string>(item => StringUtils.FromSByte(item)));
            }

            if (publicRequest.IsSetQueryShort())
            {
                request.Parameters.Add("Short", StringUtils.FromShort(publicRequest.QueryShort.Value));
            }

            if (publicRequest.IsSetQueryShortList())
            {
                request.ParameterCollection.Add("ShortList", publicRequest.QueryShortList.ConvertAll<string>(item => StringUtils.FromShort(item)));
            }

            if (publicRequest.IsSetHeaderBigDecimal())
            {
                request.Headers["X-BigDecimal"] = StringUtils.FromBigDecimal(publicRequest.HeaderBigDecimal.Value);
            }

            if (publicRequest.IsSetHeaderBigDecimalList())
            {
                request.Headers["X-BigDecimalList"] = StringUtils.FromValueTypeList(publicRequest.HeaderBigDecimalList, StringUtils.FromBigDecimal);
            }

            if (publicRequest.IsSetHeaderBigInteger())
            {
                request.Headers["X-BigInteger"] = StringUtils.FromBigInteger(publicRequest.HeaderBigInteger.Value);
            }

            if (publicRequest.IsSetHeaderBigIntegerList())
            {
                request.Headers["X-BigIntegerList"] = StringUtils.FromValueTypeList(publicRequest.HeaderBigIntegerList, StringUtils.FromBigInteger);
            }

            if (publicRequest.IsSetHeaderByte())
            {
                request.Headers["X-Byte"] = StringUtils.FromSByte(publicRequest.HeaderByte.Value);
            }

            if (publicRequest.IsSetHeaderShort())
            {
                request.Headers["X-Short"] = StringUtils.FromShort(publicRequest.HeaderShort.Value);
            }

            if (publicRequest.IsSetHeaderShortList())
            {
                request.Headers["X-ShortList"] = StringUtils.FromValueTypeList(publicRequest.HeaderShortList, StringUtils.FromShort);
            }

            if (!publicRequest.IsSetLabelBigDecimal())
            {
                throw new AmazonNumericTypesRestJsonException("Request object does not have required field LabelBigDecimal set");
            }
            request.AddPathResource("{LabelBigDecimal}", StringUtils.FromBigDecimal(publicRequest.LabelBigDecimal.Value));

            if (!publicRequest.IsSetLabelBigInteger())
            {
                throw new AmazonNumericTypesRestJsonException("Request object does not have required field LabelBigInteger set");
            }
            request.AddPathResource("{LabelBigInteger}", StringUtils.FromBigInteger(publicRequest.LabelBigInteger.Value));

            if (!publicRequest.IsSetLabelByte())
            {
                throw new AmazonNumericTypesRestJsonException("Request object does not have required field LabelByte set");
            }
            request.AddPathResource("{LabelByte}", StringUtils.FromSByte(publicRequest.LabelByte.Value));

            if (!publicRequest.IsSetLabelShort())
            {
                throw new AmazonNumericTypesRestJsonException("Request object does not have required field LabelShort set");
            }
            request.AddPathResource("{LabelShort}", StringUtils.FromShort(publicRequest.LabelShort.Value));

            request.ResourcePath = "/HttpNumbers/{LabelByte}/{LabelShort}/{LabelBigInteger}/{LabelBigDecimal}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly HttpNumbersRequestMarshaller _instance = new();

        internal static HttpNumbersRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static HttpNumbersRequestMarshaller Instance => _instance;
    }
}
