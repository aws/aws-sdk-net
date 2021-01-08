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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DefineSuggester Request Marshaller
    /// </summary>       
    public class DefineSuggesterRequestMarshaller : IMarshaller<IRequest, DefineSuggesterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DefineSuggesterRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DefineSuggesterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudSearch");
            request.Parameters.Add("Action", "DefineSuggester");
            request.Parameters.Add("Version", "2013-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDomainName())
                {
                    request.Parameters.Add("DomainName", StringUtils.FromString(publicRequest.DomainName));
                }
                if(publicRequest.IsSetSuggester())
                {
                    if(publicRequest.Suggester.IsSetDocumentSuggesterOptions())
                    {
                        if(publicRequest.Suggester.DocumentSuggesterOptions.IsSetFuzzyMatching())
                        {
                            request.Parameters.Add("Suggester" + "." + "DocumentSuggesterOptions" + "." + "FuzzyMatching", StringUtils.FromString(publicRequest.Suggester.DocumentSuggesterOptions.FuzzyMatching));
                        }
                        if(publicRequest.Suggester.DocumentSuggesterOptions.IsSetSortExpression())
                        {
                            request.Parameters.Add("Suggester" + "." + "DocumentSuggesterOptions" + "." + "SortExpression", StringUtils.FromString(publicRequest.Suggester.DocumentSuggesterOptions.SortExpression));
                        }
                        if(publicRequest.Suggester.DocumentSuggesterOptions.IsSetSourceField())
                        {
                            request.Parameters.Add("Suggester" + "." + "DocumentSuggesterOptions" + "." + "SourceField", StringUtils.FromString(publicRequest.Suggester.DocumentSuggesterOptions.SourceField));
                        }
                    }
                    if(publicRequest.Suggester.IsSetSuggesterName())
                    {
                        request.Parameters.Add("Suggester" + "." + "SuggesterName", StringUtils.FromString(publicRequest.Suggester.SuggesterName));
                    }
                }
            }
            return request;
        }
                    private static DefineSuggesterRequestMarshaller _instance = new DefineSuggesterRequestMarshaller();        

        internal static DefineSuggesterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DefineSuggesterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}