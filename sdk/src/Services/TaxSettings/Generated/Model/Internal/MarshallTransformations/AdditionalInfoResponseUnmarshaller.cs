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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TaxSettings.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.TaxSettings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AdditionalInfoResponse Object
    /// </summary>  
    public class AdditionalInfoResponseUnmarshaller : IJsonUnmarshaller<AdditionalInfoResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AdditionalInfoResponse Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AdditionalInfoResponse unmarshalledObject = new AdditionalInfoResponse();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("brazilAdditionalInfo", targetDepth))
                {
                    var unmarshaller = BrazilAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.BrazilAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("canadaAdditionalInfo", targetDepth))
                {
                    var unmarshaller = CanadaAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.CanadaAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("egyptAdditionalInfo", targetDepth))
                {
                    var unmarshaller = EgyptAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.EgyptAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("estoniaAdditionalInfo", targetDepth))
                {
                    var unmarshaller = EstoniaAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.EstoniaAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("georgiaAdditionalInfo", targetDepth))
                {
                    var unmarshaller = GeorgiaAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.GeorgiaAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("greeceAdditionalInfo", targetDepth))
                {
                    var unmarshaller = GreeceAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.GreeceAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("indiaAdditionalInfo", targetDepth))
                {
                    var unmarshaller = IndiaAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.IndiaAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("indonesiaAdditionalInfo", targetDepth))
                {
                    var unmarshaller = IndonesiaAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.IndonesiaAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("israelAdditionalInfo", targetDepth))
                {
                    var unmarshaller = IsraelAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.IsraelAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("italyAdditionalInfo", targetDepth))
                {
                    var unmarshaller = ItalyAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.ItalyAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kenyaAdditionalInfo", targetDepth))
                {
                    var unmarshaller = KenyaAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.KenyaAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("malaysiaAdditionalInfo", targetDepth))
                {
                    var unmarshaller = MalaysiaAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.MalaysiaAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("polandAdditionalInfo", targetDepth))
                {
                    var unmarshaller = PolandAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.PolandAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("romaniaAdditionalInfo", targetDepth))
                {
                    var unmarshaller = RomaniaAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.RomaniaAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("saudiArabiaAdditionalInfo", targetDepth))
                {
                    var unmarshaller = SaudiArabiaAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.SaudiArabiaAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("southKoreaAdditionalInfo", targetDepth))
                {
                    var unmarshaller = SouthKoreaAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.SouthKoreaAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("spainAdditionalInfo", targetDepth))
                {
                    var unmarshaller = SpainAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.SpainAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("turkeyAdditionalInfo", targetDepth))
                {
                    var unmarshaller = TurkeyAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.TurkeyAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ukraineAdditionalInfo", targetDepth))
                {
                    var unmarshaller = UkraineAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.UkraineAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("uzbekistanAdditionalInfo", targetDepth))
                {
                    var unmarshaller = UzbekistanAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.UzbekistanAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("vietnamAdditionalInfo", targetDepth))
                {
                    var unmarshaller = VietnamAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.VietnamAdditionalInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AdditionalInfoResponseUnmarshaller _instance = new AdditionalInfoResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AdditionalInfoResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}