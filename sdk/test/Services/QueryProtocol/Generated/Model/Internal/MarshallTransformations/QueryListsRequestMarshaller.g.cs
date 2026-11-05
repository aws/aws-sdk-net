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
    /// QueryLists Request Marshaller
    /// </summary>
    public partial class QueryListsRequestMarshaller : IMarshaller<IRequest, QueryListsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((QueryListsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(QueryListsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QueryProtocol");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "QueryLists");
            request.Parameters.Add("Version", "2020-01-08");

            if (publicRequest.IsSetComplexListArg())
            {
                if (publicRequest.ComplexListArg.Count == 0)
                {
                    request.Parameters.Add("ComplexListArg", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ComplexListArg)
                    {
                        if (item0.IsSetHi())
                        {
                            request.Parameters.Add("ComplexListArg" + ".member" + "." + index0 + ".hi", StringUtils.FromString(item0.Hi));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetFlattenedListArg())
            {
                if (publicRequest.FlattenedListArg.Count == 0)
                {
                    request.Parameters.Add("FlattenedListArg", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.FlattenedListArg)
                    {
                        request.Parameters.Add("FlattenedListArg" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetFlattenedListArgWithXmlName())
            {
                if (publicRequest.FlattenedListArgWithXmlName.Count == 0)
                {
                    request.Parameters.Add("Hi", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.FlattenedListArgWithXmlName)
                    {
                        request.Parameters.Add("Hi" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetListArg())
            {
                if (publicRequest.ListArg.Count == 0)
                {
                    request.Parameters.Add("ListArg", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ListArg)
                    {
                        request.Parameters.Add("ListArg" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetListArgWithXmlNameMember())
            {
                if (publicRequest.ListArgWithXmlNameMember.Count == 0)
                {
                    request.Parameters.Add("ListArgWithXmlNameMember", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ListArgWithXmlNameMember)
                    {
                        request.Parameters.Add("ListArgWithXmlNameMember" + ".item" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetNestedWithList())
            {
                if (publicRequest.NestedWithList.IsSetListArg())
                {
                    if (publicRequest.NestedWithList.ListArg.Count == 0)
                    {
                        request.Parameters.Add("NestedWithList" + ".ListArg", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.NestedWithList.ListArg)
                        {
                            request.Parameters.Add("NestedWithList" + ".ListArg" + ".member" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly QueryListsRequestMarshaller _instance = new();

        internal static QueryListsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static QueryListsRequestMarshaller Instance => _instance;
    }
}
