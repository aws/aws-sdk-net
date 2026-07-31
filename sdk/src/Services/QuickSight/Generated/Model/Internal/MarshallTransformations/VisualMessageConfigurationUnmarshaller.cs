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
    /// Response Unmarshaller for VisualMessageConfiguration Object
    /// </summary>  
    public class VisualMessageConfigurationUnmarshaller : IJsonUnmarshaller<VisualMessageConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public VisualMessageConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            VisualMessageConfiguration unmarshalledObject = new VisualMessageConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Description", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DescriptionVisibility", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DescriptionVisibility = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Enabled", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Enabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LinkText", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LinkText = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LinkUrl", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LinkUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LinkVisibility", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LinkVisibility = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TitleVisibility", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TitleVisibility = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static VisualMessageConfigurationUnmarshaller _instance = new VisualMessageConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VisualMessageConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}