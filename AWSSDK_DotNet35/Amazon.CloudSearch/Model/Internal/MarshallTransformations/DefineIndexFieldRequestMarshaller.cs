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
    /// Define Index Field Request Marshaller
    /// </summary>       
    public class DefineIndexFieldRequestMarshaller : IMarshaller<IRequest, DefineIndexFieldRequest>
    {
        public IRequest Marshall(DefineIndexFieldRequest defineIndexFieldRequest)
        {
            IRequest request = new DefaultRequest(defineIndexFieldRequest, "AmazonCloudSearch");
            request.Parameters.Add("Action", "DefineIndexField");
            request.Parameters.Add("Version", "2013-01-01");
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
                    IntOptions intOptions = indexField.IntOptions;
                    if (intOptions != null && intOptions.IsSetDefaultValue())
                    {
                        request.Parameters.Add("IndexField.IntOptions.DefaultValue", StringUtils.FromLong(intOptions.DefaultValue));
                    }
                    if (intOptions != null && intOptions.IsSetSourceField())
                    {
                        request.Parameters.Add("IndexField.IntOptions.SourceField", StringUtils.FromString(intOptions.SourceField));
                    }
                    if (intOptions != null && intOptions.IsSetFacetEnabled())
                    {
                        request.Parameters.Add("IndexField.IntOptions.FacetEnabled", StringUtils.FromBool(intOptions.FacetEnabled));
                    }
                    if (intOptions != null && intOptions.IsSetSearchEnabled())
                    {
                        request.Parameters.Add("IndexField.IntOptions.SearchEnabled", StringUtils.FromBool(intOptions.SearchEnabled));
                    }
                    if (intOptions != null && intOptions.IsSetReturnEnabled())
                    {
                        request.Parameters.Add("IndexField.IntOptions.ReturnEnabled", StringUtils.FromBool(intOptions.ReturnEnabled));
                    }
                    if (intOptions != null && intOptions.IsSetSortEnabled())
                    {
                        request.Parameters.Add("IndexField.IntOptions.SortEnabled", StringUtils.FromBool(intOptions.SortEnabled));
                    }
                }
                if (indexField != null)
                {
                    DoubleOptions doubleOptions = indexField.DoubleOptions;
                    if (doubleOptions != null && doubleOptions.IsSetDefaultValue())
                    {
                        request.Parameters.Add("IndexField.DoubleOptions.DefaultValue", StringUtils.FromDouble(doubleOptions.DefaultValue));
                    }
                    if (doubleOptions != null && doubleOptions.IsSetSourceField())
                    {
                        request.Parameters.Add("IndexField.DoubleOptions.SourceField", StringUtils.FromString(doubleOptions.SourceField));
                    }
                    if (doubleOptions != null && doubleOptions.IsSetFacetEnabled())
                    {
                        request.Parameters.Add("IndexField.DoubleOptions.FacetEnabled", StringUtils.FromBool(doubleOptions.FacetEnabled));
                    }
                    if (doubleOptions != null && doubleOptions.IsSetSearchEnabled())
                    {
                        request.Parameters.Add("IndexField.DoubleOptions.SearchEnabled", StringUtils.FromBool(doubleOptions.SearchEnabled));
                    }
                    if (doubleOptions != null && doubleOptions.IsSetReturnEnabled())
                    {
                        request.Parameters.Add("IndexField.DoubleOptions.ReturnEnabled", StringUtils.FromBool(doubleOptions.ReturnEnabled));
                    }
                    if (doubleOptions != null && doubleOptions.IsSetSortEnabled())
                    {
                        request.Parameters.Add("IndexField.DoubleOptions.SortEnabled", StringUtils.FromBool(doubleOptions.SortEnabled));
                    }
                }
                if (indexField != null)
                {
                    LiteralOptions literalOptions = indexField.LiteralOptions;
                    if (literalOptions != null && literalOptions.IsSetDefaultValue())
                    {
                        request.Parameters.Add("IndexField.LiteralOptions.DefaultValue", StringUtils.FromString(literalOptions.DefaultValue));
                    }
                    if (literalOptions != null && literalOptions.IsSetSourceField())
                    {
                        request.Parameters.Add("IndexField.LiteralOptions.SourceField", StringUtils.FromString(literalOptions.SourceField));
                    }
                    if (literalOptions != null && literalOptions.IsSetFacetEnabled())
                    {
                        request.Parameters.Add("IndexField.LiteralOptions.FacetEnabled", StringUtils.FromBool(literalOptions.FacetEnabled));
                    }
                    if (literalOptions != null && literalOptions.IsSetSearchEnabled())
                    {
                        request.Parameters.Add("IndexField.LiteralOptions.SearchEnabled", StringUtils.FromBool(literalOptions.SearchEnabled));
                    }
                    if (literalOptions != null && literalOptions.IsSetReturnEnabled())
                    {
                        request.Parameters.Add("IndexField.LiteralOptions.ReturnEnabled", StringUtils.FromBool(literalOptions.ReturnEnabled));
                    }
                    if (literalOptions != null && literalOptions.IsSetSortEnabled())
                    {
                        request.Parameters.Add("IndexField.LiteralOptions.SortEnabled", StringUtils.FromBool(literalOptions.SortEnabled));
                    }
                }
                if (indexField != null)
                {
                    TextOptions textOptions = indexField.TextOptions;
                    if (textOptions != null && textOptions.IsSetDefaultValue())
                    {
                        request.Parameters.Add("IndexField.TextOptions.DefaultValue", StringUtils.FromString(textOptions.DefaultValue));
                    }
                    if (textOptions != null && textOptions.IsSetSourceField())
                    {
                        request.Parameters.Add("IndexField.TextOptions.SourceField", StringUtils.FromString(textOptions.SourceField));
                    }
                    if (textOptions != null && textOptions.IsSetReturnEnabled())
                    {
                        request.Parameters.Add("IndexField.TextOptions.ReturnEnabled", StringUtils.FromBool(textOptions.ReturnEnabled));
                    }
                    if (textOptions != null && textOptions.IsSetSortEnabled())
                    {
                        request.Parameters.Add("IndexField.TextOptions.SortEnabled", StringUtils.FromBool(textOptions.SortEnabled));
                    }
                    if (textOptions != null && textOptions.IsSetHighlightEnabled())
                    {
                        request.Parameters.Add("IndexField.TextOptions.HighlightEnabled", StringUtils.FromBool(textOptions.HighlightEnabled));
                    }
                    if (textOptions != null && textOptions.IsSetAnalysisScheme())
                    {
                        request.Parameters.Add("IndexField.TextOptions.AnalysisScheme", StringUtils.FromString(textOptions.AnalysisScheme));
                    }
                }
                if (indexField != null)
                {
                    DateOptions dateOptions = indexField.DateOptions;
                    if (dateOptions != null && dateOptions.IsSetDefaultValue())
                    {
                        request.Parameters.Add("IndexField.DateOptions.DefaultValue", StringUtils.FromString(dateOptions.DefaultValue));
                    }
                    if (dateOptions != null && dateOptions.IsSetSourceField())
                    {
                        request.Parameters.Add("IndexField.DateOptions.SourceField", StringUtils.FromString(dateOptions.SourceField));
                    }
                    if (dateOptions != null && dateOptions.IsSetFacetEnabled())
                    {
                        request.Parameters.Add("IndexField.DateOptions.FacetEnabled", StringUtils.FromBool(dateOptions.FacetEnabled));
                    }
                    if (dateOptions != null && dateOptions.IsSetSearchEnabled())
                    {
                        request.Parameters.Add("IndexField.DateOptions.SearchEnabled", StringUtils.FromBool(dateOptions.SearchEnabled));
                    }
                    if (dateOptions != null && dateOptions.IsSetReturnEnabled())
                    {
                        request.Parameters.Add("IndexField.DateOptions.ReturnEnabled", StringUtils.FromBool(dateOptions.ReturnEnabled));
                    }
                    if (dateOptions != null && dateOptions.IsSetSortEnabled())
                    {
                        request.Parameters.Add("IndexField.DateOptions.SortEnabled", StringUtils.FromBool(dateOptions.SortEnabled));
                    }
                }
                if (indexField != null)
                {
                    LatLonOptions latLonOptions = indexField.LatLonOptions;
                    if (latLonOptions != null && latLonOptions.IsSetDefaultValue())
                    {
                        request.Parameters.Add("IndexField.LatLonOptions.DefaultValue", StringUtils.FromString(latLonOptions.DefaultValue));
                    }
                    if (latLonOptions != null && latLonOptions.IsSetSourceField())
                    {
                        request.Parameters.Add("IndexField.LatLonOptions.SourceField", StringUtils.FromString(latLonOptions.SourceField));
                    }
                    if (latLonOptions != null && latLonOptions.IsSetFacetEnabled())
                    {
                        request.Parameters.Add("IndexField.LatLonOptions.FacetEnabled", StringUtils.FromBool(latLonOptions.FacetEnabled));
                    }
                    if (latLonOptions != null && latLonOptions.IsSetSearchEnabled())
                    {
                        request.Parameters.Add("IndexField.LatLonOptions.SearchEnabled", StringUtils.FromBool(latLonOptions.SearchEnabled));
                    }
                    if (latLonOptions != null && latLonOptions.IsSetReturnEnabled())
                    {
                        request.Parameters.Add("IndexField.LatLonOptions.ReturnEnabled", StringUtils.FromBool(latLonOptions.ReturnEnabled));
                    }
                    if (latLonOptions != null && latLonOptions.IsSetSortEnabled())
                    {
                        request.Parameters.Add("IndexField.LatLonOptions.SortEnabled", StringUtils.FromBool(latLonOptions.SortEnabled));
                    }
                }
                if (indexField != null)
                {
                    IntArrayOptions intArrayOptions = indexField.IntArrayOptions;
                    if (intArrayOptions != null && intArrayOptions.IsSetDefaultValue())
                    {
                        request.Parameters.Add("IndexField.IntArrayOptions.DefaultValue", StringUtils.FromLong(intArrayOptions.DefaultValue));
                    }
                    if (intArrayOptions != null && intArrayOptions.IsSetSourceFields())
                    {
                        request.Parameters.Add("IndexField.IntArrayOptions.SourceFields", StringUtils.FromString(intArrayOptions.SourceFields));
                    }
                    if (intArrayOptions != null && intArrayOptions.IsSetFacetEnabled())
                    {
                        request.Parameters.Add("IndexField.IntArrayOptions.FacetEnabled", StringUtils.FromBool(intArrayOptions.FacetEnabled));
                    }
                    if (intArrayOptions != null && intArrayOptions.IsSetSearchEnabled())
                    {
                        request.Parameters.Add("IndexField.IntArrayOptions.SearchEnabled", StringUtils.FromBool(intArrayOptions.SearchEnabled));
                    }
                    if (intArrayOptions != null && intArrayOptions.IsSetReturnEnabled())
                    {
                        request.Parameters.Add("IndexField.IntArrayOptions.ReturnEnabled", StringUtils.FromBool(intArrayOptions.ReturnEnabled));
                    }
                }
                if (indexField != null)
                {
                    DoubleArrayOptions doubleArrayOptions = indexField.DoubleArrayOptions;
                    if (doubleArrayOptions != null && doubleArrayOptions.IsSetDefaultValue())
                    {
                        request.Parameters.Add("IndexField.DoubleArrayOptions.DefaultValue", StringUtils.FromDouble(doubleArrayOptions.DefaultValue));
                    }
                    if (doubleArrayOptions != null && doubleArrayOptions.IsSetSourceFields())
                    {
                        request.Parameters.Add("IndexField.DoubleArrayOptions.SourceFields", StringUtils.FromString(doubleArrayOptions.SourceFields));
                    }
                    if (doubleArrayOptions != null && doubleArrayOptions.IsSetFacetEnabled())
                    {
                        request.Parameters.Add("IndexField.DoubleArrayOptions.FacetEnabled", StringUtils.FromBool(doubleArrayOptions.FacetEnabled));
                    }
                    if (doubleArrayOptions != null && doubleArrayOptions.IsSetSearchEnabled())
                    {
                        request.Parameters.Add("IndexField.DoubleArrayOptions.SearchEnabled", StringUtils.FromBool(doubleArrayOptions.SearchEnabled));
                    }
                    if (doubleArrayOptions != null && doubleArrayOptions.IsSetReturnEnabled())
                    {
                        request.Parameters.Add("IndexField.DoubleArrayOptions.ReturnEnabled", StringUtils.FromBool(doubleArrayOptions.ReturnEnabled));
                    }
                }
                if (indexField != null)
                {
                    LiteralArrayOptions literalArrayOptions = indexField.LiteralArrayOptions;
                    if (literalArrayOptions != null && literalArrayOptions.IsSetDefaultValue())
                    {
                        request.Parameters.Add("IndexField.LiteralArrayOptions.DefaultValue", StringUtils.FromString(literalArrayOptions.DefaultValue));
                    }
                    if (literalArrayOptions != null && literalArrayOptions.IsSetSourceFields())
                    {
                        request.Parameters.Add("IndexField.LiteralArrayOptions.SourceFields", StringUtils.FromString(literalArrayOptions.SourceFields));
                    }
                    if (literalArrayOptions != null && literalArrayOptions.IsSetFacetEnabled())
                    {
                        request.Parameters.Add("IndexField.LiteralArrayOptions.FacetEnabled", StringUtils.FromBool(literalArrayOptions.FacetEnabled));
                    }
                    if (literalArrayOptions != null && literalArrayOptions.IsSetSearchEnabled())
                    {
                        request.Parameters.Add("IndexField.LiteralArrayOptions.SearchEnabled", StringUtils.FromBool(literalArrayOptions.SearchEnabled));
                    }
                    if (literalArrayOptions != null && literalArrayOptions.IsSetReturnEnabled())
                    {
                        request.Parameters.Add("IndexField.LiteralArrayOptions.ReturnEnabled", StringUtils.FromBool(literalArrayOptions.ReturnEnabled));
                    }
                }
                if (indexField != null)
                {
                    TextArrayOptions textArrayOptions = indexField.TextArrayOptions;
                    if (textArrayOptions != null && textArrayOptions.IsSetDefaultValue())
                    {
                        request.Parameters.Add("IndexField.TextArrayOptions.DefaultValue", StringUtils.FromString(textArrayOptions.DefaultValue));
                    }
                    if (textArrayOptions != null && textArrayOptions.IsSetSourceFields())
                    {
                        request.Parameters.Add("IndexField.TextArrayOptions.SourceFields", StringUtils.FromString(textArrayOptions.SourceFields));
                    }
                    if (textArrayOptions != null && textArrayOptions.IsSetReturnEnabled())
                    {
                        request.Parameters.Add("IndexField.TextArrayOptions.ReturnEnabled", StringUtils.FromBool(textArrayOptions.ReturnEnabled));
                    }
                    if (textArrayOptions != null && textArrayOptions.IsSetHighlightEnabled())
                    {
                        request.Parameters.Add("IndexField.TextArrayOptions.HighlightEnabled", StringUtils.FromBool(textArrayOptions.HighlightEnabled));
                    }
                    if (textArrayOptions != null && textArrayOptions.IsSetAnalysisScheme())
                    {
                        request.Parameters.Add("IndexField.TextArrayOptions.AnalysisScheme", StringUtils.FromString(textArrayOptions.AnalysisScheme));
                    }
                }
                if (indexField != null)
                {
                    DateArrayOptions dateArrayOptions = indexField.DateArrayOptions;
                    if (dateArrayOptions != null && dateArrayOptions.IsSetDefaultValue())
                    {
                        request.Parameters.Add("IndexField.DateArrayOptions.DefaultValue", StringUtils.FromString(dateArrayOptions.DefaultValue));
                    }
                    if (dateArrayOptions != null && dateArrayOptions.IsSetSourceFields())
                    {
                        request.Parameters.Add("IndexField.DateArrayOptions.SourceFields", StringUtils.FromString(dateArrayOptions.SourceFields));
                    }
                    if (dateArrayOptions != null && dateArrayOptions.IsSetFacetEnabled())
                    {
                        request.Parameters.Add("IndexField.DateArrayOptions.FacetEnabled", StringUtils.FromBool(dateArrayOptions.FacetEnabled));
                    }
                    if (dateArrayOptions != null && dateArrayOptions.IsSetSearchEnabled())
                    {
                        request.Parameters.Add("IndexField.DateArrayOptions.SearchEnabled", StringUtils.FromBool(dateArrayOptions.SearchEnabled));
                    }
                    if (dateArrayOptions != null && dateArrayOptions.IsSetReturnEnabled())
                    {
                        request.Parameters.Add("IndexField.DateArrayOptions.ReturnEnabled", StringUtils.FromBool(dateArrayOptions.ReturnEnabled));
                    }
                }
            }

            return request;
        }
    }
}
