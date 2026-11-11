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
    /// QueryMaps Request Marshaller
    /// </summary>
    public partial class QueryMapsRequestMarshaller : IMarshaller<IRequest, QueryMapsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((QueryMapsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(QueryMapsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QueryProtocol");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "QueryMaps");
            request.Parameters.Add("Version", "2020-01-08");

            if (publicRequest.IsSetComplexMapArg())
            {
                int index0 = 1;
                foreach (var kvp0 in publicRequest.ComplexMapArg)
                {
                    request.Parameters.Add("ComplexMapArg" + ".entry" + "." + index0 + ".key", StringUtils.FromString(kvp0.Key));
                    if (kvp0.Value.IsSetHi())
                    {
                        request.Parameters.Add("ComplexMapArg" + ".entry" + "." + index0 + ".value" + ".hi", StringUtils.FromString(kvp0.Value.Hi));
                    }
                    index0++;
                }
            }
            if (publicRequest.IsSetFlattenedMap())
            {
                int index0 = 1;
                foreach (var kvp0 in publicRequest.FlattenedMap)
                {
                    request.Parameters.Add("FlattenedMap" + "." + index0 + ".key", StringUtils.FromString(kvp0.Key));
                    request.Parameters.Add("FlattenedMap" + "." + index0 + ".value", StringUtils.FromString(kvp0.Value));
                    index0++;
                }
            }
            if (publicRequest.IsSetFlattenedMapWithXmlName())
            {
                int index0 = 1;
                foreach (var kvp0 in publicRequest.FlattenedMapWithXmlName)
                {
                    request.Parameters.Add("Hi" + "." + index0 + ".K", StringUtils.FromString(kvp0.Key));
                    request.Parameters.Add("Hi" + "." + index0 + ".V", StringUtils.FromString(kvp0.Value));
                    index0++;
                }
            }
            if (publicRequest.IsSetMapArg())
            {
                int index0 = 1;
                foreach (var kvp0 in publicRequest.MapArg)
                {
                    request.Parameters.Add("MapArg" + ".entry" + "." + index0 + ".key", StringUtils.FromString(kvp0.Key));
                    request.Parameters.Add("MapArg" + ".entry" + "." + index0 + ".value", StringUtils.FromString(kvp0.Value));
                    index0++;
                }
            }
            if (publicRequest.IsSetMapOfLists())
            {
                int index0 = 1;
                foreach (var kvp0 in publicRequest.MapOfLists)
                {
                    request.Parameters.Add("MapOfLists" + ".entry" + "." + index0 + ".key", StringUtils.FromString(kvp0.Key));
                    int vindex0 = 1;
                    foreach (var vitem0 in kvp0.Value)
                    {
                        request.Parameters.Add("MapOfLists" + ".entry" + "." + index0 + ".value" + ".member" + "." + vindex0, StringUtils.FromString(vitem0));
                        vindex0++;
                    }
                    index0++;
                }
            }
            if (publicRequest.IsSetMapWithXmlMemberName())
            {
                int index0 = 1;
                foreach (var kvp0 in publicRequest.MapWithXmlMemberName)
                {
                    request.Parameters.Add("MapWithXmlMemberName" + ".entry" + "." + index0 + ".K", StringUtils.FromString(kvp0.Key));
                    request.Parameters.Add("MapWithXmlMemberName" + ".entry" + "." + index0 + ".V", StringUtils.FromString(kvp0.Value));
                    index0++;
                }
            }
            if (publicRequest.IsSetNestedStructWithMap())
            {
                if (publicRequest.NestedStructWithMap.IsSetMapArg())
                {
                    int index1 = 1;
                    foreach (var kvp1 in publicRequest.NestedStructWithMap.MapArg)
                    {
                        request.Parameters.Add("NestedStructWithMap" + ".MapArg" + ".entry" + "." + index1 + ".key", StringUtils.FromString(kvp1.Key));
                        request.Parameters.Add("NestedStructWithMap" + ".MapArg" + ".entry" + "." + index1 + ".value", StringUtils.FromString(kvp1.Value));
                        index1++;
                    }
                }
            }
            if (publicRequest.IsSetRenamedMapArg())
            {
                int index0 = 1;
                foreach (var kvp0 in publicRequest.RenamedMapArg)
                {
                    request.Parameters.Add("Foo" + ".entry" + "." + index0 + ".key", StringUtils.FromString(kvp0.Key));
                    request.Parameters.Add("Foo" + ".entry" + "." + index0 + ".value", StringUtils.FromString(kvp0.Value));
                    index0++;
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly QueryMapsRequestMarshaller _instance = new();

        internal static QueryMapsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static QueryMapsRequestMarshaller Instance => _instance;
    }
}
