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
    /// Response Unmarshaller for ConditionalFormattingCustomIconCondition Object
    /// </summary>  
    public class ConditionalFormattingCustomIconConditionUnmarshaller : IUnmarshaller<ConditionalFormattingCustomIconCondition, XmlUnmarshallerContext>, IUnmarshaller<ConditionalFormattingCustomIconCondition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConditionalFormattingCustomIconCondition IUnmarshaller<ConditionalFormattingCustomIconCondition, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConditionalFormattingCustomIconCondition Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ConditionalFormattingCustomIconCondition unmarshalledObject = new ConditionalFormattingCustomIconCondition();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Color", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Color = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisplayConfiguration", targetDepth))
                {
                    var unmarshaller = ConditionalFormattingIconDisplayConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DisplayConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Expression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Expression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IconOptions", targetDepth))
                {
                    var unmarshaller = ConditionalFormattingCustomIconOptionsUnmarshaller.Instance;
                    unmarshalledObject.IconOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ConditionalFormattingCustomIconConditionUnmarshaller _instance = new ConditionalFormattingCustomIconConditionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConditionalFormattingCustomIconConditionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}