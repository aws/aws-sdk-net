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

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for KPIActualValueConditionalFormatting Object
    /// </summary>  
    public class KPIActualValueConditionalFormattingUnmarshaller : IUnmarshaller<KPIActualValueConditionalFormatting, XmlUnmarshallerContext>, IUnmarshaller<KPIActualValueConditionalFormatting, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        KPIActualValueConditionalFormatting IUnmarshaller<KPIActualValueConditionalFormatting, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public KPIActualValueConditionalFormatting Unmarshall(JsonUnmarshallerContext context)
        {
            KPIActualValueConditionalFormatting unmarshalledObject = new KPIActualValueConditionalFormatting();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Icon", targetDepth))
                {
                    var unmarshaller = ConditionalFormattingIconUnmarshaller.Instance;
                    unmarshalledObject.Icon = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TextColor", targetDepth))
                {
                    var unmarshaller = ConditionalFormattingColorUnmarshaller.Instance;
                    unmarshalledObject.TextColor = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static KPIActualValueConditionalFormattingUnmarshaller _instance = new KPIActualValueConditionalFormattingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KPIActualValueConditionalFormattingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618