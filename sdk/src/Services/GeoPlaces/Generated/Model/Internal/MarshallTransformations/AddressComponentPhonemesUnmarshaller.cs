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
    /// Response Unmarshaller for AddressComponentPhonemes Object
    /// </summary>  
    public class AddressComponentPhonemesUnmarshaller : IUnmarshaller<AddressComponentPhonemes, XmlUnmarshallerContext>, IUnmarshaller<AddressComponentPhonemes, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AddressComponentPhonemes IUnmarshaller<AddressComponentPhonemes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AddressComponentPhonemes Unmarshall(JsonUnmarshallerContext context)
        {
            AddressComponentPhonemes unmarshalledObject = new AddressComponentPhonemes();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Block", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PhonemeTranscription, PhonemeTranscriptionUnmarshaller>(PhonemeTranscriptionUnmarshaller.Instance);
                    unmarshalledObject.Block = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Country", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PhonemeTranscription, PhonemeTranscriptionUnmarshaller>(PhonemeTranscriptionUnmarshaller.Instance);
                    unmarshalledObject.Country = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("District", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PhonemeTranscription, PhonemeTranscriptionUnmarshaller>(PhonemeTranscriptionUnmarshaller.Instance);
                    unmarshalledObject.District = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Locality", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PhonemeTranscription, PhonemeTranscriptionUnmarshaller>(PhonemeTranscriptionUnmarshaller.Instance);
                    unmarshalledObject.Locality = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Region", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PhonemeTranscription, PhonemeTranscriptionUnmarshaller>(PhonemeTranscriptionUnmarshaller.Instance);
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Street", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PhonemeTranscription, PhonemeTranscriptionUnmarshaller>(PhonemeTranscriptionUnmarshaller.Instance);
                    unmarshalledObject.Street = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubBlock", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PhonemeTranscription, PhonemeTranscriptionUnmarshaller>(PhonemeTranscriptionUnmarshaller.Instance);
                    unmarshalledObject.SubBlock = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubDistrict", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PhonemeTranscription, PhonemeTranscriptionUnmarshaller>(PhonemeTranscriptionUnmarshaller.Instance);
                    unmarshalledObject.SubDistrict = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubRegion", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PhonemeTranscription, PhonemeTranscriptionUnmarshaller>(PhonemeTranscriptionUnmarshaller.Instance);
                    unmarshalledObject.SubRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AddressComponentPhonemesUnmarshaller _instance = new AddressComponentPhonemesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AddressComponentPhonemesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}