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
    /// Response Unmarshaller for AutocompleteResultItem Object
    /// </summary>  
    public class AutocompleteResultItemUnmarshaller : IUnmarshaller<AutocompleteResultItem, XmlUnmarshallerContext>, IUnmarshaller<AutocompleteResultItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AutocompleteResultItem IUnmarshaller<AutocompleteResultItem, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AutocompleteResultItem Unmarshall(JsonUnmarshallerContext context)
        {
            AutocompleteResultItem unmarshalledObject = new AutocompleteResultItem();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Address", targetDepth))
                {
                    var unmarshaller = AddressUnmarshaller.Instance;
                    unmarshalledObject.Address = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Distance", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Distance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Highlights", targetDepth))
                {
                    var unmarshaller = AutocompleteHighlightsUnmarshaller.Instance;
                    unmarshalledObject.Highlights = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Language", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Language = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AutocompleteResultItemUnmarshaller _instance = new AutocompleteResultItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutocompleteResultItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}