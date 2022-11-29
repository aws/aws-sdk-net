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
    /// Response Unmarshaller for PercentageDisplayFormatConfiguration Object
    /// </summary>  
    public class PercentageDisplayFormatConfigurationUnmarshaller : IUnmarshaller<PercentageDisplayFormatConfiguration, XmlUnmarshallerContext>, IUnmarshaller<PercentageDisplayFormatConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PercentageDisplayFormatConfiguration IUnmarshaller<PercentageDisplayFormatConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PercentageDisplayFormatConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PercentageDisplayFormatConfiguration unmarshalledObject = new PercentageDisplayFormatConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DecimalPlacesConfiguration", targetDepth))
                {
                    var unmarshaller = DecimalPlacesConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DecimalPlacesConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NegativeValueConfiguration", targetDepth))
                {
                    var unmarshaller = NegativeValueConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NegativeValueConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NullValueFormatConfiguration", targetDepth))
                {
                    var unmarshaller = NullValueFormatConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NullValueFormatConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Prefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Prefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SeparatorConfiguration", targetDepth))
                {
                    var unmarshaller = NumericSeparatorConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SeparatorConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Suffix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Suffix = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PercentageDisplayFormatConfigurationUnmarshaller _instance = new PercentageDisplayFormatConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PercentageDisplayFormatConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}