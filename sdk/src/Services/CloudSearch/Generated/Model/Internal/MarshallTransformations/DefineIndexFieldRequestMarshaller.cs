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
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudSearch");
            request.Parameters.Add("Action", "DefineIndexField");
            request.Parameters.Add("Version", "2013-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDomainName())
                {
                    request.Parameters.Add("DomainName", StringUtils.FromString(publicRequest.DomainName));
                }
                if(publicRequest.IsSetIndexField())
                {
                    if(publicRequest.IndexField.IsSetDateArrayOptions())
                    {
                        if(publicRequest.IndexField.DateArrayOptions.IsSetDefaultValue())
                        {
                            request.Parameters.Add("IndexField" + "." + "DateArrayOptions" + "." + "DefaultValue", StringUtils.FromString(publicRequest.IndexField.DateArrayOptions.DefaultValue));
                        }
                        if(publicRequest.IndexField.DateArrayOptions.IsSetFacetEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "DateArrayOptions" + "." + "FacetEnabled", StringUtils.FromBool(publicRequest.IndexField.DateArrayOptions.FacetEnabled));
                        }
                        if(publicRequest.IndexField.DateArrayOptions.IsSetReturnEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "DateArrayOptions" + "." + "ReturnEnabled", StringUtils.FromBool(publicRequest.IndexField.DateArrayOptions.ReturnEnabled));
                        }
                        if(publicRequest.IndexField.DateArrayOptions.IsSetSearchEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "DateArrayOptions" + "." + "SearchEnabled", StringUtils.FromBool(publicRequest.IndexField.DateArrayOptions.SearchEnabled));
                        }
                        if(publicRequest.IndexField.DateArrayOptions.IsSetSourceFields())
                        {
                            request.Parameters.Add("IndexField" + "." + "DateArrayOptions" + "." + "SourceFields", StringUtils.FromString(publicRequest.IndexField.DateArrayOptions.SourceFields));
                        }
                    }
                    if(publicRequest.IndexField.IsSetDateOptions())
                    {
                        if(publicRequest.IndexField.DateOptions.IsSetDefaultValue())
                        {
                            request.Parameters.Add("IndexField" + "." + "DateOptions" + "." + "DefaultValue", StringUtils.FromString(publicRequest.IndexField.DateOptions.DefaultValue));
                        }
                        if(publicRequest.IndexField.DateOptions.IsSetFacetEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "DateOptions" + "." + "FacetEnabled", StringUtils.FromBool(publicRequest.IndexField.DateOptions.FacetEnabled));
                        }
                        if(publicRequest.IndexField.DateOptions.IsSetReturnEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "DateOptions" + "." + "ReturnEnabled", StringUtils.FromBool(publicRequest.IndexField.DateOptions.ReturnEnabled));
                        }
                        if(publicRequest.IndexField.DateOptions.IsSetSearchEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "DateOptions" + "." + "SearchEnabled", StringUtils.FromBool(publicRequest.IndexField.DateOptions.SearchEnabled));
                        }
                        if(publicRequest.IndexField.DateOptions.IsSetSortEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "DateOptions" + "." + "SortEnabled", StringUtils.FromBool(publicRequest.IndexField.DateOptions.SortEnabled));
                        }
                        if(publicRequest.IndexField.DateOptions.IsSetSourceField())
                        {
                            request.Parameters.Add("IndexField" + "." + "DateOptions" + "." + "SourceField", StringUtils.FromString(publicRequest.IndexField.DateOptions.SourceField));
                        }
                    }
                    if(publicRequest.IndexField.IsSetDoubleArrayOptions())
                    {
                        if(publicRequest.IndexField.DoubleArrayOptions.IsSetDefaultValue())
                        {
                            request.Parameters.Add("IndexField" + "." + "DoubleArrayOptions" + "." + "DefaultValue", StringUtils.FromDouble(publicRequest.IndexField.DoubleArrayOptions.DefaultValue));
                        }
                        if(publicRequest.IndexField.DoubleArrayOptions.IsSetFacetEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "DoubleArrayOptions" + "." + "FacetEnabled", StringUtils.FromBool(publicRequest.IndexField.DoubleArrayOptions.FacetEnabled));
                        }
                        if(publicRequest.IndexField.DoubleArrayOptions.IsSetReturnEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "DoubleArrayOptions" + "." + "ReturnEnabled", StringUtils.FromBool(publicRequest.IndexField.DoubleArrayOptions.ReturnEnabled));
                        }
                        if(publicRequest.IndexField.DoubleArrayOptions.IsSetSearchEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "DoubleArrayOptions" + "." + "SearchEnabled", StringUtils.FromBool(publicRequest.IndexField.DoubleArrayOptions.SearchEnabled));
                        }
                        if(publicRequest.IndexField.DoubleArrayOptions.IsSetSourceFields())
                        {
                            request.Parameters.Add("IndexField" + "." + "DoubleArrayOptions" + "." + "SourceFields", StringUtils.FromString(publicRequest.IndexField.DoubleArrayOptions.SourceFields));
                        }
                    }
                    if(publicRequest.IndexField.IsSetDoubleOptions())
                    {
                        if(publicRequest.IndexField.DoubleOptions.IsSetDefaultValue())
                        {
                            request.Parameters.Add("IndexField" + "." + "DoubleOptions" + "." + "DefaultValue", StringUtils.FromDouble(publicRequest.IndexField.DoubleOptions.DefaultValue));
                        }
                        if(publicRequest.IndexField.DoubleOptions.IsSetFacetEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "DoubleOptions" + "." + "FacetEnabled", StringUtils.FromBool(publicRequest.IndexField.DoubleOptions.FacetEnabled));
                        }
                        if(publicRequest.IndexField.DoubleOptions.IsSetReturnEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "DoubleOptions" + "." + "ReturnEnabled", StringUtils.FromBool(publicRequest.IndexField.DoubleOptions.ReturnEnabled));
                        }
                        if(publicRequest.IndexField.DoubleOptions.IsSetSearchEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "DoubleOptions" + "." + "SearchEnabled", StringUtils.FromBool(publicRequest.IndexField.DoubleOptions.SearchEnabled));
                        }
                        if(publicRequest.IndexField.DoubleOptions.IsSetSortEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "DoubleOptions" + "." + "SortEnabled", StringUtils.FromBool(publicRequest.IndexField.DoubleOptions.SortEnabled));
                        }
                        if(publicRequest.IndexField.DoubleOptions.IsSetSourceField())
                        {
                            request.Parameters.Add("IndexField" + "." + "DoubleOptions" + "." + "SourceField", StringUtils.FromString(publicRequest.IndexField.DoubleOptions.SourceField));
                        }
                    }
                    if(publicRequest.IndexField.IsSetIndexFieldName())
                    {
                        request.Parameters.Add("IndexField" + "." + "IndexFieldName", StringUtils.FromString(publicRequest.IndexField.IndexFieldName));
                    }
                    if(publicRequest.IndexField.IsSetIndexFieldType())
                    {
                        request.Parameters.Add("IndexField" + "." + "IndexFieldType", StringUtils.FromString(publicRequest.IndexField.IndexFieldType));
                    }
                    if(publicRequest.IndexField.IsSetIntArrayOptions())
                    {
                        if(publicRequest.IndexField.IntArrayOptions.IsSetDefaultValue())
                        {
                            request.Parameters.Add("IndexField" + "." + "IntArrayOptions" + "." + "DefaultValue", StringUtils.FromLong(publicRequest.IndexField.IntArrayOptions.DefaultValue));
                        }
                        if(publicRequest.IndexField.IntArrayOptions.IsSetFacetEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "IntArrayOptions" + "." + "FacetEnabled", StringUtils.FromBool(publicRequest.IndexField.IntArrayOptions.FacetEnabled));
                        }
                        if(publicRequest.IndexField.IntArrayOptions.IsSetReturnEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "IntArrayOptions" + "." + "ReturnEnabled", StringUtils.FromBool(publicRequest.IndexField.IntArrayOptions.ReturnEnabled));
                        }
                        if(publicRequest.IndexField.IntArrayOptions.IsSetSearchEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "IntArrayOptions" + "." + "SearchEnabled", StringUtils.FromBool(publicRequest.IndexField.IntArrayOptions.SearchEnabled));
                        }
                        if(publicRequest.IndexField.IntArrayOptions.IsSetSourceFields())
                        {
                            request.Parameters.Add("IndexField" + "." + "IntArrayOptions" + "." + "SourceFields", StringUtils.FromString(publicRequest.IndexField.IntArrayOptions.SourceFields));
                        }
                    }
                    if(publicRequest.IndexField.IsSetIntOptions())
                    {
                        if(publicRequest.IndexField.IntOptions.IsSetDefaultValue())
                        {
                            request.Parameters.Add("IndexField" + "." + "IntOptions" + "." + "DefaultValue", StringUtils.FromLong(publicRequest.IndexField.IntOptions.DefaultValue));
                        }
                        if(publicRequest.IndexField.IntOptions.IsSetFacetEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "IntOptions" + "." + "FacetEnabled", StringUtils.FromBool(publicRequest.IndexField.IntOptions.FacetEnabled));
                        }
                        if(publicRequest.IndexField.IntOptions.IsSetReturnEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "IntOptions" + "." + "ReturnEnabled", StringUtils.FromBool(publicRequest.IndexField.IntOptions.ReturnEnabled));
                        }
                        if(publicRequest.IndexField.IntOptions.IsSetSearchEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "IntOptions" + "." + "SearchEnabled", StringUtils.FromBool(publicRequest.IndexField.IntOptions.SearchEnabled));
                        }
                        if(publicRequest.IndexField.IntOptions.IsSetSortEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "IntOptions" + "." + "SortEnabled", StringUtils.FromBool(publicRequest.IndexField.IntOptions.SortEnabled));
                        }
                        if(publicRequest.IndexField.IntOptions.IsSetSourceField())
                        {
                            request.Parameters.Add("IndexField" + "." + "IntOptions" + "." + "SourceField", StringUtils.FromString(publicRequest.IndexField.IntOptions.SourceField));
                        }
                    }
                    if(publicRequest.IndexField.IsSetLatLonOptions())
                    {
                        if(publicRequest.IndexField.LatLonOptions.IsSetDefaultValue())
                        {
                            request.Parameters.Add("IndexField" + "." + "LatLonOptions" + "." + "DefaultValue", StringUtils.FromString(publicRequest.IndexField.LatLonOptions.DefaultValue));
                        }
                        if(publicRequest.IndexField.LatLonOptions.IsSetFacetEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "LatLonOptions" + "." + "FacetEnabled", StringUtils.FromBool(publicRequest.IndexField.LatLonOptions.FacetEnabled));
                        }
                        if(publicRequest.IndexField.LatLonOptions.IsSetReturnEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "LatLonOptions" + "." + "ReturnEnabled", StringUtils.FromBool(publicRequest.IndexField.LatLonOptions.ReturnEnabled));
                        }
                        if(publicRequest.IndexField.LatLonOptions.IsSetSearchEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "LatLonOptions" + "." + "SearchEnabled", StringUtils.FromBool(publicRequest.IndexField.LatLonOptions.SearchEnabled));
                        }
                        if(publicRequest.IndexField.LatLonOptions.IsSetSortEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "LatLonOptions" + "." + "SortEnabled", StringUtils.FromBool(publicRequest.IndexField.LatLonOptions.SortEnabled));
                        }
                        if(publicRequest.IndexField.LatLonOptions.IsSetSourceField())
                        {
                            request.Parameters.Add("IndexField" + "." + "LatLonOptions" + "." + "SourceField", StringUtils.FromString(publicRequest.IndexField.LatLonOptions.SourceField));
                        }
                    }
                    if(publicRequest.IndexField.IsSetLiteralArrayOptions())
                    {
                        if(publicRequest.IndexField.LiteralArrayOptions.IsSetDefaultValue())
                        {
                            request.Parameters.Add("IndexField" + "." + "LiteralArrayOptions" + "." + "DefaultValue", StringUtils.FromString(publicRequest.IndexField.LiteralArrayOptions.DefaultValue));
                        }
                        if(publicRequest.IndexField.LiteralArrayOptions.IsSetFacetEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "LiteralArrayOptions" + "." + "FacetEnabled", StringUtils.FromBool(publicRequest.IndexField.LiteralArrayOptions.FacetEnabled));
                        }
                        if(publicRequest.IndexField.LiteralArrayOptions.IsSetReturnEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "LiteralArrayOptions" + "." + "ReturnEnabled", StringUtils.FromBool(publicRequest.IndexField.LiteralArrayOptions.ReturnEnabled));
                        }
                        if(publicRequest.IndexField.LiteralArrayOptions.IsSetSearchEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "LiteralArrayOptions" + "." + "SearchEnabled", StringUtils.FromBool(publicRequest.IndexField.LiteralArrayOptions.SearchEnabled));
                        }
                        if(publicRequest.IndexField.LiteralArrayOptions.IsSetSourceFields())
                        {
                            request.Parameters.Add("IndexField" + "." + "LiteralArrayOptions" + "." + "SourceFields", StringUtils.FromString(publicRequest.IndexField.LiteralArrayOptions.SourceFields));
                        }
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
                        if(publicRequest.IndexField.LiteralOptions.IsSetReturnEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "LiteralOptions" + "." + "ReturnEnabled", StringUtils.FromBool(publicRequest.IndexField.LiteralOptions.ReturnEnabled));
                        }
                        if(publicRequest.IndexField.LiteralOptions.IsSetSearchEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "LiteralOptions" + "." + "SearchEnabled", StringUtils.FromBool(publicRequest.IndexField.LiteralOptions.SearchEnabled));
                        }
                        if(publicRequest.IndexField.LiteralOptions.IsSetSortEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "LiteralOptions" + "." + "SortEnabled", StringUtils.FromBool(publicRequest.IndexField.LiteralOptions.SortEnabled));
                        }
                        if(publicRequest.IndexField.LiteralOptions.IsSetSourceField())
                        {
                            request.Parameters.Add("IndexField" + "." + "LiteralOptions" + "." + "SourceField", StringUtils.FromString(publicRequest.IndexField.LiteralOptions.SourceField));
                        }
                    }
                    if(publicRequest.IndexField.IsSetTextArrayOptions())
                    {
                        if(publicRequest.IndexField.TextArrayOptions.IsSetAnalysisScheme())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextArrayOptions" + "." + "AnalysisScheme", StringUtils.FromString(publicRequest.IndexField.TextArrayOptions.AnalysisScheme));
                        }
                        if(publicRequest.IndexField.TextArrayOptions.IsSetDefaultValue())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextArrayOptions" + "." + "DefaultValue", StringUtils.FromString(publicRequest.IndexField.TextArrayOptions.DefaultValue));
                        }
                        if(publicRequest.IndexField.TextArrayOptions.IsSetHighlightEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextArrayOptions" + "." + "HighlightEnabled", StringUtils.FromBool(publicRequest.IndexField.TextArrayOptions.HighlightEnabled));
                        }
                        if(publicRequest.IndexField.TextArrayOptions.IsSetReturnEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextArrayOptions" + "." + "ReturnEnabled", StringUtils.FromBool(publicRequest.IndexField.TextArrayOptions.ReturnEnabled));
                        }
                        if(publicRequest.IndexField.TextArrayOptions.IsSetSourceFields())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextArrayOptions" + "." + "SourceFields", StringUtils.FromString(publicRequest.IndexField.TextArrayOptions.SourceFields));
                        }
                    }
                    if(publicRequest.IndexField.IsSetTextOptions())
                    {
                        if(publicRequest.IndexField.TextOptions.IsSetAnalysisScheme())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextOptions" + "." + "AnalysisScheme", StringUtils.FromString(publicRequest.IndexField.TextOptions.AnalysisScheme));
                        }
                        if(publicRequest.IndexField.TextOptions.IsSetDefaultValue())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextOptions" + "." + "DefaultValue", StringUtils.FromString(publicRequest.IndexField.TextOptions.DefaultValue));
                        }
                        if(publicRequest.IndexField.TextOptions.IsSetHighlightEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextOptions" + "." + "HighlightEnabled", StringUtils.FromBool(publicRequest.IndexField.TextOptions.HighlightEnabled));
                        }
                        if(publicRequest.IndexField.TextOptions.IsSetReturnEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextOptions" + "." + "ReturnEnabled", StringUtils.FromBool(publicRequest.IndexField.TextOptions.ReturnEnabled));
                        }
                        if(publicRequest.IndexField.TextOptions.IsSetSortEnabled())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextOptions" + "." + "SortEnabled", StringUtils.FromBool(publicRequest.IndexField.TextOptions.SortEnabled));
                        }
                        if(publicRequest.IndexField.TextOptions.IsSetSourceField())
                        {
                            request.Parameters.Add("IndexField" + "." + "TextOptions" + "." + "SourceField", StringUtils.FromString(publicRequest.IndexField.TextOptions.SourceField));
                        }
                    }
                }
            }
            return request;
        }
                    private static DefineIndexFieldRequestMarshaller _instance = new DefineIndexFieldRequestMarshaller();        

        internal static DefineIndexFieldRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DefineIndexFieldRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}