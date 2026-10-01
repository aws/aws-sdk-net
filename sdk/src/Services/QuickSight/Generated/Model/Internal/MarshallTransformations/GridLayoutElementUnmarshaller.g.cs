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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.QuickSight.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GridLayoutElement Object
    /// </summary>
    public partial class GridLayoutElementUnmarshaller : IJsonUnmarshaller<GridLayoutElement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public GridLayoutElement Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new GridLayoutElement();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("BackgroundStyle", targetDepth, ref reader))
                {
                    var unmarshaller = GridLayoutElementBackgroundStyleUnmarshaller.Instance;
                    unmarshalledObject.BackgroundStyle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("BorderRadius", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BorderRadius = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("BorderStyle", targetDepth, ref reader))
                {
                    var unmarshaller = GridLayoutElementBorderStyleUnmarshaller.Instance;
                    unmarshalledObject.BorderStyle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ColumnIndex", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ColumnIndex = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ColumnSpan", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ColumnSpan = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ElementId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ElementId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ElementType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ElementType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LoadingAnimation", targetDepth, ref reader))
                {
                    var unmarshaller = LoadingAnimationUnmarshaller.Instance;
                    unmarshalledObject.LoadingAnimation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Padding", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Padding = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RowIndex", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.RowIndex = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RowSpan", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.RowSpan = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SelectedBorderStyle", targetDepth, ref reader))
                {
                    var unmarshaller = GridLayoutElementBorderStyleUnmarshaller.Instance;
                    unmarshalledObject.SelectedBorderStyle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static GridLayoutElementUnmarshaller _instance = new GridLayoutElementUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GridLayoutElementUnmarshaller Instance => _instance;
    }
}
