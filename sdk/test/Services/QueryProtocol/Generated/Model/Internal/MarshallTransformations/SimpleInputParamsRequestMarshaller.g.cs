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
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.QueryProtocol.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.QueryProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SimpleInputParams Request Marshaller
    /// </summary>
    public partial class SimpleInputParamsRequestMarshaller : IMarshaller<IRequest, SimpleInputParamsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SimpleInputParamsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SimpleInputParamsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QueryProtocol");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "SimpleInputParams");
            request.Parameters.Add("Version", "2020-01-08");

            if (publicRequest.IsSetBam())
            {
                request.Parameters.Add("Bam", StringUtils.FromInt(publicRequest.Bam.Value));
            }
            if (publicRequest.IsSetBar())
            {
                request.Parameters.Add("Bar", StringUtils.FromString(publicRequest.Bar));
            }
            if (publicRequest.IsSetBaz())
            {
                request.Parameters.Add("Baz", StringUtils.FromBool(publicRequest.Baz.Value));
            }
            if (publicRequest.IsSetBoo())
            {
                request.Parameters.Add("Boo", StringUtils.FromDouble(publicRequest.Boo.Value));
            }
            if (publicRequest.IsSetFloatValue())
            {
                request.Parameters.Add("FloatValue", StringUtils.FromFloat(publicRequest.FloatValue.Value));
            }
            if (publicRequest.IsSetFoo())
            {
                request.Parameters.Add("Foo", StringUtils.FromString(publicRequest.Foo));
            }
            if (publicRequest.IsSetFooEnum())
            {
                request.Parameters.Add("FooEnum", StringUtils.FromString(publicRequest.FooEnum));
            }
            if (publicRequest.IsSetIntegerEnum())
            {
                request.Parameters.Add("IntegerEnum", StringUtils.FromInt(publicRequest.IntegerEnum.Value));
            }
            if (publicRequest.IsSetQux())
            {
                request.Parameters.Add("Qux", StringUtils.FromMemoryStream(publicRequest.Qux));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly SimpleInputParamsRequestMarshaller _instance = new();

        internal static SimpleInputParamsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SimpleInputParamsRequestMarshaller Instance => _instance;
    }
}
