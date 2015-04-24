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
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudSearch_2011_02_01.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.CloudSearch_2011_02_01.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DefineIndexField Request Marshaller
    /// </summary>       
    public class DefineIndexFieldRequestMarshaller : IMarshaller<IRequest, DefineIndexFieldRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DefineIndexFieldRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DefineIndexFieldRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudSearch_2011_02_01");
            request.Parameters.Add("Action", "DefineIndexField");
            request.Parameters.Add("Version", "2011-02-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDomainName())
                {
                    request.Parameters.Add("DomainName", StringUtils.FromString(publicRequest.DomainName));
                }
                if(publicRequest.IsSetIndexField())
                {
                    if(publicRequest.IndexField.IsSetIndexFieldName())
                    {
                        request.Parameters.Add("IndexField" + "." + "IndexFieldName", StringUtils.FromString(publicRequest.IndexField.IndexFieldName));
                    }
                    if(publicRequest.IndexField.IsSetIndexFieldType())
                    {
                        request.Parameters.Add("IndexField" + "." + "IndexFieldType", StringUtils.FromString(publicRequest.IndexField.IndexFieldType));
                    }
                    if(publicRequest.IndexField.IsSetLiteralOptions())
                    {
                        if(publicRequest.IndexField.LiteralOptions.IsSetDefaultValue())
                        {
                            request.Parameters.Add("IndexField" + "." + "LiteralOptions" + "." + "DefaultValue", StringUtils.FromString(publicRequest.IndexField.LiteralOptions.DefaultValue));
                        }
                        if(publicRequest.IndexField.LiteralOptions.IsSetFacetEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "LiteralOptions" + "." + "FacetEnabled", StringUtils.FromBool(publicRequest.IndexField.LiteralOptions.FacetEnabled));
                        }
                        if(publicRequest.IndexField.LiteralOptions.IsSetResultEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "LiteralOptions" + "." + "ResultEnabled", StringUtils.FromBool(publicRequest.IndexField.LiteralOptions.ResultEnabled));
                        }
                        if(publicRequest.IndexField.LiteralOptions.IsSetSearchEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "LiteralOptions" + "." + "SearchEnabled", StringUtils.FromBool(publicRequest.IndexField.LiteralOptions.SearchEnabled));
                        }
                    }
                    if(publicRequest.IndexField.IsSetSourceAttributes())
                    {
                        int publicRequestIndexFieldlistValueIndex = 1;
                        foreach(var publicRequestIndexFieldlistValue in publicRequest.IndexField.SourceAttributes)
                        {
                            if(publicRequestIndexFieldlistValue.IsSetSourceDataCopy())
                            {
                                if(publicRequestIndexFieldlistValue.SourceDataCopy.IsSetDefaultValue())
                                {
                                    request.Parameters.Add("IndexField" + "." + "SourceAttributes" + "." + "member" + "." + publicRequestIndexFieldlistValueIndex + "." + "SourceDataCopy" + "." + "DefaultValue", StringUtils.FromString(publicRequestIndexFieldlistValue.SourceDataCopy.DefaultValue));
                                }
                                if(publicRequestIndexFieldlistValue.SourceDataCopy.IsSetSourceName())
                                {
                                    request.Parameters.Add("IndexField" + "." + "SourceAttributes" + "." + "member" + "." + publicRequestIndexFieldlistValueIndex + "." + "SourceDataCopy" + "." + "SourceName", StringUtils.FromString(publicRequestIndexFieldlistValue.SourceDataCopy.SourceName));
                                }
                            }
                            if(publicRequestIndexFieldlistValue.IsSetSourceDataFunction())
                            {
                                request.Parameters.Add("IndexField" + "." + "SourceAttributes" + "." + "member" + "." + publicRequestIndexFieldlistValueIndex + "." + "SourceDataFunction", StringUtils.FromString(publicRequestIndexFieldlistValue.SourceDataFunction));
                            }
                            if(publicRequestIndexFieldlistValue.IsSetSourceDataMap())
                            {
                                if(publicRequestIndexFieldlistValue.SourceDataMap.IsSetCases())
                                {
                                    int mapIndex = 1;
                                    foreach(var key in publicRequestIndexFieldlistValue.SourceDataMap.Cases.Keys)
                                    {
                                        String value;
                                        bool hasValue = publicRequestIndexFieldlistValue.SourceDataMap.Cases.TryGetValue(key, out value);
                                        request.Parameters.Add("IndexField" + "." + "SourceAttributes" + "." + "member" + "." + publicRequestIndexFieldlistValueIndex + "." + "SourceDataMap" + "." + "Cases" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                                        if (hasValue)
                                        {
                                            request.Parameters.Add("IndexField" + "." + "SourceAttributes" + "." + "member" + "." + publicRequestIndexFieldlistValueIndex + "." + "SourceDataMap" + "." + "Cases" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                                        }
                                        mapIndex++;
                                    }
                                }
                                if(publicRequestIndexFieldlistValue.SourceDataMap.IsSetDefaultValue())
                                {
                                    request.Parameters.Add("IndexField" + "." + "SourceAttributes" + "." + "member" + "." + publicRequestIndexFieldlistValueIndex + "." + "SourceDataMap" + "." + "DefaultValue", StringUtils.FromString(publicRequestIndexFieldlistValue.SourceDataMap.DefaultValue));
                                }
                                if(publicRequestIndexFieldlistValue.SourceDataMap.IsSetSourceName())
                                {
                                    request.Parameters.Add("IndexField" + "." + "SourceAttributes" + "." + "member" + "." + publicRequestIndexFieldlistValueIndex + "." + "SourceDataMap" + "." + "SourceName", StringUtils.FromString(publicRequestIndexFieldlistValue.SourceDataMap.SourceName));
                                }
                            }
                            if(publicRequestIndexFieldlistValue.IsSetSourceDataTrimTitle())
                            {
                                if(publicRequestIndexFieldlistValue.SourceDataTrimTitle.IsSetDefaultValue())
                                {
                                    request.Parameters.Add("IndexField" + "." + "SourceAttributes" + "." + "member" + "." + publicRequestIndexFieldlistValueIndex + "." + "SourceDataTrimTitle" + "." + "DefaultValue", StringUtils.FromString(publicRequestIndexFieldlistValue.SourceDataTrimTitle.DefaultValue));
                                }
                                if(publicRequestIndexFieldlistValue.SourceDataTrimTitle.IsSetLanguage())
                                {
                                    request.Parameters.Add("IndexField" + "." + "SourceAttributes" + "." + "member" + "." + publicRequestIndexFieldlistValueIndex + "." + "SourceDataTrimTitle" + "." + "Language", StringUtils.FromString(publicRequestIndexFieldlistValue.SourceDataTrimTitle.Language));
                                }
                                if(publicRequestIndexFieldlistValue.SourceDataTrimTitle.IsSetSeparator())
                                {
                                    request.Parameters.Add("IndexField" + "." + "SourceAttributes" + "." + "member" + "." + publicRequestIndexFieldlistValueIndex + "." + "SourceDataTrimTitle" + "." + "Separator", StringUtils.FromString(publicRequestIndexFieldlistValue.SourceDataTrimTitle.Separator));
                                }
                                if(publicRequestIndexFieldlistValue.SourceDataTrimTitle.IsSetSourceName())
                                {
                                    request.Parameters.Add("IndexField" + "." + "SourceAttributes" + "." + "member" + "." + publicRequestIndexFieldlistValueIndex + "." + "SourceDataTrimTitle" + "." + "SourceName", StringUtils.FromString(publicRequestIndexFieldlistValue.SourceDataTrimTitle.SourceName));
                                }
                            }
                            publicRequestIndexFieldlistValueIndex++;
                        }
                    }
                    if(publicRequest.IndexField.IsSetTextOptions())
                    {
                        if(publicRequest.IndexField.TextOptions.IsSetDefaultValue())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextOptions" + "." + "DefaultValue", StringUtils.FromString(publicRequest.IndexField.TextOptions.DefaultValue));
                        }
                        if(publicRequest.IndexField.TextOptions.IsSetFacetEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextOptions" + "." + "FacetEnabled", StringUtils.FromBool(publicRequest.IndexField.TextOptions.FacetEnabled));
                        }
                        if(publicRequest.IndexField.TextOptions.IsSetResultEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextOptions" + "." + "ResultEnabled", StringUtils.FromBool(publicRequest.IndexField.TextOptions.ResultEnabled));
                        }
                        if(publicRequest.IndexField.TextOptions.IsSetTextProcessor())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextOptions" + "." + "TextProcessor", StringUtils.FromString(publicRequest.IndexField.TextOptions.TextProcessor));
                        }
                    }
                    if(publicRequest.IndexField.IsSetUIntOptions())
                    {
                        if(publicRequest.IndexField.UIntOptions.IsSetDefaultValue())
                        {
                            request.Parameters.Add("IndexField" + "." + "UIntOptions" + "." + "DefaultValue", StringUtils.FromInt(publicRequest.IndexField.UIntOptions.DefaultValue));
                        }
                    }
                }
            }
            return request;
        }
    }
}