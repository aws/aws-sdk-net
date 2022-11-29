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
    /// Response Unmarshaller for DestinationParameterValueConfiguration Object
    /// </summary>  
    public class DestinationParameterValueConfigurationUnmarshaller : IUnmarshaller<DestinationParameterValueConfiguration, XmlUnmarshallerContext>, IUnmarshaller<DestinationParameterValueConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DestinationParameterValueConfiguration IUnmarshaller<DestinationParameterValueConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DestinationParameterValueConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DestinationParameterValueConfiguration unmarshalledObject = new DestinationParameterValueConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CustomValuesConfiguration", targetDepth))
                {
                    var unmarshaller = CustomValuesConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CustomValuesConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelectAllValueOptions", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SelectAllValueOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceField", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceField = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceParameterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceParameterName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DestinationParameterValueConfigurationUnmarshaller _instance = new DestinationParameterValueConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DestinationParameterValueConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}