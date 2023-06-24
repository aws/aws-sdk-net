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
    /// Response Unmarshaller for FormatConfiguration Object
    /// </summary>  
    public class FormatConfigurationUnmarshaller : IUnmarshaller<FormatConfiguration, XmlUnmarshallerContext>, IUnmarshaller<FormatConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FormatConfiguration IUnmarshaller<FormatConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FormatConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FormatConfiguration unmarshalledObject = new FormatConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DateTimeFormatConfiguration", targetDepth))
                {
                    var unmarshaller = DateTimeFormatConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DateTimeFormatConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberFormatConfiguration", targetDepth))
                {
                    var unmarshaller = NumberFormatConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NumberFormatConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StringFormatConfiguration", targetDepth))
                {
                    var unmarshaller = StringFormatConfigurationUnmarshaller.Instance;
                    unmarshalledObject.StringFormatConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FormatConfigurationUnmarshaller _instance = new FormatConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FormatConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}