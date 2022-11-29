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
    /// Response Unmarshaller for ReferenceLine Object
    /// </summary>  
    public class ReferenceLineUnmarshaller : IUnmarshaller<ReferenceLine, XmlUnmarshallerContext>, IUnmarshaller<ReferenceLine, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ReferenceLine IUnmarshaller<ReferenceLine, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReferenceLine Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ReferenceLine unmarshalledObject = new ReferenceLine();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DataConfiguration", targetDepth))
                {
                    var unmarshaller = ReferenceLineDataConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DataConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelConfiguration", targetDepth))
                {
                    var unmarshaller = ReferenceLineLabelConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LabelConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StyleConfiguration", targetDepth))
                {
                    var unmarshaller = ReferenceLineStyleConfigurationUnmarshaller.Instance;
                    unmarshalledObject.StyleConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ReferenceLineUnmarshaller _instance = new ReferenceLineUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReferenceLineUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}