/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudSearchDomain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudSearchDomain.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Search Request Marshaller
    /// </summary>       
    public class SearchRequestMarshaller : IMarshaller<IRequest, SearchRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudSearchDomain");
            request.HttpMethod = "GET";

            string uriResourcePath = "/2013-01-01/search";
            request.AddSubResource("format", "sdk");
            request.AddSubResource("pretty", "true");
            
            if (publicRequest.IsSetCursor())
                request.Parameters.Add("cursor", StringUtils.FromString(publicRequest.Cursor));
            
            if (publicRequest.IsSetExpr())
                request.Parameters.Add("expr", StringUtils.FromString(publicRequest.Expr));
            
            if (publicRequest.IsSetFacet())
                request.Parameters.Add("facet", StringUtils.FromString(publicRequest.Facet));
            
            if (publicRequest.IsSetFilterQuery())
                request.Parameters.Add("fq", StringUtils.FromString(publicRequest.FilterQuery));
            
            if (publicRequest.IsSetHighlight())
                request.Parameters.Add("highlight", StringUtils.FromString(publicRequest.Highlight));
            
            if (publicRequest.IsSetPartial())
                request.Parameters.Add("partial", StringUtils.FromBool(publicRequest.Partial));
            
            if (publicRequest.IsSetQuery())
                request.Parameters.Add("q", StringUtils.FromString(publicRequest.Query));
            
            if (publicRequest.IsSetQueryOptions())
                request.Parameters.Add("q.options", StringUtils.FromString(publicRequest.QueryOptions));
            
            if (publicRequest.IsSetQueryParser())
                request.Parameters.Add("q.parser", StringUtils.FromString(publicRequest.QueryParser));
            
            if (publicRequest.IsSetReturn())
                request.Parameters.Add("return", StringUtils.FromString(publicRequest.Return));
            
            if (publicRequest.IsSetSize())
                request.Parameters.Add("size", StringUtils.FromLong(publicRequest.Size));
            
            if (publicRequest.IsSetSort())
                request.Parameters.Add("sort", StringUtils.FromString(publicRequest.Sort));
            
            if (publicRequest.IsSetStart())
                request.Parameters.Add("start", StringUtils.FromLong(publicRequest.Start));
            
            if (publicRequest.IsSetStats())
                request.Parameters.Add("stats", StringUtils.FromString(publicRequest.Stats));
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }
        private static SearchRequestMarshaller _instance = new SearchRequestMarshaller();        

        internal static SearchRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}