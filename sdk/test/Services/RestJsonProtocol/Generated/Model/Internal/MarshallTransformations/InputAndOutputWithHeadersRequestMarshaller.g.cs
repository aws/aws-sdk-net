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
    /// InputAndOutputWithHeaders Request Marshaller
    /// </summary>
    public partial class InputAndOutputWithHeadersRequestMarshaller : IMarshaller<IRequest, InputAndOutputWithHeadersRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InputAndOutputWithHeadersRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(InputAndOutputWithHeadersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetHeaderBooleanList())
            {
                request.Headers["X-BooleanList"] = StringUtils.FromValueTypeList(publicRequest.HeaderBooleanList);
            }

            if (publicRequest.IsSetHeaderByte())
            {
                request.Headers["X-Byte"] = StringUtils.FromInt(publicRequest.HeaderByte.Value);
            }

            if (publicRequest.IsSetHeaderDouble())
            {
                request.Headers["X-Double"] = StringUtils.FromDouble(publicRequest.HeaderDouble.Value);
            }

            if (publicRequest.IsSetHeaderEnum())
            {
                request.Headers["X-Enum"] = publicRequest.HeaderEnum;
            }

            if (publicRequest.IsSetHeaderEnumList())
            {
                request.Headers["X-EnumList"] = StringUtils.FromList(publicRequest.HeaderEnumList);
            }

            if (publicRequest.IsSetHeaderFalseBool())
            {
                request.Headers["X-Boolean2"] = StringUtils.FromBool(publicRequest.HeaderFalseBool.Value);
            }

            if (publicRequest.IsSetHeaderFloat())
            {
                request.Headers["X-Float"] = StringUtils.FromFloat(publicRequest.HeaderFloat.Value);
            }

            if (publicRequest.IsSetHeaderInteger())
            {
                request.Headers["X-Integer"] = StringUtils.FromInt(publicRequest.HeaderInteger.Value);
            }

            if (publicRequest.IsSetHeaderIntegerEnum())
            {
                request.Headers["X-IntegerEnum"] = StringUtils.FromInt(publicRequest.HeaderIntegerEnum.Value);
            }

            if (publicRequest.IsSetHeaderIntegerEnumList())
            {
                request.Headers["X-IntegerEnumList"] = StringUtils.FromValueTypeList(publicRequest.HeaderIntegerEnumList);
            }

            if (publicRequest.IsSetHeaderIntegerList())
            {
                request.Headers["X-IntegerList"] = StringUtils.FromValueTypeList(publicRequest.HeaderIntegerList);
            }

            if (publicRequest.IsSetHeaderLong())
            {
                request.Headers["X-Long"] = StringUtils.FromLong(publicRequest.HeaderLong.Value);
            }

            if (publicRequest.IsSetHeaderShort())
            {
                request.Headers["X-Short"] = StringUtils.FromInt(publicRequest.HeaderShort.Value);
            }

            if (publicRequest.IsSetHeaderString())
            {
                request.Headers["X-String"] = publicRequest.HeaderString;
            }

            if (publicRequest.IsSetHeaderStringList())
            {
                request.Headers["X-StringList"] = StringUtils.FromList(publicRequest.HeaderStringList);
            }

            if (publicRequest.IsSetHeaderStringSet())
            {
                request.Headers["X-StringSet"] = StringUtils.FromList(publicRequest.HeaderStringSet);
            }

            if (publicRequest.IsSetHeaderTimestampList())
            {
                request.Headers["X-TimestampList"] = StringUtils.FromValueTypeList(publicRequest.HeaderTimestampList);
            }

            if (publicRequest.IsSetHeaderTrueBool())
            {
                request.Headers["X-Boolean1"] = StringUtils.FromBool(publicRequest.HeaderTrueBool.Value);
            }

            request.ResourcePath = "/InputAndOutputWithHeaders";

            return request;
        }

        private static readonly InputAndOutputWithHeadersRequestMarshaller _instance = new();

        internal static InputAndOutputWithHeadersRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InputAndOutputWithHeadersRequestMarshaller Instance => _instance;
    }
}
