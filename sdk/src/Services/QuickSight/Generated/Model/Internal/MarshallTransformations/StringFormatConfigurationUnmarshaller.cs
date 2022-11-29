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
    /// Response Unmarshaller for StringFormatConfiguration Object
    /// </summary>  
    public class StringFormatConfigurationUnmarshaller : IUnmarshaller<StringFormatConfiguration, XmlUnmarshallerContext>, IUnmarshaller<StringFormatConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StringFormatConfiguration IUnmarshaller<StringFormatConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public StringFormatConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            StringFormatConfiguration unmarshalledObject = new StringFormatConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("NullValueFormatConfiguration", targetDepth))
                {
                    var unmarshaller = NullValueFormatConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NullValueFormatConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumericFormatConfiguration", targetDepth))
                {
                    var unmarshaller = NumericFormatConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NumericFormatConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static StringFormatConfigurationUnmarshaller _instance = new StringFormatConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StringFormatConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}