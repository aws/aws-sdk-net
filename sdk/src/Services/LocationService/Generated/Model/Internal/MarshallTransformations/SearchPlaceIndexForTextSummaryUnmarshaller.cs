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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SearchPlaceIndexForTextSummary Object
    /// </summary>  
    public class SearchPlaceIndexForTextSummaryUnmarshaller : IUnmarshaller<SearchPlaceIndexForTextSummary, XmlUnmarshallerContext>, IUnmarshaller<SearchPlaceIndexForTextSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SearchPlaceIndexForTextSummary IUnmarshaller<SearchPlaceIndexForTextSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SearchPlaceIndexForTextSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SearchPlaceIndexForTextSummary unmarshalledObject = new SearchPlaceIndexForTextSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BiasPosition", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.BiasPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataSource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterBBox", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.FilterBBox = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterCategories", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.FilterCategories = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterCountries", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.FilterCountries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Language", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Language = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxResults", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxResults = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResultBBox", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.ResultBBox = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Text", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Text = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SearchPlaceIndexForTextSummaryUnmarshaller _instance = new SearchPlaceIndexForTextSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchPlaceIndexForTextSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}