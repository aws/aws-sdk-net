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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DAX.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DAX.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Parameter Object
    /// </summary>  
    public class ParameterUnmarshaller : IUnmarshaller<Parameter, XmlUnmarshallerContext>, IUnmarshaller<Parameter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Parameter IUnmarshaller<Parameter, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Parameter Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Parameter unmarshalledObject = new Parameter();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AllowedValues", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AllowedValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChangeType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChangeType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsModifiable", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IsModifiable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NodeTypeSpecificValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NodeTypeSpecificValue, NodeTypeSpecificValueUnmarshaller>(NodeTypeSpecificValueUnmarshaller.Instance);
                    unmarshalledObject.NodeTypeSpecificValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParameterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParameterName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParameterType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParameterType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParameterValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParameterValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Source", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Source = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ParameterUnmarshaller _instance = new ParameterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ParameterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}