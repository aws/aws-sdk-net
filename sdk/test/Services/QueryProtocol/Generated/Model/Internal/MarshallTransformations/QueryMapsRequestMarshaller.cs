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
 * Do not modify this file. This file is generated from the query-protocol-2020-01-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QueryProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QueryProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueryMaps Request Marshaller
    /// </summary>       
    public class QueryMapsRequestMarshaller : IMarshaller<IRequest, QueryMapsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((QueryMapsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(QueryMapsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QueryProtocol");
            request.Parameters.Add("Action", "QueryMaps");
            request.Parameters.Add("Version", "2020-01-08");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetComplexMapArg())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.ComplexMapArg.Keys)
                    {
                        GreetingStruct value;
                        bool hasValue = publicRequest.ComplexMapArg.TryGetValue(key, out value);
                        request.Parameters.Add("ComplexMapArg" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            if(value.IsSetHi())
                            {
                                request.Parameters.Add("ComplexMapArg" + "." + "entry" + "." + mapIndex + "." + "value" + "." + "hi", StringUtils.FromString(value.Hi));
                            }
                        }
                        mapIndex++;
                    }
                }
                if(publicRequest.IsSetFlattenedMap())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.FlattenedMap.Keys)
                    {
                        String value;
                        bool hasValue = publicRequest.FlattenedMap.TryGetValue(key, out value);
                        request.Parameters.Add("FlattenedMap" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            request.Parameters.Add("FlattenedMap" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                        }
                        mapIndex++;
                    }
                }
                if(publicRequest.IsSetFlattenedMapWithXmlName())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.FlattenedMapWithXmlName.Keys)
                    {
                        String value;
                        bool hasValue = publicRequest.FlattenedMapWithXmlName.TryGetValue(key, out value);
                        request.Parameters.Add("Hi" + "." + mapIndex + "." + "K", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            request.Parameters.Add("Hi" + "." + mapIndex + "." + "V", StringUtils.FromString(value));
                        }
                        mapIndex++;
                    }
                }
                if(publicRequest.IsSetMapArg())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.MapArg.Keys)
                    {
                        String value;
                        bool hasValue = publicRequest.MapArg.TryGetValue(key, out value);
                        request.Parameters.Add("MapArg" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            request.Parameters.Add("MapArg" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                        }
                        mapIndex++;
                    }
                }
                if(publicRequest.IsSetMapOfLists())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.MapOfLists.Keys)
                    {
                        List<String> value;

                        bool hasValue = publicRequest.MapOfLists.TryGetValue(key, out value);
                        request.Parameters.Add("MapOfLists" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            int valueIndex = 1;
                            foreach(var listValue in value)
                            {
                                request.Parameters.Add("MapOfLists" + "." + "entry" + "." + mapIndex + "." + "value" + "." + "member" + "." + valueIndex, StringUtils.FromString(listValue));
                                valueIndex++;
                            }
                        }
                        mapIndex++;
                    }
                }
                if(publicRequest.IsSetMapWithXmlMemberName())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.MapWithXmlMemberName.Keys)
                    {
                        String value;
                        bool hasValue = publicRequest.MapWithXmlMemberName.TryGetValue(key, out value);
                        request.Parameters.Add("MapWithXmlMemberName" + "." + "entry" + "." + mapIndex + "." + "K", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            request.Parameters.Add("MapWithXmlMemberName" + "." + "entry" + "." + mapIndex + "." + "V", StringUtils.FromString(value));
                        }
                        mapIndex++;
                    }
                }
                if(publicRequest.IsSetNestedStructWithMap())
                {
                    if(publicRequest.NestedStructWithMap.IsSetMapArg())
                    {
                        int mapIndex = 1;
                        foreach(var key in publicRequest.NestedStructWithMap.MapArg.Keys)
                        {
                            String value;
                            bool hasValue = publicRequest.NestedStructWithMap.MapArg.TryGetValue(key, out value);
                            request.Parameters.Add("NestedStructWithMap" + "." + "MapArg" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                            if (hasValue)
                            {
                                request.Parameters.Add("NestedStructWithMap" + "." + "MapArg" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                            }
                            mapIndex++;
                        }
                    }
                }
                if(publicRequest.IsSetRenamedMapArg())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.RenamedMapArg.Keys)
                    {
                        String value;
                        bool hasValue = publicRequest.RenamedMapArg.TryGetValue(key, out value);
                        request.Parameters.Add("Foo" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            request.Parameters.Add("Foo" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                        }
                        mapIndex++;
                    }
                }
            }
            return request;
        }
                    private static QueryMapsRequestMarshaller _instance = new QueryMapsRequestMarshaller();        

        internal static QueryMapsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QueryMapsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}