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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.GeoPlaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SuggestPlaceResult Object
    /// </summary>  
    public class SuggestPlaceResultUnmarshaller : IJsonUnmarshaller<SuggestPlaceResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SuggestPlaceResult Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SuggestPlaceResult unmarshalledObject = new SuggestPlaceResult();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AccessPoints", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AccessPoint, AccessPointUnmarshaller>(AccessPointUnmarshaller.Instance);
                    unmarshalledObject.AccessPoints = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AccessRestrictions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AccessRestriction, AccessRestrictionUnmarshaller>(AccessRestrictionUnmarshaller.Instance);
                    unmarshalledObject.AccessRestrictions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Address", targetDepth))
                {
                    var unmarshaller = AddressUnmarshaller.Instance;
                    unmarshalledObject.Address = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BusinessChains", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<BusinessChain, BusinessChainUnmarshaller>(BusinessChainUnmarshaller.Instance);
                    unmarshalledObject.BusinessChains = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Categories", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Category, CategoryUnmarshaller>(CategoryUnmarshaller.Instance);
                    unmarshalledObject.Categories = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Distance", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Distance = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FoodTypes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<FoodType, FoodTypeUnmarshaller>(FoodTypeUnmarshaller.Instance);
                    unmarshalledObject.FoodTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MapView", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.MapView = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Phonemes", targetDepth))
                {
                    var unmarshaller = PhonemeDetailsUnmarshaller.Instance;
                    unmarshalledObject.Phonemes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PlaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlaceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PlaceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlaceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PoliticalView", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PoliticalView = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Position", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.Position = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TimeZone", targetDepth))
                {
                    var unmarshaller = TimeZoneUnmarshaller.Instance;
                    unmarshalledObject.TimeZone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SuggestPlaceResultUnmarshaller _instance = new SuggestPlaceResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SuggestPlaceResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}