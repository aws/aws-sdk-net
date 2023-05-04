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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DisplayFormatOptions Object
    /// </summary>  
    public class DisplayFormatOptionsUnmarshaller : IUnmarshaller<DisplayFormatOptions, XmlUnmarshallerContext>, IUnmarshaller<DisplayFormatOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DisplayFormatOptions IUnmarshaller<DisplayFormatOptions, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DisplayFormatOptions Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DisplayFormatOptions unmarshalledObject = new DisplayFormatOptions();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BlankCellFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BlankCellFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrencySymbol", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrencySymbol = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DateFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DateFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DecimalSeparator", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DecimalSeparator = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FractionDigits", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FractionDigits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GroupingSeparator", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GroupingSeparator = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NegativeFormat", targetDepth))
                {
                    var unmarshaller = NegativeFormatUnmarshaller.Instance;
                    unmarshalledObject.NegativeFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Prefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Prefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Suffix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Suffix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UnitScaler", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UnitScaler = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseBlankCellFormat", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseBlankCellFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseGrouping", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseGrouping = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DisplayFormatOptionsUnmarshaller _instance = new DisplayFormatOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DisplayFormatOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}