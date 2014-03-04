/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Define Index Field Request Marshaller
    /// </summary>       
    public class DefineIndexFieldRequestMarshaller : IMarshaller<IRequest, DefineIndexFieldRequest>
    {
        public IRequest Marshall(DefineIndexFieldRequest defineIndexFieldRequest)
        {
            IRequest request = new DefaultRequest(defineIndexFieldRequest, "AmazonCloudSearch");
            request.Parameters.Add("Action", "DefineIndexField");
            request.Parameters.Add("Version", "2011-02-01");
            if (defineIndexFieldRequest != null && defineIndexFieldRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(defineIndexFieldRequest.DomainName));
            }
            if (defineIndexFieldRequest != null)
            {
                IndexField indexField = defineIndexFieldRequest.IndexField;
                if (indexField != null && indexField.IsSetIndexFieldName())
                {
                    request.Parameters.Add("IndexField.IndexFieldName", StringUtils.FromString(indexField.IndexFieldName));
                }
                if (indexField != null && indexField.IsSetIndexFieldType())
                {
                    request.Parameters.Add("IndexField.IndexFieldType", StringUtils.FromString(indexField.IndexFieldType));
                }
                if (indexField != null)
                {
                    UIntOptions uIntOptions = indexField.UIntOptions;
                    if (uIntOptions != null && uIntOptions.IsSetDefaultValue())
                    {
                        request.Parameters.Add("IndexField.UIntOptions.DefaultValue", StringUtils.FromInt(uIntOptions.DefaultValue));
                    }
                }
                if (indexField != null)
                {
                    LiteralOptions literalOptions = indexField.LiteralOptions;
                    if (literalOptions != null && literalOptions.IsSetDefaultValue())
                    {
                        request.Parameters.Add("IndexField.LiteralOptions.DefaultValue", StringUtils.FromString(literalOptions.DefaultValue));
                    }
                    if (literalOptions != null && literalOptions.IsSetSearchEnabled())
                    {
                        request.Parameters.Add("IndexField.LiteralOptions.SearchEnabled", StringUtils.FromBool(literalOptions.SearchEnabled));
                    }
                    if (literalOptions != null && literalOptions.IsSetFacetEnabled())
                    {
                        request.Parameters.Add("IndexField.LiteralOptions.FacetEnabled", StringUtils.FromBool(literalOptions.FacetEnabled));
                    }
                    if (literalOptions != null && literalOptions.IsSetResultEnabled())
                    {
                        request.Parameters.Add("IndexField.LiteralOptions.ResultEnabled", StringUtils.FromBool(literalOptions.ResultEnabled));
                    }
                }
                if (indexField != null)
                {
                    TextOptions textOptions = indexField.TextOptions;
                    if (textOptions != null && textOptions.IsSetDefaultValue())
                    {
                        request.Parameters.Add("IndexField.TextOptions.DefaultValue", StringUtils.FromString(textOptions.DefaultValue));
                    }
                    if (textOptions != null && textOptions.IsSetFacetEnabled())
                    {
                        request.Parameters.Add("IndexField.TextOptions.FacetEnabled", StringUtils.FromBool(textOptions.FacetEnabled));
                    }
                    if (textOptions != null && textOptions.IsSetResultEnabled())
                    {
                        request.Parameters.Add("IndexField.TextOptions.ResultEnabled", StringUtils.FromBool(textOptions.ResultEnabled));
                    }
                    if (textOptions != null && textOptions.IsSetTextProcessor())
                    {
                        request.Parameters.Add("IndexField.TextOptions.TextProcessor", StringUtils.FromString(textOptions.TextProcessor));
                    }
                }

                if (indexField != null)
                {
                    List<SourceAttribute> sourceAttributesList = indexField.SourceAttributes;
                    int sourceAttributesListIndex = 1;
                    foreach (SourceAttribute sourceAttributesListValue in sourceAttributesList)
                    {
                        if (sourceAttributesListValue != null && sourceAttributesListValue.IsSetSourceDataFunction())
                        {
                            request.Parameters.Add("IndexField.SourceAttributes.member." + sourceAttributesListIndex + ".SourceDataFunction", StringUtils.FromString(sourceAttributesListValue.SourceDataFunction));
                        }
                        if (sourceAttributesListValue != null)
                        {
                            SourceData sourceDataCopy = sourceAttributesListValue.SourceDataCopy;
                            if (sourceDataCopy != null && sourceDataCopy.IsSetSourceName())
                            {
                                request.Parameters.Add("IndexField.SourceAttributes.member." + sourceAttributesListIndex + ".SourceDataCopy.SourceName", StringUtils.FromString(sourceDataCopy.SourceName));
                            }
                            if (sourceDataCopy != null && sourceDataCopy.IsSetDefaultValue())
                            {
                                request.Parameters.Add("IndexField.SourceAttributes.member." + sourceAttributesListIndex + ".SourceDataCopy.DefaultValue", StringUtils.FromString(sourceDataCopy.DefaultValue));
                            }
                        }
                        if (sourceAttributesListValue != null)
                        {
                            SourceDataTrimTitle sourceDataTrimTitle = sourceAttributesListValue.SourceDataTrimTitle;
                            if (sourceDataTrimTitle != null && sourceDataTrimTitle.IsSetSourceName())
                            {
                                request.Parameters.Add("IndexField.SourceAttributes.member." + sourceAttributesListIndex + ".SourceDataTrimTitle.SourceName", StringUtils.FromString(sourceDataTrimTitle.SourceName));
                            }
                            if (sourceDataTrimTitle != null && sourceDataTrimTitle.IsSetDefaultValue())
                            {
                                request.Parameters.Add("IndexField.SourceAttributes.member." + sourceAttributesListIndex + ".SourceDataTrimTitle.DefaultValue", StringUtils.FromString(sourceDataTrimTitle.DefaultValue));
                            }
                            if (sourceDataTrimTitle != null && sourceDataTrimTitle.IsSetSeparator())
                            {
                                request.Parameters.Add("IndexField.SourceAttributes.member." + sourceAttributesListIndex + ".SourceDataTrimTitle.Separator", StringUtils.FromString(sourceDataTrimTitle.Separator));
                            }
                            if (sourceDataTrimTitle != null && sourceDataTrimTitle.IsSetLanguage())
                            {
                                request.Parameters.Add("IndexField.SourceAttributes.member." + sourceAttributesListIndex + ".SourceDataTrimTitle.Language", StringUtils.FromString(sourceDataTrimTitle.Language));
                            }
                        }
                        if (sourceAttributesListValue != null)
                        {
                            SourceDataMap sourceDataMap = sourceAttributesListValue.SourceDataMap;
                            if (sourceDataMap != null && sourceDataMap.IsSetSourceName())
                            {
                                request.Parameters.Add("IndexField.SourceAttributes.member." + sourceAttributesListIndex + ".SourceDataMap.SourceName", StringUtils.FromString(sourceDataMap.SourceName));
                            }
                            if (sourceDataMap != null && sourceDataMap.IsSetDefaultValue())
                            {
                                request.Parameters.Add("IndexField.SourceAttributes.member." + sourceAttributesListIndex + ".SourceDataMap.DefaultValue", StringUtils.FromString(sourceDataMap.DefaultValue));
                            }
                            if (sourceDataMap != null)
                            {
                                if (sourceDataMap.Cases != null)
                                {
                                    int casesListIndex = 1;
                                    foreach (string key in sourceDataMap.Cases.Keys)
                                    {
                                        string value;
                                        bool hasValue = sourceDataMap.Cases.TryGetValue(key, out value);
                                        request.Parameters.Add("sourceDataMap.entry." + casesListIndex + ".key", StringUtils.FromString(key));
                                        if (hasValue) 
                                        {
                                            request.Parameters.Add("sourceDataMap.entry." + casesListIndex + ".value", StringUtils.FromString(value));
                                        }
                                        ++casesListIndex;
                                    }
                                }
                            }
                        }

                        sourceAttributesListIndex++;
                    }
                }
            }

            return request;
        }
    }
}
