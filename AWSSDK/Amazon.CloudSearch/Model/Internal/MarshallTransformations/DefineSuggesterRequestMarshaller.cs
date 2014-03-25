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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.CloudSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Define Suggester Request Marshaller
    /// </summary>       
    public class DefineSuggesterRequestMarshaller : IMarshaller<IRequest, DefineSuggesterRequest>
    {
        public IRequest Marshall(DefineSuggesterRequest defineSuggesterRequest)
        {
            IRequest request = new DefaultRequest(defineSuggesterRequest, "AmazonCloudSearch");
            request.Parameters.Add("Action", "DefineSuggester");
            request.Parameters.Add("Version", "2013-01-01");
            if (defineSuggesterRequest != null && defineSuggesterRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(defineSuggesterRequest.DomainName));
            }
            if (defineSuggesterRequest != null)
            {
                Suggester suggester = defineSuggesterRequest.Suggester;
                if (suggester != null && suggester.IsSetSuggesterName())
                {
                    request.Parameters.Add("Suggester.SuggesterName", StringUtils.FromString(suggester.SuggesterName));
                }
                if (suggester != null)
                {
                    DocumentSuggesterOptions documentSuggesterOptions = suggester.DocumentSuggesterOptions;
                    if (documentSuggesterOptions != null && documentSuggesterOptions.IsSetSourceField())
                    {
                        request.Parameters.Add("Suggester.DocumentSuggesterOptions.SourceField", StringUtils.FromString(documentSuggesterOptions.SourceField));
                    }
                    if (documentSuggesterOptions != null && documentSuggesterOptions.IsSetFuzzyMatching())
                    {
                        request.Parameters.Add("Suggester.DocumentSuggesterOptions.FuzzyMatching", StringUtils.FromString(documentSuggesterOptions.FuzzyMatching));
                    }
                    if (documentSuggesterOptions != null && documentSuggesterOptions.IsSetSortExpression())
                    {
                        request.Parameters.Add("Suggester.DocumentSuggesterOptions.SortExpression", StringUtils.FromString(documentSuggesterOptions.SortExpression));
                    }
                }
            }

            return request;
        }
    }
}
