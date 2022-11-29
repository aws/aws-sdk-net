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
    /// Response Unmarshaller for ParameterListControl Object
    /// </summary>  
    public class ParameterListControlUnmarshaller : IUnmarshaller<ParameterListControl, XmlUnmarshallerContext>, IUnmarshaller<ParameterListControl, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ParameterListControl IUnmarshaller<ParameterListControl, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ParameterListControl Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ParameterListControl unmarshalledObject = new ParameterListControl();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CascadingControlConfiguration", targetDepth))
                {
                    var unmarshaller = CascadingControlConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CascadingControlConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisplayOptions", targetDepth))
                {
                    var unmarshaller = ListControlDisplayOptionsUnmarshaller.Instance;
                    unmarshalledObject.DisplayOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParameterControlId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParameterControlId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelectableValues", targetDepth))
                {
                    var unmarshaller = ParameterSelectableValuesUnmarshaller.Instance;
                    unmarshalledObject.SelectableValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceParameterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceParameterName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ParameterListControlUnmarshaller _instance = new ParameterListControlUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ParameterListControlUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}