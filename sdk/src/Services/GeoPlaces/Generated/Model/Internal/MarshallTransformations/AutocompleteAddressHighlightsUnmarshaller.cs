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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoPlaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GeoPlaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AutocompleteAddressHighlights Object
    /// </summary>  
    public class AutocompleteAddressHighlightsUnmarshaller : IUnmarshaller<AutocompleteAddressHighlights, XmlUnmarshallerContext>, IUnmarshaller<AutocompleteAddressHighlights, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AutocompleteAddressHighlights IUnmarshaller<AutocompleteAddressHighlights, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AutocompleteAddressHighlights Unmarshall(JsonUnmarshallerContext context)
        {
            AutocompleteAddressHighlights unmarshalledObject = new AutocompleteAddressHighlights();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AddressNumber", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Highlight, HighlightUnmarshaller>(HighlightUnmarshaller.Instance);
                    unmarshalledObject.AddressNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Block", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Highlight, HighlightUnmarshaller>(HighlightUnmarshaller.Instance);
                    unmarshalledObject.Block = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Building", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Highlight, HighlightUnmarshaller>(HighlightUnmarshaller.Instance);
                    unmarshalledObject.Building = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Country", targetDepth))
                {
                    var unmarshaller = CountryHighlightsUnmarshaller.Instance;
                    unmarshalledObject.Country = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("District", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Highlight, HighlightUnmarshaller>(HighlightUnmarshaller.Instance);
                    unmarshalledObject.District = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Intersection", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<List<Highlight>, ListUnmarshaller<Highlight, HighlightUnmarshaller>>(new ListUnmarshaller<Highlight, HighlightUnmarshaller>(HighlightUnmarshaller.Instance));
                    unmarshalledObject.Intersection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Label", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Highlight, HighlightUnmarshaller>(HighlightUnmarshaller.Instance);
                    unmarshalledObject.Label = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Locality", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Highlight, HighlightUnmarshaller>(HighlightUnmarshaller.Instance);
                    unmarshalledObject.Locality = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PostalCode", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Highlight, HighlightUnmarshaller>(HighlightUnmarshaller.Instance);
                    unmarshalledObject.PostalCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Region", targetDepth))
                {
                    var unmarshaller = RegionHighlightsUnmarshaller.Instance;
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Street", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Highlight, HighlightUnmarshaller>(HighlightUnmarshaller.Instance);
                    unmarshalledObject.Street = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubBlock", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Highlight, HighlightUnmarshaller>(HighlightUnmarshaller.Instance);
                    unmarshalledObject.SubBlock = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubDistrict", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Highlight, HighlightUnmarshaller>(HighlightUnmarshaller.Instance);
                    unmarshalledObject.SubDistrict = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubRegion", targetDepth))
                {
                    var unmarshaller = SubRegionHighlightsUnmarshaller.Instance;
                    unmarshalledObject.SubRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AutocompleteAddressHighlightsUnmarshaller _instance = new AutocompleteAddressHighlightsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutocompleteAddressHighlightsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}