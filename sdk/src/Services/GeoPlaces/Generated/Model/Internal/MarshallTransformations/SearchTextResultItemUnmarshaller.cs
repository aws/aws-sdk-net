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
    /// Response Unmarshaller for SearchTextResultItem Object
    /// </summary>  
    public class SearchTextResultItemUnmarshaller : IUnmarshaller<SearchTextResultItem, XmlUnmarshallerContext>, IUnmarshaller<SearchTextResultItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SearchTextResultItem IUnmarshaller<SearchTextResultItem, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SearchTextResultItem Unmarshall(JsonUnmarshallerContext context)
        {
            SearchTextResultItem unmarshalledObject = new SearchTextResultItem();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessPoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AccessPoint, AccessPointUnmarshaller>(AccessPointUnmarshaller.Instance);
                    unmarshalledObject.AccessPoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AccessRestrictions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AccessRestriction, AccessRestrictionUnmarshaller>(AccessRestrictionUnmarshaller.Instance);
                    unmarshalledObject.AccessRestrictions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Address", targetDepth))
                {
                    var unmarshaller = AddressUnmarshaller.Instance;
                    unmarshalledObject.Address = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AddressNumberCorrected", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AddressNumberCorrected = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BusinessChains", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BusinessChain, BusinessChainUnmarshaller>(BusinessChainUnmarshaller.Instance);
                    unmarshalledObject.BusinessChains = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Categories", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Category, CategoryUnmarshaller>(CategoryUnmarshaller.Instance);
                    unmarshalledObject.Categories = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Contacts", targetDepth))
                {
                    var unmarshaller = ContactsUnmarshaller.Instance;
                    unmarshalledObject.Contacts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Distance", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Distance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FoodTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FoodType, FoodTypeUnmarshaller>(FoodTypeUnmarshaller.Instance);
                    unmarshalledObject.FoodTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MapView", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.MapView = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OpeningHours", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OpeningHours, OpeningHoursUnmarshaller>(OpeningHoursUnmarshaller.Instance);
                    unmarshalledObject.OpeningHours = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Phonemes", targetDepth))
                {
                    var unmarshaller = PhonemeDetailsUnmarshaller.Instance;
                    unmarshalledObject.Phonemes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlaceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlaceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlaceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PoliticalView", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PoliticalView = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Position", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.Position = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeZone", targetDepth))
                {
                    var unmarshaller = TimeZoneUnmarshaller.Instance;
                    unmarshalledObject.TimeZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SearchTextResultItemUnmarshaller _instance = new SearchTextResultItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchTextResultItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}