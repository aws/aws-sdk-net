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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LayerCustomActionOperation Object
    /// </summary>  
    public class LayerCustomActionOperationUnmarshaller : IJsonUnmarshaller<LayerCustomActionOperation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public LayerCustomActionOperation Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            LayerCustomActionOperation unmarshalledObject = new LayerCustomActionOperation();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("FilterOperation", targetDepth))
                {
                    var unmarshaller = CustomActionFilterOperationUnmarshaller.Instance;
                    unmarshalledObject.FilterOperation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NavigationOperation", targetDepth))
                {
                    var unmarshaller = CustomActionNavigationOperationUnmarshaller.Instance;
                    unmarshalledObject.NavigationOperation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SetParametersOperation", targetDepth))
                {
                    var unmarshaller = CustomActionSetParametersOperationUnmarshaller.Instance;
                    unmarshalledObject.SetParametersOperation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("URLOperation", targetDepth))
                {
                    var unmarshaller = CustomActionURLOperationUnmarshaller.Instance;
                    unmarshalledObject.URLOperation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LayerCustomActionOperationUnmarshaller _instance = new LayerCustomActionOperationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LayerCustomActionOperationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}