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
    /// Define Analysis Scheme Request Marshaller
    /// </summary>       
    public class DefineAnalysisSchemeRequestMarshaller : IMarshaller<IRequest, DefineAnalysisSchemeRequest>
    {
        public IRequest Marshall(DefineAnalysisSchemeRequest defineAnalysisSchemeRequest)
        {
            IRequest request = new DefaultRequest(defineAnalysisSchemeRequest, "AmazonCloudSearch");
            request.Parameters.Add("Action", "DefineAnalysisScheme");
            request.Parameters.Add("Version", "2013-01-01");
            if (defineAnalysisSchemeRequest != null && defineAnalysisSchemeRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(defineAnalysisSchemeRequest.DomainName));
            }
            if (defineAnalysisSchemeRequest != null)
            {
                AnalysisScheme analysisScheme = defineAnalysisSchemeRequest.AnalysisScheme;
                if (analysisScheme != null && analysisScheme.IsSetAnalysisSchemeName())
                {
                    request.Parameters.Add("AnalysisScheme.AnalysisSchemeName", StringUtils.FromString(analysisScheme.AnalysisSchemeName));
                }
                if (analysisScheme != null && analysisScheme.IsSetAnalysisSchemeLanguage())
                {
                    request.Parameters.Add("AnalysisScheme.AnalysisSchemeLanguage", StringUtils.FromString(analysisScheme.AnalysisSchemeLanguage));
                }
                if (analysisScheme != null)
                {
                    AnalysisOptions analysisOptions = analysisScheme.AnalysisOptions;
                    if (analysisOptions != null && analysisOptions.IsSetSynonyms())
                    {
                        request.Parameters.Add("AnalysisScheme.AnalysisOptions.Synonyms", StringUtils.FromString(analysisOptions.Synonyms));
                    }
                    if (analysisOptions != null && analysisOptions.IsSetStopwords())
                    {
                        request.Parameters.Add("AnalysisScheme.AnalysisOptions.Stopwords", StringUtils.FromString(analysisOptions.Stopwords));
                    }
                    if (analysisOptions != null && analysisOptions.IsSetStemmingDictionary())
                    {
                        request.Parameters.Add("AnalysisScheme.AnalysisOptions.StemmingDictionary", StringUtils.FromString(analysisOptions.StemmingDictionary));
                    }
                    if (analysisOptions != null && analysisOptions.IsSetAlgorithmicStemming())
                    {
                        request.Parameters.Add("AnalysisScheme.AnalysisOptions.AlgorithmicStemming", StringUtils.FromString(analysisOptions.AlgorithmicStemming));
                    }
                }
            }

            return request;
        }
    }
}
